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
namespace Warehouse
{
    public partial class 端口设置 : UITitlePage
    {
        public 端口设置()
        {
            InitializeComponent();
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
    }
}
