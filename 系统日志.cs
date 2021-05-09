using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;
using Warehouse.工具窗体;

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
			uiDataGridView1.AddColumn("编 号", "log_num").SetFixedMode(80);
			uiDataGridView1.AddColumn("类 型", "log_type").SetFixedMode(60);
			uiDataGridView1.AddColumn("入库编号", "enter_num").SetFixedMode(110);
			uiDataGridView1.AddColumn("描 述", "log_describe").SetFixedMode(370);
			uiDataGridView1.AddColumn("时 间", "log_time").SetFixedMode(110);
			uiDataGridView1.AddColumn("模 块", "page").SetFixedMode(90);
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

		private void uiButton1_Click(object sender, EventArgs e)
		{
			//ExcelHelp excelHelp = new ExcelHelp();
			string filePath= ExcelHelp.ExportToExcel(uiDataGridView1, "系统日志", "D:\\DownLoad\\AS.xlsx");
			MessageBox.Show(filePath);
		}

		private void deriveButton_Click(object sender, EventArgs e)
		{
			string filename ="系统日志"+ DateTime.Now.ToString("yy-MM-dd-h-m-s") + ".xlsx";
			IList<KeyValuePair<string, string>> listName=new List<KeyValuePair<string, string>>();
			KeyValuePair<string, string> keyValuePair1 = new KeyValuePair<string, string>("log_num", "编号");
			KeyValuePair<string, string> keyValuePair2 = new KeyValuePair<string, string>("log_type", "类型");
			KeyValuePair<string, string> keyValuePair3 = new KeyValuePair<string, string>("enter_num", "入库编号"); 
			KeyValuePair<string, string> keyValuePair4 = new KeyValuePair<string, string>("log_describe", "描述");
			KeyValuePair<string, string> keyValuePair5 = new KeyValuePair<string, string>("log_time", "时间");
			KeyValuePair<string, string> keyValuePair6 = new KeyValuePair<string, string>("page", "模块");
			KeyValuePair<string, string> keyValuePair7 = new KeyValuePair<string, string>("staff_id", "用户名");
			listName.Add(keyValuePair1);
			listName.Add(keyValuePair2);
			listName.Add(keyValuePair3);
			listName.Add(keyValuePair4);
			listName.Add(keyValuePair5);
			listName.Add(keyValuePair6);
			listName.Add(keyValuePair7);
			string filePath = ExcelHelp.ExportToExcel(data,listName, "系统日志", "D:\\DownLoad\\"+filename);
			MessageBox.Show("导出成功");
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			DialogFrm dialog = new DialogFrm();
			dialog.TopLevel = true;
			dialog.ShowDialog();
		}
	}



}
