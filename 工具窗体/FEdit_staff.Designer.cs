
namespace Warehouse.工具窗体
{
    partial class FEdit_staff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("系统管理员");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("部门管理员");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("操作员");
            this.edtName = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.editAge = new Sunny.UI.UITextBox();
            this.rbMale = new Sunny.UI.UIRadioButton();
            this.rbFemale = new Sunny.UI.UIRadioButton();
            this.cbDepartment = new Sunny.UI.UIComboBox();
            this.phone = new Sunny.UI.UITextBox();
            this.idcard = new Sunny.UI.UITextBox();
            this.hire_date = new Sunny.UI.UIDatePicker();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiComboTreeView1 = new Sunny.UI.UIComboTreeView();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 498);
            this.pnlBtm.Size = new System.Drawing.Size(526, 55);
            // 
            // edtName
            // 
            this.edtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtName.FillColor = System.Drawing.Color.White;
            this.edtName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.edtName.Location = new System.Drawing.Point(194, 67);
            this.edtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtName.Maximum = 2147483647D;
            this.edtName.Minimum = -2147483648D;
            this.edtName.MinimumSize = new System.Drawing.Size(1, 1);
            this.edtName.Name = "edtName";
            this.edtName.Padding = new System.Windows.Forms.Padding(5);
            this.edtName.Size = new System.Drawing.Size(150, 39);
            this.edtName.TabIndex = 2;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(49, 78);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = " 姓名";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(49, 121);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = " 年龄";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(49, 174);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = " 性别";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(49, 335);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = " 身份证";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(49, 276);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 23);
            this.uiLabel5.TabIndex = 3;
            this.uiLabel5.Text = " 手机号";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(49, 231);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 23);
            this.uiLabel6.TabIndex = 3;
            this.uiLabel6.Text = " 部门";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(49, 394);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(100, 23);
            this.uiLabel7.TabIndex = 3;
            this.uiLabel7.Text = " 入职时间";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editAge
            // 
            this.editAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editAge.FillColor = System.Drawing.Color.White;
            this.editAge.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.editAge.Location = new System.Drawing.Point(194, 109);
            this.editAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editAge.Maximum = 2147483647D;
            this.editAge.Minimum = -2147483648D;
            this.editAge.MinimumSize = new System.Drawing.Size(1, 1);
            this.editAge.Name = "editAge";
            this.editAge.Padding = new System.Windows.Forms.Padding(5);
            this.editAge.Size = new System.Drawing.Size(150, 39);
            this.editAge.TabIndex = 4;
            this.editAge.Text = " ";
            // 
            // rbMale
            // 
            this.rbMale.Checked = true;
            this.rbMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMale.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rbMale.Location = new System.Drawing.Point(194, 167);
            this.rbMale.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbMale.Name = "rbMale";
            this.rbMale.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbMale.Size = new System.Drawing.Size(52, 29);
            this.rbMale.TabIndex = 1;
            this.rbMale.Text = " 男";
            // 
            // rbFemale
            // 
            this.rbFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFemale.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rbFemale.Location = new System.Drawing.Point(263, 167);
            this.rbFemale.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbFemale.Size = new System.Drawing.Size(52, 29);
            this.rbFemale.TabIndex = 2;
            this.rbFemale.Text = " 女";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FillColor = System.Drawing.Color.White;
            this.cbDepartment.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbDepartment.Location = new System.Drawing.Point(194, 219);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDepartment.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbDepartment.Size = new System.Drawing.Size(150, 39);
            this.cbDepartment.TabIndex = 5;
            this.cbDepartment.Text = " ";
            this.cbDepartment.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phone
            // 
            this.phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone.FillColor = System.Drawing.Color.White;
            this.phone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.phone.Location = new System.Drawing.Point(194, 264);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone.Maximum = 2147483647D;
            this.phone.Minimum = -2147483648D;
            this.phone.MinimumSize = new System.Drawing.Size(1, 1);
            this.phone.Name = "phone";
            this.phone.Padding = new System.Windows.Forms.Padding(5);
            this.phone.Size = new System.Drawing.Size(214, 39);
            this.phone.TabIndex = 6;
            // 
            // idcard
            // 
            this.idcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idcard.FillColor = System.Drawing.Color.White;
            this.idcard.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.idcard.Location = new System.Drawing.Point(194, 323);
            this.idcard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idcard.Maximum = 2147483647D;
            this.idcard.Minimum = -2147483648D;
            this.idcard.MinimumSize = new System.Drawing.Size(1, 1);
            this.idcard.Name = "idcard";
            this.idcard.Padding = new System.Windows.Forms.Padding(5);
            this.idcard.Size = new System.Drawing.Size(258, 39);
            this.idcard.TabIndex = 7;
            // 
            // hire_date
            // 
            this.hire_date.FillColor = System.Drawing.Color.White;
            this.hire_date.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.hire_date.Location = new System.Drawing.Point(194, 382);
            this.hire_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hire_date.MaxLength = 10;
            this.hire_date.MinimumSize = new System.Drawing.Size(63, 0);
            this.hire_date.Name = "hire_date";
            this.hire_date.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.hire_date.Size = new System.Drawing.Size(150, 39);
            this.hire_date.SymbolDropDown = 61555;
            this.hire_date.SymbolNormal = 61555;
            this.hire_date.TabIndex = 8;
            this.hire_date.Text = "2021-03-07";
            this.hire_date.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.hire_date.Value = new System.DateTime(2021, 3, 7, 17, 37, 38, 882);
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(49, 447);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(100, 23);
            this.uiLabel8.TabIndex = 3;
            this.uiLabel8.Text = "权限：";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboTreeView1
            // 
            this.uiComboTreeView1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiComboTreeView1.FillColor = System.Drawing.Color.White;
            this.uiComboTreeView1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboTreeView1.Location = new System.Drawing.Point(194, 447);
            this.uiComboTreeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboTreeView1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboTreeView1.Name = "uiComboTreeView1";
            treeNode1.Name = "节点0";
            treeNode1.Text = "系统管理员";
            treeNode2.Name = "节点1";
            treeNode2.Text = "部门管理员";
            treeNode3.Name = "节点2";
            treeNode3.Text = "操作员";
            this.uiComboTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.uiComboTreeView1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboTreeView1.Size = new System.Drawing.Size(150, 39);
            this.uiComboTreeView1.TabIndex = 9;
            this.uiComboTreeView1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FEdit_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 556);
            this.Controls.Add(this.uiComboTreeView1);
            this.Controls.Add(this.hire_date);
            this.Controls.Add(this.idcard);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.editAge);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.edtName);
            this.Name = "FEdit_staff";
            this.Text = "新增用户";
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.edtName, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.uiLabel3, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.uiLabel7, 0);
            this.Controls.SetChildIndex(this.uiLabel8, 0);
            this.Controls.SetChildIndex(this.editAge, 0);
            this.Controls.SetChildIndex(this.rbMale, 0);
            this.Controls.SetChildIndex(this.rbFemale, 0);
            this.Controls.SetChildIndex(this.cbDepartment, 0);
            this.Controls.SetChildIndex(this.phone, 0);
            this.Controls.SetChildIndex(this.idcard, 0);
            this.Controls.SetChildIndex(this.hire_date, 0);
            this.Controls.SetChildIndex(this.uiComboTreeView1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox edtName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox editAge;
        private Sunny.UI.UIRadioButton rbMale;
        private Sunny.UI.UIRadioButton rbFemale;
        private Sunny.UI.UIComboBox cbDepartment;
        private Sunny.UI.UITextBox phone;
        private Sunny.UI.UITextBox idcard;
        private Sunny.UI.UIDatePicker hire_date;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIComboTreeView uiComboTreeView1;
    }
}