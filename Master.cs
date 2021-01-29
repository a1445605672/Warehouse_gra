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
	public partial class Master : Skin_Color
	{
		public Master()
		{
			InitializeComponent();
		}

		private void BasicInformBut_Click(object sender, EventArgs e)
		{
			BasicInformBut.BackColor = Color.Black;     //选基础信息BUt背景变成黑色

			#region  非选择的button变成默认颜色

			SystemManagmentBut.BackColor = Color.Transparent;      //系统管理But
			OutIntWarehouseBut.BackColor = Color.Transparent;      //出入库But
			StatisticalStatementBut.BackColor = Color.Transparent; //统计报表But

			#endregion

			BasicMenuPanel.Visible = true; //基础信息Panel显示

			#region  隐藏Panel


			SystemManagPanel.Visible = false;                //系统管理Panel
			OutIntWarehousePanel.Visible = false;			 //出入库Panel
			StatisticalStatementPanel.Visible = false;		 //统计报表Panel

			#endregion
		}

		private void SystemManagmentBUt_Click(object sender, EventArgs e)
		{
			SystemManagmentBut.BackColor = Color.Black;  //系统管理But背景变成黑色

			#region  非选择的button变成默认颜色


			BasicInformBut.BackColor = Color.Transparent;			//基础信息But
			OutIntWarehouseBut.BackColor = Color.Transparent;		//出入库But
			StatisticalStatementBut.BackColor = Color.Transparent;	//统计报表But

			#endregion

			SystemManagPanel.Visible = true;	//显示系统管理Panel

			#region  隐藏Panel


			BasicMenuPanel.Visible = false;				//基础信息Panel
			OutIntWarehousePanel.Visible = false;		//出入库Panel
			StatisticalStatementPanel.Visible = false;	//统计报表Panel

			#endregion
		}

		private void OutIntWarehouseBut_Click(object sender, EventArgs e)
		{

			OutIntWarehouseBut.BackColor = Color.Black;     //出入库But背景变成黑色


			#region  非选择的button变成默认颜色

			BasicInformBut.BackColor = Color.Transparent;           //基础信息But
			SystemManagmentBut.BackColor = Color.Transparent;		//系统管理But
			StatisticalStatementBut.BackColor = Color.Transparent;	//统计报表But

			#endregion

			OutIntWarehousePanel.Visible = true;        //显示出入库Panel

			#region  隐藏Panel

			BasicMenuPanel.Visible = false;				//基础信息Panel
			SystemManagPanel.Visible = false;			//系统管理Panel
			StatisticalStatementPanel.Visible = false;	//统计报表Panel

			#endregion

		}

		private void StatisticalStatementBut_Click(object sender, EventArgs e)
		{
			StatisticalStatementBut.BackColor = Color.Black;     //统计报表But背景变成黑色

			#region  非选择的button变成默认颜色

			BasicInformBut.BackColor = Color.Transparent;           //基础信息But
			OutIntWarehouseBut.BackColor = Color.Transparent;		//出入库But
			SystemManagmentBut.BackColor = Color.Transparent;       //系统管理But

			#endregion

			StatisticalStatementPanel.Visible = true;  //显示统计报表Panel

			#region  隐藏Panel

			BasicMenuPanel.Visible = false;             //基础信息Panel
			SystemManagPanel.Visible = false;           //系统管理Panel
			OutIntWarehousePanel.Visible = false;        //出入库Panel
			
			#endregion

		}

		private void skinPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void StatisticalStatementPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void OutIntWarehousePanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void SystemManagPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void BasicMenuPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void ParentMenuPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void skinButton16_Click(object sender, EventArgs e)
		{

		}

		private void skinButton17_Click(object sender, EventArgs e)
		{

		}

		private void skinButton20_Click(object sender, EventArgs e)
		{

		}

		private void skinButton18_Click(object sender, EventArgs e)
		{

		}

		private void skinButton19_Click(object sender, EventArgs e)
		{

		}

		private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void skinButton5_Click(object sender, EventArgs e)
		{

		}

		private void skinButton4_Click(object sender, EventArgs e)
		{

		}

		private void skinButton3_Click(object sender, EventArgs e)
		{

		}

		private void skinButton2_Click(object sender, EventArgs e)
		{

		}

		private void skinButton1_Click(object sender, EventArgs e)
		{

		}

		private void skinButton6_Click(object sender, EventArgs e)
		{

		}

		private void skinButton7_Click(object sender, EventArgs e)
		{

		}

		private void skinButton8_Click(object sender, EventArgs e)
		{

		}

		private void skinButton9_Click(object sender, EventArgs e)
		{

		}

		private void skinButton10_Click(object sender, EventArgs e)
		{

		}

		private void skinButton11_Click(object sender, EventArgs e)
		{

		}

		private void skinButton12_Click(object sender, EventArgs e)
		{

		}

		private void skinButton13_Click(object sender, EventArgs e)
		{

		}

		private void skinButton14_Click(object sender, EventArgs e)
		{

		}

		private void skinButton15_Click(object sender, EventArgs e)
		{

		}
	}
}
