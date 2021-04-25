using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.工具窗体;
namespace Warehouse
{
    public partial class new_物料盘存 : UIPage
    {
        BLL.in_storage bllenter = new BLL.in_storage();
        int Dindex = -1;
        public new_物料盘存()
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
        //删除
        private void delete_sr_Click(object sender, EventArgs e)
        {
            if (ShowAskDialog("此操作不可恢复。是否确认删除?"))
            {


                foreach (DataGridViewRow row in uiDataGridView1.SelectedRows)
                {
                    string m = row.Cells[0].Value.ToString().Trim();


                    BLL.in_storage sta = new BLL.in_storage();
                    bool dle = sta.Delete(m);
                    if (dle)
                    {
                        ShowSuccessDialog("删除成功");
                        AddRow();
                    }
                    else
                    {
                        ShowErrorDialog("删除失败");
                    }
                }
            }
        }
        //编辑
        private void update_sr_Click(object sender, EventArgs e)
        {
            int rowIndex = uiDataGridView1.SelectedRows[0].Index;
            string id = uiDataGridView1.Rows[rowIndex].Cells[0].Value.ToString().Trim();
            //string name = grid.Rows[rowIndex].Cells[1].Value.ToString().Trim();

            //FrmEdit edit_Sr = new FEdit_sr();
            //bool m = edit_Sr.FuZhi(id);
            FrmEditInstorage frmE = new FrmEditInstorage();
            bool m= frmE.FuZhi(id);

            if (m != true)
            {
                UIMessageBox.ShowWarning("出现差错");
            }
            else
            {
                frmE.ShowDialog();
            }


            if (frmE.IsOK)
            {
                BLL.in_storage info = new BLL.in_storage();
                bool w = info.Update(frmE.in_storage);
                AddRow();
            }
            else
            {
                UIMessageBox.ShowError("编辑失败");
            }
        }
        //查询
        private void uiButton1_Click(object sender, EventArgs e)
        {

        }
        //翻页
        private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            uiDataGridView1.DataSource = pagingSource;
        }
        //获取鼠标右击的位置
        private void uiDataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                // GetCellAt: 根据点击的位置，判断点中了哪个单元格
                Point p = GetCellAt(uiDataGridView1, e.Location);
                int rowIndex = p.X;

                Dindex = rowIndex;

                uiDataGridView1.ClearSelection();
                if (rowIndex >= 0)
                    uiDataGridView1.Rows[rowIndex].Selected = true;

                update_sr.Enabled = (rowIndex >= 0);
                delete_sr.Enabled = (rowIndex >= 0);
                uiContextMenuStrip2.Show(uiDataGridView1, e.Location);
            }
        }
        // 根据鼠标点击的位置，判断该位置所在的单位格的索引
        public static Point GetCellAt(DataGridView grid, Point location)
        {
            int row = -1, col = -1;

            // 一共显示的行数: DisplayedRowCount()
            // 第一个显示的行： FirstDisplayedScrollingRowIndex
            // 某行的显示区域:  GetRowDisplayRectangle()
            for (int i = grid.FirstDisplayedScrollingRowIndex;
                i < grid.FirstDisplayedScrollingRowIndex + grid.DisplayedRowCount(true);
                i++)
            {
                Rectangle rect = grid.GetRowDisplayRectangle(i, true);
                if (location.Y > rect.Top && location.Y < rect.Bottom)
                {
                    row = i;
                    break;
                }
            }

            for (int k = grid.FirstDisplayedScrollingColumnIndex;
                k < grid.FirstDisplayedScrollingColumnIndex + grid.DisplayedColumnCount(true);
                k++)
            {
                Rectangle rect = grid.GetColumnDisplayRectangle(k, true);
                if (location.X > rect.Left && location.X < rect.Right)
                {
                    col = k;
                    break;
                }
            }

            return new Point(row, col);
        }
    }
}
