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
	public partial class 物料信息管理 : UITitlePage
	{
		public 物料信息管理()
		{
			InitializeComponent();
			//窗体初始化绑定数据
			grid.AddColumn("物料id", "mat_id");
			grid.AddColumn("物料名", "mat_name");
			grid.AddColumn("物料父类id", "mat_father_id");
			grid.AddColumn("创建时间", "mat_create_time");
			grid.AddColumn("丰度", "mat_fengdu");
			grid.AddColumn("物料状态", "mat_state");
			grid.AddColumn("物料颜色", "mat_colour");
			grid.AddColumn("物料气味", "mat_smell");
			grid.AddColumn("物料类别", "mat_type");
			grid.AddColumn("物料类别id", "mat_type_id");
			grid.AddColumn("物料用途", "mat_purpose");
			grid.AddColumn("物料来源", "mat_source");
			grid.AddColumn("物料酸碱性", "mat_suanjianxing");
			grid.AddColumn("元素百分比", "mat_yuansuzhanbi");
			grid.AddColumn("元素量", "mat_yuansuliang");
			grid.AddColumn("缩写", "mat_sx");
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
			search1.uiComboBox1.Items.Add("房间ID");
			search1.uiComboBox1.Items.Add("房子名字");
			//search1.uiComboBox1.Items.Add("负责人名称");
			search1.uiComboBox1.SelectedIndex = 0;
			//确定按钮和搜索按钮赋值
			search1.uiButton1.Click += new EventHandler(this.search1_AddEvent);
			search1.SearchButton.Click += new EventHandler(this.search1_SearchEvent);
		}
		private void AddRow()
		{
			BLL.material_info bsta = new BLL.material_info();
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
			Frmaterial mat = new Frmaterial();
			mat.ShowDialog();
			if (mat.IsOK)
			{
				BLL.material_info sr_ = new BLL.material_info();
				bool m = sr_.Add(mat.materialModel);
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
				//string id = grid.Rows[rowIndex].Cells[0].Value.ToString().Trim();
				Model.material_info sta = new Model.material_info();
				sta.mat_id = id;
				Frmaterial mat = new Frmaterial();
				bool m = mat.FuZhi(id);
				if (m != true)
				{
					UIMessageBox.ShowWarning("错误", true);
				}
				else
				{
					mat.ShowDialog();
				}
				if (mat.IsOK)
				{
					BLL.material_info bllstorage = new BLL.material_info();
					bool k = bllstorage.Update(mat.MaterialModel);
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
				//删除
				if (grid.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
				{
				}
			}
		}
	}
}
