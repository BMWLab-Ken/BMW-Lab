namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_signalCheck = new System.Windows.Forms.Button();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.progressBar_status = new System.Windows.Forms.ProgressBar();
            this.groupBox_send = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button_sendData = new System.Windows.Forms.Button();
            this.button_networkJoin = new System.Windows.Forms.Button();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.groupBox_receive = new System.Windows.Forms.GroupBox();
            this.textBox_receive = new System.Windows.Forms.TextBox();
            this.button_openPort = new System.Windows.Forms.Button();
            this.button_closePort = new System.Windows.Forms.Button();
            this.label_portName = new System.Windows.Forms.Label();
            this.label_baudRate = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_send.SuspendLayout();
            this.groupBox_receive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_signalCheck
            // 
            this.button_signalCheck.Enabled = false;
            this.button_signalCheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signalCheck.Location = new System.Drawing.Point(960, 100);
            this.button_signalCheck.Name = "button1";
            this.button_signalCheck.Size = new System.Drawing.Size(100, 40);
            this.button_signalCheck.TabIndex = 0;
            this.button_signalCheck.Text = "Signal Check";
            this.button_signalCheck.UseVisualStyleBackColor = true;
            this.button_signalCheck.Click += new System.EventHandler(this.button1_Click);
          
            // 
            // comboBox_port
            // 
            this.comboBox_port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(840, 90);
            this.comboBox_port.Name = "comboBox1";
            this.comboBox_port.Size = new System.Drawing.Size(100, 10);
            this.comboBox_port.TabIndex = 4;
			this.comboBox_port.Text = "Hello World!";
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox_baudRate.Location = new System.Drawing.Point(840, 140);
            this.comboBox_baudRate.Name = "comboBox2";
            this.comboBox_baudRate.Size = new System.Drawing.Size(100, 10);
            this.comboBox_baudRate.TabIndex = 5;
            this.comboBox_baudRate.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // progressBar_status
            // 
			this.progressBar_status.Location = new System.Drawing.Point(840, 50);
            this.progressBar_status.Name = "progressBar1";
            this.progressBar_status.Size = new System.Drawing.Size(100, 10);
            this.progressBar_status.TabIndex = 6;
            // 
            // groupBox_send
            // 
           // this.groupBox_send.Controls.Add(this.button_sendData);
            //this.groupBox_send.Controls.Add(this.button_networkJoin);
            this.groupBox_send.Controls.Add(this.textBox_send);
            //this.groupBox_send.Controls.Add(this.button_signalCheck);
            this.groupBox_send.Location = new System.Drawing.Point(20, 540);
            this.groupBox_send.Name = "groupBox1";
            this.groupBox_send.Size = new System.Drawing.Size(800, 100);
            this.groupBox_send.TabIndex = 7;
            this.groupBox_send.TabStop = false;
            this.groupBox_send.Text = "Send";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(9, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 23);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ASCII";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(79, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 23);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "HEX";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button_sendData
            // 
            this.button_sendData.Enabled = false;
            this.button_sendData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sendData.Location = new System.Drawing.Point(960, 20);
            this.button_sendData.Name = "button6";
            this.button_sendData.Size = new System.Drawing.Size(100, 40);
            this.button_sendData.TabIndex = 14;
            this.button_sendData.Text = "Send Data";
            this.button_sendData.UseVisualStyleBackColor = true;
            this.button_sendData.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_networkJoin
            // 
            this.button_networkJoin.Enabled = false;
            this.button_networkJoin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_networkJoin.Location = new System.Drawing.Point(960, 10);
            this.button_networkJoin.Name = "button5";
            this.button_networkJoin.Size = new System.Drawing.Size(100, 40);
            this.button_networkJoin.TabIndex = 13;
            this.button_networkJoin.Text = "Network Join";
            this.button_networkJoin.UseVisualStyleBackColor = true;
            this.button_networkJoin.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox_send
            // 
			this.textBox_send.Enabled = true;
            this.textBox_send.Location = new System.Drawing.Point(20, 20);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox1";
            this.textBox_send.Size = new System.Drawing.Size(760, 60);
            this.textBox_send.TabIndex = 0;
            this.textBox_send.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // groupBox_receive
            // 
            this.groupBox_receive.Controls.Add(this.textBox_receive);
            this.groupBox_receive.Location = new System.Drawing.Point(20, 20);
            this.groupBox_receive.Name = "groupBox2";
            this.groupBox_receive.Size = new System.Drawing.Size(800, 500);
            this.groupBox_receive.TabIndex = 8;
            this.groupBox_receive.TabStop = false;
            this.groupBox_receive.Text = "Receive";

            // 
            // textBox_receive
            // 
            this.textBox_receive.Enabled = false;
            this.textBox_receive.Location = new System.Drawing.Point(20, 20);
            this.textBox_receive.Multiline = true;
            this.textBox_receive.Name = "textBox2";
            this.textBox_receive.ReadOnly = true;
            this.textBox_receive.Size = new System.Drawing.Size(760, 460);
            this.textBox_receive.TabIndex = 0;

            // 
            // button_openPort
            // 
            this.button_openPort.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openPort.Location = new System.Drawing.Point(840, 200);
            this.button_openPort.Name = "button3";
            this.button_openPort.Size = new System.Drawing.Size(90, 40);
            this.button_openPort.TabIndex = 9;
            this.button_openPort.Text = "Open Port";
            this.button_openPort.UseVisualStyleBackColor = true;
            this.button_openPort.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_closePort
            // 
            this.button_closePort.Enabled = false;
            this.button_closePort.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_closePort.Location = new System.Drawing.Point(940, 200);
            this.button_closePort.Name = "button4";
            this.button_closePort.Size = new System.Drawing.Size(90, 40);
            this.button_closePort.TabIndex = 2;
            this.button_closePort.Text = "Close Port";
            this.button_closePort.UseVisualStyleBackColor = true;
            this.button_closePort.Click += new System.EventHandler(this.button4_Click);
            // 
            // label_portName
            // 
            this.label_portName.AutoSize = true;
            this.label_portName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_portName.Location = new System.Drawing.Point(840, 70);
            this.label_portName.Name = "label1";
            this.label_portName.Size = new System.Drawing.Size(50, 10);
            this.label_portName.TabIndex = 10;
            this.label_portName.Text = "Port Name";
            // 
            // lable_baudRate
            // 
            this.label_baudRate.AutoSize = true;
            this.label_baudRate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_baudRate.Location = new System.Drawing.Point(840, 120);
            this.label_baudRate.Name = "label2";
            this.label_baudRate.Size = new System.Drawing.Size(100, 10);
            this.label_baudRate.TabIndex = 11;
            this.label_baudRate.Text = "Baud Rate";
            // 
            // lable_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(840, 20);
            this.label_status.Name = "label3";
            this.label_status.Size = new System.Drawing.Size(50, 10);
            this.label_status.TabIndex = 12;
            this.label_status.Text = "Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(840, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(840, 286);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(840, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Made by";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 482);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_baudRate);
            this.Controls.Add(this.label_portName);
            this.Controls.Add(this.button_closePort);
            this.Controls.Add(this.button_openPort);
            this.Controls.Add(this.groupBox_receive);
            this.Controls.Add(this.groupBox_send);
            this.Controls.Add(this.progressBar_status);
            this.Controls.Add(this.comboBox_baudRate);
            this.Controls.Add(this.comboBox_port);
            this.Name = "Form1";
            this.Text = "Blutech LoRa Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_send.ResumeLayout(false);
            this.groupBox_send.PerformLayout();
            this.groupBox_receive.ResumeLayout(false);
            this.groupBox_receive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_signalCheck;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.ProgressBar progressBar_status;
        private System.Windows.Forms.GroupBox groupBox_send;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.GroupBox groupBox_receive;
        private System.Windows.Forms.TextBox textBox_receive;
        private System.Windows.Forms.Button button_openPort;
        private System.Windows.Forms.Button button_closePort;
        private System.Windows.Forms.Label label_portName;
        private System.Windows.Forms.Label label_baudRate;
        private System.Windows.Forms.Label label_status;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button_networkJoin;
        private System.Windows.Forms.Button button_sendData;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
    }
}

