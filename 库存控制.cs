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
    public partial class 库存控制 : UITitlePage
    {
        BLL.in_storage bllenter = new BLL.in_storage();
        public 库存控制()
        {
            InitializeComponent();

            uiDataGridView1.ClearAll();
            uiDataGridView1.AddColumn("入库编号", "enter_num");
            uiDataGridView1.AddColumn("物料ID", "mat_id");
            uiDataGridView1.AddColumn("物料名称", "mat_name");
            uiDataGridView1.AddColumn("入库量", "in_time");
            uiDataGridView1.AddColumn("在库时间", "in_time");
            uiDataGridView1.AddColumn("库位编号", "sl_id");
            uiDataGridView1.AddColumn("存量", "in_amount");
            uiDataGridView1.AddColumn("重量", "in_weight");
            uiDataGridView1.AddColumn("体积", "in_volume");
            uiDataGridView1.AddColumn("库存上限", "maxpo");
            uiDataGridView1.AddColumn("库存下限", "minpo");
            DataGridViewButtonColumn but = new DataGridViewButtonColumn();
            but.HeaderText = "操作";  //设置列表头的名字
            but.SetFixedMode(50);//设置按钮大小
            but.Name = "UpDate";//设置按钮的名字

            but.DefaultCellStyle.NullValue = "修改";
            uiDataGridView1.Columns.Add(but);
            for (int i = 0; i < uiDataGridView1.ColumnCount; i++) { uiDataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }
            AddRow();
           
            //库存控制思路：
            //1、根据物料ID对于在库物料的重量进行求和
            //2、构建一个  物料ID-上限-下限表，每一个物料ID都会有上下限
            //3、如果在库求和  超出或者小于上下限，进行提示
        }
        //鼠标点击以后文本框清空
        private void uiTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            uiTextBox1.Text = "";
        }
        // 为gridview填充值
        private void AddRow()
        {
            //GridView添加属性
            //data = bllenter.GetModelList("");
            this.uiDataGridView1.DataSource = bllenter.GetModelList("in_amount<maxpo AND in_amount>minpo");
            this.uiPagination1.DataSource = bllenter.GetModelList("in_amount<maxpo AND in_amount>minpo");
            uiPagination1.ActivePage = 1;
            //自适应列距离

            //BLL.in_storage istr = new BLL.in_storage();
            //this.uiDataGridView1.DataSource = istr.GetModelList("");

        }
        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //更新
            if (uiDataGridView1.Columns[e.ColumnIndex].Name == "UpDate" && e.RowIndex >= 0)
            {
                //获得选择的行
                int rowIndex = e.RowIndex;
                string id = uiDataGridView1.CurrentRow.Cells[1].Value.ToString();
                Model.in_storage sta = new Model.in_storage();
                sta.mat_id = id;
                FrmLimit1 roo = new FrmLimit1();
                bool m = roo.FuZhi(id);
                if (m != true)
                {
                    UIMessageBox.ShowWarning("错误", true);
                }
                else
                {
                    roo.ShowDialog();
                }
                if (roo.IsOK)
                {

                    BLL.in_storage bllin = new BLL.in_storage();
                    bool k = bllin.Update(roo.Getstr(id));
                    //更改成功
                    if (k)
                    {
                        ShowSuccessDialog("更改成功");

                    }
                    //更改失败
                    else
                    {
                        UIMessageBox.ShowError("编辑失败");
                    }
                }
                else
                {
                    UIMessageBox.ShowError("编辑失败");
                }
            }
        }
        //新增库存控制
        private void uiButton2_Click(object sender, EventArgs e)
        {
            //FrmLimit limit = new FrmLimit();
            //limit.Show();
        }
    }
}
