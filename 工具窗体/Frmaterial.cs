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
    public partial class Frmaterial : UIEditForm
    {
        public Frmaterial()
        {
            InitializeComponent();
        }
        public Model.material_info materialModel;
        public Model.material_info MaterialModel
        {
            get
            {
                if (materialModel == null)
                {
                    materialModel = new Model.material_info();
                    materialModel.mat_id = txtID.Text.Trim();
                    materialModel.mat_type = txtInfo.Text.Trim();
                    materialModel.mat_name = txtName.Text.Trim();
                    materialModel.mat_fengdu = txtFengdu.IntValue;
                    materialModel.mat_state = comboxState.SelectedText.Trim();
                    materialModel.mat_colour = comSmell.SelectedText.Trim();
                    materialModel.mat_smell = comSmell.SelectedText.Trim();
                    materialModel.mat_purpose = txtUseFor.Text.Trim();
                    materialModel.mat_source = txtSource.Text.Trim();
                    materialModel.mat_suanjianxing = comsuan.SelectedText.Trim();
                    materialModel.mat_yuansuzhanbi = txtPercent1.Text.Trim();
                    materialModel.mat_yuansuzhanbi = txtRich.Text.Trim();
                }
                return materialModel;
            }
            set
            {
                
            }
        }
    }
}
