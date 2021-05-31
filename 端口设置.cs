using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBUtility;
using System.IO.Ports;
using INIFILE;

namespace Warehouse
{
    public partial class 端口设置 : UITitlePage
    {
        SerialPort sp1 = new SerialPort();
        public 端口设置()
        {
            InitializeComponent();
            INIFILE.Profile.LoadProfile();//加载所有

            // 预置波特率
            switch (Profile.G_BAUDRATE)
            {
                case "300":
                    cbBaudRate.SelectedIndex = 0;
                    break;
                case "600":
                    cbBaudRate.SelectedIndex = 1;
                    break;
                case "1200":
                    cbBaudRate.SelectedIndex = 2;
                    break;
                case "2400":
                    cbBaudRate.SelectedIndex = 3;
                    break;
                case "4800":
                    cbBaudRate.SelectedIndex = 4;
                    break;
                case "9600":
                    cbBaudRate.SelectedIndex = 5;
                    break;
                case "19200":
                    cbBaudRate.SelectedIndex = 6;
                    break;
                case "38400":
                    cbBaudRate.SelectedIndex = 7;
                    break;
                case "115200":
                    cbBaudRate.SelectedIndex = 8;
                    break;
                default:
                    {
                        MessageBox.Show("波特率预置参数错误。");
                        return;
                    }
            }

            //预置波特率
            switch (Profile.G_DATABITS)
            {
                case "5":
                    cbDataBits.SelectedIndex = 0;
                    break;
                case "6":
                    cbDataBits.SelectedIndex = 1;
                    break;
                case "7":
                    cbDataBits.SelectedIndex = 2;
                    break;
                case "8":
                    cbDataBits.SelectedIndex = 3;
                    break;
                default:
                    {
                        MessageBox.Show("数据位预置参数错误。");
                        return;
                    }

            }
            //预置停止位
            switch (Profile.G_STOP)
            {
                case "1":
                    cbStop.SelectedIndex = 0;
                    break;
                case "1.5":
                    cbStop.SelectedIndex = 1;
                    break;
                case "2":
                    cbStop.SelectedIndex = 2;
                    break;
                default:
                    {
                        MessageBox.Show("停止位预置参数错误。");
                        return;
                    }
            }

            //预置校验位
            switch (Profile.G_PARITY)
            {
                case "NONE":
                    cbParity.SelectedIndex = 0;
                    break;
                case "ODD":
                    cbParity.SelectedIndex = 1;
                    break;
                case "EVEN":
                    cbParity.SelectedIndex = 2;
                    break;
                default:
                    {
                        MessageBox.Show("校验位预置参数错误。");
                        return;
                    }
            }

            //检查是否含有串口
            string[] str = SerialPort.GetPortNames();
            if (str != null)
            {
                UIMessageBox.ShowInfo("本机没有串口！");
             //   uiMessageBox.Show();
                return;
            }

            //添加串口项目
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {//获取有多少个COM口
                //System.Diagnostics.Debug.WriteLine(s);
                //cbSerial.Items.Add(s);
            }

            //串口设置默认选择项
            // cbSerial.SelectedIndex = 1;         //note：获得COM9口，但别忘修改
            //cbBaudRate.SelectedIndex = 5;
            // cbDataBits.SelectedIndex = 3;
            // cbStop.SelectedIndex = 0;
            //  cbParity.SelectedIndex = 0;
            sp1.BaudRate = 9600;

            Control.CheckForIllegalCrossThreadCalls = false;    //这个类中我们不检查跨线程的调用是否合法(因为.net 2.0以后加强了安全机制,，不允许在winform中直接跨线程访问控件的属性)
                                                                // sp1.DataReceived += new SerialDataReceivedEventHandler(sp1_DataReceived);
                                                                //sp1.ReceivedBytesThreshold = 1;

            radio1.Checked = true;  //单选按钮默认是选中的
            rbRcvStr.Checked = true;

            //准备就绪              
            sp1.DtrEnable = true;
            sp1.RtsEnable = true;
            //设置数据读取超时为1秒
            sp1.ReadTimeout = 1000;

            sp1.Close();
        }
        //确定连接
        private void uiButton1_Click(object sender, EventArgs e)
        {
           


            //扫码枪
            string scan = uiComboBox1.SelectedItem.ToString();
            //电子秤
            string weight = uiComboBox2.SelectedItem.ToString();
            //rfid
            string reid = uiComboBox3.SelectedItem.ToString();
            //柜子
            string guiz = uiComboBox4.SelectedItem.ToString();
            string strsql = "UPDATE yingjian SET RFID='"+reid+"',Scan='"+scan+"',weig='"+weight+"',guiz='"+guiz+"',beizhu='1' WHERE beizhu='1' ";
            int i=DbHelperMySQL.ExecuteSql(strsql);
            if (i > 0)
            {
                UIMessageBox.ShowSuccess("设置成功");
            }
            else
            {
                UIMessageBox.ShowWarning("设置失败，请重新尝试");
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            uiComboBox1.Items.Clear();
            uiComboBox2.Items.Clear();
            uiComboBox3.Items.Clear();
            uiComboBox4.Items.Clear();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
