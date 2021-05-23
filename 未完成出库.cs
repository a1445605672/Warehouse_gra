using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Warehouse.工具窗体;

namespace Warehouse
{
	
	public partial class 未完成出库 : UITitlePage
	{
		SystemLog log = new SystemLog();
		Model.out_storage out_storage = new Model.out_storage();
		BLL.out_storage out_Storage = new BLL.out_storage();
		public 未完成出库()
		{
			ShowStatusForm(100, "数据加载中......");
			InitializeComponent();
			for (int i = 0; i < 10; i++)
				StatusFormStepIt();
			uiDataGridView1.BringToFront();
			#region  datagridview添加列
			//第一个参数是列表头，第二个参数用于绑定数据
			uiDataGridView1.AddColumn("出库编号", "out_id").SetFixedMode(150);//150
			//uiDataGridView1.AddColumn("收货商", "").SetFixedMode(150);
			//uiDataGridView1.AddColumn("物料编号", "out_mat_id").SetFixedMode(150);
			uiDataGridView1.AddColumn("物料名称", "out_mat_name").SetFixedMode(160);//160
			uiDataGridView1.AddColumn("出库量", "out_account").SetFixedMode(80);
			uiDataGridView1.AddColumn("批次", "out_batch_id").SetFixedMode(130);//130
			uiDataGridView1.AddColumn("出库日期", "out_data").SetFixedMode(160);//160
			//uiDataGridView1.AddColumn("经办人编号", "out_staff_id").SetFixedMode(60);
			uiDataGridView1.AddColumn("经办人", "out_staff_name").SetFixedMode(120);//120
			uiDataGridView1.ReadOnly = true;
			#endregion
			for (int i = 0; i < 30; i++)
				StatusFormStepIt();
			#region  添加删除，修改两个按钮
			DataGridViewButtonColumn but2 = new DataGridViewButtonColumn();
			but2.HeaderText = "操作";
			but2.SetFixedMode(50);
			but2.Name = "outStorage";
			but2.DefaultCellStyle.NullValue = "出库";
			uiDataGridView1.Columns.Add(but2);

			DataGridViewButtonColumn but = new DataGridViewButtonColumn();
			but.HeaderText = "";  //设置列表头的名字
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

			string SQL = "select out_id,out_mat_id,out_mat_name,out_account,out_batch_id,out_data,out_staff_id,out_staff_name,enter_id,out_sr_id FROM out_storage where out_if_accomplish=0";
			DataSet ds = out_Storage.getDataList(SQL);
			this.uiPagination1.DataSource = ds.Tables[0];//绑定到在库数据绑定到datagridview
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
				updatafrm.OutWarwhouseNumberBox.Text = uiDataGridView1.CurrentRow.Cells[3].Value.ToString();
				//物料名称
				updatafrm.Materialsbox.Text = uiDataGridView1.CurrentRow.Cells[5].Value.ToString();
				//出库量
				updatafrm.outWarehouseAmountBox.Text = uiDataGridView1.CurrentRow.Cells[6].Value.ToString();
				//批次
				updatafrm.batchNumberBox.Text = uiDataGridView1.CurrentRow.Cells[7].Value.ToString();
				//日期
				updatafrm.edtDate.Text =Convert.ToDateTime( uiDataGridView1.CurrentRow.Cells[8].Value.ToString()).ToString("yyyy-MM-dd");
				//经办人
				updatafrm.staffBox.Text = uiDataGridView1.CurrentRow.Cells[10].Value.ToString();
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
					log.WriteLog(2, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "未完成出库", "删除物料", uiDataGridView1.CurrentRow.Cells[13].Value.ToString());
				}
				else
				{
					ShowSuccessTip("您已取消");
					
				}
			}
			//出库
			if (uiDataGridView1.Columns[e.ColumnIndex].Name == "outStorage" && e.RowIndex >= 0)
			{
				

				out_storage.out_id = uiDataGridView1.CurrentRow.Cells[3].Value.ToString();//出库编号
				out_storage.out_mat_id = uiDataGridView1.CurrentRow.Cells[3].Value.ToString();//物料id
				//out_storage.out_mat_name =uiDataGridView1.CurrentRow.Cells[5].Value.ToString();//物料名称
				out_storage.out_account = Convert.ToDecimal(uiDataGridView1.CurrentRow.Cells[6].Value.ToString());//出库量
				out_storage.out_batch_id = uiDataGridView1.CurrentRow.Cells[7].Value.ToString();//批次编号
				out_storage.out_data = uiDataGridView1.CurrentRow.Cells[8].Value.ToString();//入库时间
				out_storage.out_staff_id = uiDataGridView1.CurrentRow.Cells[9].Value.ToString();//经办人编号
				out_storage.out_staff_name = uiDataGridView1.CurrentRow.Cells[10].Value.ToString();//经办人姓名
				out_storage.out_if_accomplish = 1;
				out_storage.out_sr_id = uiDataGridView1.CurrentRow.Cells[15].Value.ToString();//收货商id
				out_storage.remark = "";//备注
				out_storage.enter_id = uiDataGridView1.CurrentRow.Cells[14].Value.ToString();//入库编号
			}
		}
		#endregion
	}
}