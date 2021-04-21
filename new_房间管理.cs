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
    public partial class new_房间管理 : UITitlePage
    {
        public new_房间管理()
        {
			InitializeComponent();
			//给search控件赋值
			search1.uiComboBox1.Items.Add("房间ID");
			search1.uiComboBox1.Items.Add("房子名字");
			//search1.uiComboBox1.Items.Add("负责人名称");
			search1.uiComboBox1.SelectedIndex = 0;
			grid.ClearAll();
			//窗体初始化绑定数据
			grid.AddColumn("仓库id", "storage_id");
			grid.AddColumn("仓库名", "storage_name");
			grid.AddColumn("仓库创建时间", "storage_create_time");
			grid.AddColumn("仓库面积大小", "storage_area");
			grid.AddColumn("仓库剩余库柜数", "storage_remain_chest");
			grid.AddColumn("仓库剩余库位", "storage_remain_seat");
			grid.AddColumn("仓库备注信息", "storage_comment");
			for (int i = 0; i < grid.ColumnCount; i++) { grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }
			AddRow();

			//确定按钮和搜索按钮赋值
			search1.uiButton1.Click += new EventHandler(this.search1_AddEvent);
			search1.SearchButton.Click += new EventHandler(this.search1_SearchEvent);
		}
		//赋值
		private void AddRow()
		{
			BLL.storage bsta = new BLL.storage();
			this.grid.DataSource = bsta.GetModelList("");
			this.uiPagination1.DataSource = bsta.GetModelList("");
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
			FormEditRoom room = new FormEditRoom();
			room.ShowDialog();
			if (room.IsOK)
			{
				BLL.storage sr_ = new BLL.storage();
				bool m = sr_.Add(room.storageModel);
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