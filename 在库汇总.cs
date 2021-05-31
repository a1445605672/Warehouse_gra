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
			//文件位置
			string a = "D:" + "\\在库汇总.xls";
			//调用文件导出函数
			ExportExcels(a, uiDataGridView1);
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
		/// <summary>
		///
		/// </summary>
		/// <param name="fileName">文件路径</param>
		/// <param name="myDGV">控件DataGridView</param>
		private void ExportExcels(string fileName, DataGridView myDGV)
		{
			string saveFileName = "";
			SaveFileDialog saveDialog = new SaveFileDialog();
			saveDialog.DefaultExt = "xls";
			saveDialog.Filter = "Excel文件|*.xls";
			saveDialog.FileName = fileName;
			saveDialog.ShowDialog();
			saveFileName = saveDialog.FileName;
			if (saveFileName.IndexOf(":") < 0) return; //被点了取消
			Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
			if (xlApp == null)
			{
				MessageBox.Show("无法创建Excel对象，可能您的机子未安装Excel");
				return;
			}
			Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
			Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
			Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1
																																  //写入标题
			for (int i = 0; i < myDGV.ColumnCount; i++)
			{
				worksheet.Cells[1, i + 1] = myDGV.Columns[i].HeaderText;
			}
			//写入数值
			for (int r = 0; r < myDGV.Rows.Count; r++)
			{
				for (int i = 0; i < myDGV.ColumnCount; i++)
				{
					worksheet.Cells[r + 2, i + 1] = myDGV.Rows[r].Cells[i].Value;
				}
				System.Windows.Forms.Application.DoEvents();
			}
			worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
			if (saveFileName != "")
			{
				try
				{
					workbook.Saved = true;
					workbook.SaveCopyAs(saveFileName);
				}
				catch (Exception ex)
				{
					MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
				}
			}
			xlApp.Quit();
			GC.Collect();//强行销毁
			MessageBox.Show("文件： " + fileName + ".xls 保存成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
