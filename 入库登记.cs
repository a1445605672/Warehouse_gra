using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;


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
			#region 生成入库编号
			BLL.enter_storage enterStoeage = new BLL.enter_storage();
			string Where = "enter_date=";
			string time = "yyyy-MM-dd";
			Where+= "'"+DateTime.Now.ToString(time)+"'";
			DataSet ds = enterStoeage.GetList(Where);
			string inNumber = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2,'0') + DateTime.Now.Day.ToString().PadLeft(2,'0');//获得今天日期
			inNumber += ds.Tables[0].Rows.Count.ToString().PadLeft(4,'0'); //获得当前行数
			InWarwhouseNumberBox.Text ="I" +inNumber;
			#endregion

		}
		#endregion
	}
}
