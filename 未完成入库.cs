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
using Warehouse.工具窗体;

namespace Warehouse
{
	public partial class 未完成入库 : UITitlePage
	{
		SystemLog log = new SystemLog();
		Model.in_storage in_Storage = new Model.in_storage();
		BLL.enter_storage enter_Storage = new BLL.enter_storage();
		BLL.in_storage inStorage = new BLL.in_storage();
		BLL.storagelocation Storagelocation = new BLL.storagelocation();
		public 未完成入库()
		{
			
			InitializeComponent();
			IniData();
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
			//更新
			if (uiDataGridView1.Columns[e.ColumnIndex].Name== "UpDate" && e.RowIndex>=0)
			{
				UpdataInWarehouseFrm UpF = new UpdataInWarehouseFrm();
			
				#region 窗体传值
				//编号
				UpF.NumberBox.Text = uiDataGridView1.CurrentRow.Cells[3].Value.ToString();
				//物料
				UpF.MaterialBox.Text= uiDataGridView1.CurrentRow.Cells[8].Value.ToString();
				//库位
				UpF.StorageLocationBox.Text= uiDataGridView1.CurrentRow.Cells[5].Value.ToString();
				//入库量
				UpF.InWarehouseAccountBox.Text= uiDataGridView1.CurrentRow.Cells[6].Value.ToString();
				//体积
				//UpF.VolumeBox.Text= uiDataGridView1.CurrentRow.Cells[7].Value.ToString();
				//供应商
				UpF.ProviderBox.Text= uiDataGridView1.CurrentRow.Cells[7].Value.ToString();
				//批次
				UpF.batchBox.Text= uiDataGridView1.CurrentRow.Cells[4].Value.ToString();
				//日期
				UpF.DateBox.Text=Convert.ToDateTime(uiDataGridView1.CurrentRow.Cells[9].Value.ToString()).ToString("yyyy-MM-dd");
				#endregion
				UpF.TopLevel = true;
				UpF.ShowDialog();	
			}
			//删除
			if(uiDataGridView1.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
			{
				if(ShowAskDialog("您确定要删除吗？"))
				{
					BLL.enter_storage enter_Storage = new BLL.enter_storage();

					#region 真删除
					//if (enter_Storage.Delete(uiDataGridView1.CurrentRow.Cells[3].Value.ToString()))
					//{
					//	ShowErrorTip("删除成功");
					//	//加载为完成入库数据
					//	loadData();
					//}
					//else
					//{
					//	ShowSuccessTip("删除失败");
					//}
					#endregion

					#region 假删除  需要专门清理缓存
					string deleteSql = "update enter_storage set enter_if_accomplish=3 where enter_id=" + "\'" + uiDataGridView1.CurrentRow.Cells[3].Value.ToString() + "\'";
					if (enter_Storage.Update(deleteSql))
					{
						log.WriteLog(2, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "未完成出库", "删除未完成入库信息", uiDataGridView1.CurrentRow.Cells[3].Value.ToString());
						ShowErrorTip("删除成功");
						//加载为完成入库数据
						loadData();
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

			//入库
			if(uiDataGridView1.Columns[e.ColumnIndex].Name == "inStorage" && e.RowIndex >= 0)
				{
				string enter_Sql = "select * from enter_storage where enter_id=\'" + uiDataGridView1.CurrentRow.Cells[3].Value.ToString() + "\' and enter_if_accomplish=0";
				DataSet ds = enter_Storage.getDataList(enter_Sql);
				in_Storage.mat_id =ds.Tables[0].Rows[0]["enter_mat_id"].ToString();//物料ID
				in_Storage.mat_name = ds.Tables[0].Rows[0]["enter_mat_name"].ToString();//物料名称
				in_Storage.in_time =Convert.ToDateTime( ds.Tables[0].Rows[0]["enter_date"].ToString());//入库时间
				in_Storage.in_weight =Convert.ToDecimal( ds.Tables[0].Rows[0]["enter_unit_bulk"].ToString());
				in_Storage.in_volume = 28;
				in_Storage.enter_num = ds.Tables[0].Rows[0]["enter_id"].ToString();//入库ID
				in_Storage.sl_id = ds.Tables[0].Rows[0]["enter_sl_id"].ToString();//库位编号
				in_Storage.in_amount = Convert.ToDecimal(ds.Tables[0].Rows[0]["enter_amount"].ToString());
				inStorage.Add(in_Storage);
				string Sql = "UPDATE  storagelocation SET sl_remain_bulk=sl_remain_bulk-" + in_Storage.in_amount + " WHERE sl_id=\'" + in_Storage.sl_id + "\'";
				Storagelocation.Update(Sql);
				//更新入库状态
				String mat_sql= "UPDATE  enter_storage set enter_if_accomplish=1 where enter_id=\'"+ ds.Tables[0].Rows[0]["enter_id"].ToString()+"\'";
				Storagelocation.Update(mat_sql);
				ShowSuccessDialog("入库已完成，请及时查看");
				log.WriteLog(6, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "未完成入库", "完成入库", ds.Tables[0].Rows[0]["enter_id"].ToString());
				ShowSuccessDialog("入库已完成，请及时查看");


			}
		}
		#endregion

		#region 初始化数据
		private void IniData()
		{
			ShowStatusForm(100, "数据加载中......");
			for (int i = 0; i < 10; i++)
				StatusFormStepIt();
			uiDataGridView1.ReadOnly = true;
			#region 列表头
			uiDataGridView1.AddColumn("编号", "enter_id").SetFixedMode(129);
			uiDataGridView1.AddColumn("批次", "enter_batch_id").SetFixedMode(123);
			uiDataGridView1.AddColumn("库位", "enter_sl_id").SetFixedMode(105);
			uiDataGridView1.AddColumn("入库量", "enter_amount").SetFixedMode(65);
			//uiDataGridView1.AddColumn("体积", "enter_unit_bulk").SetFixedMode(60);
			uiDataGridView1.AddColumn("供应商", "sr_name").SetFixedMode(90);
			uiDataGridView1.AddColumn("物料", "enter_mat_name").SetFixedMode(130);
			uiDataGridView1.AddColumn("日期", "enter_date").SetFixedMode(90);
			uiDataGridView1.AddColumn("经办人", "enter_agent_name").SetFixedMode(70);
			#endregion
			for (int i = 0; i < 30; i++)
				StatusFormStepIt();
			//加载未完成入库数据
			loadData();

			for (int i = 0; i < 30; i++)
				StatusFormStepIt();

			#region  添加删除，修改两个按钮
			DataGridViewButtonColumn but2 = new DataGridViewButtonColumn();
			but2.HeaderText = "操作";
			but2.SetFixedMode(50);
			but2.Name = "inStorage";
			but2.DefaultCellStyle.NullValue = "入库";
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
			HideStatusForm();
		}
		#endregion

		#region 加载未完成入库数据
		private void loadData()
		{
			#region 绑定数据
			BLL.enter_storage enter_Storage = new BLL.enter_storage();
			string sql = "SELECT enter_storage.enter_id,  enter_storage.enter_batch_id,  enter_storage.enter_sl_id," +
				"enter_storage.enter_amount,   sr_info.sr_name," +
				"  enter_storage.enter_mat_name,  enter_storage.enter_date,  enter_storage.enter_agent_name " +
				"FROM sr_info,  enter_storage WHERE sr_info.sr_id = enter_storage.supplier_id and enter_if_accomplish=0  ";
			DataSet ds = enter_Storage.getDataList(sql);
			uiPagination1.DataSource = ds.Tables[0];
			uiPagination1.ActivePage = 1;
			#endregion
		}
		#endregion

	}
}
