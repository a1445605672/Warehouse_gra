﻿using Sunny.UI;
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

		private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//更新
			if (grid.Columns[e.ColumnIndex].Name == "UpDate" && e.RowIndex >= 0)
			{
				//获得选择的行
				int rowIndex = e.RowIndex;
				string id = grid.CurrentRow.Cells[2].Value.ToString();
				//string id = grid.Rows[rowIndex].Cells[0].Value.ToString().Trim();
				Model.material_type sta = new Model.material_type();
				sta.type_id = id;
				//弹出对话框
				FrmmaterType type = new FrmmaterType();
				type.uiTextBox1.Enabled = false;
				type.uiTextBox1.Text = "物料编号不能更改";
				bool m= type.FuZhi(id);
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
					BLL.material_type bllstorage = new BLL.material_type();
					bool k = bllstorage.Update(type.MaterTypeModel);
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
					//获得选择的行
					int rowIndex = e.RowIndex;
					string id = grid.CurrentRow.Cells[2].Value.ToString();
					BLL.material_type bllstorage = new BLL.material_type();
					bool die = bllstorage.Delete(id);
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


