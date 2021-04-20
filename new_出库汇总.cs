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
    public partial class new_出库汇总 : UITitlePage
    {
        BLL.out_storage bllout = new BLL.out_storage();
        public new_出库汇总()
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
        //导出
        private void uiButton3_Click(object sender, EventArgs e)
        {

        }
        //查询
        private void uiButton2_Click(object sender, EventArgs e)
        {
            //StringBuilder strSql = new StringBuilder();
            string strSql = "";
            //用于判断时间是否填写
            if (startTime1.Value.ToString() != null)
            {
                if (endTime1.Value.ToString() != null)
                {
                    //时间戳的查询
                    //SELECT * FROM enter_storage WHERE  UNIX_TIMESTAMP(enter_date)  BETWEEN UNIX_TIMESTAMP('2019-07-25 00:00:33') AND UNIX_TIMESTAMP('2019-07-25 00:54:33')
                    //如果时间输入不合法则判断错误
                    DateTime time1 = DateTime.Parse(startTime1.Value.ToString());
                    DateTime time2 = DateTime.Parse(endTime1.Value.ToString());

                    if (time1 > time2)
                    {
                        //提示错误
                        UIMessageBox.ShowSuccess("时间填写错误");
                    }
                }
                //strSql += "and date between '" + startTime1.Text.ToString() + " 00:00:00.000000' and '" + endTime1.Text.ToString() + " 00:00:00.000000";
                //strSql += "and date between '"+ startTime1.Text.ToString() + "' and '"+ endTime1.Text.ToString() + "' ";
                strSql += "UNIX_TIMESTAMP(out_data) between UNIX_TIMESTAMP('" + (startTime1.Text.ToString()) + "')and UNIX_TIMESTAMP('" + (endTime1.Text.ToString()) + "')";
            }
            //用于判断物品名称是否选择
            if (comMatName.Text != "")
            {
                strSql += "and out_storage.out_mat_name='" + comMatName.SelectedValue.ToString() + "'";
            }
            //用于判断库位编号是否选择
            if (comStorage.Text != "")
            {
                strSql += "and out_storage.out_id='" + comStorage.SelectedValue.ToString() + "'";
            }
            //用于判断经办人是否选择
            if (comStaffName.Text != "")
            {
                strSql += "and out_storage.out_agent_name='" + comStaffName.SelectedValue.ToString() + "'";
            }
            //入库批次是否选择
            if (comBatch.Text != "")
            {
                strSql += "and out_storage.out_batch_id='" + comBatch.SelectedValue.ToString() + "'";
            }
            grid.ClearAll();
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
            uiPagination1.DataSource = bllout.GetModelList(strSql);
            grid.DataSource = bllout.GetModelList(strSql);
        }
        //重置
        private void uiButton1_Click(object sender, EventArgs e)
        {
            comBatch.Text = "";
            comMatName.Text = "";
            comStorage.Text = "";
            comStaffName.Text = "";
        }
        //加载物品名称
        private void comMatName_Load(object sender, EventArgs e)
        {
            //BLL.chest_type blltype = new BLL.chest_type();
            //DataSet ds = new DataSet();
            //ds = blltype.GetList(0);
            //int num = ds.Tables[0].Rows.Count;
            //for (int i = 0; i < num; i++)
            //{
            //    uiListBox1.Items.Add(ds.Tables[0].Rows[i][0]);
            //    //ds.Tables[0].Rows[i][0];  
            //}
            //DataSet ds= bllout.GetAllList();
            //comMatName.DataSource = ds;
            comMatName.DataSource = bllout.GetModelList("");
            comMatName.DisplayMember = "out_mat_name";
            comMatName.ValueMember = "out_mat_name";
            //DataSet ds=new DataSet ();
            //ds = bllout.GetList("out_mat_name", 0);
            //int num = ds.Tables[0].Rows.Count;
            //for (int i = 0; i < num; i++)
            //{
            //    comMatName.DisplayMember = ds.Tables[0].Rows[0][0].ToString();
            //    comMatName.ValueMember= ds.Tables[0].Rows[0][0].ToString();
            //}
        }
        //加载出库编号
        private void comStorage_Load(object sender, EventArgs e)
        {
            comStorage.DataSource = bllout.GetModelList("");
            comStorage.DisplayMember = "out_id";
            comStorage.ValueMember = "out_id";
        }
        //加载经办人
        private void comStaffName_Load(object sender, EventArgs e)
        {
            //List<Model.out_storage> outmodel = new 



            comStaffName.DataSource = bllout.GetModelList("");
            comStaffName.DisplayMember = "out_staff_name";
            comStaffName.ValueMember = "out_staff_name";
        }
        //加载批次编号
        private void comBatch_Load(object sender, EventArgs e)
        {
            comBatch.DataSource = bllout.GetModelList("");
            comBatch.DisplayMember = "out_batch_id";
            comBatch.ValueMember = "out_batch_id";
        }
    }
}
