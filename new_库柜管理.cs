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

			#region 添加修改，删除两个按钮
			DataGridViewButtonColumn but = new DataGridViewButtonColumn();
			but.HeaderText = "操作";  //设置列表头的名字
			but.SetFixedMode(50);//设置按钮大小
			but.Name = "UpDate";//设置按钮的名字

			but.DefaultCellStyle.NullValue = "修改";
			grid.Columns.Add(but);

			DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
			but1.HeaderText = "";
			but1.SetFixedMode(50);
			but1.Name = "Delete";
			but1.DefaultCellStyle.NullValue = "删除";
			grid.Columns.Add(but1);
			#endregion

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
				bool m = sr_.Add(ku.ChestModel);
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

		private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//更新
			if (grid.Columns[e.ColumnIndex].Name == "UpDate" && e.RowIndex >= 0)
			{
				//获得选择的行
				int rowIndex = e.RowIndex;
				string id = grid.CurrentRow.Cells[2].Value.ToString();
				Model.chest sta = new Model.chest();
				sta.chest_id = id;
				//弹出对话框
				kugui gui = new kugui();
				bool m = gui.FuZhi(id);
				if (m != true)
				{
					UIMessageBox.ShowWarning("错误", true);
				}
				else
				{
					gui.ShowDialog();
				}
				if (gui.IsOK)
				{
					BLL.chest bllchest = new BLL.chest();
					bool k = bllchest.Update(gui.ChestModel);
					//更改成功
					if (k)
					{
						ShowSuccessDialog("更改成功");

					}
					//更改失败
					else
					{
						UIMessageBox.ShowError("编辑失败");
					}
				}
				else
				{
					UIMessageBox.ShowError("编辑失败");
				}
			}
			//删除
			if (grid.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
			{
				if (ShowAskDialog("此操作不可恢复。是否确认删除?"))
				{
					foreach (DataGridViewRow row in grid.SelectedRows)
					{
						string m = row.Cells[0].Value.ToString().Trim();
						BLL.chest bllstorage = new BLL.chest();
						bool die = bllstorage.Delete(m);
						if (die)
						{
							ShowSuccessDialog("删除成功");
							AddRow();
						}
						else
						{
							ShowErrorDialog("删除失败");
						}
					}
				}
			}
		}
	}
}