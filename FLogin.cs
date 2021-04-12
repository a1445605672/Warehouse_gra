using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using Warehouse.工具窗体;
namespace Warehouse
{
	public partial class FLogin : UILoginForm
	{
		public FLogin()
		{
			InitializeComponent();
		}
        BLL.staff staff = new BLL.staff();

        private void FLogin_ButtonLoginClick(object sender, System.EventArgs e)
        {
            //UserName就是封装了界面里用户名输入框的值
            //Password就是封装了界面里密码输入框的值
            string staffSQL = "select staff_id,staff_phone_number,staff_name from staff where staff_id=" + "\'" + UserName.Trim() + "\'";
            DataSet staffDs = staff.getDataList(staffSQL);
           

            if (staffDs.Tables[0].Rows.Count>=1 && staffDs.Tables[0].Rows[0][1].ToString()== Password)
            {
                IsLogin = true;
                //记住登录用户名和id
                Session.staffName = staffDs.Tables[0].Rows[0][2].ToString();
                Session.staffId = staffDs.Tables[0].Rows[0][0].ToString();


                FMain fmain = new FMain();
                fmain.Show();
               
                this.Hide();
                SystemLog log = new SystemLog();
                log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "登录页面", "登录成功", "");
            }
            else
            {
                ShowErrorTip("用户名或者密码错误。");
            }
        }

        private void FLogin_ButtonCancelClick(object sender,System.EventArgs e)
		{
            Close();
        }

    }
}
