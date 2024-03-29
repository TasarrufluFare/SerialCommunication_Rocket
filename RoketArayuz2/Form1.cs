﻿//Tasarruflu Fare Tarafından Oluşturulmuştur.
using OpenTK;
using OpenTK.Graphics.OpenGL;
using ZedGraph;
using System;
using System.IO.Ports;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.Security.Policy;
using System.Diagnostics.CodeAnalysis;

namespace RoketArayuz2
{
    public partial class Form1 : Form
    {
        //GL-Control Global Degiskenleri
        float x = 0, y = 0, z = 0;
        bool cx = false, cy = false, cz = false;
        //--------------------------------

        //Serial Ports Global Degiskenleri
        SerialPort mySerialPort = new SerialPort();
        short gelen_paket_sayisi = 0;
        List<double> xs1 = new List<double>();
        double gecen_zaman = 0;
        //--------------------------------

        //Zed Graph Tanımlamaları
        List<double> kaydedilen_surat_bilgisi = new List<double>();
        List<double> kaydedilen_ivme_bilgisi = new List<double>();
        List<double> kaydedilen_basinc_bilgisi = new List<double>();
        List<double> kaydedilen_yukseklik_bilgisi = new List<double>();
        List<double> kaydedilen_sicaklik_bilgisi = new List<double>();
        //--------------------------------Tasarruflu Fare--------------------------

        //Sensör Verileri Global Dictionary
        Dictionary<string, string> sensorInformations = new Dictionary<string, string>()
        {
            {"MotorKonumu1", "NaN"},
            {"MotorKonumu2", "NaN"},
            {"MotorKonumu3", "NaN"},
            {"Sürat", "NaN"},
            {"İvme", "NaN"},
            {"Basınç", "NaN"},
            {"Yükseklik", "NaN"},
            {"Sıcaklık", "NaN"}
        };
        //--------------------------------Tasarruflu Fare-----------------------------
        public Form1()
        {
            InitializeComponent();
        }
        //Motor Durumu Fonksiyonlari
        public void engine_ok()
        {
            textBox_engine_ok.BackColor = Color.Lime;
            textBox_engine_ok.Height = 30;
            textBox_engine_off.BackColor = Color.DarkRed;
            textBox_engine_off.Height = 20;
            textBox_engine_error.BackColor = Color.LightSeaGreen;
            textBox_engine_error.Height = 20;
        }
        public void engine_off()
        {
            textBox_engine_ok.BackColor = Color.Green;
            textBox_engine_ok.Height = 20;
            textBox_engine_off.BackColor = Color.Red;
            textBox_engine_off.Height = 30;
            textBox_engine_error.BackColor = Color.LightSeaGreen;
            textBox_engine_error.Height = 20;
        }
        public void engine_error()
        {
            textBox_engine_off.BackColor = Color.Red;
            textBox_engine_off.Height = 20;
            textBox_engine_ok.BackColor = Color.Green;
            textBox_engine_ok.Height = 20;
            textBox_engine_error.BackColor = Color.Cyan;
            textBox_engine_error.Height = 30;
        }
        //------------------------Tasarruflu Fare--------------------------------

        //Loglari Kaydetme
        public void SaveLogs()
        {
            // at the specified location 
            StreamWriter sw = new StreamWriter("PortLogsSave.txt");

            // To write a line in buffer
            foreach (string log_item in listBox_port_logs.Items)
            {
                sw.WriteLine(log_item);
            }

            // To write in output stream
            sw.Flush();

            // To close the stream
            sw.Close();

            MessageBox.Show("Port Loglari Kaydedildi", "Kayit Basarili");
        }
        //----------------------------Tasarruflu Fare--------------------------------------
        private void button_port_connect_Click(object sender, EventArgs e)
        {
            try
            {
                mySerialPort.PortName = comboBox_ports.Text;
                mySerialPort.BaudRate = Convert.ToInt32(textBox_Parametre1.Text);
                mySerialPort.DataBits = Convert.ToInt32(comboBox_Parametre2.Text);
                mySerialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox_Parametre3.Text);
                mySerialPort.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox_Parametre4.Text); ;
                mySerialPort.Open();
                listBox_port_logs.Items.Add($"{mySerialPort.PortName}'e bağlandı.");
                listBox_port_logs.TopIndex = listBox_port_logs.Items.Count - 1;
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(mySerialPort_DataRecieved);
                engine_ok();
            }
            catch (Exception error)
            {
                listBox_error_msgs.Items.Add(error.Message);
                listBox_error_msgs.TopIndex = listBox_error_msgs.Items.Count - 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_ports.Items.AddRange(ports);
            timer1_GLControl_X.Interval = 100;
            textBox_Parametre1.Text = "9600";
            comboBox_Parametre2.SelectedItem = "8";
            comboBox_Parametre3.SelectedItem = "One";
            comboBox_Parametre4.SelectedItem = "None";
            engine_off();
        }

        private void button_port_dc_Click(object sender, EventArgs e)
        {
            try
            {
                if (mySerialPort.IsOpen)
                {
                    mySerialPort.Close();
                    engine_off();
                    listBox_port_logs.Items.Add($"{mySerialPort.PortName} ile olan bağlantı kesildi.");
                    listBox_port_logs.TopIndex = listBox_port_logs.Items.Count - 1;
                }
            }
            catch (Exception error)
            {
                listBox_error_msgs.Items.Add(error.Message);
                listBox_error_msgs.TopIndex = listBox_error_msgs.Items.Count - 1;
            }

        }

        private void button_port_logs_save_Click(object sender, EventArgs e)
        {
            engine_error();
            SaveLogs();
        }

        //GL-Control Komutlari
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            float step = 1.0f;
            float topla = step;
            float radius = 5.0f;
            float dikey1 = radius, dikey2 = -radius;
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Clear(ClearBufferMask.DepthBufferBit);

            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(1.04f, 4 / 3, 1, 10000);
            Matrix4 lookat = Matrix4.LookAt(25, 0, 0, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.LoadMatrix(ref perspective);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.LoadMatrix(ref lookat);
            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);

            GL.Rotate(x, 1.0, 0.0, 0.0);//ÖNEMLİ
            GL.Rotate(z, 0.0, 1.0, 0.0);
            GL.Rotate(y, 0.0, 0.0, 1.0);

            silindir(step, topla, radius, 5, -5);
            silindir(0.01f, topla, 0.5f, 9, 9.7f);
            silindir(0.01f, topla, 0.1f, 5, dikey1 + 5);
            koni(0.01f, 0.01f, radius, 3.0f, 3, 5);
            koni(0.01f, 0.01f, radius, 2.0f, -5.0f, -10.0f);
            Pervane(9.0f, 11.0f, 0.2f, 0.5f);

            GL.Begin(BeginMode.Lines);

            GL.Color3(Color.FromArgb(250, 0, 0));
            GL.Vertex3(-30.0, 0.0, 0.0);
            GL.Vertex3(30.0, 0.0, 0.0);


            GL.Color3(Color.FromArgb(0, 0, 0));
            GL.Vertex3(0.0, 30.0, 0.0);
            GL.Vertex3(0.0, -30.0, 0.0);

            GL.Color3(Color.FromArgb(0, 0, 250));
            GL.Vertex3(0.0, 0.0, 30.0);
            GL.Vertex3(0.0, 0.0, -30.0);

            GL.End();
            //GraphicsContext.CurrentContext.VSync = true;
            glControl1.SwapBuffers();
        }

        private void button_turnOn_Xaxis_Click(object sender, EventArgs e)
        {
            if (cx == false)
                cx = true;
            else
                cx = false;
            timer1_GLControl_X.Start();
        }
        //Dönüş animasyonu için tur sayisi
        short tur_sayisi = 0;
        //--------------------------Tasarruflu Fare---------------------------
        private void timer1_GLControl_X_Tick(object sender, EventArgs e)
        {
            /*
            if (cx == true)
            {
                if (x < 360)
                    x += 5;
                else
                    x = 0;
            }
            if (x == 0)
            {
                tur_sayisi += 1;
            }
            if (tur_sayisi == 2)
            {
                timer1_GLControl_X.Stop();
            }
            else
            {
                glControl1.Invalidate();
            }  */
            for (short i = 0; i < 200; i++)
            {
                x = i;
                glControl1.Invalidate();
            }
            for (short k = 0; k > -300; k--)
            {
                z = k;
                glControl1.Invalidate();
            }
        }

        private void button_refresh_ports_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_ports.Items.Clear();
            comboBox_ports.Items.AddRange(ports);
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            GL.Enable(EnableCap.DepthTest);
        }
        private void silindir(float step, float topla, float radius, float dikey1, float dikey2)
        {
            float eski_step = 0.1f;
            GL.Begin(BeginMode.Quads);//Y EKSEN CIZIM DAİRENİN
            while (step <= 360)
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 0, 0));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(255, 255, 255));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 0, 0));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(255, 255, 255));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 0, 0));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(255, 255, 255));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 0, 0));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(255, 255, 255));


                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                float ciz2_x = (float)(radius * Math.Cos((step + 2) * Math.PI / 180F));
                float ciz2_y = (float)(radius * Math.Sin((step + 2) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey1, ciz2_y);

                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();
            GL.Begin(BeginMode.Lines);
            step = eski_step;
            topla = step;
            while (step <= 180)// UST KAPAK
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(250, 250, 200));


                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                float ciz2_x = (float)(radius * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey1, ciz2_y);

                GL.Vertex3(ciz1_x, dikey1, ciz1_y);
                GL.Vertex3(ciz2_x, dikey1, ciz2_y);
                step += topla;
            }
            step = eski_step;
            topla = step;
            while (step <= 180)//ALT KAPAK
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(250, 250, 200));

                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey2, ciz1_y);

                float ciz2_x = (float)(radius * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);

                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();
        }
        private void koni(float step, float topla, float radius1, float radius2, float dikey1, float dikey2)
        {
            float eski_step = 0.1f;
            GL.Begin(BeginMode.Lines);//Y EKSEN CIZIM DAIRENIN
            while (step <= 360)
            {
                if (step < 45)
                    GL.Color3(1.0, 1.0, 1.0);
                else if (step < 90)
                    GL.Color3(1.0, 0.0, 0.0);
                else if (step < 135)
                    GL.Color3(1.0, 1.0, 1.0);
                else if (step < 180)
                    GL.Color3(1.0, 0.0, 0.0);
                else if (step < 225)
                    GL.Color3(1.0, 1.0, 1.0);
                else if (step < 270)
                    GL.Color3(1.0, 0.0, 0.0);
                else if (step < 315)
                    GL.Color3(1.0, 1.0, 1.0);
                else if (step < 360)
                    GL.Color3(1.0, 0.0, 0.0);


                float ciz1_x = (float)(radius1 * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius1 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                float ciz2_x = (float)(radius2 * Math.Cos(step * Math.PI / 180F));
                float ciz2_y = (float)(radius2 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();

            GL.Begin(BeginMode.Lines);
            step = eski_step;
            topla = step;
            while (step <= 180)// UST KAPAK
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(250, 250, 200));


                float ciz1_x = (float)(radius2 * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius2 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey2, ciz1_y);

                float ciz2_x = (float)(radius2 * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius2 * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);

                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            step = eski_step;
            topla = step;
            GL.End();
        }
        private void Pervane(float yukseklik, float uzunluk, float kalinlik, float egiklik)
        {
            float radius = 10, angle = 45.0f;
            GL.Begin(BeginMode.Quads);

            GL.Color3(Color.Red);
            GL.Vertex3(uzunluk, yukseklik, kalinlik);
            GL.Vertex3(uzunluk, yukseklik + egiklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik + egiklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik, kalinlik);

            GL.Color3(Color.Red);
            GL.Vertex3(-uzunluk, yukseklik + egiklik, kalinlik);
            GL.Vertex3(-uzunluk, yukseklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik + egiklik, kalinlik);

            GL.Color3(Color.White);
            GL.Vertex3(kalinlik, yukseklik, -uzunluk);
            GL.Vertex3(-kalinlik, yukseklik + egiklik, -uzunluk);
            GL.Vertex3(-kalinlik, yukseklik + egiklik, 0.0);//+
            GL.Vertex3(kalinlik, yukseklik, 0.0);//-

            GL.Color3(Color.White);
            GL.Vertex3(kalinlik, yukseklik + egiklik, +uzunluk);
            GL.Vertex3(-kalinlik, yukseklik, +uzunluk);
            GL.Vertex3(-kalinlik, yukseklik, 0.0);
            GL.Vertex3(kalinlik, yukseklik + egiklik, 0.0);
            GL.End();

        }
        //--------------------------------Tasarruflu Fare------------------------------------------------

        //Serial Port Read Data Continuously
        List<String> Info_Value_Seperated = new List<String>();
        List<String> Info_Value = new List<String>();
        public void readed_data_analysis(String s)
        {   
            try
            {
                //string[]? Info_Value = Array.Empty<string>(); //Tasarruflu Fare
                Info_Value = s.Split(",").ToList();

                foreach (String Value in Info_Value)
                {
                    if (Value.Split(":")[1] != "")
                    {
                        Info_Value_Seperated.Add(Value.Split(":")[1]);
                    }
                    else if (Value.Split(":")[1] == "")
                    {
                        Info_Value_Seperated.Add("NaN");
                    }
                }
                if (Info_Value_Seperated[0] == "1")
                {
                    listBox_port_logs.Items.Add("Yeni Düşüş Verileri Başlangıcı");
                    Info_Value.Clear();
                    Info_Value_Seperated.Clear();
                    kaydedilen_surat_bilgisi.Clear();
                    kaydedilen_ivme_bilgisi.Clear();
                    kaydedilen_basinc_bilgisi.Clear();
                    kaydedilen_yukseklik_bilgisi.Clear();
                    kaydedilen_sicaklik_bilgisi.Clear();
                    xs1.Clear();
                    gecen_zaman = 0;
                }
                else if (Info_Value_Seperated[0]=="0")
                {
                    textBox_Motor1_Konumu.Text = Info_Value_Seperated[1];
                    textBox_Motor2_Konumu.Text = Info_Value_Seperated[2];
                    textBox_Motor3_Konumu.Text = Info_Value_Seperated[3];
                    textBox_Surat_Degeri.Text = Info_Value_Seperated[4];
                    textBox_Ivme_Degeri.Text = Info_Value_Seperated[5];
                    textBox_Basinc_Degeri.Text = Info_Value_Seperated[6];
                    textBox_Yukseklik_Degeri.Text = Info_Value_Seperated[7];
                    textBox_Sicaklik_Degeri.Text = Info_Value_Seperated[8];
                    Save_Data_For_Graph(Info_Value_Seperated);
                    Info_Value_Seperated.Clear();
                    draw_graph_func();
                }
                
   
            }
            catch(Exception error)
            {
                listBox_error_msgs.Items.Add("Data Analysis Error: Got Wrong Format Data | " + error.Message);
                listBox_error_msgs.TopIndex = listBox_error_msgs.Items.Count - 1;
            }
            
        }
        public delegate void read_write_data(String s);

        public void write_to_log_correct_data(String s)
        {
            readed_data_analysis(s);
            //listBox_port_logs.Items.Add($"Gelen Paket Sayisi = {gelen_paket_sayisi}");
            xs1.Add(gecen_zaman);
            gelen_paket_sayisi = 0;
            //listBox_port_logs.TopIndex = listBox_port_logs.Items.Count - 1;
        }
        public void write_to_log_error(String s) 
        {
            listBox_error_msgs.Items.Add(s);   
            xs1.Add(gecen_zaman);
            listBox_error_msgs.TopIndex = listBox_error_msgs.Items.Count - 1;
        }
        
        public void mySerialPort_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                gelen_paket_sayisi += 1;
                gecen_zaman = gecen_zaman + 5;
                String data_readed = mySerialPort.ReadExisting();
                listBox_port_logs.Invoke(new read_write_data(write_to_log_correct_data),data_readed);
                
                
            }
            catch (Exception error)
            {
                gecen_zaman += 5;
                listBox_error_msgs.Invoke(new read_write_data(write_to_log_error),error.Message);
            }

        }



        //---------------------------------------Tasarruflu Fare-----------------------------------------

        //Zed Graph
        private Random rand = new Random(0);
        private double[] RandomWalk(int points = 5, double start = 100, double mult = 50)
        {
            // return an array of difting random numbers
            double[] values = new double[points];
            values[0] = start;
            for (int i = 1; i < points; i++)
                values[i] = values[i - 1] + (rand.NextDouble() - .5) * mult;
            return values;
        }
        public void Save_Data_For_Graph(List<string> data_List)
        {
            try 
            {
                kaydedilen_surat_bilgisi.Add(Convert.ToInt16(data_List[4]));
                kaydedilen_ivme_bilgisi.Add(Convert.ToInt16(data_List[5]));
                kaydedilen_basinc_bilgisi.Add(Convert.ToInt16(data_List[6]));
                kaydedilen_yukseklik_bilgisi.Add(Convert.ToInt16(data_List[7]));
                kaydedilen_sicaklik_bilgisi.Add(Convert.ToInt16(data_List[8]));
            }
            catch(Exception error) 
            {
                listBox_error_msgs.Items.Add("Save Data For Graph Error: Could not save data for graphics | "+error.Message);
                listBox_error_msgs.TopIndex = listBox_error_msgs.Items.Count - 1;
            }   
        }
        public void draw_graph_func()
        {
            int pointCount = 100;
            // clear old curves
            zedGraphControl1.GraphPane.CurveList.Clear();

            if (checkBox_Surat.Checked)
            {
                var curve1 = zedGraphControl1.GraphPane.AddCurve("Sürat Serisi", xs1.ToArray(), kaydedilen_surat_bilgisi.ToArray(), Color.Red);
                curve1.Line.IsAntiAlias = true;
            }
            // plot the data as curves
            if (checkBox_Ivme.Checked)
            {
                var curve1 = zedGraphControl1.GraphPane.AddCurve("İvme Serisi ", xs1.ToArray(), kaydedilen_ivme_bilgisi.ToArray(), Color.Blue);
                curve1.Line.IsAntiAlias = true;
            }
            if (checkBox_Basinc.Checked)
            {
                var curve1 = zedGraphControl1.GraphPane.AddCurve("Basınç Serisi", xs1.ToArray(), kaydedilen_basinc_bilgisi.ToArray(), Color.Green);
                curve1.Line.IsAntiAlias = true;
            }
            if (checkBox_Yukseklik.Checked)
            {
                var curve1 = zedGraphControl1.GraphPane.AddCurve("Yükseklik Serisi", xs1.ToArray(), kaydedilen_yukseklik_bilgisi.ToArray(), Color.Orange);
                curve1.Line.IsAntiAlias = true;
            }
            if (checkBox_Sicaklik.Checked)
            {
                var curve1 = zedGraphControl1.GraphPane.AddCurve("Sıcaklık Serisi", xs1.ToArray(), kaydedilen_sicaklik_bilgisi.ToArray(), Color.Purple);
                curve1.Line.IsAntiAlias = true;
            }

            // style the plot
            zedGraphControl1.GraphPane.Title.Text = $"Scatter Plot ({pointCount:n0} points)";
            zedGraphControl1.GraphPane.XAxis.Title.Text = "Zaman";
            zedGraphControl1.GraphPane.YAxis.Title.Text = "Dikey Eksen";

            // auto-axis and update the display
            zedGraphControl1.GraphPane.XAxis.ResetAutoScale(zedGraphControl1.GraphPane, CreateGraphics());
            zedGraphControl1.GraphPane.YAxis.ResetAutoScale(zedGraphControl1.GraphPane, CreateGraphics());
            zedGraphControl1.Refresh();
        }
        private void button_draw_graph_Click(object sender, EventArgs e)
        {
            // generate some random Y data
            
            //double[] xs1 = RandomWalk(pointCount);
            //double[] ys1 = RandomWalk(pointCount);
            //double[] xs2 = RandomWalk(pointCount);
            //double[] ys2 = RandomWalk(pointCount);

            draw_graph_func();
        }
        //----------------------------Tasarruflu Fare----------------------------------------------------

        //Grafik verilerinin kaydedilmesi
        public void Write_to_database()
        {
            try
            {
                string dosya_konumu;
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Kayıt Konumu Seçin";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    dosya_konumu = fbd.SelectedPath;
                    
                }
                else
                {
                    return;
                }
                byte data_base_no = 1;
                while (System.IO.File.Exists(dosya_konumu + $"\\OlcumSonuclari_{data_base_no}.sqlite"))
                {
                    data_base_no++;
                }

                string db_name = dosya_konumu + $"\\OlcumSonuclari_{data_base_no}.sqlite";
                SQLiteConnection.CreateFile(db_name);

                SQLiteConnection my_conn = new SQLiteConnection($"Data Source={db_name};Version=3;");
                my_conn.Open();
                string sql_table = "create table sonuclar (time real ,name varchar(20), sensorvalue real)";

                SQLiteCommand command = new SQLiteCommand(sql_table, my_conn);
                command.ExecuteNonQuery();

                for (int i = 0; i < xs1.Count - 1; i++)
                {
                    sql_table = $"insert into sonuclar (time, name, sensorvalue) values ({xs1[i]}, 'Surat', {kaydedilen_surat_bilgisi[i]})";
                    command = new SQLiteCommand(sql_table, my_conn);
                    command.ExecuteNonQuery();
                    sql_table = $"insert into sonuclar (time, name, sensorvalue) values ({xs1[i]}, 'Ivme', {kaydedilen_ivme_bilgisi[i]})";
                    command = new SQLiteCommand(sql_table, my_conn);
                    command.ExecuteNonQuery();
                    sql_table = $"insert into sonuclar (time, name, sensorvalue) values ({xs1[i]}, 'Basinc', {kaydedilen_basinc_bilgisi[i]})";
                    command = new SQLiteCommand(sql_table, my_conn);
                    command.ExecuteNonQuery();
                    sql_table = $"insert into sonuclar (time, name, sensorvalue) values ({xs1[i]}, 'Yukseklik', {kaydedilen_yukseklik_bilgisi[i]})";
                    command = new SQLiteCommand(sql_table, my_conn);
                    command.ExecuteNonQuery();
                    sql_table = $"insert into sonuclar (time, name, sensorvalue) values ({xs1[i]}, 'Sicaklik', {kaydedilen_sicaklik_bilgisi[i]})";
                    command = new SQLiteCommand(sql_table, my_conn);
                    command.ExecuteNonQuery();
                }
                my_conn.Close();
                my_conn.Dispose();
                command.Dispose();
                SQLiteConnection.ClearAllPools();
                my_conn = null;

                listBox_port_logs.Items.Add($"Veri Tabanı {dosya_konumu} Yoluna OlcumSonuclari_{data_base_no}.sqlite Adıyla Kaydedildi.");
                listBox_port_logs.TopIndex = listBox_port_logs.Items.Count - 1;
                MessageBox.Show("Veri Tabanı Başarıyla Kaydedildi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception error)
            {
                listBox_error_msgs.Items.Add("Could not save to database | " + error.Message);
                listBox_error_msgs.TopIndex = listBox_error_msgs.Items.Count - 1;
            }

        }
        private void button_writeToExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaydediceğiniz VeriTabanında Müdahale Yapabilmeniz İçin Uygulamayı Kapatmanız/Yeniden Başlatmanız Gerekmektedir?\n" +
                "Hatanın sebebi: System.Data.SQLite(1.0.116)","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            if (xs1.Count !=0)
            {
                Write_to_database();
            }
            else
            {
                listBox_error_msgs.Items.Add("Veri Tabanına Yazılacak Bir Veri Bulunamadı.");
                listBox_error_msgs.TopIndex = listBox_error_msgs.Items.Count - 1;
            }
            
        }
        //-------------------------------Tasarruflu Fare---------------------------------------------------------------------------------------------------------
    }
}