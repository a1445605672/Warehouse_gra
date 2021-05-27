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
    public partial class FrmLimit1 : UIEditForm
    {
        public FrmLimit1()
        {
            InitializeComponent();
        }
        public string Getstr(string enter_num)
        {
            string str = "UPDATE in_storage SET mat_name ='"+ uiTextBox4.Text.Trim()+ "', minpo ="+ decimal.Parse(uiTextBox2.Text.Trim()) + ", maxpo ="+ decimal.Parse(uiTextBox1.Text.Trim()) + " WHERE enter_num='"+enter_num+"'";
            return str;
        }
        public Model.in_storage limitModel1;
        public Model.in_storage LimitModel1
        {
            get
            {
                //新增
                if (limitModel1 == null)
                {
                    limitModel1 = new Model.in_storage();
                    BLL.in_storage bllim = new BLL.in_storage();
                    limitModel1.mat_id = uiComboBox1.SelectedItem.ToString();
                    limitModel1.mat_name = uiTextBox4.Text;
                    limitModel1.maxpo = decimal.Parse(uiTextBox2.Text.Trim());
                    limitModel1.minpo = decimal.Parse(uiTextBox1.Text.Trim());
                    return limitModel1;
                }
                //更改
                else
                {
                    limitModel1.mat_id = uiComboBox1.SelectedItem.ToString();
                    limitModel1.mat_name = uiTextBox4.Text;
                    limitModel1.maxpo = decimal.Parse(uiTextBox2.Text.Trim());
                    limitModel1.minpo = decimal.Parse(uiTextBox1.Text.Trim());
                    return limitModel1;
                }
            }
            set
            {
            }
        }
        private void FrmLimit1_Load(object sender, EventArgs e)
        {

        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            uiTextBox4.Text = uiComboBox1.SelectedValue.ToString();
        }
        public bool FuZhi(string id)
        {


            BLL.in_storage bllim = new BLL.in_storage();
            limitModel1 = bllim.GetModelById(id);
            if (limitModel1 != null)
            {
                //这里需要
                //string sql = "mat_id='"+limitModel1.mat_id +"'";
                //BLL.Limit1 blltype = new BLL.Limit1();
                //uiComboBox1.DataSource = blltype.GetModelList(sql);
                //uiComboBox1.ValueMember = "mat_id";
                //uiComboBox1.DisplayMember = "mat_id";

                uiComboBox1.Items.Clear();
                uiComboBox1.Items.Add(id);
                uiTextBox4.Text = limitModel1.mat_name;
                uiTextBox1.Text = limitModel1.maxpo.ToString();
                uiTextBox2.Text = limitModel1.minpo.ToString();

                return true;
            }
            else
            {
                return false;
            }
        }
        private void uiComboBox1_Load(object sender, EventArgs e)
        {
            BLL.material_info bllinfo = new BLL.material_info();
            uiComboBox1.DataSource = bllinfo.GetModelList("");
            uiComboBox1.DisplayMember = "mat_id";
            uiComboBox1.ValueMember = "mat_name";
        }
    }
}
