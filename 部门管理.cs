using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;
using Warehouse.工具窗体;

namespace Warehouse
{


	public partial class 部门管理 : UIPage
	{
		SystemLog log = new SystemLog();
		public 部门管理()
		{

			
			InitializeComponent();


			search1.uiComboBox1.Items.Add("部门号");
			search1.uiComboBox1.Items.Add("部门名");
			search1.uiComboBox1.Items.Add("部门负责人");
			search1.uiComboBox1.SelectedIndex = 0;


			grid.AddColumn("部门号", "dep_id");
			grid.AddColumn("部门名", "dep_name");
			grid.AddColumn("部门负责人姓名", "dep_principal_name");
			grid.AddColumn("部门负责人id", "dep_principal_id");
			grid.AddColumn("部门缩写", "dep_sx");
			//自适应列距离
			for (int i = 0; i < grid.ColumnCount; i++) { grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }

			AddRow();

			search1.SearchButton.Click += new EventHandler(this.search1_SearchEvent);
			search1.uiButton1.Click += new EventHandler(this.search1_AddEvent);
	
		}


        //新增部门
        private void search1_AddEvent(object sender, EventArgs e)
        {
            FEdit_department dep = new FEdit_department();
			
			dep.ShowDialog();

            if (dep.IsOK)
            {
				BLL.department depp = new BLL.department();
				bool m = depp.Add(dep.Department);
				if (m)
				{
					this.ShowSuccessDialog("插入成功");
					AddRow();
				}
				else
				{
					this.ShowSuccessDialog("插入失败");
				}
			}
        }


        // 为gridview填充值
        private void AddRow()
		{

			BLL.department bsta = new BLL.department();

			//this.grid.DataSource = bsta.GetModelList("");

			uiPagination1.DataSource = bsta.GetModelList("");
			uiPagination1.ActivePage = 1;

		}
		private void search1_SearchEvent(object sender, EventArgs e)
        {
			if(search1.SearchBox.Text.Trim() != "")
            {
				int f = search1.uiComboBox1.SelectedIndex;
				string leixing = null;
				if(f == 0)
                {
					leixing = "dep_id";

				}
               if(f == 1)
                {
					leixing = "dep_name";

				}
                if (f == 2)
                {
					leixing = "dep_principal_name";
				}



				string m = search1.SearchBox.Text.Trim();

				
				string str = leixing.Trim() +
				"=" + "\"" +search1.SearchBox.Text.Trim() + "\""; 

				BLL.department department = new BLL.department();
				uiPagination1.DataSource = department.GetModelList(str);


            }
            else
            {
				UIMessageBox.ShowInfo("搜索框不能为空");
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

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grid_MouseUp(object sender, MouseEventArgs e)
        {
			if (e.Button == MouseButtons.Right)
			{

				// GetCellAt: 根据点击的位置，判断点中了哪个单元格
				Point p = GetCellAt(grid, e.Location);
				int rowIndex = p.X;

				grid.ClearSelection();
				if (rowIndex >= 0)
					grid.Rows[rowIndex].Selected = true;

				update.Enabled = (rowIndex >= 0);
				delete.Enabled = (rowIndex >= 0);
				uiContextMenuStrip1.Show(grid, e.Location);
			}
		}


        private void delete_Click(object sender, EventArgs e)
        {
			if (ShowAskDialog("此操作不可恢复。是否确认删除?"))
			{


				foreach (DataGridViewRow row in grid.SelectedRows)
				{
					string m = row.Cells[0].Value.ToString().Trim();


					BLL.department sta = new BLL.department();
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

        private void update_Click(object sender, EventArgs e)
        {
            // 当前行
            int rowIndex = grid.SelectedRows[0].Index;
            string id = grid.Rows[rowIndex].Cells[0].Value.ToString().Trim();



            Model.department sta = new Model.department();
            sta.dep_id = id;





            // 弹出对话框
            
            FEdit_department dlg = new FEdit_department();
            bool m = dlg.FuZhi(id);
            //dlg.Staff.staff_name = name;

            if (m != true)
            {
				UIMessageBox.ShowWarning("错误", true);
			}
            else
            {
				dlg.ShowDialog();
            }
            

            if (dlg.IsOK)
            {

                BLL.department stt = new BLL.department();
                stt.Update(dlg.Department);
                AddRow();
				log.WriteLog(3, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "部门管理", "编辑部门信息", "");
            }
            else
            {
                UIMessageBox.ShowError("编辑失败");
            }

        }
    }
}
