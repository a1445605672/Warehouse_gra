using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;

namespace Warehouse
{
	public partial class 出库登记 : UITitlePage
    {
		public 出库登记()
		{
			InitializeComponent();
            uiPanel1.BringToFront(); //panel 顶层显示
            uiPanel1.Visible = false;  //隐藏表单panel

			#region  datagridview添加列
			//第一个参数是列表头，第二个参数用于绑定数据
			uiDataGridView1.AddColumn("入库编号", "enter_num").SetFixedMode(100);
			uiDataGridView1.AddColumn("物料ID", "mat_id").SetFixedMode(100);
			uiDataGridView1.AddColumn("物料名称", "mat_name").SetFixedMode(10);
			uiDataGridView1.AddColumn("入库时间", "in_time").SetFixedMode(100);
			uiDataGridView1.AddColumn("库位编号", "sl_id").SetFixedMode(100);
			uiDataGridView1.AddColumn("存量", "in_amount").SetFixedMode(100);
			uiDataGridView1.AddColumn("重量", "in_weight").SetFixedMode(100);
			uiDataGridView1.AddColumn("体积", "in_volume").SetFixedMode(100);
			uiDataGridView1.ReadOnly = true;
			#endregion

			#region   datagridview添加两个按钮
			DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
            but1.SetFixedMode(50); //设置单元格大小
            but1.HeaderText = "出库";     //设置列表头名称
            but1.Name = "OutWarehouse";     //指定按钮的名字
            but1.DefaultCellStyle.NullValue = "手动"; 
            uiDataGridView1.Columns.Add(but1);

            DataGridViewButtonColumn but = new DataGridViewButtonColumn();
            but.SetFixedMode(50);
            but.HeaderText = "";
            but.Name = "AutoOtWarehouse";
            but.DefaultCellStyle.NullValue = "自动";
            //but.Visible = false;//控件先隐藏 
            uiDataGridView1.Columns.Add(but);
            #endregion

		}


		

		#region  窗体加载事件
		private void 出库_Load(object sender, EventArgs e)
		{
			BLL.in_storage instorage = new BLL.in_storage();
            uiPagination1.DataSource = instorage.GetModelList("");
            uiPagination1.ActivePage = 1;
        }
		#endregion

		#region 翻页事件
		private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
		{
            uiDataGridView1.DataSource = pagingSource;
        }
		#endregion

		#region 点击datagridview的按钮事件
		private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            //判断点击的按钮 且行数大于0
            if (uiDataGridView1.Columns[e.ColumnIndex].Name == "OutWarehouse" && e.RowIndex >= 0)
			{
                uiPanel1.Visible = true;
                string label = uiDataGridView1.CurrentRow.Cells[2].Value.ToString();  //获取当前行的列
                //ShowAskDialog(label);//显示消息框
			}
		}
		#endregion

		#region 返回按钮事件
		private void ReturnBut_Click(object sender, EventArgs e)
		{
            uiPanel1.Visible = false;
		}
        #endregion

        #region 未完成出库事件
        private void SaveBut_Click(object sender, EventArgs e)
        {
            ShowAskDialog("我还没有完成出库哦");
        }
        #endregion

        #region 出库完成事件
        private void OutWarehouseBut_Click(object sender, EventArgs e)
        {
            ShowAskDialog("完成出库");
        }

		#endregion

		
	}
}
