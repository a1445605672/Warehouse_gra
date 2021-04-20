using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse.工具窗体;
namespace Warehouse
{
	public partial class 库位管理 : UITitlePage
	{
		public 库位管理()
		{
			InitializeComponent();

			grid.AddColumn("库位ID", "sl_id");
			grid.AddColumn("库位类型", "sl_store_type_id");
			grid.AddColumn("库位上限", "sl_store_max");
			grid.AddColumn("库位下限", "sl_store_min");
			grid.AddColumn("可存放面积", "sl_store_area");
			grid.AddColumn("备注", "sl_comment");
			grid.AddColumn("剩余面积", "sl_remain_bulk");
			grid.AddColumn("所属库柜", "sl_belong_chest");
			for (int i = 0; i < grid.ColumnCount; i++) { grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }
			AddRow();
			//给search控件赋值
			search1.uiComboBox1.Items.Add("库柜类型ID");
			//search1.uiComboBox1.Items.Add("负责人名称");
			search1.uiComboBox1.SelectedIndex = 0;
			//确定按钮和搜索按钮赋值
			search1.uiButton1.Click += new EventHandler(this.search1_AddEvent);
			search1.SearchButton.Click += new EventHandler(this.search1_SearchEvent);
		}
		//赋值
		private void AddRow()
		{
			BLL.storagelocation bsta = new BLL.storagelocation();
			this.grid.DataSource = bsta.GetModelList("");
			uiPagination1.DataSource = bsta.GetModelList("");
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
					leixing = "type_id";
				}

			}
		}
		private void search1_AddEvent(object sender, EventArgs e)
		{

		    FrmStorage str = new FrmStorage();
			str.ShowDialog();
			if (str.IsOK)
			{
				BLL.storagelocation sr_ = new BLL.storagelocation();
				bool m = sr_.Add(str.storagelocationModel);
				if (m == true)
				{
					UIMessageBox.ShowSuccess("新增成功");
				}
				else
				{
					UIMessageBox.ShowWarning("新增失败");
				}
			}
		}
		//翻页
		private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
		{
			grid.DataSource = pagingSource;
		}
	}
}
