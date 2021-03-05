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
    public partial class 用户管理 : UIForm
    {
        public 用户管理()
        {
            InitializeComponent();

            uiDataGridView1.AddColumn("员工id", "staff_id");
            uiDataGridView1.AddColumn("员工名", "staff_name");
            uiDataGridView1.AddColumn("性别", "staff_sex");
            uiDataGridView1.AddColumn("身份证号", "staff_identity_card");
            uiDataGridView1.AddColumn("手机号", "staff_phone_number");
            uiDataGridView1.AddColumn("年龄", "staff_age");
            uiDataGridView1.AddColumn("入职时间", "staff_hire_date");
            uiDataGridView1.AddColumn("所属部门", "staff_belong_dep_id");
            uiDataGridView1.AddColumn("缩写","staff_sx");

            //自适应列距离
            for (int i = 0; i < uiDataGridView1.ColumnCount; i++) { uiDataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; }

            AddRow();
        }


        // 为gridview填充值
        private void AddRow()
        {
            
            BLL.staff bsta = new BLL.staff();
            
            this.uiDataGridView1.DataSource = bsta.GetModelList(""); 
           
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            //UIEditOption option = new UIEditOption();
            //option.AutoLabelWidth = true;
            //option.Text = "增加";
            //option.AddText("Name", "姓名", "", true);
            //option.AddInteger("Age", "年龄", 20);
            //option.AddDate("staff_hire_date", "入职时间", DateTime.Now);
            //option.AddText("staff_sex", "性别", "", true);
            //option.AddText("staff_identity_card", "身份证号", "", true);




            //UIEditForm frm = new UIEditForm(option);
            //frm.ShowDialog();

            //if (frm.IsOK)


            //    Console.WriteLine("姓名: " + frm["Name"]);
            //Console.WriteLine("年龄: " + frm["Age"]);
            //Console.WriteLine("生日: " + frm["Birthday"]);
        }

     

        
    }
}
