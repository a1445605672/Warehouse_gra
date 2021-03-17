using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Warehouse
{
	public partial class 入库日报 : UITitlePage
	{
		public 入库日报()
		{
			InitializeComponent();
			//GridView添加属性
			uiDataGridView1.AddColumn("入库ID", "enter_num");
			uiDataGridView1.AddColumn("商品编号", "mat_id");
			uiDataGridView1.AddColumn("商品名称", "mat_name");
			uiDataGridView1.AddColumn("入库时间", "in_time");
			uiDataGridView1.AddColumn("入库量","in_amount");
			uiDataGridView1.AddColumn("入库重量", "in_weight");
			uiDataGridView1.AddColumn("入库体积", "in_volume");
			//自适应列距离
			for (int i = 0; i < uiDataGridView1.ColumnCount; i++) { uiDataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }

			AddRow();
		}
		// 为gridview填充值
		private void AddRow()
		{

			BLL.in_storage  istr = new BLL.in_storage();

			this.uiDataGridView1.DataSource = istr.GetModelList("");

		}
		//根据日期进行查询
        private void uiButton1_Click(object sender, EventArgs e)
        {
			string newtime = uiDatePicker1.Text.Trim();
			BLL.in_storage istr = new BLL.in_storage();
			this.uiDataGridView1.DataSource = istr.GetModel(newtime);
        }
    }
}
