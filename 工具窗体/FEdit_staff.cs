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
    public partial class FEdit_staff : UIEditForm
    {
        public FEdit_staff()
        {
            InitializeComponent();
        }

        protected override bool CheckData()
        {
            return CheckEmpty(edtName, "请输入姓名") 
                && CheckRange(editAge,18,60, "输入年龄范围18~60")
                && CheckEmpty(cbDepartment, "请选择部门")
                && CheckEmpty(hire_date,"请选择入职时间");
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

                staff.staff_belong_dep_id = cbDepartment.Text;
                staff.staff_identity_card = idcard.Text;
                staff.staff_phone_number = phone.Text;
                staff.staff_hire_date = hire_date.Value;

                staff.staff_id = edtName.Text + phone.Text;
                

                return staff;
               
                

                
                

                 


                
            }
            set
            {
                staff = value;

                //edtName.Text = value.staff_name;
                //editAge.IntValue = (int)value.staff_age;





            }
        }
    }
}
