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
    public partial class new_入库汇总 : UITitlePage
    {
        BLL.enter_storage bllenter = new BLL.enter_storage();
        public new_入库汇总()
        {
            InitializeComponent();
            //加载几个下拉框
            //加载库位编号
            comStorage.DisplayMember = "enter_sl_id";
            //加载物品名称
            comStorage.DisplayMember = "enter_mat_name";
            //加载经办人
            comStorage.DisplayMember = "enter_agent_name";
            //加载入库批次编号
            comStorage.DisplayMember = "enter_batch_id";
            //进行数据绑定
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
        }
        private void AddRow()
        {
            BLL.enter_storage bllenter = new BLL.enter_storage();
            this.grid.DataSource = bllenter.GetModelList("");
            uiPagination1.DataSource = bllenter.GetModelList("");
            uiPagination1.ActivePage = 1;
        }
        private void uiLabel5_Click(object sender, EventArgs e)
        {

        }
        //查询
        private void uiButton2_Click(object sender, EventArgs e)
        {

        }
        //重置
        private void uiButton1_Click(object sender, EventArgs e)
        {

        }
        //加载物品名称
        private void comMatName_Load(object sender, EventArgs e)
        {
            //comStorage.DataSource = bllenter.GetModelList("");
            //comStorage.DisplayMember = "enter_mat_name";
        }
        //加载库位编号
        private void comStorage_Load(object sender, EventArgs e)
        {
            //comStorage.DataSource = bllenter.GetModelList("");
            //comStorage.DisplayMember = "enter_sl_id";
        }
        //加载经办人
        private void comStaffName_Load(object sender, EventArgs e)
        {
            //comStorage.DataSource = bllenter.GetModelList("");
            //comStorage.DisplayMember = "enter_agent_name";
        }
        //加载入库批次编号
        private void comBatch_Load(object sender, EventArgs e)
        {
            //comStorage.DataSource = bllenter.GetModelList("");
            //comStorage.DisplayMember = "enter_batch_id";
        }
    }
}
