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
			InitializeComponent();

			#region  datagridview添加列
			//第一个参数是列表头，第二个参数用于绑定数据
			uiDataGridView1.AddColumn("出库编号", "enter_num").SetFixedMode(130);
			uiDataGridView1.AddColumn("物料编号", "mat_id").SetFixedMode(150);
			uiDataGridView1.AddColumn("物料名称", "mat_name").SetFixedMode(160);
			uiDataGridView1.AddColumn("出库量", "in_time").SetFixedMode(130);
			uiDataGridView1.AddColumn("批次编号", "sl_id").SetFixedMode(100);
			uiDataGridView1.AddColumn("出库日期", "in_amount").SetFixedMode(60);
			uiDataGridView1.AddColumn("经办人编号", "in_weight").SetFixedMode(60);
			uiDataGridView1.AddColumn("经办人姓名", "in_volume").SetFixedMode(60);
	
			uiDataGridView1.ReadOnly = true;
			#endregion

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

			#region 在库，数据绑定到datagridview
			List<Model.out_storage> datas = new List<Model.out_storage>();
			BLL.out_storage out_Storage = new BLL.out_storage();
			string Where = "out_if_accomplish=0";
			datas = out_Storage.GetModelList(Where);
			uiPagination1.DataSource = datas;//绑定到在库数据绑定到datagridview
			uiPagination1.ActivePage = 1;
			
			#endregion

		}
		#region  窗体加载事件
		private void 未完成出库_Load(object sender, EventArgs e)
		{
			List<Data> datas = new List<Data>();
			for (int i = 0; i < 3650; i++)
			{
				Data data = new Data();
				data.Column1 = "Data" + i.ToString("D2");
				data.Column2 = i.Mod(2) == 0 ? "A" : "B";
				data.Column3 = "编辑";
				data.Column4 = i.Mod(4) == 0;
				datas.Add(data);
			}

			uiPagination1.DataSource = datas;
			uiPagination1.ActivePage = 1;
		}
		#endregion
		public class Data
		{
			public string Column1 { get; set; }

			public string Column2 { get; set; }

			public string Column3 { get; set; }

			public bool Column4 { get; set; }

			public override string ToString()
			{
				return Column1;
			}
		}

		#region 翻页事件
		private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
		{
			uiDataGridView1.DataSource = pagingSource;
		}
		#endregion
		#region 点击datagridview按钮事件
		private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			if (uiDataGridView1.Columns[e.ColumnIndex].Name == "UpDate" && e.RowIndex > 0)
			{
				ShowAskDialog("我要修改内容");
			}
			if (uiDataGridView1.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex > 0)
			{
				if (ShowAskDialog("我要删除你"))
				{
					ShowSuccessTip("您点击了确定按钮");
				}
				else
				{
					ShowErrorTip("您点击了取消按钮");
				}
			}
		}
		#endregion
	}
}