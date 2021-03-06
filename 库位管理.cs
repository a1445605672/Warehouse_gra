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
	public partial class 库位管理 : UITitlePage
	{
		SystemLog log = new SystemLog();
		int Dindex = -1;
		public 库位管理()
		{
			InitializeComponent();
			//给search控件赋值
			search1.uiComboBox1.Items.Add("库位编号");
			search1.uiComboBox1.Items.Add("库位类型");
			search1.uiComboBox1.SelectedIndex = 0;
			grid.ClearAll();
			grid.AddColumn("库位ID", "sl_id");
			grid.AddColumn("库位类型", "sl_store_type_id");
			grid.AddColumn("库位上限", "sl_store_max");
			grid.AddColumn("库位下限", "sl_store_min");
			grid.AddColumn("可存放面积", "sl_store_area");
			grid.AddColumn("备注", "sl_comment");
			grid.AddColumn("剩余面积", "sl_remain_bulk");
			grid.AddColumn("所属库柜", "sl_belong_chest");
			grid.AddColumn("缩写", "sl_sx");

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
				string leixing_log = null;
				if (f == 0)
				{
					leixing = "sl_id";
					leixing_log = "库位编号";
				}
				if (f == 1)
				{
					leixing = "sl_store_type_id";
					leixing_log = "库位类型";
				}
				string m = search1.SearchBox.Text.Trim();
				string str = leixing.Trim() +
				"=" + "\"" + search1.SearchBox.Text.Trim() + "\"";
				BLL.storagelocation dep = new BLL.storagelocation();
				uiPagination1.DataSource = dep.GetModelList(str);
				grid.DataSource = dep.GetModelList(str);
				log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "库位管理", "查询" + leixing_log, "");
			}
		}
		private void search1_AddEvent(object sender, EventArgs e)
		{
			FrmStorage str = new FrmStorage();
			str.ShowDialog();
			if (str.IsOK)
			{
				BLL.storagelocation sr_ = new BLL.storagelocation();
				bool m = sr_.Add(str.StoragelocationModel);
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
				Model.storagelocation sta = new Model.storagelocation();
				sta.sl_id = id;
				FrmStorage stor = new FrmStorage();
				stor.uiButton1.Visible = false;
				stor.uiListBox1.Visible = false;
				bool m = stor.FuZhi(id);
				if (m != true)
				{
					UIMessageBox.ShowWarning("错误", true);
				}
				else
				{
					stor.ShowDialog();
				}
				if (stor.IsOK)
				{
					BLL.storagelocation bllstorage = new BLL.storagelocation();
					bool k = bllstorage.Update(stor.StoragelocationModel);
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
					int rowindex = e.RowIndex;
					string id = grid.CurrentRow.Cells[2].Value.ToString();
					BLL.storagelocation bllstorage = new BLL.storagelocation();
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
