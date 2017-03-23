using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Globalization;




namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

    
        public Form1()
        {
            InitializeComponent();
            GetAvaliblePorts();
            serialPort1.ReadTimeout = 1000;
            serialPort1.WriteTimeout = 1000;
        }
        void GetAvaliblePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        delegate void Display(byte[] buffer);
        private Boolean receiving;
        private Boolean Looptest; /*Test variable*/
        private Boolean connect; /*Network variable*/
        private Thread t;
        private void DisplayText(byte[] buffer)
        {
            byte[] join_success = { 0x02, 0x01, 0x01 };
            byte[] join_timeout = { 0x02, 0x01, 0x03 };
            if (buffer [0] == 0x01)
            {
                textBox2.Text += "[" + DateTime.Now.ToString() + "]" + "Received: " + string.Format("{0}{1}", bytesToHex(buffer), Environment.NewLine);
            }
            else if (buffer.SequenceEqual(join_success))
            {
                connect = true;
                textBox2.Text += "[" + DateTime.Now.ToString() + "]" + "Received: " + string.Format("{0}{1}", bytesToHex(buffer), Environment.NewLine);
            }
            else if (buffer.SequenceEqual(join_timeout))
            {
                connect = false;
                textBox2.Text += "[" + DateTime.Now.ToString() + "]" + "Received: " + string.Format("{0}{1}", bytesToHex(buffer), Environment.NewLine);
            }
            else if (buffer[0] == 0x03)
            {
                textBox2.Text += "[" + DateTime.Now.ToString() + "]" + "Received: " + string.Format("{0}{1}", bytesToHex(buffer), Environment.NewLine);
            }
            else
            {
                connect = false;
                textBox2.Text += "[" + DateTime.Now.ToString() + "]" + "Receive error" + Environment.NewLine;
            }
        }
        private void button1_Click(object sender, EventArgs e)          /*Send Signal Check*/
        {
            byte[] Commend = { 0x01, 0x01, 0x01 };
            //serialPort1.WriteLine(textBox1.Text);
            serialPort1.Write(Commend,0,Commend.Length);
            textBox2.Text += "[" + DateTime.Now.ToString() + "]" + " Try signal check..." + Environment.NewLine;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)         /*open port*/
        {
            try
            {
                if(comboBox1.Text == "" || comboBox2.Text == "")
                {
                    textBox2.Text = "Please select port settings";
                }
                else
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.Open();
                    receiving = true;
                    t = new Thread(DoReceive);
                    t.IsBackground = true;
                    t.Start();
                    progressBar1.Value = 100;
                    button1.Enabled = true;
                    textBox1.Enabled = true;
                    button3.Enabled = false;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    textBox2.Enabled = true;
                    textBox2.Clear();
                    textBox2.WordWrap = true;
                }
            }
            catch(UnauthorizedAccessException)
            {
                textBox2.Text = "Unauthorized Access";
            }
        }

        private void button4_Click(object sender, EventArgs e)        /*close port*/
        {
            serialPort1.Close();
            progressBar1.Value = 0;
            button1.Enabled = false;
            textBox1.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            t.Abort();
        }    

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        
        private void DoReceive()
        {
            try
            {
                Byte[] buffer = new Byte[1024];
                while (receiving)
                {
                    if (serialPort1.BytesToRead > 0)
                    {
                        Int32 length = serialPort1.Read(buffer, 0, buffer.Length);
                        Array.Resize(ref buffer, length);
                        //DisplayText(buffer);
                        Console.WriteLine("{0}", bytesToHex(buffer)); //check data on console
                        Display d = new Display(DisplayText);
                        this.Invoke(d, new Object[] { buffer });
                        Array.Resize(ref buffer, 1024);
                    }
                    Thread.Sleep(16);
                }
            }
            catch(InvalidOperationException) /*Avoid Derictly Close The Form without close port*/
            {
                t.IsBackground = false;
                t.Abort();
            }
        }

        private void button5_Click(object sender, EventArgs e)       /*Network Join*/
        {
            byte[] Commend = { 0x02, 0x01, 0x01 };
            //serialPort1.WriteLine(textBox1.Text);
            serialPort1.Write(Commend, 0, Commend.Length);
            textBox2.Text += "[" + DateTime.Now.ToString() + "]" + " Try network join..." + Environment.NewLine;
        }

        private void button6_Click(object sender, EventArgs e)       /*Send Data*/
        {
            byte[] Commend = new byte[1024];
            if (radioButton1.Checked) /*read as ASCII*/
            {
                byte[] Data = Encoding.ASCII.GetBytes(textBox1.Text);
                int lens = 0;
                lens += textBox1.TextLength;
                Commend[0] = 0x03;
                Commend[1] = Convert.ToByte(lens);
                Array.Resize(ref Commend, lens + 2);
                int i = 2;
                foreach (byte element in Data)
                {
                    //Console.WriteLine("{0} = {1}", element, (char)element); //check data on console
                    Commend[i] = element;
                    i++;
                }
            }
            if (radioButton2.Checked) /*read as HEX*/
            {
                byte[] Data = StringToByteArray(textBox1.Text);
                int lens = 0;
                lens += Data.Length;
                if (lens <=128) /*lens more than 128 will be failure array*/
                {
                    Commend[0] = 0x03;
                    Commend[1] = Convert.ToByte(lens);
                    Array.Resize(ref Commend, lens + 2);
                    int i = 2;
                    foreach (byte element in Data)
                    {
                        //Console.WriteLine("{0} = {1}", element, (char)element); //check data on console
                        Commend[i] = element;
                        i++;
                    }
                    serialPort1.Write(Commend, 0, Commend.Length);
                }
            }
            textBox2.Text += "[" + DateTime.Now.ToString() + "]" + " Send data: " + string.Join(", ", bytesToHex(Commend)) + Environment.NewLine;
            textBox1.Text = "";
        }
        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            try
            {
                for (int i = 0; i < NumberChars; i += 2)
                    bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
                return bytes;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Wrong Hex format..");
                byte[] FailArray = new byte[200];
                FailArray[199] = 0xFF;
                return FailArray;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Wrong Hex length..");
                byte[] FailArray = new byte[200];
                FailArray[199] = 0xFF;
                return FailArray;
            }
        }
        string stringToHex(string astr)
        {
            return stringToHex(astr, System.Text.Encoding.Default);
        }
        string stringToHex(string astr, System.Text.Encoding enc)
        {
            return bytesToHex(enc.GetBytes(astr));
        }
        string bytesToHex(byte[] bytes)
        {
            if (bytes.Length == 0) return "";
            var sb = new StringBuilder();
            var n = bytes.Length - 1;
            for (int i = 0; i < n; i++)
            {
                sb.Append(byteToHex(bytes[i]));
                sb.Append(" ");
            }
            sb.Append(byteToHex(bytes[n]));
            return sb.ToString();
        }
        string byteToHex(byte b)
        {
            string hx = Convert.ToString(b, 16).ToUpper();
            if (hx.Length < 2) hx = "0" + hx;
            return hx;
        }
        private void button2_Click(object sender, EventArgs e)           /*Loop Test START*/
        {
            /*function array*/
            byte[] signalcheck = { 0x01, 0x01, 0x01 };
            byte[] networkjoin = { 0x02, 0x01, 0x01 };
            byte[] senddata = { 0x03, 0x02, 0xAA, 0xBB };

            /*join process*/
            if (!connect)
            {
                serialPort1.Write(networkjoin, 0, networkjoin.Length);
                textBox2.Text += "[" + DateTime.Now.ToString() + "]" + " Try network join..." + Environment.NewLine;
            }
            /*if success, send data*/
            else
            {
                serialPort1.Write(senddata, 0, senddata.Length);
                textBox2.Text += "[" + DateTime.Now.ToString() + "]" + " Send data" + String.Format(" {0}{1}",bytesToHex(senddata), Environment.NewLine);
            }        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += "[" + DateTime.Now.ToString() + "]" + " Stop Loop Test " + Environment.NewLine;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
