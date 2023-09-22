namespace BTL_Doluongcongnghiepmr
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.connect_butt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.receiveData_txt = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Disconnect_butt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pitchMpu_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rollMpu_txt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yawEnc_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pitchEnc_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rollEnc_txt = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.baud_cb = new System.Windows.Forms.ComboBox();
            this.port_cb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // connect_butt
            // 
            this.connect_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_butt.Location = new System.Drawing.Point(22, 28);
            this.connect_butt.Name = "connect_butt";
            this.connect_butt.Size = new System.Drawing.Size(112, 26);
            this.connect_butt.TabIndex = 0;
            this.connect_butt.Text = "Connect";
            this.connect_butt.UseVisualStyleBackColor = true;
            this.connect_butt.Click += new System.EventHandler(this.receive_butt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.receiveData_txt);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data receive";
            // 
            // receiveData_txt
            // 
            this.receiveData_txt.Location = new System.Drawing.Point(10, 24);
            this.receiveData_txt.Multiline = true;
            this.receiveData_txt.Name = "receiveData_txt";
            this.receiveData_txt.Size = new System.Drawing.Size(389, 39);
            this.receiveData_txt.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(405, 37);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 26);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(517, 180);
            this.listBox1.TabIndex = 1;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Disconnect_butt
            // 
            this.Disconnect_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect_butt.Location = new System.Drawing.Point(22, 60);
            this.Disconnect_butt.Name = "Disconnect_butt";
            this.Disconnect_butt.Size = new System.Drawing.Size(112, 26);
            this.Disconnect_butt.TabIndex = 2;
            this.Disconnect_butt.Text = "Disconnect";
            this.Disconnect_butt.UseVisualStyleBackColor = true;
            this.Disconnect_butt.Click += new System.EventHandler(this.Disconnect_butt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pitchMpu_txt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rollMpu_txt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 98);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data MPU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yaw";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(379, 53);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 25);
            this.textBox3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pitch";
            // 
            // pitchMpu_txt
            // 
            this.pitchMpu_txt.Location = new System.Drawing.Point(216, 53);
            this.pitchMpu_txt.Multiline = true;
            this.pitchMpu_txt.Name = "pitchMpu_txt";
            this.pitchMpu_txt.Size = new System.Drawing.Size(94, 25);
            this.pitchMpu_txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Roll";
            // 
            // rollMpu_txt
            // 
            this.rollMpu_txt.Location = new System.Drawing.Point(59, 53);
            this.rollMpu_txt.Multiline = true;
            this.rollMpu_txt.Name = "rollMpu_txt";
            this.rollMpu_txt.Size = new System.Drawing.Size(94, 25);
            this.rollMpu_txt.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.yawEnc_txt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.pitchEnc_txt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.rollEnc_txt);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 529);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 98);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Encoder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yaw";
            // 
            // yawEnc_txt
            // 
            this.yawEnc_txt.Location = new System.Drawing.Point(379, 53);
            this.yawEnc_txt.Multiline = true;
            this.yawEnc_txt.Name = "yawEnc_txt";
            this.yawEnc_txt.Size = new System.Drawing.Size(94, 25);
            this.yawEnc_txt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pitch";
            // 
            // pitchEnc_txt
            // 
            this.pitchEnc_txt.Location = new System.Drawing.Point(216, 49);
            this.pitchEnc_txt.Multiline = true;
            this.pitchEnc_txt.Name = "pitchEnc_txt";
            this.pitchEnc_txt.Size = new System.Drawing.Size(94, 25);
            this.pitchEnc_txt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Roll";
            // 
            // rollEnc_txt
            // 
            this.rollEnc_txt.Location = new System.Drawing.Point(59, 53);
            this.rollEnc_txt.Multiline = true;
            this.rollEnc_txt.Name = "rollEnc_txt";
            this.rollEnc_txt.Size = new System.Drawing.Size(94, 25);
            this.rollEnc_txt.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.baud_cb);
            this.groupBox4.Controls.Add(this.port_cb);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(154, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(396, 77);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Config";
            // 
            // baud_cb
            // 
            this.baud_cb.FormattingEnabled = true;
            this.baud_cb.Location = new System.Drawing.Point(276, 27);
            this.baud_cb.Name = "baud_cb";
            this.baud_cb.Size = new System.Drawing.Size(99, 24);
            this.baud_cb.TabIndex = 7;
            // 
            // port_cb
            // 
            this.port_cb.FormattingEnabled = true;
            this.port_cb.Location = new System.Drawing.Point(83, 27);
            this.port_cb.Name = "port_cb";
            this.port_cb.Size = new System.Drawing.Size(99, 24);
            this.port_cb.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Baud";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Port";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(567, 28);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(679, 295);
            this.zedGraphControl1.TabIndex = 9;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(567, 321);
            this.zedGraphControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(679, 296);
            this.zedGraphControl2.TabIndex = 10;
            this.zedGraphControl2.UseExtendedPrintDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 658);
            this.Controls.Add(this.zedGraphControl2);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Disconnect_butt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.connect_butt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connect_butt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Disconnect_butt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pitchMpu_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rollMpu_txt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yawEnc_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pitchEnc_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rollEnc_txt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox baud_cb;
        private System.Windows.Forms.ComboBox port_cb;
        private System.Windows.Forms.ListBox listBox1;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox receiveData_txt;
    }
}

