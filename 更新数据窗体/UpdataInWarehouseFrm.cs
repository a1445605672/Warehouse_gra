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

namespace Warehouse.更新数据窗体
{
	public partial class UpdataInWarehouseFrm : UITitlePage
	{
		public UpdataInWarehouseFrm()
		{
			InitializeComponent();
		}

		private void uiButton13_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void uiButton17_Click(object sender, EventArgs e)
		{
			ShowAskDialog("修改成功");
		}
	}
}
