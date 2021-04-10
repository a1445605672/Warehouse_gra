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
	public partial class 系统日志 : UITitlePage
	{
		public 系统日志()
		{
			InitializeComponent();
		}
		SystemLog log = new SystemLog();
		private void 系统日志_Load(object sender, EventArgs e)
		{

			if (log.WriteLog(1,"冯家振","2021-04-10","系统日志","查看日志","") == 0)
			{
				ShowAskDialog("插入成功");
			}
		}
	}

	
}
