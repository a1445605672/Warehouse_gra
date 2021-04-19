using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
	public partial class 出库汇总 : UITitlePage
	{
		public 出库汇总()
		{
			InitializeComponent();
			search1.uiComboBox1.Items.Add("出库编号");
			search1.uiComboBox1.Items.Add("物料编号");
			search1.uiComboBox1.Items.Add("物料名称");
			search1.uiComboBox1.SelectedIndex = 0;

			grid.AddColumn("出库编号", "out_id");
			grid.AddColumn("物料编号", "out_mat_id");
			grid.AddColumn("物料名称", "out_mat_name");
			grid.AddColumn("出库量", "out_account");
			grid.AddColumn("批次编号", "out_batch_id");
			grid.AddColumn("出库日期", "out_data");
			grid.AddColumn("经办人id", "out_staff_id");
			grid.AddColumn("经办人姓名", "out_staff_name");
			grid.AddColumn("收货商编号", "out_sr_id");
			grid.AddColumn("备注", "remark");
			grid.AddColumn("入库编号", "enter_id");
			//自适应列距离
			for (int i = 0; i < grid.ColumnCount; i++) { grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }

			AddRow();

			search1.SearchButton.Click += new EventHandler(this.search1_SearchEvent);
			search1.uiButton1.Click += new EventHandler(this.search1_AddEvent);
		}
		private void search1_AddEvent(object sender, EventArgs e)
		{
			
		}
		// 为gridview填充值
		private void AddRow()
		{
			BLL.out_storage bllout = new BLL.out_storage();
			this.grid.DataSource = bllout.GetModelList("");
			uiPagination1.DataSource = bllout.GetModelList("");
			uiPagination1.ActivePage = 1;
		}
		private void search1_SearchEvent(object sender, EventArgs e)
		{
			if (search1.SearchBox.Text.Trim() != "")
			{
				int f = search1.uiComboBox1.SelectedIndex;
				string leixing = null;
				if (f == 0)
				{
					leixing = "out_id";

				}
				if (f == 1)
				{
					leixing = "out_mat_id";

				}
				if (f == 2)
				{
					leixing = "out_mat_name";
				}



				string m = search1.SearchBox.Text.Trim();


				string str = leixing.Trim() +
				"=" + "\"" + search1.SearchBox.Text.Trim() + "\"";

				BLL.out_storage bllout = new BLL.out_storage();
				uiPagination1.DataSource = bllout.GetModelList(str);


			}
			else
			{
				UIMessageBox.ShowInfo("搜索框不能为空");
			}
		}
	}
}