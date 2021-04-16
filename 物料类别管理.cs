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
	public partial class 物料类别管理 : UITitlePage
	{
		public 物料类别管理()
		{
			InitializeComponent();
			//窗体初始绑定数据
			grid.AddColumn("物料类别编号", "type_id");
			grid.AddColumn("物料类别名", "type_name");
			grid.AddColumn("备注", "type_comment");
			grid.AddColumn("缩写", "type_sx");
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

			BLL.material_type bsta = new BLL.material_type();
			grid.DataSource = bsta.GetModelList("");
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

			FrmmaterType type = new FrmmaterType();
			type.ShowDialog();
			if (type.IsOK)
			{
				BLL.material_type sr_ = new BLL.material_type();
				bool m = sr_.Add(type.MaterTypeModel);
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


