using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace WakeOnLan_WPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListDevices();
        }

        // Handle the "Add Device" button click event
        private void AddDevice_btn_Click(object sender, EventArgs e)
        {
            // Get user input
            string deviceName = deviceName_txtbox.Text;
            string macAddress = macAddress_txtbox.Text;
            string ipAddress = ipAddress_txtbox.Text;
            string port = port_txtbox.Text;

            if (!string.IsNullOrEmpty(macAddress) && !string.IsNullOrEmpty(ipAddress) && !string.IsNullOrEmpty(port))
            {
                // Construct device information
                string deviceInfo = $"Device Name: {deviceName}, MAC Address: {macAddress}, IP Address: {ipAddress}, Port: {port}";

                // Create the WakeOnLan folder if it doesn't exist
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WakeOnLan");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Add device information to a file
                string filePath = Path.Combine(folderPath, "devices.txt");

                try
                {
                    using (StreamWriter writer = File.AppendText(filePath))
                    {
                        writer.WriteLine(deviceInfo);
                    }

                    MessageBox.Show("The device has been added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the device: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter all information.");
            }
        }

        // Handle the "Wake Up" button click event
        private void WakeUp_btn_Click(object sender, EventArgs e)
        {
            if (DeviceList_lstbox.SelectedIndex >= 0)
            {
                // Get the selected device's name
                string selectedDeviceName = DeviceList_lstbox.SelectedItem.ToString();

                // Search for the device's information in the TXT file
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WakeOnLan");
                string filePath = Path.Combine(folderPath, "devices.txt");

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        if (line.Contains(selectedDeviceName))
                        {
                            // Extract and use the device's information
                            string[] parts = line.Split(new string[] { "MAC Address: ", "IP Address: ", "Port: " }, StringSplitOptions.None);
                            if (parts.Length == 4)
                            {
                                string deviceName = selectedDeviceName;
                                string macAddress = parts[1];
                                string ipAddress = parts[2];
                                string port = parts[3];

                                // Perform the wake-up operation
                                if (FormatMacAddress(macAddress, out string formattedMacAddress))
                                {
                                    SendMagicPacket(formattedMacAddress);
                                    MessageBox.Show($"The device '{deviceName}' with MAC Address '{macAddress}' has been woken up.");
                                    break; // Device found, exit the loop
                                }
                                else
                                {
                                    MessageBox.Show("Invalid MAC Address format.");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a device to wake up.");
            }
            ListDevices();
        }

        // Format a MAC address for Wake-on-LAN
        private bool FormatMacAddress(string macAddress, out string formattedMacAddress)
        {
            // Convert the MAC address to the proper format (e.g., "00:11:22:33:44:55" -> "001122334455")
            formattedMacAddress = macAddress.Replace(":", "").Replace("-", "").Replace(" ", "").Replace(",", "");

            if (formattedMacAddress.Length == 12)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid MAC Address format.");
                return false;
            }
        }

        // Send the Wake-on-LAN magic packet
        private void SendMagicPacket(string macAddress)
        {
            // Create the magic packet required for Wake-on-LAN
            byte[] magicPacket = new byte[102];

            // Set the first 6 bytes as the destination MAC address
            for (int i = 0; i < 6; i++)
            {
                magicPacket[i] = 0xFF;
            }

            // Repeat the destination MAC address 16 times in the next section
            for (int i = 6; i < 102; i += 6)
            {
                for (int j = 0; j < 6; j++)
                {
                    magicPacket[i + j] = byte.Parse(macAddress.Substring(j * 2, 2), System.Globalization.NumberStyles.HexNumber);
                }
            }

            // Send the wake-up packet
            using (UdpClient client = new UdpClient())
            {
                client.Connect(IPAddress.Broadcast, 7); // Send to the broadcast address
                client.Send(magicPacket, magicPacket.Length);
            }
        }

        // Populate the device list
        private void ListDevices()
        {
            DeviceList_lstbox.Items.Clear();
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WakeOnLan");
            string filePath = Path.Combine(folderPath, "devices.txt");

            if (File.Exists(filePath))
            {
                // If the file exists, read its contents and add device names to ListBox1
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    // Here, we're adding the line as the device name. For example, we're extracting the MAC Address from the line "Device Name: MyDevice, MAC Address: 00:11:22:33:44:55, IP Address: 192.168.1.100, Port: 9".
                    string[] parts = line.Split(new string[] { "Device Name: " }, StringSplitOptions.None);
                    if (parts.Length > 1)
                    {
                        string macAddress = parts[1].Split(',')[0].Trim();
                        DeviceList_lstbox.Items.Add(macAddress);
                    }
                }
            }
        }
    }
}
