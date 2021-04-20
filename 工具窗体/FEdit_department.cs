using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunny.UI;

namespace Warehouse.工具窗体
{
    public partial class FEdit_department : UIEditForm
    {
        private UILabel dep_name;
        private UILabel name;
        private UIComboBox uiComboBox1;
        private UITextBox name_box;

        
        public FEdit_department()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dep_name = new Sunny.UI.UILabel();
            this.name = new Sunny.UI.UILabel();
            this.name_box = new Sunny.UI.UITextBox();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 347);
            this.pnlBtm.Size = new System.Drawing.Size(526, 55);
            // 
            // dep_name
            // 
            this.dep_name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dep_name.Location = new System.Drawing.Point(59, 95);
            this.dep_name.Name = "dep_name";
            this.dep_name.Size = new System.Drawing.Size(100, 23);
            this.dep_name.TabIndex = 2;
            this.dep_name.Text = "部门名称";
            this.dep_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.name.Location = new System.Drawing.Point(54, 160);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(119, 23);
            this.name.TabIndex = 3;
            this.name.Text = "部门负责人";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name_box
            // 
            this.name_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_box.FillColor = System.Drawing.Color.White;
            this.name_box.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.name_box.Location = new System.Drawing.Point(232, 95);
            this.name_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_box.Maximum = 2147483647D;
            this.name_box.Minimum = -2147483648D;
            this.name_box.MinimumSize = new System.Drawing.Size(1, 1);
            this.name_box.Name = "name_box";
            this.name_box.Padding = new System.Windows.Forms.Padding(5);
            this.name_box.Size = new System.Drawing.Size(150, 34);
            this.name_box.TabIndex = 5;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboBox1.Location = new System.Drawing.Point(232, 160);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 34);
            this.uiComboBox1.TabIndex = 6;
            this.uiComboBox1.Text = "请选择部门管理人";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Load += new System.EventHandler(this.uiComboBox1_Load);
            // 
            // FEdit_department
            // 
            this.ClientSize = new System.Drawing.Size(528, 405);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dep_name);
            this.Name = "FEdit_department";
            this.Text = "FEdit_department";
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.dep_name, 0);
            this.Controls.SetChildIndex(this.name, 0);
            this.Controls.SetChildIndex(this.name_box, 0);
            this.Controls.SetChildIndex(this.uiComboBox1, 0);
            this.ResumeLayout(false);

        }

        //输入检查
        protected override bool CheckData()
        {
            return CheckEmpty(name_box,"请输入部门名称")&&
                CheckEmpty(uiComboBox1,"请选择部门主管");
        }

        private Model.department department;
        public Model.department Department
        {
            get
            {
                if(department == null)
                {
                    department = new Model.department();
                }

                department.dep_name = name_box.Text.Trim();

                //department.dep_principal_name =Convert.ToString( uiComboBox1.SelectedItem);
                //没找到属性无法使用的原因，暂时用这种方式替代
                string st = Convert.ToString(uiComboBox1.SelectedItem);
                string[] sArray = st.Split(',');
                department.dep_principal_name = sArray[0];

               
                BLL.staff sta = new BLL.staff();
                Model.staff staff =  sta.GetModel_Name(sArray[0].Trim());
                
                department.dep_principal_id = staff.staff_id.Trim();

                //查询数据表内数据行数
                BLL.department dep = new BLL.department();
                int amount = dep.Count_data("");

                //定义部门id
                department.dep_id = "D_" + (amount+1).ToString().Trim();


                return department;

            }
            set
            {

            }

        }
        
        //加载下拉框的内容
        private void uiComboBox1_Load(object sender, EventArgs e)
        {
            BLL.staff sta = new BLL.staff();
            uiComboBox1.DataSource = sta.GetModelList("");
            uiComboBox1.DisplayMember = "staff_name";
            uiComboBox1.ValueMember = "staff_id";

            BLL.department dep = new BLL.department();
            
           




        }


        public bool FuZhi(string id)
        {
            BLL.department sta = new BLL.department();
            department = sta.GetModel(id);
            if (department != null)
            {
                name_box.Text = department.dep_name;
                


                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
