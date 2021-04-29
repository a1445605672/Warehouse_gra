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

namespace Warehouse.工具窗体
{
    public partial class FrmStorage : UIEditForm
    {
        public FrmStorage()
        {
            InitializeComponent();
        }
        public Model.storagelocation storagelocationModel;
        public Model.storagelocation StoragelocationModel
        {
            get
            {
                if (storagelocationModel == null)
                {
                    storagelocationModel = new Model.storagelocation();
                    //s1_id，系统生成
                    //生成规则: chestID+库位typeID+num
                    //查询chestID
                    BLL.chest blltype = new BLL.chest();
                    DataSet ds = new DataSet();
                    ds = blltype.GetList(0);
                    string num = Convert.ToString(ds.Tables[0].Rows[0][0]);
                    //找到typeID
                    string typeID = uiComboBox1.SelectedValue.ToString();
                    //找到num
                    BLL.storagelocation bllsta = new BLL.storagelocation();
                    int num1=bllsta.GetRecordCount("1=1");
                    num1++;
                    storagelocationModel.sl_id = num + typeID + num1;
                    //storagelocationModel.sl_id = txtID.Text.Trim();
                    //库位类型
                    storagelocationModel.sl_store_type_id = uiComboBox1.SelectedText;
                    //所属库柜
                    storagelocationModel.sl_belong_chest = txtBelongto.Text.Trim();
                    //备注
                    storagelocationModel.sl_comment = txtComment1.Text.Trim();
                    //剩余量
                    storagelocationModel.sl_remain_bulk = txtLeftVo.IntValue;
                    //库存放量
                    storagelocationModel.sl_store_area = txtArea.IntValue;
                    //库位上限
                    storagelocationModel.sl_store_max = txtMax.IntValue;
                    //库位下限
                    storagelocationModel.sl_store_min = txtMin.IntValue;

                    return storagelocationModel;
                }
                else
                {
                    return storagelocationModel;
                }
            }
        }
        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void uiListBox1_Load(object sender, EventArgs e)
        {
            BLL.chest blltype = new BLL.chest();
            DataSet ds = new DataSet();
            ds = blltype.GetList(0);
            int num = ds.Tables[0].Rows.Count;
            for (int i = 0; i < num; i++)
            {
                uiListBox1.Items.Add(ds.Tables[0].Rows[i][0]);
                //ds.Tables[0].Rows[i][0];  
            }
        }
        //选择库柜
        private void uiButton1_Click(object sender, EventArgs e)
        {
            txtBelongto.Text = uiListBox1.SelectedItem.ToString();
        }
        //库位类型的加载
        private void uiComboBox1_Load(object sender, EventArgs e)
        {
            BLL.storagelocation_type blltype = new BLL.storagelocation_type();
            uiComboBox1.DataSource = blltype.GetModelList("");
            uiComboBox1.ValueMember = "type_id";
            uiComboBox1.DisplayMember = "type_id";
        }
        //编辑时为文本框赋值
        public bool FuZhi(string id)
        {
            BLL.storagelocation sta = new BLL.storagelocation();
            storagelocationModel = sta.GetModel(id);
            if (storagelocationModel!=null)
            {
                //storagelocationModel.sl_id = num + typeID + num1;
                txtID.Text = storagelocationModel.sl_id;
                //库位类型
                uiComboBox1.SelectedValue = storagelocationModel.sl_store_type_id;
                //所属库柜
                txtBelongto.Text = storagelocationModel.sl_belong_chest;
                //备注
                txtComment1.Text = storagelocationModel.sl_comment;
                //剩余量
                txtLeftVo.Text =Convert.ToString(storagelocationModel.sl_remain_bulk);
                //库存放量
                txtArea.Text = Convert.ToString(storagelocationModel.sl_store_area);
                //库位上限
                txtMax.Text = Convert.ToString(storagelocationModel.sl_store_max);
                //库位下限
                txtMin.Text = Convert.ToString(storagelocationModel.sl_store_min);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
