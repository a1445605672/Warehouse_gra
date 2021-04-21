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
		//List<Model.enter_storage> data;
		BLL.in_storage bllenter = new BLL.in_storage();
		public 在库汇总()
		{
			InitializeComponent();
			uiDataGridView1.ClearAll();
			uiDataGridView1.AddColumn("入库编号", "enter_num");
			uiDataGridView1.AddColumn("物料id", "mat_id");
			uiDataGridView1.AddColumn("物料名称", "mat_name");
			uiDataGridView1.AddColumn("入库量", "in_time");
			uiDataGridView1.AddColumn("在库时间", "in_time");
			uiDataGridView1.AddColumn("库位编号", "sl_id");
			uiDataGridView1.AddColumn("存量", "in_amount");
			uiDataGridView1.AddColumn("重量", "in_weight");
			uiDataGridView1.AddColumn("体积", "in_volume");
			for (int i = 0; i < uiDataGridView1.ColumnCount; i++) { uiDataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }
			AddRow();

		}
		// 为gridview填充值
		private void AddRow()
		{
			//GridView添加属性
			//data = bllenter.GetModelList("");
			this.uiDataGridView1.DataSource = bllenter.GetModelList("");
			this.uiPagination1.DataSource = bllenter.GetModelList("");
			uiPagination1.ActivePage = 1;
			//自适应列距离

			//BLL.in_storage istr = new BLL.in_storage();
			//this.uiDataGridView1.DataSource = istr.GetModelList("");

		}
		//查询
		private void uiButton2_Click(object sender, EventArgs e)
		{
			//判断日期
			string strSql = "";
			if (startTime1.Value.ToString() != null)
			{
				if (endTime1.Value.ToString() != null)
				{
					DateTime time1 = DateTime.Parse(startTime1.Value.ToString());
					DateTime time2 = DateTime.Parse(endTime1.Value.ToString());

					if (time1 > time2)
					{
						//提示错误
						UIMessageBox.ShowSuccess("时间填写错误");
					}
				}
				strSql += "UNIX_TIMESTAMP(in_time) between UNIX_TIMESTAMP('" + (startTime1.Text.ToString()) + "') and UNIX_TIMESTAMP('" + (endTime1.Text.ToString()) + "')";
			}
			//物料ID
			if (txtMatid1.Text != "")
			{
				strSql += "and in_storage.mat_id='" + txtMatid1.Text.ToString() + "'";
			}
			//物料名称
			if (txtMatName1.Text != "")
			{
				strSql += "and in_storage.mat_name='" + txtMatName1.Text.ToString() + "'";
			}
			//入库ID
			if (comIn_num.Text != "")
			{
				strSql += "and in_storage.enter_num='" + comIn_num.SelectedValue.ToString() + "'";
			}

			//库位编号
			if (comStorageNum.Text != "")
			{
				strSql += "and in_storage.sl_id='" + comStorageNum.SelectedValue.ToString() + "'";
			}
			uiDataGridView1.ClearAll();
			uiDataGridView1.ClearAll();
			uiDataGridView1.AddColumn("入库编号", "enter_num");
			uiDataGridView1.AddColumn("物料id", "mat_id");
			uiDataGridView1.AddColumn("物料名称", "mat_name");
			uiDataGridView1.AddColumn("入库量", "in_time");
			uiDataGridView1.AddColumn("在库时间", "in_time");
			uiDataGridView1.AddColumn("库位编号", "sl_id");
			uiDataGridView1.AddColumn("存量", "in_amount");
			uiDataGridView1.AddColumn("重量", "in_weight");
			uiDataGridView1.AddColumn("体积", "in_volume");
			for (int i = 0; i < uiDataGridView1.ColumnCount; i++) { uiDataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }
			uiPagination1.DataSource = bllenter.GetModelList(strSql);
			uiDataGridView1.DataSource = bllenter.GetModelList(strSql);
		}
			//AddRow();
			//Model.in_storage in_Storage = new Model.in_storage();
			//string wheresql = "select * from in_storage where 1=1";
			//if (txtMatName1.Text!="")
			//{
			//	wheresql+=" and mat_name='" + txtMatName1.Text.ToString() + "'";
			//}
			//this.uiDataGridView1.DataSource=bllenter.GetModelList(wheresql);
			//this.uiPagination1.DataSource = bllenter.GetModelList(wheresql);
			//uiPagination1.ActivePage = 1;

			//string wheresql = "select * from in_storage where 1=1";
			//if (uiTextBox1.Text!="")
			//{
			//	wheresql+=" and mat_name='" + uiTextBox1.Text.ToString() + "'";
			//}
			//this.uiDataGridView1.DataSource = new BLL.in_storage().Getmat_name(uiTextBox1.Text.ToString());

		

	
        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
		//重置
        private void uiButton1_Click(object sender, EventArgs e)
        {

        }
		//导出
        private void uiButton3_Click(object sender, EventArgs e)
        {

        }
		//加载入库编号
        private void comIn_num_Load(object sender, EventArgs e)
        {
			comIn_num.DataSource= bllenter.GetModelList("");
			comIn_num.DisplayMember = "enter_num";
			comIn_num.ValueMember = "enter_num";
		}
		//加载库位编号
        private void comStorageNum_Load(object sender, EventArgs e)
        {
			comStorageNum.DataSource = bllenter.GetModelList("");
			comStorageNum.DisplayMember = "sl_id";
			comStorageNum.ValueMember = "sl_id";
		}
    }
}
