using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace Warehouse
{
    public partial class 部门人员管理 : UIPage
    {

        BLL.material_type material_Type = new BLL.material_type();
        BLL.material_info material_Info = new BLL.material_info();
        BLL.sr_info sr_Info = new BLL.sr_info();
        BLL.staff staff = new BLL.staff();
        BLL.chest chest = new BLL.chest();

        List<Model.material_type> Material_Type = new List<Model.material_type>();

        List<Model.material_info> material_Infos = new List<Model.material_info>();

        List<Model.sr_info> sr_Infos = new List<Model.sr_info>();

        List<Model.staff> staffs = new List<Model.staff>();

       public 部门人员管理()
        {
            InitializeComponent();

            int count = this.uiGroupBox1.Controls.Count;
            for (int i = 0; i < count; i++)
            {
                this.uiGroupBox1.Controls[i].Enabled = false;
            }
       

            int count1 = this.uiGroupBox2.Controls.Count;
            for (int i = 0; i < count; i++)
            {
                this.uiGroupBox2.Controls[i].Enabled = false;
            }

            Load_material_Type();
            Load_sr_Name();
            Load_Staff_Name();
       }


        private void Load_chest_info()
        {

        }

        /// <summary>
        /// 加载物品类型的下拉信息
        /// </summary>
        private void Load_material_Type()
        {
            this.uiComboTreeView1.Enabled = true;
            this.uiComboTreeView1.Nodes.Clear();
            Material_Type = material_Type.GetModelList("");

            for(int i = 0; i< Material_Type.Count; i++)
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Name = Material_Type[i].type_id.ToString();
                treeNode.Text = Material_Type[i].type_name.ToString();
                this.uiComboTreeView1.Nodes.Add(treeNode);
            }
        }

        private void Load_sr_Name()
        {
            this.uiComboTreeView3.Nodes.Clear();
            sr_Infos = sr_Info.GetModelList("");

            for(int i=0; i<sr_Infos.Count; i++)
            {
                TreeNode tree = new TreeNode();
                tree.Name = sr_Infos[i].sr_id.ToString();
                tree.Text = sr_Infos[i].sr_name.ToString();
                this.uiComboTreeView3.Nodes.Add(tree);
            }
        }

        private void Load_Staff_Name()
        {
            this.uiComboTreeView4.Nodes.Clear();
            staffs = staff.GetModelList("");

            for (int i = 0; i < sr_Infos.Count; i++)
            {
                TreeNode tree = new TreeNode();
                tree.Name = staffs[i].staff_id.ToString();
                tree.Text = staffs[i].staff_name.ToString();
                this.uiComboTreeView4.Nodes.Add(tree);
            }
        }


        private void uiComboTreeView1_NodeSelected(object sender, TreeNode node)
        {

            string id = node.Name;
            string Cha_xun = "mat_type_id = " + "\"" + id.Trim() + "\"";
            material_Infos = material_Info.GetModelList(Cha_xun);
            this.uiComboTreeView2.Nodes.Clear();
            for(int i = 0; i< material_Infos.Count; i++)
            {
                TreeNode treenode = new TreeNode();

                treenode.Name = material_Infos[i].mat_id;
                treenode.Text = material_Infos[i].mat_name;
                this.uiComboTreeView2.Nodes.Add(treenode);
            }
            this.uiComboTreeView2.Enabled = true;
            this.uiTextBox4.Enabled = true;
        }

        private void uiComboTreeView2_NodeSelected(object sender, TreeNode node)
        {
            this.uiComboTreeView3.Enabled = true;
            this.uiComboTreeView4.Enabled = true;

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            //判断数量是否合规
            
        }

        private void uiTextBox4_Validated(object sender, EventArgs e)
        {
            if(uiTextBox4.Text == null)
            {
                UIMessageBox.ShowWarning("采购数量不能为空");
                uiButton1.Enabled = false;
            }
            else
            {
                uiButton1.Enabled = true;
                uiButton2.Enabled = true;
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
           
           
        }
    }
}
