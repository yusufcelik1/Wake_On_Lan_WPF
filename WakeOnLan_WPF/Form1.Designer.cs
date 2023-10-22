namespace WakeOnLan_WPF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WakeUp_btn = new Button();
            DeviceList_lstbox = new ListBox();
            AddDevice_btn = new Button();
            macAdress_lbl = new Label();
            ipAddress_lbl = new Label();
            port_lbl = new Label();
            macAddress_txtbox = new TextBox();
            ipAddress_txtbox = new TextBox();
            port_txtbox = new TextBox();
            deviceName_lbl = new Label();
            deviceName_txtbox = new TextBox();
            SuspendLayout();
            // 
            // WakeUp_btn
            // 
            WakeUp_btn.Location = new Point(407, 269);
            WakeUp_btn.Margin = new Padding(3, 4, 3, 4);
            WakeUp_btn.Name = "WakeUp_btn";
            WakeUp_btn.Size = new Size(114, 31);
            WakeUp_btn.TabIndex = 0;
            WakeUp_btn.Text = "Wake Up";
            WakeUp_btn.UseVisualStyleBackColor = true;
            WakeUp_btn.Click += WakeUp_btn_Click;
            // 
            // DeviceList_lstbox
            // 
            DeviceList_lstbox.FormattingEnabled = true;
            DeviceList_lstbox.ItemHeight = 20;
            DeviceList_lstbox.Location = new Point(45, 45);
            DeviceList_lstbox.Margin = new Padding(3, 4, 3, 4);
            DeviceList_lstbox.Name = "DeviceList_lstbox";
            DeviceList_lstbox.Size = new Size(207, 264);
            DeviceList_lstbox.TabIndex = 3;
            // 
            // AddDevice_btn
            // 
            AddDevice_btn.Location = new Point(281, 269);
            AddDevice_btn.Margin = new Padding(3, 4, 3, 4);
            AddDevice_btn.Name = "AddDevice_btn";
            AddDevice_btn.Size = new Size(114, 31);
            AddDevice_btn.TabIndex = 4;
            AddDevice_btn.Text = "Add Device";
            AddDevice_btn.UseVisualStyleBackColor = true;
            AddDevice_btn.Click += AddDevice_btn_Click;
            // 
            // macAdress_lbl
            // 
            macAdress_lbl.AutoSize = true;
            macAdress_lbl.Location = new Point(297, 93);
            macAdress_lbl.Name = "macAdress_lbl";
            macAdress_lbl.Size = new Size(98, 20);
            macAdress_lbl.TabIndex = 5;
            macAdress_lbl.Text = "MAC Address";
            // 
            // ipAddress_lbl
            // 
            ipAddress_lbl.AutoSize = true;
            ipAddress_lbl.Location = new Point(297, 147);
            ipAddress_lbl.Name = "ipAddress_lbl";
            ipAddress_lbl.Size = new Size(78, 20);
            ipAddress_lbl.TabIndex = 6;
            ipAddress_lbl.Text = "IP Address";
            // 
            // port_lbl
            // 
            port_lbl.AutoSize = true;
            port_lbl.Location = new Point(297, 204);
            port_lbl.Name = "port_lbl";
            port_lbl.Size = new Size(35, 20);
            port_lbl.TabIndex = 7;
            port_lbl.Text = "Port";
            // 
            // macAddress_txtbox
            // 
            macAddress_txtbox.Location = new Point(407, 89);
            macAddress_txtbox.Margin = new Padding(3, 4, 3, 4);
            macAddress_txtbox.Name = "macAddress_txtbox";
            macAddress_txtbox.Size = new Size(114, 27);
            macAddress_txtbox.TabIndex = 8;
            // 
            // ipAddress_txtbox
            // 
            ipAddress_txtbox.Location = new Point(407, 143);
            ipAddress_txtbox.Margin = new Padding(3, 4, 3, 4);
            ipAddress_txtbox.Name = "ipAddress_txtbox";
            ipAddress_txtbox.Size = new Size(114, 27);
            ipAddress_txtbox.TabIndex = 9;
            // 
            // port_txtbox
            // 
            port_txtbox.Location = new Point(407, 200);
            port_txtbox.Margin = new Padding(3, 4, 3, 4);
            port_txtbox.Name = "port_txtbox";
            port_txtbox.Size = new Size(114, 27);
            port_txtbox.TabIndex = 10;
            // 
            // deviceName_lbl
            // 
            deviceName_lbl.AutoSize = true;
            deviceName_lbl.Location = new Point(297, 49);
            deviceName_lbl.Name = "deviceName_lbl";
            deviceName_lbl.Size = new Size(98, 20);
            deviceName_lbl.TabIndex = 11;
            deviceName_lbl.Text = "Device Name";
            // 
            // deviceName_txtbox
            // 
            deviceName_txtbox.Location = new Point(407, 45);
            deviceName_txtbox.Margin = new Padding(3, 4, 3, 4);
            deviceName_txtbox.Name = "deviceName_txtbox";
            deviceName_txtbox.Size = new Size(114, 27);
            deviceName_txtbox.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 338);
            Controls.Add(deviceName_txtbox);
            Controls.Add(deviceName_lbl);
            Controls.Add(port_txtbox);
            Controls.Add(ipAddress_txtbox);
            Controls.Add(macAddress_txtbox);
            Controls.Add(port_lbl);
            Controls.Add(ipAddress_lbl);
            Controls.Add(macAdress_lbl);
            Controls.Add(AddDevice_btn);
            Controls.Add(DeviceList_lstbox);
            Controls.Add(WakeUp_btn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button WakeUp_btn;
        private ListBox DeviceList_lstbox;
        private Button AddDevice_btn;
        private Label macAdress_lbl;
        private Label ipAddress_lbl;
        private Label port_lbl;
        private TextBox macAddress_txtbox;
        private TextBox ipAddress_txtbox;
        private TextBox port_txtbox;
        private Label deviceName_lbl;
        private TextBox deviceName_txtbox;
    }
}