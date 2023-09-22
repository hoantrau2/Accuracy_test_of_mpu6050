using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ZedGraph;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms.ComponentModel.Com2Interop;
using System.IO;

namespace BTL_Doluongcongnghiepmr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string rcv_data = "";
        //string port;
        //int baud;
        double[] Ain = new double[6];
        double time;
        string[] mybaud = { "9600", "115200", "921600" };
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            GraphPane pane_x = zedGraphControl1.GraphPane;
            GraphPane pane_y = zedGraphControl2.GraphPane;
            pane_x.Title.Text = "Đồ thị góc roll theo thời gian";
            pane_x.XAxis.Title.Text = "Thời gian (ms)";
            pane_x.YAxis.Title.Text = "Góc roll (degree)";
            pane_y.Title.Text = "Đồ thị góc pitch theo thời gian";
            pane_y.XAxis.Title.Text = "Thời gian (ms)";
            pane_y.YAxis.Title.Text = "Góc pitch (degree)";

            RollingPointPairList roll_mpu = new RollingPointPairList(20000);
            RollingPointPairList pitch_mpu = new RollingPointPairList(20000);
            RollingPointPairList roll_enc = new RollingPointPairList(20000);
            RollingPointPairList pitch_enc = new RollingPointPairList(20000);
            LineItem curve_x_mpu = pane_x.AddCurve("roll_mpu", roll_mpu, Color.Red, SymbolType.None);
            LineItem curve_y_mpu = pane_y.AddCurve("pitch_mpu", pitch_mpu, Color.Black, SymbolType.None);
            LineItem curve_x_enc = pane_x.AddCurve("roll_enc", roll_enc, Color.Blue, SymbolType.None);
            LineItem curve_y_enc = pane_y.AddCurve("pitch_enc", pitch_enc, Color.Green, SymbolType.None);

            string[] myport = SerialPort.GetPortNames();
            port_cb.Items.AddRange(myport);
            baud_cb.Items.AddRange(mybaud);

        }

        private void receive_butt_Click(object sender, EventArgs e)
        {


            try
            {
                //port = port_txt.Text;
                //baud = Int32.Parse(baud_txt.Text);
                //port = "COM2";
                //baud = 921600;
                //port_txt.Text = port;
                //baud_txt.Text = baud.ToString();
                serialPort1.PortName = port_cb.Text;
                serialPort1.BaudRate = int.Parse(baud_cb.Text);
                serialPort1.DataBits = 8;
                serialPort1.Parity = System.IO.Ports.Parity.None;
                serialPort1.StopBits = System.IO.Ports.StopBits.One;
                if (serialPort1.IsOpen) return;
                serialPort1.Open();
                connect_butt.Enabled = false;
                Disconnect_butt.Enabled = true;
                port_cb.Enabled = false;
                baud_cb.Enabled = false;
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void Disconnect_butt_Click(object sender, EventArgs e)
        {
            connect_butt.Enabled = true;
            Disconnect_butt.Enabled = false;
            port_cb.Enabled = true;
            baud_cb.Enabled = true;
            //listBox1.Text = "";
            rollMpu_txt.Text = string.Empty;
            pitchMpu_txt.Text = string.Empty;
            rollEnc_txt.Text = string.Empty;
            pitchEnc_txt.Text = string.Empty;
            yawEnc_txt.Text = string.Empty;
            //port_txt.Text = string.Empty;
            //baud_txt.Text = string.Empty;

            if (serialPort1.IsOpen == false) return;
            serialPort1.Close();

            timer1.Enabled = false;

            //zedGraphControl1.GraphPane.CurveList.Clear();
            //zedGraphControl1.GraphPane.GraphObjList.Clear();

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string tmp = "";
             rcv_data += serialPort1.ReadExisting();

            if (rcv_data.Length > 42)
            {
                Invoke(new MethodInvoker(() => listBox1.Items.Add(rcv_data)));
                tmp = rcv_data;
                rcv_data = ""; // tranh chong lap luong lon duu kieu
            }
            
            //tmp = serialPort1.ReadExisting();
            receiveData_txt.Text = tmp + '\n';


            string[] sub_data = tmp.Split(' ');
            string[] sub_data_v1 = sub_data;
            int j = 0;

            for (int i = 0; i < sub_data.Length; i++)
            {
                if ((sub_data[i] != " ") && (sub_data[i] != "\r") && (sub_data[i] != "\n"))
                {
                    sub_data_v1[j] = sub_data[i];
                    j++;
                }
            }



            Ain[0] = double.Parse(sub_data_v1[0]);
            Ain[0] /= 1000;
            rollMpu_txt.Text = Ain[0].ToString();

            Ain[1] = double.Parse(sub_data_v1[1]);
            Ain[1] /= 1000;
            pitchMpu_txt.Text = Ain[1].ToString();

            Ain[3] = double.Parse(sub_data_v1[3]);
            //Ain[3] = ((32000 - Ain[3]) / 2500) * 360;
            double tmp3 = (Ain[3] - 32000)/10000;
            while (Math.Abs(tmp3) > 1)
            {
                tmp3 = Math.Abs(tmp3) - 1;
            }
            
            while (tmp3> 1 || tmp3 <- 1)
            {
                if (tmp3 > 1) tmp3 -= 1;
                if (tmp3 <- 1) tmp3 += 1;
            }


            Ain[3] = tmp3 * 360;
            if (Ain[3] > 90) Ain[3] = 180 - Ain[3] ;
            if (Ain[3] < -90) Ain[3] = Math.Abs(Ain[3]) - 180;
            rollEnc_txt.Text = Ain[3].ToString();


            Ain[4] = double.Parse(sub_data_v1[4]);
            double tmp4 = (Ain[4] - 32000) / 10000;
            while (Math.Abs(tmp4) > 1)
            {
                tmp4 = Math.Abs(tmp4) - 1;
            }
            Ain[4] = (tmp4 * 360);
            if (Ain[4] > 180) Ain[4] = Ain[4] - 180;
            if (Ain[4] < -180) Ain[4] = Ain[4] + 180;
            pitchEnc_txt.Text = Ain[4].ToString();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += timer1.Interval; // update time elapsed
            GraphPane pane_x = zedGraphControl1.GraphPane;
            GraphPane pane_y = zedGraphControl2.GraphPane;

            LineItem curve_x_mpu = pane_x.CurveList[0] as LineItem;
            LineItem curve_y_mpu = pane_y.CurveList[0] as LineItem; 
            LineItem curve_x_enc = pane_x.CurveList[1] as LineItem;
            LineItem curve_y_enc = pane_y.CurveList[1] as LineItem;

            IPointListEdit x_mpuList = curve_x_mpu.Points as IPointListEdit;
            IPointListEdit y_mpuList = curve_y_mpu.Points as IPointListEdit;
            IPointListEdit x_encList = curve_x_enc.Points as IPointListEdit;
            IPointListEdit y_encList = curve_y_enc.Points as IPointListEdit;

            x_mpuList.Add(time,Ain[0]); // add the new point 
            y_mpuList.Add(time,Ain[1]);
            x_encList.Add(time, Ain[3]);  
            y_encList.Add(time, Ain[4]);

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl2.AxisChange();
            zedGraphControl2.Invalidate();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //SaveFileDialog dlg = new SaveFileDialog();
            //if (dlg.ShowDialog() == DialogResult.OK )
            //{
            //    StreamWriter writer = new StreamWriter(dlg.FileName);

            //    for (int i = 0; i< listBox1.Items.Count; i++)
            //    {
            //        writer.Write(listBox1.Items[i].ToString());
            //    }

            //    writer.Close();
            //}

            //dlg.Dispose();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
