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
    //public partial class StaffEdit : UIEditForm
    //{
    //    public StaffEdit()
    //    {
    //        InitializeComponent();
    //    }

    //    protected override bool CheckData()
    //    {
    //        return CheckEmpty(edtName, "请输入姓名")
    //               && CheckEmpty(edtAge, "请输入年龄")
    //               && CheckRange(edtAge, 18, 60, "输入年龄范围18~60")
    //               && CheckEmpty(cbDepartment, "请选择部门")
    //               && CheckEmpty(edtDate, "请选择生日");
    //    }

    //    private Model.staff sta;

    //    public Model.staff sta
    //    {
    //        get
    //        {
    //            if (sta == null)
    //            {
    //                sta = new Person();
    //            }

    //            person.Name = edtName.Text;
    //            person.Age = edtAge.IntValue;
    //            person.Birthday = edtDate.Value;
    //            person.Address = edtAddress.Text;
    //            if (rbMale.Checked)
    //                person.Sex = Sex.Male;
    //            if (rbFemale.Checked)
    //                person.Sex = Sex.Female;
    //            person.Department = cbDepartment.Text;
    //            return person;
    //        }

    //        set
    //        {
    //            person = value;
    //            edtName.Text = value.Name;
    //            edtAge.IntValue = value.Age;
    //            edtDate.Value = value.Birthday;
    //            edtAddress.Text = value.Address;
    //            cbDepartment.SelectedIndex = cbDepartment.Items.IndexOf(value.Department);
    //            rbMale.Checked = value.Sex == Sex.Male;
    //            rbFemale.Checked = value.Sex == Sex.Female;
    //        }
    //    }

    //    public class Person
    //    {
    //        public string Name { get; set; }

    //        public int Age { get; set; }

    //        public Sex Sex { get; set; }

    //        public string Department { get; set; }

    //        public DateTime Birthday { get; set; }

    //        public string Address { get; set; }

    //        public override string ToString()
    //        {
    //            return Name + ", " + Age + ", " + Department;
    //        }
    //    }
    //}
}
