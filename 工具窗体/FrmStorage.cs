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
                    storagelocationModel.sl_id = txtID.Text.Trim();
                    storagelocationModel.sl_store_type_id = uiComboBox1.SelectedText;
                    storagelocationModel.sl_belong_chest = txtBelongto.Text.Trim();
                    storagelocationModel.sl_comment = txtComment1.Text.Trim();
                    storagelocationModel.sl_remain_bulk = txtLeftVo.IntValue;
                    storagelocationModel.sl_store_area = txtArea.IntValue;
                    storagelocationModel.sl_store_max = txtMax.IntValue;
                    storagelocationModel.sl_store_min = txtMin.IntValue;


                }
                return storagelocationModel;
            }
        }
        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
