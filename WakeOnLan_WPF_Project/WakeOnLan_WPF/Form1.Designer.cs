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
            Restart_btn = new Button();
            shutdown_btn = new Button();
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
            WakeUp_btn.Location = new Point(356, 242);
            WakeUp_btn.Name = "WakeUp_btn";
            WakeUp_btn.Size = new Size(100, 23);
            WakeUp_btn.TabIndex = 0;
            WakeUp_btn.Text = "Wake Up";
            WakeUp_btn.UseVisualStyleBackColor = true;
            WakeUp_btn.Click += WakeUp_btn_Click;
            // 
            // Restart_btn
            // 
            Restart_btn.Location = new Point(356, 271);
            Restart_btn.Name = "Restart_btn";
            Restart_btn.Size = new Size(100, 23);
            Restart_btn.TabIndex = 1;
            Restart_btn.Text = "Restart";
            Restart_btn.UseVisualStyleBackColor = true;
            // 
            // shutdown_btn
            // 
            shutdown_btn.Location = new Point(356, 300);
            shutdown_btn.Name = "shutdown_btn";
            shutdown_btn.Size = new Size(100, 23);
            shutdown_btn.TabIndex = 2;
            shutdown_btn.Text = "Shut Down";
            shutdown_btn.UseVisualStyleBackColor = true;
            // 
            // DeviceList_lstbox
            // 
            DeviceList_lstbox.FormattingEnabled = true;
            DeviceList_lstbox.ItemHeight = 15;
            DeviceList_lstbox.Location = new Point(39, 34);
            DeviceList_lstbox.Name = "DeviceList_lstbox";
            DeviceList_lstbox.Size = new Size(182, 244);
            DeviceList_lstbox.TabIndex = 3;
            // 
            // AddDevice_btn
            // 
            AddDevice_btn.Location = new Point(356, 193);
            AddDevice_btn.Name = "AddDevice_btn";
            AddDevice_btn.Size = new Size(100, 23);
            AddDevice_btn.TabIndex = 4;
            AddDevice_btn.Text = "Add Device";
            AddDevice_btn.UseVisualStyleBackColor = true;
            AddDevice_btn.Click += AddDevice_btn_Click;
            // 
            // macAdress_lbl
            // 
            macAdress_lbl.AutoSize = true;
            macAdress_lbl.Location = new Point(260, 70);
            macAdress_lbl.Name = "macAdress_lbl";
            macAdress_lbl.Size = new Size(79, 15);
            macAdress_lbl.TabIndex = 5;
            macAdress_lbl.Text = "MAC Address";
            // 
            // ipAddress_lbl
            // 
            ipAddress_lbl.AutoSize = true;
            ipAddress_lbl.Location = new Point(260, 110);
            ipAddress_lbl.Name = "ipAddress_lbl";
            ipAddress_lbl.Size = new Size(62, 15);
            ipAddress_lbl.TabIndex = 6;
            ipAddress_lbl.Text = "IP Address";
            // 
            // port_lbl
            // 
            port_lbl.AutoSize = true;
            port_lbl.Location = new Point(260, 153);
            port_lbl.Name = "port_lbl";
            port_lbl.Size = new Size(29, 15);
            port_lbl.TabIndex = 7;
            port_lbl.Text = "Port";
            // 
            // macAddress_txtbox
            // 
            macAddress_txtbox.Location = new Point(356, 67);
            macAddress_txtbox.Name = "macAddress_txtbox";
            macAddress_txtbox.Size = new Size(100, 23);
            macAddress_txtbox.TabIndex = 8;
            // 
            // ipAddress_txtbox
            // 
            ipAddress_txtbox.Location = new Point(356, 107);
            ipAddress_txtbox.Name = "ipAddress_txtbox";
            ipAddress_txtbox.Size = new Size(100, 23);
            ipAddress_txtbox.TabIndex = 9;
            // 
            // port_txtbox
            // 
            port_txtbox.Location = new Point(356, 150);
            port_txtbox.Name = "port_txtbox";
            port_txtbox.Size = new Size(100, 23);
            port_txtbox.TabIndex = 10;
            // 
            // deviceName_lbl
            // 
            deviceName_lbl.AutoSize = true;
            deviceName_lbl.Location = new Point(260, 37);
            deviceName_lbl.Name = "deviceName_lbl";
            deviceName_lbl.Size = new Size(77, 15);
            deviceName_lbl.TabIndex = 11;
            deviceName_lbl.Text = "Device Name";
            // 
            // deviceName_txtbox
            // 
            deviceName_txtbox.Location = new Point(356, 34);
            deviceName_txtbox.Name = "deviceName_txtbox";
            deviceName_txtbox.Size = new Size(100, 23);
            deviceName_txtbox.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 355);
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
            Controls.Add(shutdown_btn);
            Controls.Add(Restart_btn);
            Controls.Add(WakeUp_btn);
            Name = "Form1";
            Text = "Form1";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button WakeUp_btn;
        private Button Restart_btn;
        private Button shutdown_btn;
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