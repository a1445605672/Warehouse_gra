using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace Warehouse
{
	public partial class 入库登记 : UITitlePage
	{
		
		public 入库登记()
		{
			InitializeComponent();
		}

		#region 未完成入库事件
		private void SaveBut_Click(object sender, EventArgs e)
		{
			ShowAskDialog("我还没有完成入库");
		}
		#endregion

		#region 入库事件
		private void OutWarehouseBut_Click(object sender, EventArgs e)
		{
			ShowAskDialog("我已经入库啦");
		}

		#endregion

		#region  窗体加载事件
		private void 入库登记_Load(object sender, EventArgs e)
		{
			#region 生成入库编号模块
			BLL.enter_storage enterStoeage = new BLL.enter_storage();
			string inNum_where = "enter_date=";
			string time = "yyyy-MM-dd";
			inNum_where += "'" + DateTime.Now.ToString(time) + "'";
			string inNumber_Sql = "SELECT enter_id FROM enter_storage WHERE " + inNum_where;
			DataSet inNumber_ds = enterStoeage.getDataList(inNumber_Sql);
			string inNumber = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');//获得今天日期
			inNumber += inNumber_ds.Tables[0].Rows.Count.ToString().PadLeft(3, '0'); //获得当前行数
			InWarwhouseNumberBox.Text = "I" + inNumber;
			#endregion

			#region 供应商模块
			BLL.sr_info srInfor = new BLL.sr_info();
			string provider_sql = "SELECT  sr_name FROM sr_info WHERE sr_type=\'供应商\'";
			DataSet Provider_ds = srInfor.getDataList(provider_sql);
			for (int i = 0; i < Provider_ds.Tables[0].Rows.Count; i++)
			{
				ProviderBox.Items.Add(Provider_ds.Tables[0].Rows[i][0].ToString());
			}
			#endregion

			#region 物品模块
			BLL.material_info materialInfo = new BLL.material_info();
			string Material_Sql = "SELECT  mat_name FROM material_info";
			DataSet ds = materialInfo.getDataList(Material_Sql);
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				Materialsbox.Items.Add(ds.Tables[0].Rows[i][0]);
			}
			#endregion
		}
		#endregion

		private void Materialsbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string Material_Sql = "SELECT  mat_state FROM material_info WHERE mat_name=";
			string Material_Where = Materialsbox.Text.ToString();
			Material_Sql += "\'"+Material_Where+"\'";
			BLL.material_info materialInfo = new BLL.material_info();
			DataSet Material_ds =	materialInfo.getDataList(Material_Sql);

			switch (Material_ds.Tables[0].Rows[0][0].ToString())
			{
				case "固态":
					unitLabel.Text = "cm"+Convert.ToChar(0x00b3);
					break;
				case "液态":
					unitLabel.Text = "mL";
					break;
				case "气态":
					unitLabel.Text = "cm" + Convert.ToChar(0x00b3);
					break;
				

			}
			
				
				
		}
	}
}


	


	


	

