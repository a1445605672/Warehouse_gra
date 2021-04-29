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
	public partial class 库位类型管理 : UITitlePage
	{
		public 库位类型管理()
		{
			InitializeComponent();

			//窗体初始化绑定数据
			grid.AddColumn("库位类型ID", "type_id");
			grid.AddColumn("库位长", "type_length");
			grid.AddColumn("库位宽", "type_high");
			grid.AddColumn("库位高", "type_wide");
			grid.AddColumn("缩写","type_sx");
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

			BLL.storagelocation_type bsta = new BLL.storagelocation_type();
			grid.DataSource= bsta.GetModelList("");
			uiPagination1.DataSource = bsta.GetModelList("");
			uiPagination1.ActivePage = 1;

		}
		//搜索
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

			kuguitype type = new kuguitype();
			type.ShowDialog();
			if (type.IsOK)
			{
				BLL.chest_type sr_ = new BLL.chest_type();
				bool m = sr_.Add(type.Chest_typeModel);
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
