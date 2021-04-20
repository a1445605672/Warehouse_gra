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
	public partial class 出库日报 : UITitlePage
	{
		public 出库日报()
		{
			InitializeComponent();
            grid.AddColumn("出库编号", "out_id");
            grid.AddColumn("物料编号", "out_mat_id");
            grid.AddColumn("物料名称", "out_mat_name");
            grid.AddColumn("出库量", "out_account");
            grid.AddColumn("批次编号", "out_batch_id");
            grid.AddColumn("出库日期", "out_data");
            grid.AddColumn("经办人id", "out_staff_id");
            grid.AddColumn("经办人姓名", "out_staff_name");
            grid.AddColumn("收货商编号", "out_sr_id");
            grid.AddColumn("备注", "remark");
            grid.AddColumn("入库编号", "enter_id");
            //自适应列距离
            for (int i = 0; i < grid.ColumnCount; i++) { grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }

            AddRow();
        }
        // 为gridview填充值
        private void AddRow()
        {
            BLL.out_storage bllout = new BLL.out_storage();
            this.grid.DataSource = bllout.GetModelList("");
            uiPagination1.DataSource = bllout.GetModelList("");
            uiPagination1.ActivePage = 1;
        }
        //查询
        private void uiButton1_Click(object sender, EventArgs e)
        {
            //获取日期输入
            string newtime = uiDatePicker1.Text.Trim();
            //数据库语句
            string strSql = "";
            if (newtime != "")
            {
                //UNIX_TIMESTAMP('"+(startTime1.Text.ToString())+"')
                //SELECT * FROM enter_storage WHERE UNIX_TIMESTAMP(enter_date)=UNIX_TIMESTAMP('2021-03-24')
                strSql += "UNIX_TIMESTAMP(out_data)=UNIX_TIMESTAMP('" + uiDatePicker1.Text.ToString() + "')";
            }
            else
            {
                UIMessageBox.ShowSuccess("请选择时间");
            }
            BLL.out_storage bllout = new BLL.out_storage();
            grid.AddColumn("出库编号", "out_id");
            grid.AddColumn("物料编号", "out_mat_id");
            grid.AddColumn("物料名称", "out_mat_name");
            grid.AddColumn("出库量", "out_account");
            grid.AddColumn("批次编号", "out_batch_id");
            grid.AddColumn("出库日期", "out_data");
            grid.AddColumn("经办人id", "out_staff_id");
            grid.AddColumn("经办人姓名", "out_staff_name");
            grid.AddColumn("收货商编号", "out_sr_id");
            grid.AddColumn("备注", "remark");
            grid.AddColumn("入库编号", "enter_id");
            //自适应列距离
            for (int i = 0; i < grid.ColumnCount; i++) { grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }
            this.uiPagination1.DataSource = bllout.GetModelList(strSql);
            this.grid.DataSource = bllout.GetModelList(strSql);
        }

        //导出
        private void uiButton2_Click(object sender, EventArgs e)
        {
            //文件位置
            string a = "D:" + "\\出库日报.xls";
            //调用文件导出函数
            ExportExcels(a, grid);
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
        //导出
        private void uiButton2_ClientSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
