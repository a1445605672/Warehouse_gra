using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 毕设
{
	public partial class InWareHouse : UserControl
	{
		public InWareHouse()
		{
			InitializeComponent();
			SelectListBox.Items.Add("我爱你晏传利");
			SelectListBox.Items.Add("你爱我吗");
			SelectListBox.Items.Add("我爱你冯家振");
			SelectListBox.Items.Add("你好");
			SelectListBox.Items.Add("大家好");
			//skinDataGridView1.Rows.Add();
		}

		#region 加载窗体
		private void InWareHouse_Load(object sender, EventArgs e)
		{
			SelectListBox.BringToFront();  //查询条件顶层显示


		}

		#endregion

		private void SelectListBut_Click(object sender, EventArgs e)
		{
			SelectListBut.BackgroundImage = Image.FromFile(@"Image\login_inputbtn_down.png");
			SelectListBox.Visible = true;
			

		}

		private void SelectListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			SelectCondition.Text=SelectListBox.SelectedItem.ToString();
			SelectListBox.Visible = false;
		}

		private void panel1_MouseEnter(object sender, EventArgs e)
		{
			SelectListBox.Visible = false;
			SelectListBut.BackgroundImage = Image.FromFile(@"Image\login_inputbtn_normal.png");
		}
	}
}
