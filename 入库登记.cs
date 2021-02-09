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
	}
}
