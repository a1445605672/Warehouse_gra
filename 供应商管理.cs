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
	public partial class 供应商管理 : UIPage
	{
		SystemLog log = new SystemLog();
		int Dindex = -1;

        public 供应商管理()
		{
			InitializeComponent();
			//UIButton uIButton = new UIButton();
			//this.tableLayoutPanel1.Controls.Add(uIButton);

			grid.AddColumn("供收货商编号", "sr_id");
			grid.AddColumn("供收货商名称", "sr_name");
			grid.AddColumn("供收货商类型", "sr_type");
			grid.AddColumn("负责人姓名（员工）", "sr_resp_name");
			grid.AddColumn("负责人id(员工", "sr_resp_id");
			grid.AddColumn("联系人姓名", "sr_contact_name");
			grid.AddColumn("联系人电话", "sr_contact_phone");
			grid.AddColumn("地址", "sr_place");
			grid.AddColumn("创建时间", "sr_create_time");
			grid.AddColumn("更新时间", "sr_update_time");
			grid.AddColumn("缩写", "sr_sx");
			for (int i = 0; i < grid.ColumnCount; i++) { grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }
			AddRow();

			search1.uiComboBox1.Items.Add("类型");
			search1.uiComboBox1.Items.Add("供应商名称");
			search1.uiComboBox1.Items.Add("负责人名称");
			search1.uiComboBox1.SelectedIndex = 0;

			search1.uiButton1.Click += new EventHandler(this.search1_AddEvent);
			search1.SearchButton.Click += new EventHandler(this.search1_SearchEvent);

		
		}


        //搜索
        private void search1_SearchEvent(object sender, EventArgs e)
        {
			if (search1.SearchBox.Text.Trim() != "")
			{
				int f = search1.uiComboBox1.SelectedIndex;
				string leixing = null;
				string leixing_log = null;
				if (f == 0)
				{
					leixing = "sr_type";

				}
				if (f == 1)
				{
					leixing = "sr_name";
					leixing_log = "供收货商名";
				}
				if (f == 2)
				{
					leixing = "sr_resp_name";
					leixing_log = "供收货商类型";
				}



				string m = search1.SearchBox.Text.Trim();


				string str = leixing.Trim() +
				"=" + "\"" + search1.SearchBox.Text.Trim() + "\"";

				BLL.sr_info department = new BLL.sr_info();
				uiPagination1.DataSource = department.GetModelList(str);
				log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "供收货商管理", "查询" + leixing_log, "");

			}
		}

        private void search1_AddEvent(object sender, EventArgs e)
        {
			FEdit_sr sr = new FEdit_sr();
			sr.ShowDialog();

            if (sr.IsOK)
            {
				BLL.sr_info sr_ = new BLL.sr_info();
				bool m = sr_.Add(sr.Sr_Info);
				if(m == true)
                {
					UIMessageBox.ShowSuccess("新增成功");
                }
                else
                {
					UIMessageBox.ShowWarning("新增失败");
                }
            }
        }

        //赋值
        private void AddRow()
		{

			BLL.sr_info bsta = new BLL.sr_info();
			uiPagination1.DataSource = bsta.GetModelList("");
			uiPagination1.ActivePage = 1;

		}

		//翻页
        private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
			grid.DataSource = pagingSource;
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

		//获取鼠标右击的位置
		private void grid_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{

				// GetCellAt: 根据点击的位置，判断点中了哪个单元格
				Point p = GetCellAt(grid, e.Location);
				int rowIndex = p.X;
				
				Dindex = rowIndex;
				
				grid.ClearSelection();
				if (rowIndex >= 0)
				grid.Rows[rowIndex].Selected = true;

				update_sr.Enabled = (rowIndex >= 0);
				delete_sr.Enabled = (rowIndex >= 0);
				uiContextMenuStrip2.Show(grid, e.Location);
			}
		}

        private void delete_sr_Click(object sender, EventArgs e)
        {
			if (ShowAskDialog("此操作不可恢复。是否确认删除?"))
			{


				foreach (DataGridViewRow row in grid.SelectedRows)
				{
					string m = row.Cells[0].Value.ToString().Trim();


					BLL.sr_info sta = new BLL.sr_info();
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

		private Model.sr_info Find_value(int index)
        {

			string m = this.grid.SelectedRows[index].Cells[0].Value.ToString();



			return null;
        }

        private void update_sr_Click(object sender, EventArgs e)
        {
			int rowIndex = grid.SelectedRows[0].Index;
			string id = grid.Rows[rowIndex].Cells[0].Value.ToString().Trim();
			//string name = grid.Rows[rowIndex].Cells[1].Value.ToString().Trim();

			FEdit_sr edit_Sr = new FEdit_sr();
			bool m = edit_Sr.FuZhi(id);

			if(m != true)
            {
				UIMessageBox.ShowWarning("出现差错");
            }
            else
            {
				edit_Sr.ShowDialog();
            }


            if (edit_Sr.IsOK)
            {
				BLL.sr_info info = new BLL.sr_info();
				bool w =  info.Update(edit_Sr.Sr_Info);

			
				AddRow();
            }
            else
            {
				UIMessageBox.ShowError("编辑失败");
            }

		

		}

        private void search1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
