using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace 毕设
{
	public partial class Login : Skin_Color
	{
		public Login()
		{
			InitializeComponent();
		}
		#region  窗体加载事件
		private void Login_Load(object sender, EventArgs e)
		{
			LoginAcountText.WaterText = "账号";
			LoginPassWordText.WaterText = "密码";
		}
		#endregion


		#region  DownMenuBut 登录下拉菜单按钮 点击按钮事件
		private void DownMenuBut_MouseUp(object sender, MouseEventArgs e)
		{
			DownMenuBut.BackgroundImage = Image.FromFile(@"Image\login_inputbtn_down.png");
		}
		#endregion



		#region  DownMenuBut 登录下拉菜单按钮 离开按钮事件
		private void DownMenuBut_Leave(object sender, EventArgs e)
		{
			DownMenuBut.BackgroundImage = Image.FromFile(@"Image\login_inputbtn_normal.png");

		}
		#endregion
	}
}
