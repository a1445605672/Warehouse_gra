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

		private void 系统日志_Load(object sender, EventArgs e)
		{
			SystemLog log = new SystemLog();
			if(log.WriteLog(1,"冯家振","2021-03-25","日志页面","查看日志"))
				{
				ShowAskDialog("插入成功");
			}
			else
			{
				ShowAskDialog("插入失败");
			}
		}
	}

	
}
