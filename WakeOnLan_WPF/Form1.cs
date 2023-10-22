using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;

namespace WakeOnLan_WPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListDevices();
        }

        private void AddDevice_btn_Click(object sender, EventArgs e)
        {
            string deviceName = deviceName_txtbox.Text;
            string macAddress = macAddress_txtbox.Text;
            string ipAddress = ipAddress_txtbox.Text;
            string port = port_txtbox.Text;

            if (!string.IsNullOrEmpty(macAddress) && !string.IsNullOrEmpty(ipAddress) && !string.IsNullOrEmpty(port))
            {
                string deviceInfo = $"Device Name: {deviceName}, MAC Address: {macAddress}, IP Address: {ipAddress}, Port: {port}";

                // WakeOnLan klasörünü oluştur
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WakeOnLan");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Dosyaya cihaz bilgilerini ekle
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
            ListDevices();
        }

        private void WakeUp_btn_Click(object sender, EventArgs e)
        {
            if (DeviceList_lstbox.SelectedIndex >= 0)
            {
                // Seçilen cihazın adını al
                string selectedDeviceName = DeviceList_lstbox.SelectedItem.ToString();

                // TXT dosyasından cihazın bilgilerini ara
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WakeOnLan");
                string filePath = Path.Combine(folderPath, "devices.txt");

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        if (line.Contains(selectedDeviceName))
                        {
                            // Cihazın bilgilerini ayır ve kullan
                            string[] parts = line.Split(new string[] { "MAC Address: ", "IP Address: ", "Port: " }, StringSplitOptions.None);
                            if (parts.Length == 4)
                            {
                                string deviceName = selectedDeviceName;
                                string macAddress = parts[1];
                                string ipAddress = parts[2];
                                string port = parts[3];

                                // Uyandırma işlemini gerçekleştir
                                if (FormatMacAddress(macAddress, out string formattedMacAddress))
                                {
                                    SendMagicPacket(formattedMacAddress);
                                    MessageBox.Show($"The device '{deviceName}' with MAC Address '{macAddress}' has been woken up.");
                                    break; // Cihaz bulundu, döngüyü sonlandır
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
        }

        private bool FormatMacAddress(string macAddress, out string formattedMacAddress)
        {
            // MAC adresini uygun formata dönüştür (örneğin: "00:11:22:33:44:55" -> "001122334455")
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

        private void SendMagicPacket(string macAddress)
        {
            // Wake-on-LAN için gerekli sihirli paketi oluştur
            byte[] magicPacket = new byte[102];

            // İlk 6 bayt hedef MAC adresi olarak ayarlanır
            for (int i = 0; i < 6; i++)
            {
                magicPacket[i] = 0xFF;
            }

            // Sonraki 16 defa hedef MAC adresi tekrarlanır
            for (int i = 6; i < 102; i += 6)
            {
                for (int j = 0; j < 6; j++)
                {
                    magicPacket[i + j] = byte.Parse(macAddress.Substring(j * 2, 2), System.Globalization.NumberStyles.HexNumber);
                }
            }

            // Uyandırma paketini gönder
            using (UdpClient client = new UdpClient())
            {
                client.Connect(IPAddress.Broadcast, 7); // Broadcast adresine gönderilir
                client.Send(magicPacket, magicPacket.Length);
            }
        }


        private void ListDevices()
        {
            DeviceList_lstbox.Items.Clear();
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WakeOnLan");
            string filePath = Path.Combine(folderPath, "devices.txt");

            if (File.Exists(filePath))
            {
                // Dosya varsa, içeriğini oku ve cihaz adlarını Listbox1'e ekle
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    // Burada satırı cihaz adı olarak ekliyoruz. Örneğin, "MAC Address: 00:11:22:33:44:55, IP Address: 192.168.1.100, Port: 9" satırından MAC Adresini alıyoruz.
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