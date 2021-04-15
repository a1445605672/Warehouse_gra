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
using Model;
namespace Warehouse.工具窗体
{
    public partial class kuguitype : UIEditForm
    {
        public kuguitype()
        {
            InitializeComponent();
        }
        public Model.chest_type chest_typeModel;
        public Model.chest_type Chest_typeModel
        {
            get
            {
                if (chest_typeModel == null)
                {
                    chest_typeModel = new Model.chest_type();
                    chest_typeModel.type_id = typeID.Text.Trim();
                    chest_typeModel.type_length = length.IntValue;
                    chest_typeModel.type_wide = wide.IntValue;
                    chest_typeModel.type_high = high.IntValue;
                    chest_typeModel.type_sx = beizhu.Text.Trim();
                }
                return chest_typeModel;
            }
            set
            {
                
            }
        }
        //编辑时为文本框赋值
        public bool FuZhi(string id)
        {
            BLL.chest_type sta = new BLL.chest_type();
            chest_typeModel = sta.GetModel(id);
            if (chest_typeModel != null)
            {
                typeID.Text = chest_typeModel.type_id;
                length.Text = chest_typeModel.type_length.ToString();
                high.Text = chest_typeModel.type_high.ToString();
                wide.Text = chest_typeModel.type_wide.ToString();
                beizhu.Text = chest_typeModel.type_sx;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
