using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace 毕设
{
	public partial class Login : Skin_Color
	{
		public Login()
		{
			InitializeComponent();
		}
		string path = Application.StartupPath + "\\data.xml";
		#region  窗体加载事件
		private void Login_Load(object sender, EventArgs e)
		{
			
			#region  设置账号列表控件
			AcountmenuList.BringToFront();//账号列表控件顶层显示
			AcountmenuList.Visible = false;//账号列表隐藏
			#endregion

			LoginPassWordText.SendToBack(); //登录密码textbox最底层显示
			
			RememberPassCheckBox.SendToBack(); //设置是否保存账号最底层显示
			
			AcountLabel.Visible = true; //账号label显示
			AcountLabel.BringToFront(); //账号水印顶层显示
			PwdLabel.Visible = true;

			#region  加载账号XML
			
			try  //如果没有文件则重新创建
			{
				
				FileStream fs = new FileStream(path, FileMode.Open);
				fs.Close();
				fs.Dispose();
			}
			catch
			{
				XmlDocument Xdoc = new XmlDocument();
				XmlDeclaration dec = Xdoc.CreateXmlDeclaration("1.0", "UTF-8", null);
				Xdoc.AppendChild(dec);
				XmlElement xmlroot = Xdoc.CreateElement("person");
				Xdoc.AppendChild(xmlroot);
				Xdoc.Save(path);
			}

			XElement xe = XElement.Load(path);
			foreach (XElement Person in xe.Descendants("Person"))
			{
				AcountmenuList.Items.Add(Person.Element("Name").Value.ToString());
			}
			#endregion

		}


		#endregion
		#region  DownMenuBut 登录下拉菜单按钮 点击按钮事件
		private void DownMenuBut_MouseUp(object sender, MouseEventArgs e)
		{
			DownMenuBut.BackgroundImage = Image.FromFile(@"Image\login_inputbtn_down.png");
			
			AcountmenuList.Visible = true;  //账号列表
		}
		#endregion


		#region  DownMenuBut 登录下拉菜单按钮 离开按钮事件
		private void DownMenuBut_Leave(object sender, EventArgs e)
		{
			
		}
		#endregion

		#region  给textbox添加水印   其实水印是一个label标签

		private void LoginAcountText_TextChanged(object sender, EventArgs e)
		{
			if (sender.Equals(LoginAcountText))
			{
				if (LoginAcountText.Text.Length < 1)
				{
					AcountLabel.Visible = true;
				}
				else { AcountLabel.Visible = false; }

			}
			else if (sender.Equals(LoginPassWordText))
			{
				if (LoginPassWordText.Text.Length < 1)
				{
					PwdLabel.Visible = true;
				}
				else
				{
					PwdLabel.Visible = false;
				}
			}
		}
		#endregion

		#region  登录
		private void LoginBut_Click(object sender, EventArgs e)
		{
			#region   记住登录账号
			XElement xe = XElement.Load(path);
			//读取XML文件
			if (RememberPassCheckBox.Checked)
			{
				XElement Person = new XElement("Person",
								 new XElement("Name", LoginAcountText.Text.Trim()),
								 new XElement("PassWord", LoginPassWordText.Text.Trim()));
				///添加节点到XML文件中，并保存
				xe.Add(Person);
				///创建一个新节点
				///保存到XML文件中
				xe.Save(path);
				
			}
			#endregion
			
			this.Hide();
			Home home = new Home();
			home.Show();
		}
		#endregion

		#region 登录按钮获取到焦点，账号列表隐藏
		private void LoginBut_MouseEnter(object sender, EventArgs e)
		{
			DownMenuBut.BackgroundImage = Image.FromFile(@"Image\login_inputbtn_normal.png");
			AcountmenuList.Visible = false; //账号列表
			
			
			
		}
		#endregion

		private void LoginAcountText_MouseUp(object sender, MouseEventArgs e)
		{
			DownMenuBut.BackgroundImage = Image.FromFile(@"Image\login_inputbtn_normal.png");
			AcountmenuList.Visible = false;  //账号列表
		}

		#region  选中账号列表中的值赋值给账号
		private void AcountmenuList_SelectedValueChanged(object sender, EventArgs e)
		{
			LoginAcountText.Text = AcountmenuList.SelectedItem.ToString();
		}
		#endregion
	}
}
