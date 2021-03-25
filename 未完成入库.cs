using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;
using Warehouse.更新数据窗体;
namespace Warehouse
{
	public partial class 未完成入库 : UITitlePage
	{
		public 未完成入库()
		{
			ShowStatusForm(100, "数据加载中......");
			InitializeComponent();
			for (int i = 0; i < 10; i++)
				StatusFormStepIt();
			uiDataGridView1.ReadOnly = true;
			#region 列表头
			uiDataGridView1.AddColumn("编号", "enter_id").SetFixedMode(124);
			uiDataGridView1.AddColumn("批次", "enter_batch_id").SetFixedMode(123);
			uiDataGridView1.AddColumn("库位", "enter_sl_id").SetFixedMode(100);
			uiDataGridView1.AddColumn("入库量", "enter_amount").SetFixedMode(65);
			uiDataGridView1.AddColumn("体积", "enter_unit_bulk").SetFixedMode(60);
			uiDataGridView1.AddColumn("供应商", "sr_name").SetFixedMode(90);
			uiDataGridView1.AddColumn("物料", "enter_mat_name").SetFixedMode(130);
			uiDataGridView1.AddColumn("日期", "enter_date").SetFixedMode(90);
			uiDataGridView1.AddColumn("经办人", "enter_agent_name").SetFixedMode(70);
			#endregion
			for (int i = 0; i < 30; i++)
				StatusFormStepIt();
			#region 绑定数据
			BLL.enter_storage enter_Storage = new BLL.enter_storage();
			string sql = "SELECT enter_storage.enter_id,  enter_storage.enter_batch_id,  enter_storage.enter_sl_id," +
				"enter_storage.enter_amount,  enter_storage.enter_unit_bulk,  sr_info.sr_name," +
				"  enter_storage.enter_mat_name,  enter_storage.enter_date,  enter_storage.enter_agent_name " +
				"FROM sr_info,  enter_storage WHERE sr_info.sr_id = enter_storage.supplier_id and enter_if_accomplish=0  ";
				DataSet ds=enter_Storage.getDataList(sql);
			uiPagination1.DataSource = ds.Tables[0];
			uiPagination1.ActivePage = 1;
			#endregion
			for (int i = 0; i < 30; i++)
				StatusFormStepIt();

			#region  添加删除，修改两个按钮
			DataGridViewButtonColumn but = new DataGridViewButtonColumn();
			but.HeaderText = "操作";  //设置列表头的名字
			but.SetFixedMode(50);//设置按钮大小
			but.Name = "UpDate";//设置按钮的名字
			but.DefaultCellStyle.NullValue = "修改";
			uiDataGridView1.Columns.Add(but);

			DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
			but1.HeaderText = "";
			but1.SetFixedMode(50);
			but1.Name = "Delete";
			but1.DefaultCellStyle.NullValue = "删除";
			uiDataGridView1.Columns.Add(but1);
			#endregion

			for (int i = 0; i < 30; i++)
				StatusFormStepIt();
			HideStatusForm();
		}

		#region  窗体加载事件
		private void 未完成入库_Load(object sender, EventArgs e)
		{

			
		}
		#endregion

		#region 翻页事件
		private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
		{
			uiDataGridView1.DataSource = pagingSource;
		}
		#endregion


		#region 点击datagridview按钮事件
		private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			if(uiDataGridView1.Columns[e.ColumnIndex].Name== "UpDate" && e.RowIndex>=0)
			{
				UpdataInWarehouseFrm UpF = new UpdataInWarehouseFrm();
			
				#region 窗体传值
				//编号
				UpF.NumberBox.Text = uiDataGridView1.CurrentRow.Cells[2].Value.ToString();
				//物料
				UpF.MaterialBox.Text= uiDataGridView1.CurrentRow.Cells[8].Value.ToString();
				//库位
				UpF.StorageLocationBox.Text= uiDataGridView1.CurrentRow.Cells[4].Value.ToString();
				//入库量
				UpF.InWarehouseAccountBox.Text= uiDataGridView1.CurrentRow.Cells[5].Value.ToString();
				//体积
				UpF.VolumeBox.Text= uiDataGridView1.CurrentRow.Cells[6].Value.ToString();
				//供应商
				UpF.ProviderBox.Text= uiDataGridView1.CurrentRow.Cells[7].Value.ToString();
				//批次
				UpF.batchBox.Text= uiDataGridView1.CurrentRow.Cells[3].Value.ToString();
				//日期
				UpF.DateBox.Text=Convert.ToDateTime(uiDataGridView1.CurrentRow.Cells[9].Value.ToString()).ToString("yyyy-MM-dd");
				#endregion

				UpF.TopLevel = true;
				UpF.ShowDialog();
				
			}
			if(uiDataGridView1.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
			{
				if(ShowAskDialog("您确定要删除吗？"))
				{
					BLL.enter_storage enter_Storage = new BLL.enter_storage();

					#region 真删除
					//if (enter_Storage.Delete(uiDataGridView1.CurrentRow.Cells[2].Value.ToString()))
					//{
					//	ShowErrorTip("删除成功");
					//}
					//else
					//{
					//	ShowSuccessTip("删除失败");
					//}
					#endregion

					#region 假删除  需要专门清理缓存
					string deleteSql= "update enter_storage set enter_if_accomplish=3 where enter_id=" + "\'"+ uiDataGridView1.CurrentRow.Cells[2].Value.ToString() + "\'";
					if (enter_Storage.Update(deleteSql))
					{
						ShowErrorTip("删除成功");
					}
					else
					{
						ShowSuccessTip("删除失败");
					}
					#endregion

				}
				else
				{
					
					ShowSuccessTip("您已取消");
				}
			}
		}
		#endregion

		
	}
}
