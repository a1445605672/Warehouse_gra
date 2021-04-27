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
    public partial class FrmEditInstorage : UIEditForm
    {
        public FrmEditInstorage()
        {
            InitializeComponent();
        }
        public Model.in_storage in_storage;
        public Model.in_storage In_storage
        {
            get
            {
                if (in_storage == null)
                {
                    in_storage = new Model.in_storage();
                    in_storage.enter_num = txtInNum.Text.Trim();
                    in_storage.mat_id = txtMatId.Text.Trim();
                    in_storage.mat_name = txtMatName.Text.Trim();
                    in_storage.sl_id = txtChestNum.Text.Trim();
                    in_storage.in_time = Convert.ToDateTime(txtIntime1.Text.Trim());
                    in_storage.in_amount = txtNum.IntValue;
                    in_storage.in_weight = txtWeight.IntValue;
                    in_storage.in_volume = txtVolu.IntValue;
                    return in_storage;
                }
                else
                {
                    return in_storage;
                }
            }
            set
            {

            }
        }
        public bool FuZhi(string id)
        {
            BLL.in_storage bllin = new BLL.in_storage();
            in_storage = bllin.GetModelById(id);
            if (in_storage != null)
            {
                txtInNum.Text = in_storage.enter_num;
                txtMatId.Text = in_storage.mat_id;
                txtMatName.Text = in_storage.mat_name;
                txtChestNum.Text = in_storage.sl_id;
                txtIntime1.Text = Convert.ToString(in_storage.in_time);
                txtNum.Text = Convert.ToString(in_storage.in_amount);
                txtVolu.Text = Convert.ToString(in_storage.in_volume);
                txtWeight.Text = Convert.ToString(in_storage.in_weight);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

