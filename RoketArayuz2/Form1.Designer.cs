namespace RoketArayuz2
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
            this.components = new System.ComponentModel.Container();
            this.panel_Connections = new System.Windows.Forms.Panel();
            this.comboBox_Parametre4 = new System.Windows.Forms.ComboBox();
            this.comboBox_Parametre3 = new System.Windows.Forms.ComboBox();
            this.comboBox_Parametre2 = new System.Windows.Forms.ComboBox();
            this.label_Parametre4 = new System.Windows.Forms.Label();
            this.listBox_port_logs = new System.Windows.Forms.ListBox();
            this.button_port_logs_save = new System.Windows.Forms.Button();
            this.textBox_Parametre1 = new System.Windows.Forms.TextBox();
            this.label_Parametre3 = new System.Windows.Forms.Label();
            this.label_Parametre2 = new System.Windows.Forms.Label();
            this.label_Parametre1 = new System.Windows.Forms.Label();
            this.button_refresh_ports = new System.Windows.Forms.Button();
            this.label_Kullanılabilir_Portlar = new System.Windows.Forms.Label();
            this.comboBox_ports = new System.Windows.Forms.ComboBox();
            this.button_port_dc = new System.Windows.Forms.Button();
            this.button_port_connect = new System.Windows.Forms.Button();
            this.panel_Error_msgs = new System.Windows.Forms.Panel();
            this.listBox_error_msgs = new System.Windows.Forms.ListBox();
            this.textBox_missing_pckt_count = new System.Windows.Forms.TextBox();
            this.label_missing_pckt_count = new System.Windows.Forms.Label();
            this.label_Error_Msgs = new System.Windows.Forms.Label();
            this.panel_Sensor_Infos = new System.Windows.Forms.Panel();
            this.textBox_Sicaklik_Degeri = new System.Windows.Forms.TextBox();
            this.textBox_Yukseklik_Degeri = new System.Windows.Forms.TextBox();
            this.textBox_Basinc_Degeri = new System.Windows.Forms.TextBox();
            this.textBox_Ivme_Degeri = new System.Windows.Forms.TextBox();
            this.textBox_Surat_Degeri = new System.Windows.Forms.TextBox();
            this.textBox_Motor3_Konumu = new System.Windows.Forms.TextBox();
            this.textBox_Motor2_Konumu = new System.Windows.Forms.TextBox();
            this.textBox_Motor1_Konumu = new System.Windows.Forms.TextBox();
            this.label_sicaklik = new System.Windows.Forms.Label();
            this.label_yukseklik = new System.Windows.Forms.Label();
            this.label_Basinc = new System.Windows.Forms.Label();
            this.label_ivme = new System.Windows.Forms.Label();
            this.label_surat = new System.Windows.Forms.Label();
            this.label_Motor3_Konum = new System.Windows.Forms.Label();
            this.label_Motor2_Konum = new System.Windows.Forms.Label();
            this.label_Motor1_Konum = new System.Windows.Forms.Label();
            this.textBox_engine_error = new System.Windows.Forms.TextBox();
            this.textBox_engine_off = new System.Windows.Forms.TextBox();
            this.textBox_engine_ok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.glControl1 = new OpenTK.GLControl();
            this.panel_Glcontrol = new System.Windows.Forms.Panel();
            this.button_turnOn_Xaxis = new System.Windows.Forms.Button();
            this.timer1_GLControl_X = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_graphs = new System.Windows.Forms.Panel();
            this.button_writeToExcel = new System.Windows.Forms.Button();
            this.button_draw_graph = new System.Windows.Forms.Button();
            this.groupBox_grafik_ozelligi = new System.Windows.Forms.GroupBox();
            this.checkBox_Sicaklik = new System.Windows.Forms.CheckBox();
            this.checkBox_Yukseklik = new System.Windows.Forms.CheckBox();
            this.checkBox_Basinc = new System.Windows.Forms.CheckBox();
            this.checkBox_Ivme = new System.Windows.Forms.CheckBox();
            this.checkBox_Surat = new System.Windows.Forms.CheckBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.panel_Connections.SuspendLayout();
            this.panel_Error_msgs.SuspendLayout();
            this.panel_Sensor_Infos.SuspendLayout();
            this.panel_Glcontrol.SuspendLayout();
            this.panel_graphs.SuspendLayout();
            this.groupBox_grafik_ozelligi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Connections
            // 
            this.panel_Connections.AutoSize = true;
            this.panel_Connections.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Connections.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Connections.Controls.Add(this.comboBox_Parametre4);
            this.panel_Connections.Controls.Add(this.comboBox_Parametre3);
            this.panel_Connections.Controls.Add(this.comboBox_Parametre2);
            this.panel_Connections.Controls.Add(this.label_Parametre4);
            this.panel_Connections.Controls.Add(this.listBox_port_logs);
            this.panel_Connections.Controls.Add(this.button_port_logs_save);
            this.panel_Connections.Controls.Add(this.textBox_Parametre1);
            this.panel_Connections.Controls.Add(this.label_Parametre3);
            this.panel_Connections.Controls.Add(this.label_Parametre2);
            this.panel_Connections.Controls.Add(this.label_Parametre1);
            this.panel_Connections.Controls.Add(this.button_refresh_ports);
            this.panel_Connections.Controls.Add(this.label_Kullanılabilir_Portlar);
            this.panel_Connections.Controls.Add(this.comboBox_ports);
            this.panel_Connections.Controls.Add(this.button_port_dc);
            this.panel_Connections.Controls.Add(this.button_port_connect);
            this.panel_Connections.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_Connections.Location = new System.Drawing.Point(12, 12);
            this.panel_Connections.Name = "panel_Connections";
            this.panel_Connections.Size = new System.Drawing.Size(395, 419);
            this.panel_Connections.TabIndex = 0;
            // 
            // comboBox_Parametre4
            // 
            this.comboBox_Parametre4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Parametre4.Enabled = false;
            this.comboBox_Parametre4.FormattingEnabled = true;
            this.comboBox_Parametre4.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBox_Parametre4.Location = new System.Drawing.Point(125, 178);
            this.comboBox_Parametre4.Name = "comboBox_Parametre4";
            this.comboBox_Parametre4.Size = new System.Drawing.Size(172, 23);
            this.comboBox_Parametre4.TabIndex = 18;
            // 
            // comboBox_Parametre3
            // 
            this.comboBox_Parametre3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Parametre3.Enabled = false;
            this.comboBox_Parametre3.FormattingEnabled = true;
            this.comboBox_Parametre3.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBox_Parametre3.Location = new System.Drawing.Point(125, 149);
            this.comboBox_Parametre3.Name = "comboBox_Parametre3";
            this.comboBox_Parametre3.Size = new System.Drawing.Size(172, 23);
            this.comboBox_Parametre3.TabIndex = 17;
            // 
            // comboBox_Parametre2
            // 
            this.comboBox_Parametre2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Parametre2.Enabled = false;
            this.comboBox_Parametre2.FormattingEnabled = true;
            this.comboBox_Parametre2.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_Parametre2.Location = new System.Drawing.Point(125, 119);
            this.comboBox_Parametre2.Name = "comboBox_Parametre2";
            this.comboBox_Parametre2.Size = new System.Drawing.Size(172, 23);
            this.comboBox_Parametre2.TabIndex = 16;
            // 
            // label_Parametre4
            // 
            this.label_Parametre4.AutoSize = true;
            this.label_Parametre4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Parametre4.Location = new System.Drawing.Point(9, 183);
            this.label_Parametre4.Name = "label_Parametre4";
            this.label_Parametre4.Size = new System.Drawing.Size(61, 18);
            this.label_Parametre4.TabIndex = 14;
            this.label_Parametre4.Text = "Parity :";
            // 
            // listBox_port_logs
            // 
            this.listBox_port_logs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_port_logs.FormattingEnabled = true;
            this.listBox_port_logs.HorizontalScrollbar = true;
            this.listBox_port_logs.ItemHeight = 15;
            this.listBox_port_logs.Location = new System.Drawing.Point(8, 260);
            this.listBox_port_logs.Name = "listBox_port_logs";
            this.listBox_port_logs.Size = new System.Drawing.Size(384, 124);
            this.listBox_port_logs.TabIndex = 13;
            // 
            // button_port_logs_save
            // 
            this.button_port_logs_save.BackColor = System.Drawing.SystemColors.Desktop;
            this.button_port_logs_save.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_port_logs_save.Location = new System.Drawing.Point(8, 393);
            this.button_port_logs_save.Name = "button_port_logs_save";
            this.button_port_logs_save.Size = new System.Drawing.Size(133, 23);
            this.button_port_logs_save.TabIndex = 12;
            this.button_port_logs_save.Text = "Logları Kaydet";
            this.button_port_logs_save.UseVisualStyleBackColor = false;
            this.button_port_logs_save.Click += new System.EventHandler(this.button_port_logs_save_Click);
            // 
            // textBox_Parametre1
            // 
            this.textBox_Parametre1.Enabled = false;
            this.textBox_Parametre1.Location = new System.Drawing.Point(125, 90);
            this.textBox_Parametre1.Name = "textBox_Parametre1";
            this.textBox_Parametre1.Size = new System.Drawing.Size(172, 23);
            this.textBox_Parametre1.TabIndex = 9;
            this.textBox_Parametre1.Text = "9600";
            // 
            // label_Parametre3
            // 
            this.label_Parametre3.AutoSize = true;
            this.label_Parametre3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Parametre3.Location = new System.Drawing.Point(9, 153);
            this.label_Parametre3.Name = "label_Parametre3";
            this.label_Parametre3.Size = new System.Drawing.Size(85, 18);
            this.label_Parametre3.TabIndex = 8;
            this.label_Parametre3.Text = "Stop Bits :";
            // 
            // label_Parametre2
            // 
            this.label_Parametre2.AutoSize = true;
            this.label_Parametre2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Parametre2.Location = new System.Drawing.Point(9, 124);
            this.label_Parametre2.Name = "label_Parametre2";
            this.label_Parametre2.Size = new System.Drawing.Size(85, 18);
            this.label_Parametre2.TabIndex = 7;
            this.label_Parametre2.Text = "Data Bits :";
            // 
            // label_Parametre1
            // 
            this.label_Parametre1.AutoSize = true;
            this.label_Parametre1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Parametre1.Location = new System.Drawing.Point(9, 95);
            this.label_Parametre1.Name = "label_Parametre1";
            this.label_Parametre1.Size = new System.Drawing.Size(95, 18);
            this.label_Parametre1.TabIndex = 6;
            this.label_Parametre1.Text = "Baud Rate :";
            // 
            // button_refresh_ports
            // 
            this.button_refresh_ports.BackColor = System.Drawing.SystemColors.Desktop;
            this.button_refresh_ports.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_refresh_ports.Location = new System.Drawing.Point(259, 31);
            this.button_refresh_ports.Name = "button_refresh_ports";
            this.button_refresh_ports.Size = new System.Drawing.Size(133, 23);
            this.button_refresh_ports.TabIndex = 5;
            this.button_refresh_ports.Text = "Portları Yenile";
            this.button_refresh_ports.UseVisualStyleBackColor = false;
            this.button_refresh_ports.Click += new System.EventHandler(this.button_refresh_ports_Click);
            // 
            // label_Kullanılabilir_Portlar
            // 
            this.label_Kullanılabilir_Portlar.AutoSize = true;
            this.label_Kullanılabilir_Portlar.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Kullanılabilir_Portlar.Location = new System.Drawing.Point(3, 31);
            this.label_Kullanılabilir_Portlar.Name = "label_Kullanılabilir_Portlar";
            this.label_Kullanılabilir_Portlar.Size = new System.Drawing.Size(201, 23);
            this.label_Kullanılabilir_Portlar.TabIndex = 4;
            this.label_Kullanılabilir_Portlar.Text = "Kullanılabilir Portlar";
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.Items.AddRange(new object[] {
            "Deneme-1",
            "Deneme-2"});
            this.comboBox_ports.Location = new System.Drawing.Point(3, 61);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(389, 23);
            this.comboBox_ports.TabIndex = 3;
            // 
            // button_port_dc
            // 
            this.button_port_dc.BackColor = System.Drawing.SystemColors.Desktop;
            this.button_port_dc.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_port_dc.Location = new System.Drawing.Point(259, 230);
            this.button_port_dc.Name = "button_port_dc";
            this.button_port_dc.Size = new System.Drawing.Size(133, 23);
            this.button_port_dc.TabIndex = 2;
            this.button_port_dc.Text = "Bağlantıyı Kes";
            this.button_port_dc.UseVisualStyleBackColor = false;
            this.button_port_dc.Click += new System.EventHandler(this.button_port_dc_Click);
            // 
            // button_port_connect
            // 
            this.button_port_connect.BackColor = System.Drawing.SystemColors.Desktop;
            this.button_port_connect.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_port_connect.Location = new System.Drawing.Point(8, 231);
            this.button_port_connect.Name = "button_port_connect";
            this.button_port_connect.Size = new System.Drawing.Size(133, 23);
            this.button_port_connect.TabIndex = 1;
            this.button_port_connect.Text = "Bağlan";
            this.button_port_connect.UseVisualStyleBackColor = false;
            this.button_port_connect.Click += new System.EventHandler(this.button_port_connect_Click);
            // 
            // panel_Error_msgs
            // 
            this.panel_Error_msgs.AutoSize = true;
            this.panel_Error_msgs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Error_msgs.Controls.Add(this.listBox_error_msgs);
            this.panel_Error_msgs.Controls.Add(this.textBox_missing_pckt_count);
            this.panel_Error_msgs.Controls.Add(this.label_missing_pckt_count);
            this.panel_Error_msgs.Controls.Add(this.label_Error_Msgs);
            this.panel_Error_msgs.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.panel_Error_msgs.Location = new System.Drawing.Point(12, 451);
            this.panel_Error_msgs.Name = "panel_Error_msgs";
            this.panel_Error_msgs.Size = new System.Drawing.Size(404, 419);
            this.panel_Error_msgs.TabIndex = 1;
            // 
            // listBox_error_msgs
            // 
            this.listBox_error_msgs.FormattingEnabled = true;
            this.listBox_error_msgs.HorizontalScrollbar = true;
            this.listBox_error_msgs.ItemHeight = 18;
            this.listBox_error_msgs.Location = new System.Drawing.Point(8, 50);
            this.listBox_error_msgs.Name = "listBox_error_msgs";
            this.listBox_error_msgs.Size = new System.Drawing.Size(384, 220);
            this.listBox_error_msgs.TabIndex = 4;
            // 
            // textBox_missing_pckt_count
            // 
            this.textBox_missing_pckt_count.Location = new System.Drawing.Point(8, 306);
            this.textBox_missing_pckt_count.Name = "textBox_missing_pckt_count";
            this.textBox_missing_pckt_count.ReadOnly = true;
            this.textBox_missing_pckt_count.Size = new System.Drawing.Size(150, 26);
            this.textBox_missing_pckt_count.TabIndex = 3;
            // 
            // label_missing_pckt_count
            // 
            this.label_missing_pckt_count.AutoSize = true;
            this.label_missing_pckt_count.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_missing_pckt_count.Location = new System.Drawing.Point(10, 285);
            this.label_missing_pckt_count.Name = "label_missing_pckt_count";
            this.label_missing_pckt_count.Size = new System.Drawing.Size(148, 18);
            this.label_missing_pckt_count.TabIndex = 2;
            this.label_missing_pckt_count.Text = "Kayıp Paket Sayısı";
            // 
            // label_Error_Msgs
            // 
            this.label_Error_Msgs.AutoSize = true;
            this.label_Error_Msgs.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Error_Msgs.Location = new System.Drawing.Point(8, 24);
            this.label_Error_Msgs.Name = "label_Error_Msgs";
            this.label_Error_Msgs.Size = new System.Drawing.Size(145, 23);
            this.label_Error_Msgs.TabIndex = 0;
            this.label_Error_Msgs.Text = "Hata Mesajları";
            // 
            // panel_Sensor_Infos
            // 
            this.panel_Sensor_Infos.AutoSize = true;
            this.panel_Sensor_Infos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_Sensor_Infos.Controls.Add(this.textBox_Sicaklik_Degeri);
            this.panel_Sensor_Infos.Controls.Add(this.textBox_Yukseklik_Degeri);
            this.panel_Sensor_Infos.Controls.Add(this.textBox_Basinc_Degeri);
            this.panel_Sensor_Infos.Controls.Add(this.textBox_Ivme_Degeri);
            this.panel_Sensor_Infos.Controls.Add(this.textBox_Surat_Degeri);
            this.panel_Sensor_Infos.Controls.Add(this.textBox_Motor3_Konumu);
            this.panel_Sensor_Infos.Controls.Add(this.textBox_Motor2_Konumu);
            this.panel_Sensor_Infos.Controls.Add(this.textBox_Motor1_Konumu);
            this.panel_Sensor_Infos.Controls.Add(this.label_sicaklik);
            this.panel_Sensor_Infos.Controls.Add(this.label_yukseklik);
            this.panel_Sensor_Infos.Controls.Add(this.label_Basinc);
            this.panel_Sensor_Infos.Controls.Add(this.label_ivme);
            this.panel_Sensor_Infos.Controls.Add(this.label_surat);
            this.panel_Sensor_Infos.Controls.Add(this.label_Motor3_Konum);
            this.panel_Sensor_Infos.Controls.Add(this.label_Motor2_Konum);
            this.panel_Sensor_Infos.Controls.Add(this.label_Motor1_Konum);
            this.panel_Sensor_Infos.Controls.Add(this.textBox_engine_error);
            this.panel_Sensor_Infos.Controls.Add(this.textBox_engine_off);
            this.panel_Sensor_Infos.Controls.Add(this.textBox_engine_ok);
            this.panel_Sensor_Infos.Controls.Add(this.label1);
            this.panel_Sensor_Infos.Location = new System.Drawing.Point(422, 12);
            this.panel_Sensor_Infos.Name = "panel_Sensor_Infos";
            this.panel_Sensor_Infos.Size = new System.Drawing.Size(541, 389);
            this.panel_Sensor_Infos.TabIndex = 2;
            // 
            // textBox_Sicaklik_Degeri
            // 
            this.textBox_Sicaklik_Degeri.Location = new System.Drawing.Point(332, 235);
            this.textBox_Sicaklik_Degeri.Name = "textBox_Sicaklik_Degeri";
            this.textBox_Sicaklik_Degeri.ReadOnly = true;
            this.textBox_Sicaklik_Degeri.Size = new System.Drawing.Size(100, 23);
            this.textBox_Sicaklik_Degeri.TabIndex = 19;
            this.textBox_Sicaklik_Degeri.Text = "NaN";
            this.textBox_Sicaklik_Degeri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Yukseklik_Degeri
            // 
            this.textBox_Yukseklik_Degeri.Location = new System.Drawing.Point(131, 235);
            this.textBox_Yukseklik_Degeri.Name = "textBox_Yukseklik_Degeri";
            this.textBox_Yukseklik_Degeri.ReadOnly = true;
            this.textBox_Yukseklik_Degeri.Size = new System.Drawing.Size(100, 23);
            this.textBox_Yukseklik_Degeri.TabIndex = 18;
            this.textBox_Yukseklik_Degeri.Text = "NaN";
            this.textBox_Yukseklik_Degeri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Basinc_Degeri
            // 
            this.textBox_Basinc_Degeri.Location = new System.Drawing.Point(413, 200);
            this.textBox_Basinc_Degeri.Name = "textBox_Basinc_Degeri";
            this.textBox_Basinc_Degeri.ReadOnly = true;
            this.textBox_Basinc_Degeri.Size = new System.Drawing.Size(100, 23);
            this.textBox_Basinc_Degeri.TabIndex = 17;
            this.textBox_Basinc_Degeri.Text = "NaN";
            this.textBox_Basinc_Degeri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Ivme_Degeri
            // 
            this.textBox_Ivme_Degeri.Location = new System.Drawing.Point(237, 200);
            this.textBox_Ivme_Degeri.Name = "textBox_Ivme_Degeri";
            this.textBox_Ivme_Degeri.ReadOnly = true;
            this.textBox_Ivme_Degeri.Size = new System.Drawing.Size(100, 23);
            this.textBox_Ivme_Degeri.TabIndex = 16;
            this.textBox_Ivme_Degeri.Text = "NaN";
            this.textBox_Ivme_Degeri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Surat_Degeri
            // 
            this.textBox_Surat_Degeri.Location = new System.Drawing.Point(78, 200);
            this.textBox_Surat_Degeri.Name = "textBox_Surat_Degeri";
            this.textBox_Surat_Degeri.ReadOnly = true;
            this.textBox_Surat_Degeri.Size = new System.Drawing.Size(100, 23);
            this.textBox_Surat_Degeri.TabIndex = 15;
            this.textBox_Surat_Degeri.Text = "NaN";
            this.textBox_Surat_Degeri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Motor3_Konumu
            // 
            this.textBox_Motor3_Konumu.Location = new System.Drawing.Point(160, 119);
            this.textBox_Motor3_Konumu.Name = "textBox_Motor3_Konumu";
            this.textBox_Motor3_Konumu.ReadOnly = true;
            this.textBox_Motor3_Konumu.Size = new System.Drawing.Size(100, 23);
            this.textBox_Motor3_Konumu.TabIndex = 14;
            this.textBox_Motor3_Konumu.Text = "NaN";
            this.textBox_Motor3_Konumu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Motor2_Konumu
            // 
            this.textBox_Motor2_Konumu.Location = new System.Drawing.Point(413, 81);
            this.textBox_Motor2_Konumu.Name = "textBox_Motor2_Konumu";
            this.textBox_Motor2_Konumu.ReadOnly = true;
            this.textBox_Motor2_Konumu.Size = new System.Drawing.Size(100, 23);
            this.textBox_Motor2_Konumu.TabIndex = 13;
            this.textBox_Motor2_Konumu.Text = "NaN";
            this.textBox_Motor2_Konumu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Motor1_Konumu
            // 
            this.textBox_Motor1_Konumu.Location = new System.Drawing.Point(160, 81);
            this.textBox_Motor1_Konumu.Name = "textBox_Motor1_Konumu";
            this.textBox_Motor1_Konumu.ReadOnly = true;
            this.textBox_Motor1_Konumu.Size = new System.Drawing.Size(100, 23);
            this.textBox_Motor1_Konumu.TabIndex = 12;
            this.textBox_Motor1_Konumu.Text = "NaN";
            this.textBox_Motor1_Konumu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_sicaklik
            // 
            this.label_sicaklik.AutoSize = true;
            this.label_sicaklik.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_sicaklik.Location = new System.Drawing.Point(251, 235);
            this.label_sicaklik.Name = "label_sicaklik";
            this.label_sicaklik.Size = new System.Drawing.Size(75, 18);
            this.label_sicaklik.TabIndex = 11;
            this.label_sicaklik.Text = "Sıcaklık: ";
            // 
            // label_yukseklik
            // 
            this.label_yukseklik.AutoSize = true;
            this.label_yukseklik.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_yukseklik.Location = new System.Drawing.Point(39, 235);
            this.label_yukseklik.Name = "label_yukseklik";
            this.label_yukseklik.Size = new System.Drawing.Size(86, 18);
            this.label_yukseklik.TabIndex = 10;
            this.label_yukseklik.Text = "Yükseklik:";
            // 
            // label_Basinc
            // 
            this.label_Basinc.AutoSize = true;
            this.label_Basinc.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Basinc.Location = new System.Drawing.Point(343, 200);
            this.label_Basinc.Name = "label_Basinc";
            this.label_Basinc.Size = new System.Drawing.Size(64, 18);
            this.label_Basinc.TabIndex = 9;
            this.label_Basinc.Text = "Basınç:";
            // 
            // label_ivme
            // 
            this.label_ivme.AutoSize = true;
            this.label_ivme.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_ivme.Location = new System.Drawing.Point(181, 200);
            this.label_ivme.Name = "label_ivme";
            this.label_ivme.Size = new System.Drawing.Size(50, 18);
            this.label_ivme.TabIndex = 8;
            this.label_ivme.Text = "İvme:";
            // 
            // label_surat
            // 
            this.label_surat.AutoSize = true;
            this.label_surat.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_surat.Location = new System.Drawing.Point(14, 200);
            this.label_surat.Name = "label_surat";
            this.label_surat.Size = new System.Drawing.Size(58, 18);
            this.label_surat.TabIndex = 7;
            this.label_surat.Text = "Sürat: ";
            // 
            // label_Motor3_Konum
            // 
            this.label_Motor3_Konum.AutoSize = true;
            this.label_Motor3_Konum.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Motor3_Konum.Location = new System.Drawing.Point(14, 119);
            this.label_Motor3_Konum.Name = "label_Motor3_Konum";
            this.label_Motor3_Konum.Size = new System.Drawing.Size(141, 18);
            this.label_Motor3_Konum.TabIndex = 6;
            this.label_Motor3_Konum.Text = "Motor3 Konumu: ";
            // 
            // label_Motor2_Konum
            // 
            this.label_Motor2_Konum.AutoSize = true;
            this.label_Motor2_Konum.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Motor2_Konum.Location = new System.Drawing.Point(266, 81);
            this.label_Motor2_Konum.Name = "label_Motor2_Konum";
            this.label_Motor2_Konum.Size = new System.Drawing.Size(141, 18);
            this.label_Motor2_Konum.TabIndex = 5;
            this.label_Motor2_Konum.Text = "Motor2 Konumu: ";
            // 
            // label_Motor1_Konum
            // 
            this.label_Motor1_Konum.AutoSize = true;
            this.label_Motor1_Konum.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Motor1_Konum.Location = new System.Drawing.Point(13, 81);
            this.label_Motor1_Konum.Name = "label_Motor1_Konum";
            this.label_Motor1_Konum.Size = new System.Drawing.Size(137, 18);
            this.label_Motor1_Konum.TabIndex = 4;
            this.label_Motor1_Konum.Text = "Motor1 Konumu:";
            // 
            // textBox_engine_error
            // 
            this.textBox_engine_error.BackColor = System.Drawing.Color.LightSeaGreen;
            this.textBox_engine_error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_engine_error.Enabled = false;
            this.textBox_engine_error.Location = new System.Drawing.Point(225, 48);
            this.textBox_engine_error.Multiline = true;
            this.textBox_engine_error.Name = "textBox_engine_error";
            this.textBox_engine_error.Size = new System.Drawing.Size(100, 20);
            this.textBox_engine_error.TabIndex = 3;
            // 
            // textBox_engine_off
            // 
            this.textBox_engine_off.BackColor = System.Drawing.Color.DarkRed;
            this.textBox_engine_off.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_engine_off.Enabled = false;
            this.textBox_engine_off.Location = new System.Drawing.Point(119, 48);
            this.textBox_engine_off.Multiline = true;
            this.textBox_engine_off.Name = "textBox_engine_off";
            this.textBox_engine_off.Size = new System.Drawing.Size(100, 20);
            this.textBox_engine_off.TabIndex = 2;
            // 
            // textBox_engine_ok
            // 
            this.textBox_engine_ok.BackColor = System.Drawing.Color.Green;
            this.textBox_engine_ok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_engine_ok.Enabled = false;
            this.textBox_engine_ok.Location = new System.Drawing.Point(13, 48);
            this.textBox_engine_ok.Multiline = true;
            this.textBox_engine_ok.Name = "textBox_engine_ok";
            this.textBox_engine_ok.Size = new System.Drawing.Size(100, 20);
            this.textBox_engine_ok.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motor Durumu";
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(123, 3);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(403, 384);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = true;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // panel_Glcontrol
            // 
            this.panel_Glcontrol.AutoSize = true;
            this.panel_Glcontrol.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_Glcontrol.Controls.Add(this.button_turnOn_Xaxis);
            this.panel_Glcontrol.Controls.Add(this.glControl1);
            this.panel_Glcontrol.Location = new System.Drawing.Point(969, 11);
            this.panel_Glcontrol.Name = "panel_Glcontrol";
            this.panel_Glcontrol.Size = new System.Drawing.Size(653, 390);
            this.panel_Glcontrol.TabIndex = 3;
            // 
            // button_turnOn_Xaxis
            // 
            this.button_turnOn_Xaxis.Location = new System.Drawing.Point(451, 32);
            this.button_turnOn_Xaxis.Name = "button_turnOn_Xaxis";
            this.button_turnOn_Xaxis.Size = new System.Drawing.Size(198, 23);
            this.button_turnOn_Xaxis.TabIndex = 1;
            this.button_turnOn_Xaxis.Text = "X Eksenine Göre Döndür";
            this.button_turnOn_Xaxis.UseVisualStyleBackColor = true;
            this.button_turnOn_Xaxis.Visible = false;
            this.button_turnOn_Xaxis.Click += new System.EventHandler(this.button_turnOn_Xaxis_Click);
            // 
            // timer1_GLControl_X
            // 
            this.timer1_GLControl_X.Tick += new System.EventHandler(this.timer1_GLControl_X_Tick);
            // 
            // panel_graphs
            // 
            this.panel_graphs.AutoSize = true;
            this.panel_graphs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_graphs.Controls.Add(this.button_writeToExcel);
            this.panel_graphs.Controls.Add(this.button_draw_graph);
            this.panel_graphs.Controls.Add(this.groupBox_grafik_ozelligi);
            this.panel_graphs.Controls.Add(this.zedGraphControl1);
            this.panel_graphs.Location = new System.Drawing.Point(424, 412);
            this.panel_graphs.Name = "panel_graphs";
            this.panel_graphs.Size = new System.Drawing.Size(1198, 458);
            this.panel_graphs.TabIndex = 4;
            // 
            // button_writeToExcel
            // 
            this.button_writeToExcel.BackColor = System.Drawing.SystemColors.Desktop;
            this.button_writeToExcel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_writeToExcel.Location = new System.Drawing.Point(246, 16);
            this.button_writeToExcel.Name = "button_writeToExcel";
            this.button_writeToExcel.Size = new System.Drawing.Size(145, 82);
            this.button_writeToExcel.TabIndex = 8;
            this.button_writeToExcel.Text = "Verileri Veri Tabanına Kaydet";
            this.button_writeToExcel.UseVisualStyleBackColor = false;
            this.button_writeToExcel.Click += new System.EventHandler(this.button_writeToExcel_Click);
            // 
            // button_draw_graph
            // 
            this.button_draw_graph.Location = new System.Drawing.Point(428, 36);
            this.button_draw_graph.Name = "button_draw_graph";
            this.button_draw_graph.Size = new System.Drawing.Size(111, 23);
            this.button_draw_graph.TabIndex = 7;
            this.button_draw_graph.Text = "button_draw_graph";
            this.button_draw_graph.UseVisualStyleBackColor = true;
            this.button_draw_graph.Visible = false;
            this.button_draw_graph.Click += new System.EventHandler(this.button_draw_graph_Click);
            // 
            // groupBox_grafik_ozelligi
            // 
            this.groupBox_grafik_ozelligi.Controls.Add(this.checkBox_Sicaklik);
            this.groupBox_grafik_ozelligi.Controls.Add(this.checkBox_Yukseklik);
            this.groupBox_grafik_ozelligi.Controls.Add(this.checkBox_Basinc);
            this.groupBox_grafik_ozelligi.Controls.Add(this.checkBox_Ivme);
            this.groupBox_grafik_ozelligi.Controls.Add(this.checkBox_Surat);
            this.groupBox_grafik_ozelligi.Location = new System.Drawing.Point(4, 3);
            this.groupBox_grafik_ozelligi.Name = "groupBox_grafik_ozelligi";
            this.groupBox_grafik_ozelligi.Size = new System.Drawing.Size(236, 100);
            this.groupBox_grafik_ozelligi.TabIndex = 6;
            this.groupBox_grafik_ozelligi.TabStop = false;
            this.groupBox_grafik_ozelligi.Text = "Grafik Tipi - Y Ekseni";
            // 
            // checkBox_Sicaklik
            // 
            this.checkBox_Sicaklik.AutoSize = true;
            this.checkBox_Sicaklik.Location = new System.Drawing.Point(113, 47);
            this.checkBox_Sicaklik.Name = "checkBox_Sicaklik";
            this.checkBox_Sicaklik.Size = new System.Drawing.Size(103, 19);
            this.checkBox_Sicaklik.TabIndex = 4;
            this.checkBox_Sicaklik.Text = "Sıcaklık Grafiği";
            this.checkBox_Sicaklik.UseVisualStyleBackColor = true;
            // 
            // checkBox_Yukseklik
            // 
            this.checkBox_Yukseklik.AutoSize = true;
            this.checkBox_Yukseklik.Location = new System.Drawing.Point(113, 22);
            this.checkBox_Yukseklik.Name = "checkBox_Yukseklik";
            this.checkBox_Yukseklik.Size = new System.Drawing.Size(113, 19);
            this.checkBox_Yukseklik.TabIndex = 3;
            this.checkBox_Yukseklik.Text = "Yükseklik Grafiği";
            this.checkBox_Yukseklik.UseVisualStyleBackColor = true;
            // 
            // checkBox_Basinc
            // 
            this.checkBox_Basinc.AutoSize = true;
            this.checkBox_Basinc.Location = new System.Drawing.Point(8, 72);
            this.checkBox_Basinc.Name = "checkBox_Basinc";
            this.checkBox_Basinc.Size = new System.Drawing.Size(98, 19);
            this.checkBox_Basinc.TabIndex = 2;
            this.checkBox_Basinc.Text = "Basınç Grafiği";
            this.checkBox_Basinc.UseVisualStyleBackColor = true;
            // 
            // checkBox_Ivme
            // 
            this.checkBox_Ivme.AutoSize = true;
            this.checkBox_Ivme.Location = new System.Drawing.Point(8, 47);
            this.checkBox_Ivme.Name = "checkBox_Ivme";
            this.checkBox_Ivme.Size = new System.Drawing.Size(90, 19);
            this.checkBox_Ivme.TabIndex = 1;
            this.checkBox_Ivme.Text = "İvme Grafiği";
            this.checkBox_Ivme.UseVisualStyleBackColor = true;
            // 
            // checkBox_Surat
            // 
            this.checkBox_Surat.AutoSize = true;
            this.checkBox_Surat.Location = new System.Drawing.Point(8, 22);
            this.checkBox_Surat.Name = "checkBox_Surat";
            this.checkBox_Surat.Size = new System.Drawing.Size(91, 19);
            this.checkBox_Surat.TabIndex = 0;
            this.checkBox_Surat.Text = "Sürat Grafiği";
            this.checkBox_Surat.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(4, 104);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1190, 351);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel_graphs);
            this.Controls.Add(this.panel_Glcontrol);
            this.Controls.Add(this.panel_Sensor_Infos);
            this.Controls.Add(this.panel_Error_msgs);
            this.Controls.Add(this.panel_Connections);
            this.Name = "Form1";
            this.Text = "Vega Roket Arayüzü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Connections.ResumeLayout(false);
            this.panel_Connections.PerformLayout();
            this.panel_Error_msgs.ResumeLayout(false);
            this.panel_Error_msgs.PerformLayout();
            this.panel_Sensor_Infos.ResumeLayout(false);
            this.panel_Sensor_Infos.PerformLayout();
            this.panel_Glcontrol.ResumeLayout(false);
            this.panel_graphs.ResumeLayout(false);
            this.groupBox_grafik_ozelligi.ResumeLayout(false);
            this.groupBox_grafik_ozelligi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_Connections;
        private TextBox textBox_Parametre1;
        private Label label_Parametre3;
        private Label label_Parametre2;
        private Label label_Parametre1;
        private Button button_refresh_ports;
        private Label label_Kullanılabilir_Portlar;
        private ComboBox comboBox_ports;
        private Button button_port_dc;
        private Button button_port_connect;
        private Button button_port_logs_save;
        private Panel panel_Error_msgs;
        private TextBox textBox_missing_pckt_count;
        private Label label_missing_pckt_count;
        private Label label_Error_Msgs;
        private Panel panel_Sensor_Infos;
        private TextBox textBox_engine_error;
        private TextBox textBox_engine_off;
        private TextBox textBox_engine_ok;
        private Label label1;
        private Label label_sicaklik;
        private Label label_yukseklik;
        private Label label_Basinc;
        private Label label_ivme;
        private Label label_surat;
        private Label label_Motor3_Konum;
        private Label label_Motor2_Konum;
        private Label label_Motor1_Konum;
        private TextBox textBox_Sicaklik_Degeri;
        private TextBox textBox_Yukseklik_Degeri;
        private TextBox textBox_Basinc_Degeri;
        private TextBox textBox_Ivme_Degeri;
        private TextBox textBox_Surat_Degeri;
        private TextBox textBox_Motor3_Konumu;
        private TextBox textBox_Motor2_Konumu;
        private TextBox textBox_Motor1_Konumu;
        private OpenTK.GLControl glControl1;
        private Panel panel_Glcontrol;
        private Button button_turnOn_Xaxis;
        private System.Windows.Forms.Timer timer1_GLControl_X;
        private ListBox listBox_port_logs;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox listBox_error_msgs;
        private Label label_Parametre4;
        private ComboBox comboBox_Parametre2;
        private ComboBox comboBox_Parametre3;
        private ComboBox comboBox_Parametre4;
        private Panel panel_graphs;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private GroupBox groupBox_grafik_ozelligi;
        private Button button_draw_graph;
        private CheckBox checkBox_Sicaklik;
        private CheckBox checkBox_Yukseklik;
        private CheckBox checkBox_Basinc;
        private CheckBox checkBox_Ivme;
        private CheckBox checkBox_Surat;
        private Button button_writeToExcel;
    }
}