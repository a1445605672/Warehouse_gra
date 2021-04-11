using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model; 
namespace Warehouse
{
	public partial class 在库汇总 : UITitlePage
	{
		public 在库汇总()
		{
			InitializeComponent();
			//GridView添加属性
			uiDataGridView1.AddColumn("入库编号", "enter_num");
			uiDataGridView1.AddColumn("物料id", "mat_id");
			uiDataGridView1.AddColumn("物料名称", "mat_name");
			uiDataGridView1.AddColumn("入库量", "in_time");
			uiDataGridView1.AddColumn("在库时间", "in_time");
			uiDataGridView1.AddColumn("库位编号", "sl_id");
			uiDataGridView1.AddColumn("存量", "in_amount");
			uiDataGridView1.AddColumn("重量", "in_weight");
			uiDataGridView1.AddColumn("体积", "in_volume");
			//自适应列距离
			for (int i = 0; i < uiDataGridView1.ColumnCount; i++) { uiDataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }

			AddRow();
		}
		// 为gridview填充值
		private void AddRow()
		{
			BLL.in_storage istr = new BLL.in_storage();
			this.uiDataGridView1.DataSource = istr.GetModelList("");
			
		}
		//查询
        private void uiButton2_Click(object sender, EventArgs e)
        {
			Model.in_storage in_Storage = new Model.in_storage();
			string wheresql = "select * from in_storage where 1=1";
			if (uiTextBox1.Text!="")
			{
				wheresql+=" and mat_name='" + uiTextBox1.Text.ToString() + "'";
			}

			this.uiDataGridView1.DataSource = new BLL.in_storage().GetList(wheresql);

		}
		

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
