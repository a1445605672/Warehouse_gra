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
                    //s1_id
                    storagelocationModel.sl_id = txtID.Text.Trim();
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
    }
}
