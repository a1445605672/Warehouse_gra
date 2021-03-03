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
			DataSet inNumber_ds = enterStoeage.GetList(inNum_where);
			string inNumber = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');//获得今天日期
			inNumber += inNumber_ds.Tables[0].Rows.Count.ToString().PadLeft(3, '0'); //获得当前行数
			InWarwhouseNumberBox.Text = "I" + inNumber;
			#endregion

			#region 供应商模块
			BLL.sr_info srInfor = new BLL.sr_info();
			string provider_where = "";// "sr_name=\'旺旺集团\'";
			DataSet Provider_ds = srInfor.GetList(provider_where);
			for (int i = 0; i < Provider_ds.Tables[0].Rows.Count; i++)
			{
				ProviderBox.Items.Add(Provider_ds.Tables[0].Rows[i][2].ToString());
			}
			#endregion

			#region 物品模块
			BLL.material_info materialInfo = new BLL.material_info();
			string MaterialsWhere = "mat_name=\'开封沙地带泥红萝卜\'";
			DataSet ds = materialInfo.GetList(MaterialsWhere);
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				Materialsbox.Items.Add(ds.Tables[0].Rows[i][1]);
			}
			#endregion
		}
		#endregion
	}
}


	


	


	

