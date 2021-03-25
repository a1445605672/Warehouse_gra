using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Warehouse
{
	
	public partial class 未完成出库 : UITitlePage
	{
		
		public 未完成出库()
		{
			ShowStatusForm(100, "数据加载中......");
			InitializeComponent();
			for (int i = 0; i < 10; i++)
				StatusFormStepIt();
			uiDataGridView1.BringToFront();
			#region  datagridview添加列
			//第一个参数是列表头，第二个参数用于绑定数据
			uiDataGridView1.AddColumn("出库编号", "out_id").SetFixedMode(140);
			//uiDataGridView1.AddColumn("收货商", "").SetFixedMode(150);
			//uiDataGridView1.AddColumn("物料编号", "out_mat_id").SetFixedMode(150);
			uiDataGridView1.AddColumn("物料名称", "out_mat_name").SetFixedMode(160);
			uiDataGridView1.AddColumn("出库量", "out_account").SetFixedMode(130);
			uiDataGridView1.AddColumn("批次", "out_batch_id").SetFixedMode(130);
			uiDataGridView1.AddColumn("出库日期", "out_data").SetFixedMode(160);
			//uiDataGridView1.AddColumn("经办人编号", "out_staff_id").SetFixedMode(60);
			uiDataGridView1.AddColumn("经办人", "out_staff_name").SetFixedMode(130);
			uiDataGridView1.ReadOnly = true;
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
			#region 出库，数据绑定到datagridview
			List<Model.out_storage> datas = new List<Model.out_storage>();
			BLL.out_storage out_Storage = new BLL.out_storage();
			string Where = "out_if_accomplish=0";
			datas = out_Storage.GetModelList(Where);
			this.uiPagination1.DataSource = datas;//绑定到在库数据绑定到datagridview
			this.uiPagination1.ActivePage = 1;

			#endregion
			for (int i = 0; i < 30; i++)
				StatusFormStepIt();
			HideStatusForm();
		}

		
		#region  窗体加载事件
		private void 未完成出库_Load(object sender, EventArgs e)
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
			if (uiDataGridView1.Columns[e.ColumnIndex].Name == "UpDate" && e.RowIndex >= 0)
			{
				UpdataFrm updatafrm = new UpdataFrm();
				updatafrm.TopLevel = true;
				#region 窗体传值
				//出库编号
				updatafrm.OutWarwhouseNumberBox.Text = uiDataGridView1.CurrentRow.Cells[2].Value.ToString();
				//物料名称
				updatafrm.Materialsbox.Text = uiDataGridView1.CurrentRow.Cells[4].Value.ToString();
				//出库量
				updatafrm.outWarehouseAmountBox.Text = uiDataGridView1.CurrentRow.Cells[5].Value.ToString();
				//批次
				updatafrm.batchNumberBox.Text = uiDataGridView1.CurrentRow.Cells[6].Value.ToString();
				//日期
				updatafrm.edtDate.Text =Convert.ToDateTime( uiDataGridView1.CurrentRow.Cells[7].Value.ToString()).ToString("yyyy-MM-dd");
				//经办人
				updatafrm.staffBox.Text = uiDataGridView1.CurrentRow.Cells[9].Value.ToString();
				#endregion
				updatafrm.ShowDialog();
				
			}
			if (uiDataGridView1.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
			{
				if (ShowAskDialog("您确定要删除吗？"))
				{
					BLL.out_storage out_storage = new BLL.out_storage();
					#region 真正删除
					//if (out_storage.Delete(uiDataGridView1.CurrentRow.Cells[2].Value.ToString()))
					//{
					//	ShowErrorTip("您已删除");
					//}
					//else
					//{
					//	ShowSuccessTip("删除失败");
					//}
					#endregion
					#region 假删除   需要专门清除缓存
					string deleteSql = "update out_storage set out_if_accomplish=3 where out_id=" + "\'" + uiDataGridView1.CurrentRow.Cells[2].Value.ToString() + "\'";
					if (out_storage.Update(deleteSql))
					{
						ShowErrorTip("您已删除");
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