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
using MySql;
using System.Text.RegularExpressions;

namespace Warehouse.工具窗体
{
    public partial class FEdit_staff : UIEditForm
    {
        public FEdit_staff()
        {

           
           

            InitializeComponent();

            hire_date.Text = DateTime.Now.ToString();

            if (!Warehouse.用户管理.Mode)
            {
                this.uiComboTreeView1.Text = Warehouse.用户管理.Sta_sx;
               // this.uiComboTreeView1.SelectedNode.Name = Warehouse.用户管理.Sta_sx;
            }

            

            this.cbDepartment.Items.Clear();
            Get_dep_info();
        }

        //输入检查
        protected override bool CheckData()
        {
           
            

            return CheckEmpty(edtName, "请输入姓名") 
                && CheckRange(editAge,18,60, "输入年龄范围18~60")
                && CheckEmpty(cbDepartment, "请选择部门")
                && CheckEmpty(hire_date,"请选择入职时间")
               ;
        }

        //编辑时为编辑框赋值
        public bool FuZhi(string id)
        {
            BLL.staff sta = new BLL.staff();
            staff = sta.GetModel(id);
            if(staff != null)
            {
                edtName.Text = staff.staff_name;
                editAge.Text = staff.staff_age.ToString();
                if(staff.staff_sex == "男")
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }

                Model.department dep = new Model.department();
                BLL.department depa = new BLL.department();
                dep = depa.GetModel(staff.staff_belong_dep_id.Trim());
                cbDepartment.Text = dep.dep_name;
                phone.Text = staff.staff_phone_number;
                idcard.Text = staff.staff_identity_card.Trim();
                hire_date.Value =(DateTime)staff.staff_hire_date;



                return true;
            }
            else
            {
                return false;
            }
        }

        public void Get_dep_info()
        {
            BLL.department dep = new BLL.department();
            List<Model.department> dep_list = dep.GetModelList("");
            int length = dep_list.Count;

            for (int i = 0; i < length; i++)
            {
                //TreeNode tree = new TreeNode();
                //tree.Name = dep_list[i].dep_id.ToString();
                //tree.Text = dep_list[i].dep_name.ToString();
                this.cbDepartment.Items.Add(dep_list[i].dep_name.ToString());
            }
        }

        private Model.staff staff;

        public Model.staff Staff
        {
            get
            {
                if(staff == null)
                {
                    staff = new Model.staff();
                }

                staff.staff_name = edtName.Text;
                staff.staff_age = editAge.IntValue;
                if (rbMale.Checked)
                {
                    staff.staff_sex = "男";
                }
                if (rbFemale.Checked)
                {
                    staff.staff_sex = "女";
                }

                //查询部门信息
                Model.department depz = new Model.department();
                BLL.department dep = new BLL.department();
                string m;
                if(cbDepartment.SelectedText.Trim() == "")
                {
                    m = Warehouse.用户管理.dep_id.Trim();
                    staff.staff_belong_dep_id = m;
                    Warehouse.用户管理.dep_id = null;
                }
                else
                {
                    m = cbDepartment.SelectedText.Trim();
                    depz = dep.GetModel_Name(m);

                    staff.staff_belong_dep_id = depz.dep_id;

                }
               
               
                staff.staff_identity_card = idcard.Text;
                staff.staff_phone_number = phone.Text;
                staff.staff_hire_date = hire_date.Value;

                //自定义用户id的命名方式
                staff.staff_id = edtName.Text + phone.Text;

                staff.staff_sx = uiComboTreeView1.SelectedNode.Name;
               
                return staff;
               
                

                
                

                 


                
            }
            set
            {
                staff = value;
                edtName.Text = value.staff_name;
               
                





            }
        }


        
        //
        public void InitValue(string staff_id)
        {
            //idField.Enabled = false; // 学号不可编辑
            Model.staff sta = new Model.staff();
            BLL.staff bsta = new BLL.staff();
            sta = bsta.GetModel(staff_id);

            cbDepartment.Enabled = false;
            edtName.Text = sta.staff_name;
            editAge.Text = sta.staff_age.ToString() ;
            if(sta.staff_sex == "男")
            {
                rbMale.TabIndex = 1;
            }
            else
            {
                rbFemale.TabIndex = 0;
            }

            

            //idField.Text = stu.Id + "";
            //nameField.Text = stu.Name;
            //sexField.SelectedIndex = stu.Sex ? 1 : 0;
            //phoneField.Text = stu.Phone;
        }

        private void idcard_Validated(object sender, EventArgs e)
        {
            if ((!Regex.IsMatch(this.idcard.Text, @"^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$", RegexOptions.IgnoreCase)))
            {
                UIMessageBox.ShowError("身份证位数不符合规范");

            }
            else
            {
                if (!Warehouse.表单验证.formAuthentication.CheckIDCard18(this.idcard.Text))
                {
                    UIMessageBox.ShowWarning("身份证号不符合规范");
                }
            }
        }
    }
}
