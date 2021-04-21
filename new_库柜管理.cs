using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.工具窗体;
namespace Warehouse
{
    public partial class new_库柜管理 : UITitlePage
    {
        public new_库柜管理()
        {
            InitializeComponent();
			//给search控件赋值
			search1.uiComboBox1.Items.Add("库柜ID");
			search1.uiComboBox1.Items.Add("库柜名称");
			//search1.uiComboBox1.Items.Add("负责人名称");
			search1.uiComboBox1.SelectedIndex = 0;
			grid.ClearAll();
			//窗体初始化绑定数据
			grid.AddColumn("库柜id", "chest_id");
			grid.AddColumn("库柜名", "chest_name");
			grid.AddColumn("库柜剩余体积", "chest_remain_volume");
			grid.AddColumn("库柜剩余库位", "chest_remain_seat");
			grid.AddColumn("库柜创建时间", "chest_create_time");
			grid.AddColumn("库柜类型", "chest_type");
			grid.AddColumn("库柜所属仓库", "chest_belong_storage");
			grid.AddColumn("名称缩写", "chest_sx");
			for (int i = 0; i < grid.ColumnCount; i++) { grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }
			AddRow();

			//确定按钮和搜索按钮赋值
			search1.uiButton1.Click += new EventHandler(this.search1_AddEvent);
			search1.SearchButton.Click += new EventHandler(this.search1_SearchEvent);
		}
		//赋值
		private void AddRow()
		{
			BLL.chest bllchest = new BLL.chest();
			this.grid.DataSource = bllchest.GetModelList("");
			this.uiPagination1.DataSource = bllchest.GetModelList("");
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
					leixing = "storage_id";
				}
				if (f == 1)
				{
					leixing = "storage_name";
				}
			}
		}
		private void search1_AddEvent(object sender, EventArgs e)
		{
			kugui ku = new kugui();
			ku.ShowDialog();
			if (ku.IsOK)
			{
				BLL.chest sr_ = new BLL.chest();
				bool m = sr_.Add(ku.chestModel);
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