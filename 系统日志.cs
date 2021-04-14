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
		List<Model.log_info> data;
		public 系统日志()
		{
			InitializeComponent();

			//添加列
			Addcolumns();
			#region gridview加载列
			data = new List<Model.log_info>();
			data = log.readLog("");
			uiPagination1.DataSource = data;
			uiPagination1.ActivePage = 1;
			#endregion
			//设置当前事件
			logDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
			logDate.Text = "";
		}
		private void 系统日志_Load(object sender, EventArgs e)
		{
			
		}



		private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
		{
			uiDataGridView1.DataSource = pagingSource;
		}

		#region 查询事件
		private void SearchBut_Click(object sender, EventArgs e)
		{
			Addcolumns();
			selectLog();

		}
		#endregion

		#region 给gridview添加列
		private void Addcolumns()
		{
			uiDataGridView1.ClearAll();
			uiDataGridView1.AddColumn("编号", "log_num").SetFixedMode(80);
			uiDataGridView1.AddColumn("类型", "log_type").SetFixedMode(60);
			uiDataGridView1.AddColumn("入库编号", "enter_num").SetFixedMode(110);
			uiDataGridView1.AddColumn("描述", "log_describe").SetFixedMode(370);
			uiDataGridView1.AddColumn("时间", "log_time").SetFixedMode(110);
			uiDataGridView1.AddColumn("页面", "page").SetFixedMode(90);
			uiDataGridView1.AddColumn("用户名", "staff_id").SetFixedMode(90);
			uiDataGridView1.ReadOnly = true;
		}
		#endregion



		public void selectLog()
		{
			data.Clear();
			string where = "log_num<>\'\'";
			string type = "";
			if (logType.Text != "")
			{
				switch (logType.Text)
				{
					case "查看":
						type = "4";
						break;
					case "插入":
						type = "1";
						break;
					case "删除":
						type = "2";
						break;
					case "修改":
						type = "3";
						break;
					case "出库":
						type = "5";
						break;
					case "入库":
						type = "6";
						break;
					case "系统错误":
						type = "0";
						break;
				}
				where += "and log_type=" + type;
			}
			if (logDate.Text != "")
			{
				where += " and log_time=\'" + logDate.Text + "\'";
			}
			if (staffId.Text != "")
			{
				where += " and staff_id=" + "\'" + staffId.Text + "\'";
			}
			if (page.Text != "")
			{
				where += " and page=\'" + page.Text + "\'";
			}
			if (enter_num.Text != "")
			{
				where += " and enter_num=\'" + enter_num.Text.Trim() + "\'";
			}
			data = log.readLog(where);
			uiPagination1.DataSource = data;
			uiPagination1.ActivePage = 1;
		}
	}



}
