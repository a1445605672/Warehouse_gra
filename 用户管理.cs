using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using Warehouse.工具窗体;

namespace Warehouse
{
    public partial class 用户管理 : UIPage
    {
        private List<Model.staff> staffs;

        public static string dep_id;
        public static string Sta_sx;

        public static bool Mode;

        public 用户管理()
        {
            InitializeComponent();

            
            grid.AddColumn("员工id", "staff_id");
            grid.AddColumn("员工名", "staff_name");
            grid.AddColumn("性别", "staff_sex");
            grid.AddColumn("身份证号", "staff_identity_card");
            grid.AddColumn("手机号", "staff_phone_number");
            grid.AddColumn("年龄", "staff_age");
            grid.AddColumn("入职时间", "staff_hire_date");
            grid.AddColumn("所属部门", "staff_belong_dep_id");
            grid.AddColumn("缩写","staff_sx");



            //自适应列距离
            for (int i = 0; i < grid.ColumnCount; i++) { grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }

            AddRow();
        }


        // 为gridview填充值
        private void AddRow()
        {
            
            BLL.staff bsta = new BLL.staff();

            //this.grid.DataSource = bsta.GetModelList(""); 
            
            staffs = bsta.GetModelList("");
            for(int i =0; i<staffs.Count; i++)
            {
                switch (staffs[i].staff_sx)
                {
                    case "1":
                        staffs[i].staff_sx = "系统管理员";
                        break;
                    case "2":
                        staffs[i].staff_sx = "部门管理员";
                        break;
                    case "3":
                        staffs[i].staff_sx = "操作员";
                        break;

                }

            }

            uiPagination1.DataSource = staffs;
            uiPagination1.ActivePage = 1;


        }

        //新增员工
        private void uiButton1_Click(object sender, EventArgs e)
        {
            Mode = true;

            FEdit_staff frm = new FEdit_staff();
            frm.Text = "编辑用户";
            frm.ShowDialog();
            
            if (frm.IsOK)
            {
                
                
                
                    BLL.staff sta = new BLL.staff();
                    bool m = sta.Add(frm.Staff);

                    if (m)
                    {
                        this.ShowSuccessDialog("插入成功");
                    }
                    else
                    {
                        this.ShowSuccessDialog("插入失败");
                    }
                
               
            }
            frm.Dispose();
            AddRow();



        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(uiComboBox1.SelectedItem != null || SearchBox != null)
            {
                string f = uiComboBox1.SelectedText.Trim();

                string LeiXing = null;

                if (f == "部门")
                {
                    LeiXing = "staff_belong_dep_id";
                }
                if (f == "员工号")
                {
                    LeiXing = "staff_id";
                }
                if (f == "性别")
                {
                    LeiXing = "staff_sex";
                }

                string m = SearchBox.SelectedText.Trim();

                BLL.staff sta = new BLL.staff();
               
                string str = LeiXing.Trim() + "=" + "\"" + SearchBox.Text.Trim() + "\"";
                this.grid.DataSource = sta.GetModelList(str);

            }
            else
            {
                ShowInfoDialog("必须选择查询类型，并且填写搜索内容");
            }

            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        private void uiDataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {

                // GetCellAt: 根据点击的位置，判断点中了哪个单元格
                Point p = GetCellAt(grid, e.Location);
                int rowIndex = p.X;

                grid.ClearSelection();
                if (rowIndex >= 0)
                    grid.Rows[rowIndex].Selected = true;

                MenuItem_Add.Enabled = (rowIndex >= 0);
                MenuItem_delete.Enabled = (rowIndex >= 0);
                 uiContextMenuStrip1.Show(grid, e.Location);
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

        private void MenuItem_delete_Click(object sender, EventArgs e)
        {
            if (ShowAskDialog("此操作不可恢复。是否确认删除?"))
            {


                foreach (DataGridViewRow row in grid.SelectedRows)
                {
                    string m = row.Cells[0].Value.ToString().Trim();


                    BLL.staff sta = new BLL.staff();
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


        //编辑功能
        private void MenuItem_update_Click(object sender, EventArgs e)
        {
            Mode = false;

            // 当前行
            int rowIndex = grid.SelectedRows[0].Index;
            string id = grid.Rows[rowIndex].Cells[0].Value.ToString().Trim();
            dep_id = grid.Rows[rowIndex].Cells[7].Value.ToString().Trim();
            Sta_sx = grid.Rows[rowIndex].Cells[8].Value.ToString().Trim();

            Model.staff sta = new Model.staff();
            sta.staff_id = id;
            

            


            // 弹出对话框
            FEdit_staff dlg = new FEdit_staff();
            dlg.Text = "编辑用户";
            bool m = dlg.FuZhi(id);
            //dlg.Staff.staff_name = name;

            if(m == true)
            {
                dlg.ShowDialog();
            }
            else
            {
                UIMessageBox.ShowWarning("错误", true);
            }

            if (dlg.IsOK)
            {
              
                BLL.staff stt = new BLL.staff();
                stt.Update(dlg.Staff);
                AddRow();
            }
            else
            {
                UIMessageBox.ShowError("编辑失败");
            }



           


        }
    }
}
