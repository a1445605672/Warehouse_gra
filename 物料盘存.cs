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
    public partial class 物料盘存 : UIPage
    {
        BLL.in_storage bllenter = new BLL.in_storage();
        public 物料盘存()
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

        }
        //编辑
        private void update_sr_Click(object sender, EventArgs e)
        {

        }
        //一级类别
        //BLL.material_type bllmat = new BLL.material_type();
        //uiComboBox3.DataSource = bllmat.GetModelList("");
        //uiComboBox3.DisplayMember = "type_id";
        //uiComboBox3.ValueMember = "type_name";
    }
}
