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
			grid.AddColumn("缩写", "storage_sx");
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
		//Grid的点击事件
		private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//更新
			if (grid.Columns[e.ColumnIndex].Name == "UpDate" && e.RowIndex >= 0)
			{
				//获得选择的行
				int rowIndex =e.RowIndex;
				string id= grid.CurrentRow.Cells[2].Value.ToString();
				//string id = grid.Rows[rowIndex].Cells[0].Value.ToString().Trim();
				Model.storage sta = new Model.storage();
				sta.storage_id = id;
				//弹出对话框
				FormEditRoom room = new FormEditRoom();
				bool m = room.FuZhi(id);
				if (m != true)
				{
					UIMessageBox.ShowWarning("错误", true);
				}
				else
				{
					room.ShowDialog();
				}
				if (room.IsOK)
				{
					BLL.storage bllstorage = new BLL.storage();
					bool k= bllstorage.Update(room.StorageModel);
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
						BLL.storage bllstorage = new BLL.storage();
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