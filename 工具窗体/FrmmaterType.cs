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
    public partial class FrmmaterType : UIEditForm
    {
        public FrmmaterType()
        {
            InitializeComponent();
        }
        public Model.material_type materTpyeModel;
        public Model.material_type MaterTypeModel
        {
            get
            {
                if (materTpyeModel == null)
                {
                    materTpyeModel = new Model.material_type();
                    materTpyeModel.type_id = uiTextBox1.Text.Trim();
                    materTpyeModel.type_name = uiTextBox2.Text.Trim();
                    materTpyeModel.type_comment = uiTextBox3.Text.Trim();
                    materTpyeModel.type_sx = uiTextBox4.Text.Trim();

                }
                return materTpyeModel;
            }
            set
            { 
            }
        }
    }
}
