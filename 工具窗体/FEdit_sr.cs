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

namespace Warehouse.工具窗体
{
    public partial class FEdit_sr : UIEditForm
    {

        public string Resp_name;

        public FEdit_sr()
        {
            InitializeComponent();

            uiRadioButton1.Checked = true;



            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点3");
        
            treeNode1.Name = "D_1";
            treeNode1.Text = "仓储部";
            treeNode2.Name = "D_2";
            treeNode2.Text = "供收货部";
            treeNode3.Name = "D_4";
            treeNode3.Text = "供部";

            this.uiComboTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[]
            {
                treeNode1,
                treeNode2,
                treeNode3
            });
        }

        protected override bool CheckData()
        {
            return CheckEmpty(uiTextBox4,"名称不能为空")
               
                && CheckEmpty(uiTextBox2,"联系人姓名不能为空")
                && CheckEmpty(uiTextBox5,"号码格式不符合规范")
                && CheckEmpty(uiTextBox3,"联系地址不能为空");
        }

        public bool FuZhi(string id)
        {
            BLL.sr_info sr = new BLL.sr_info();
            sr_Info = sr.GetModel(id);
            if(sr_Info != null)
            {
                uiTextBox4.Text = sr_Info.sr_name;
                uiRadioButton1.Checked = false;
                uiRadioButton2.Checked = false;
                if (sr_Info.sr_type.Trim() == "收货商")
                {
                    uiRadioButton2.Checked = true;
                }
                else
                {
                    uiRadioButton1.Checked = true;
                }

               // uiTextBox1.Text = sr_Info.sr_resp_name;

                uiComboTreeView2.Text = sr_Info.sr_resp_name;
                uiComboTreeView1.Enabled = false;
               
                uiTextBox2.Text = sr_Info.sr_contact_name;
                uiTextBox5.Text = sr_Info.sr_contact_phone;
                uiTextBox3.Text = sr_Info.sr_place;

                return true;
            }
            else
            {
                return false;
            }

           
        }

        public string GetPYString(string str)

        {

            string tempStr = "";

            foreach (char c in str)

            {

                if ((int)c >= 33 && (int)c <= 126)

                {//字母和符号原样保留

                    tempStr += c.ToString();

                }

                else

                {//累加拼音声母

                    tempStr += GetPYChar(c.ToString());

                }

            }

            return tempStr;

        }

        ///</summary>

        ///<param name="c">要转换的单个汉字</param>

        ///<returns>拼音声母</returns>

        public string GetPYChar(string c)

        {

            byte[] array = new byte[2];

            array = System.Text.Encoding.Default.GetBytes(c);

            int i = (short)(array[0] - '\0') * 256 + ((short)(array[1] - '\0'));

            if (i < 0xB0A1) return "*";

            if (i < 0xB0C5) return "a";

            if (i < 0xB2C1) return "b";

            if (i < 0xB4EE) return "c";

            if (i < 0xB6EA) return "d";

            if (i < 0xB7A2) return "e";

            if (i < 0xB8C1) return "f";

            if (i < 0xB9FE) return "g";

            if (i < 0xBBF7) return "h";

            if (i < 0xBFA6) return "g";

            if (i < 0xC0AC) return "k";

            if (i < 0xC2E8) return "l";

            if (i < 0xC4C3) return "m";

            if (i < 0xC5B6) return "n";

            if (i < 0xC5BE) return "o";

            if (i < 0xC6DA) return "p";

            if (i < 0xC8BB) return "q";

            if (i < 0xC8F6) return "r";

            if (i < 0xCBFA) return "s";

            if (i < 0xCDDA) return "t";

            if (i < 0xCEF4) return "w";

            if (i < 0xD1B9) return "x";

            if (i < 0xD4D1) return "y";

            if (i < 0xD7FA) return "z";

            return "*";

        }

        public Model.sr_info sr_Info;

        public Model.sr_info Sr_Info
        {
            get
            {
                if(sr_Info == null)
                {
                    sr_Info = new Model.sr_info();

                    sr_Info.sr_name = uiTextBox4.Text.Trim();

                    if (uiRadioButton2.Checked == true)
                    {
                        sr_Info.sr_type = "收货商";
                    }
                    else
                    {
                        sr_Info.sr_type = "供货商";
                    }

                    sr_Info.sr_id = GetPYString(uiTextBox3.Text.Trim()) + "_" + GetPYString(uiTextBox2.Text.Trim());

                    sr_Info.sr_resp_name = uiComboTreeView2.SelectedNode.Text.ToString(); ;
                    sr_Info.sr_resp_id = uiComboTreeView2.SelectedNode.Name.ToString();


                   
                   
                        
                    sr_Info.sr_contact_name = uiTextBox2.Text.Trim();
                    sr_Info.sr_contact_phone = uiTextBox5.Text.Trim();
                    sr_Info.sr_place = uiTextBox3.Text.Trim();
                    sr_Info.sr_update_time = DateTime.Now;


                    return sr_Info;

                }

                else
                {
                    sr_Info.sr_name = uiTextBox4.Text.Trim();

                    if (uiRadioButton2.Checked == true)
                    {
                        sr_Info.sr_type = "收货商";
                    }
                    else
                    {
                        sr_Info.sr_type = "供货商";
                    }
                    sr_Info.sr_resp_name = uiComboTreeView2.SelectedNode.Text.Trim();
                    sr_Info.sr_contact_name = uiTextBox2.Text.Trim();
                    sr_Info.sr_contact_phone = uiTextBox5.Text.Trim();
                    sr_Info.sr_place = uiTextBox3.Text.Trim();



                    return sr_Info;
                }

               
                
            }
            set
            {

            }
        }

        public List<Model.staff> staffs;
        private void uiComboTreeView1_NodeSelected(object sender, TreeNode node)
        {
            string name = node.Text;
            string dep_id = node.Name;
            BLL.staff sta = new BLL.staff();

            string Cha_xun = "staff_belong_dep_id = " + "\"" + dep_id.Trim() + "\"";
           
            staffs =  sta.GetModelList(Cha_xun);
            int m = staffs.Count;
           for(int i = 0 ; i < m; i++)
            {
                //string treenode = i + "hah";
                TreeNode treenode = new TreeNode("");

                treenode.Name = staffs[i].staff_id;
                treenode.Text = staffs[i].staff_name;

                this.uiComboTreeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[]
           {
                treenode
           });

            }
        }

        private void uiComboTreeView2_NodeSelected(object sender, TreeNode node)
        {
            if(uiComboTreeView1.SelectedNode == null)
            {
                UIMessageBox.ShowInfo("必须先选择所属部门");
            }
            else
            {
                uiComboTreeView2.SelectedNode = node;

                if(uiComboTreeView2.CheckBoxes == IsOK)
                {
                    UIMessageBox.Show(node.Text);
                }
                else
                {
                    UIMessageBox.ShowInfo("hah");
                }
            }
        }
    }
}
