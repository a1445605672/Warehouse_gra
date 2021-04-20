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

namespace Warehouse
{
    public partial class 入库汇总 : UITitlePage
    {
        public 入库汇总()
        {
            InitializeComponent();
            search1.uiComboBox1.Items.Add("入库编号");
            search1.uiComboBox1.Items.Add("入库批次编号");
            search1.uiComboBox1.Items.Add("物料名称");
            search1.uiComboBox1.SelectedIndex = 0;

            grid.AddColumn("入库编号", "enter_id");
            grid.AddColumn("入库批次编号", "enter_batch_id");
            grid.AddColumn("库位编号", "enter_sl_id");
            grid.AddColumn("入库量", "enter_amount");
            grid.AddColumn("单位体积", "enter_unit_bulk");
            grid.AddColumn("供应商编号", "supplier_id");
            grid.AddColumn("入库物料id", "enter_mat_id");
            grid.AddColumn("物料名称", "enter_mat_name");
            grid.AddColumn("封记号", "enter_fengji_num");
            grid.AddColumn("入库日期", "enter_date");
            grid.AddColumn("经办人id", "enter_agent_id");
            grid.AddColumn("经办人姓名", "enter_agent_name");
            grid.AddColumn("备注", "enter_comment");
            //自适应列距离
            for (int i = 0; i < grid.ColumnCount; i++) { grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }

            AddRow();

            search1.SearchButton.Click += new EventHandler(this.search1_SearchEvent);
            search1.uiButton1.Click += new EventHandler(this.search1_AddEvent);
        }
        //新增
        private void search1_AddEvent(object sender, EventArgs e)
        {

        }
        // 为gridview填充值
        private void AddRow()
        {
            BLL.enter_storage bllenter = new BLL.enter_storage();
            this.grid.DataSource = bllenter.GetModelList("");
            uiPagination1.DataSource = bllenter.GetModelList("");
            uiPagination1.ActivePage = 1;
        }
        //搜索
        private void search1_SearchEvent(object sender, EventArgs e)
        {
            if (search1.SearchBox.Text.Trim() != "")
            {
                int f = search1.uiComboBox1.SelectedIndex;
                string leixing = null;
                if (f == 0)
                {
                    leixing = "enter_id";

                }
                if (f == 1)
                {
                    leixing = "enter_batch_id";

                }
                if (f == 2)
                {
                    leixing = "enter_mat_name";
                }



                string m = search1.SearchBox.Text.Trim();
                string str = leixing.Trim() +
                "=" + "\"" + search1.SearchBox.Text.Trim() + "\"";
                BLL.enter_storage bllenter = new BLL.enter_storage();
                uiPagination1.DataSource = bllenter.GetModelList(str);
            }
            else
            {
                UIMessageBox.ShowInfo("搜索框不能为空");
            }
        }
    }
}
