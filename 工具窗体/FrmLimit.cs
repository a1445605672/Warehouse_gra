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
    public partial class FrmLimit : UIEditForm
    {
        public FrmLimit()
        {
            InitializeComponent();
        }
        
        //下拉框的加载
        private void uiComboBox1_Load(object sender, EventArgs e)
        {
            BLL.material_info bllinfo = new BLL.material_info();
            uiComboBox1.DataSource = bllinfo.GetModelList("");
            uiComboBox1.DisplayMember = "mat_id";
            uiComboBox1.ValueMember = "mat_name";
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //物料名称时uiTextBox4
            uiTextBox4.Text = uiComboBox1.SelectedValue.ToString();
        }
    }
}
