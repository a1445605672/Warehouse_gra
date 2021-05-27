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
		SystemLog log = new SystemLog();
		int Dindex = -1;
		public 库位类型管理()
		{
			InitializeComponent();

			//窗体初始化绑定数据
			grid.AddColumn("库位类型ID", "type_id");
			grid.AddColumn("库位长", "type_length");
			grid.AddColumn("库位宽", "type_high");
			grid.AddColumn("库位高", "type_wide");
			grid.AddColumn("缩写","type_sx");
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
			//给search控件赋值
			search1.uiComboBox1.Items.Add("库位类型ID");
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
				string leixing_log = null;
				if (f == 0)
				{
					leixing = "type_id";
					leixing_log = "库位类型ID";
				}
				string m = search1.SearchBox.Text.Trim();
				string str = leixing.Trim() +
				"=" + "\"" + search1.SearchBox.Text.Trim() + "\"";
				BLL.storagelocation_type dep = new BLL.storagelocation_type();
				uiPagination1.DataSource = dep.GetModelList(str);
				grid.DataSource = dep.GetModelList(str);
				log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "库位类型管理", "查询" + leixing_log, "");
			}
		}
		//新增
		private void search1_AddEvent(object sender, EventArgs e)
		{

			kuguitype type = new kuguitype();
			type.ShowDialog();
			if (type.IsOK)
			{
				BLL.storagelocation_type sr_ = new BLL.storagelocation_type();
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
		//Gridview的点击事件
		private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//更新
			if (grid.Columns[e.ColumnIndex].Name == "UpDate" && e.RowIndex >= 0)
			{
				//获得选择的行
				int rowIndex = e.RowIndex;
				string id = grid.CurrentRow.Cells[2].Value.ToString();
				//string id = grid.Rows[rowIndex].Cells[0].Value.ToString().Trim();
				Model.storagelocation_type sta = new Model.storagelocation_type();
				sta.type_id = id;
				//弹出对话框
				kuguitype type = new kuguitype();
				bool m = type.FuZhi(id);
				if (m != true)
				{
					UIMessageBox.ShowWarning("错误", true);
				}
				else
				{
					type.ShowDialog();
				}
				if (type.IsOK)
				{
					BLL.storagelocation_type bllstorage = new BLL.storagelocation_type();
					bool k = bllstorage.Update(type.Chest_typeModel);
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
						BLL.storagelocation_type bllstorage = new BLL.storagelocation_type();
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
