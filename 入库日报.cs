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
			uiDataGridView1.AddColumn("入库ID", "enter_id");
			uiDataGridView1.AddColumn("入库批次编号", "enter_batch_id");
			uiDataGridView1.AddColumn("库位编号", "enter_sl_id");
			uiDataGridView1.AddColumn("入库量", "enter_amount");
            uiDataGridView1.AddColumn("入库体积", "enter_unit_bulk");
            uiDataGridView1.AddColumn("供应商编号", "supplier_id");
			uiDataGridView1.AddColumn("入库物料id", "enter_mat_id");
			uiDataGridView1.AddColumn("物料名称", "enter_mat_name");
            uiDataGridView1.AddColumn("封记号", "enter_fengji_num");
            uiDataGridView1.AddColumn("入库日期", "enter_date");
            uiDataGridView1.AddColumn("经办人id", "enter_agent_id");
            uiDataGridView1.AddColumn("经办人姓名", "enter_agent_name");
            uiDataGridView1.AddColumn("备注", "enter_comment");
            //自适应列距离
            for (int i = 0; i < uiDataGridView1.ColumnCount; i++) { uiDataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }

			AddRow();
		}
		// 为gridview填充值
		private void AddRow()
		{
			BLL.enter_storage istr = new BLL.enter_storage();
            this.uiDataGridView1.DataSource = istr.GetModelList(1);
			this.uiPagination1.DataSource = istr.GetModelList(1);
            uiPagination1.ActivePage = 1;

		}
		//根据日期进行查询
        private void uiButton1_Click(object sender, EventArgs e)
        {
			//获取日期输入
			string newtime = uiDatePicker1.Text.Trim();
            string endtime = uiDatePicker2.Text.Trim();
            //数据库语句
            string strSql = "";
            if (newtime != ""&&endtime!=null)
            {
                //UNIX_TIMESTAMP('"+(startTime1.Text.ToString())+"')
                //SELECT * FROM enter_storage WHERE UNIX_TIMESTAMP(enter_date)=UNIX_TIMESTAMP('2021-03-24')
                strSql += "UNIX_TIMESTAMP(enter_date) between UNIX_TIMESTAMP('" + uiDatePicker1.Text.ToString() + "') and  UNIX_TIMESTAMP('"+uiDatePicker2.Text.ToString()+"')";
            }
            else
            {
                UIMessageBox.ShowSuccess("请选择时间");
            }
			//拿到业务逻辑层
			BLL.enter_storage istr = new BLL.enter_storage();
            uiDataGridView1.ClearAll();
            uiDataGridView1.AddColumn("入库ID", "enter_id");
            uiDataGridView1.AddColumn("入库批次编号", "enter_batch_id");
            uiDataGridView1.AddColumn("库位编号", "enter_sl_id");
            uiDataGridView1.AddColumn("入库量", "enter_amount");
            uiDataGridView1.AddColumn("入库体积", "enter_unit_bulk");
            uiDataGridView1.AddColumn("供应商编号", "supplier_id");
            uiDataGridView1.AddColumn("入库物料id", "enter_mat_id");
            uiDataGridView1.AddColumn("物料名称", "enter_mat_name");
            uiDataGridView1.AddColumn("封记号", "enter_fengji_num");
            uiDataGridView1.AddColumn("入库日期", "enter_date");
            uiDataGridView1.AddColumn("经办人id", "enter_agent_id");
            uiDataGridView1.AddColumn("经办人姓名", "enter_agent_name");
            uiDataGridView1.AddColumn("备注", "enter_comment");
            //自适应列距离
            for (int i = 0; i < uiDataGridView1.ColumnCount; i++) { uiDataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }
            //数据绑定
            this.uiPagination1.DataSource = istr.GetModelList(strSql);
            this.uiDataGridView1.DataSource= istr.GetModelList(strSql);
            //List<Model.in_storage> datas = new List<Model.in_storage>();
            //BLL.in_storage instorage = new BLL.in_storage();
            //string sql= "SELECT enter_num,mat_id,mat_name,in_time,sl_id,in_amount,in_weight,in_volume FROM in_storage WHERE in_time="+newtime"";
            //datas = instorage.GetModelList(sql);
            //if (datas.Count == 0)
            //{
            //	ShowAskDialog("搜索结果为空！");
            //	return;
            //}
            //else
            //{
            //	uiDataGridView1.DataSource = datas;//绑定到在库数据绑定到datagridview
            //}
        }

		//导出功能
        private void uiButton2_Click(object sender, EventArgs e)
        {
            //文件位置
            string a = "D:" + "\\入库日报.xls";
            //调用文件导出函数
            ExportExcels(a, uiDataGridView1);
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

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PagePanel_Click(object sender, EventArgs e)
        {

        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiDatePicker1_ValueChanged(object sender, DateTime value)
        {

        }

        private void uiPagination1_Click(object sender, EventArgs e)
        {

        }
    }
}
