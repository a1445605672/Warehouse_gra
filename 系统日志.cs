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
		SystemLog log = new SystemLog();
		
		public 系统日志()
		{
			InitializeComponent();

			#region 给gridview添加列
			uiDataGridView1.AddColumn("编号", "log_num").SetFixedMode(100);
			uiDataGridView1.AddColumn("类型", "log_type").SetFixedMode(100);
			uiDataGridView1.AddColumn("入库编号", "enter_num").SetFixedMode(100);
			uiDataGridView1.AddColumn("描述", "log_describe").SetFixedMode(100);
			uiDataGridView1.AddColumn("时间", "log_time").SetFixedMode(100);
			uiDataGridView1.AddColumn("页面", "page").SetFixedMode(100);
			uiDataGridView1.AddColumn("用户编号", "staff_id").SetFixedMode(100);
			uiDataGridView1.ReadOnly = true;
			#endregion

			#region gridview加载列
			List<Model.log_info> data = new List<Model.log_info>();
			data = log.readLog();
			uiPagination1.DataSource = data;
			uiPagination1.ActivePage = 1;
			#endregion

		}
		private void 系统日志_Load(object sender, EventArgs e)
		{
			//if (log.WriteLog(1,"冯家振","2021-04-10","系统日志","查看日志","") == 0)
			//{
			//	ShowAskDialog("插入成功");
			//}
		}



		private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
		{
			uiDataGridView1.DataSource = pagingSource;
		}

	}

	
}
