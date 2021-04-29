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
            BLL.material_type blltype = new BLL.material_type();
            //uiRichTextBox1.Text=blltype.GetType
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
                    return materialModel;
                }
                else
                {
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
                    return materialModel;
                }
            }
            set
            {

            }
        }
        //在ListBox中添加值
        private void uiListBox1_Load(object sender, EventArgs e)
        {
            BLL.material_type blltype = new BLL.material_type();
            DataSet ds = new DataSet();
            ds=blltype.GetList("1=1");
            int num = ds.Tables[0].Rows.Count;
            for (int i = 0; i < num; i++)
            {
                uiListBox1.Items.Add(ds.Tables[0].Rows[i][1]);
                //ds.Tables[0].Rows[i][0];  
            }
            //uiListBox1.DataSource = ds.Tables[0].DefaultView;
        }
        //物料状态
        private void comboxState_Load(object sender, EventArgs e)
        {
            comboxState.Items.Add("固态");
            comboxState.Items.Add("液态");
            comboxState.Items.Add("固液混合态");
        }
        //物料颜色
        private void comColor1_Load(object sender, EventArgs e)
        {
            //红，橙，黄，绿，青，蓝，紫，灰，粉，黑，白，棕
            comColor1.Items.Add("红");
            comColor1.Items.Add("橙");
            comColor1.Items.Add("黄");
            comColor1.Items.Add("绿");
            comColor1.Items.Add("青");
            comColor1.Items.Add("蓝");
            comColor1.Items.Add("紫");
            comColor1.Items.Add("灰");
            comColor1.Items.Add("粉");
            comColor1.Items.Add("黑");
            comColor1.Items.Add("白");
            comColor1.Items.Add("棕");
        }
        //物料气味
        private void comSmell_Load(object sender, EventArgs e)
        {
            //芬芳味 薄荷味 甜味 柠檬味 苦味 咸味
            comSmell.Items.Add("芬芳味");
            comSmell.Items.Add("薄荷味");
            comSmell.Items.Add("甜味");
            comSmell.Items.Add("柠檬味");
            comSmell.Items.Add("苦味");
            comSmell.Items.Add("咸味");
        }
        //酸碱度
        private void comsuan_Load(object sender, EventArgs e)
        {
            comsuan.Items.Add("强酸性");
            comsuan.Items.Add("弱酸性");
            comsuan.Items.Add("中性");
            comsuan.Items.Add("强碱性");
            comsuan.Items.Add("弱碱性");
        }
        //获取类型
        private void uiButton1_Click(object sender, EventArgs e)
        {
            //拿到类型信息，即物料名称
            txtInfo.Text = uiListBox1.SelectedItem.ToString();
            BLL.material_type bllinfo = new BLL.material_type();
            //生成物料编号
            DataSet ds = new DataSet();
            ds = bllinfo.GetList("type_name='"+txtInfo.Text+"'");
            string bianhao = Convert.ToString(ds.Tables[0].Rows[0][0]);
            //根据物料编号+num
            BLL.material_info bllin = new BLL.material_info();
            int num = bllin.GetRecordCount("1=1");
            num++;
            txtID.Text = bianhao + "Mat" + num;
        }
        public bool FuZhi(string id)
        {
            BLL.material_info bllinfo = new BLL.material_info();
            materialModel = bllinfo.GetModel(id);
            if (materialModel != null)
            {
                txtID.Text = materialModel.mat_id;
                txtInfo.Text = materialModel.mat_type;
                txtName.Text = materialModel.mat_name;
                txtFengdu.Text = Convert.ToString(materialModel.mat_fengdu);
                comboxState.SelectedItem = materialModel.mat_state;
                comColor1.SelectedItem = materialModel.mat_colour;
                comSmell.SelectedItem = materialModel.mat_smell;
                txtUseFor.Text = materialModel.mat_purpose;
                txtSource.Text = materialModel.mat_source;
                comsuan.SelectedItem = materialModel.mat_suanjianxing;
                txtPercent1.Text = materialModel.mat_yuansuzhanbi;
                txtRich.Text = materialModel.mat_yuansuzhanbi;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
