
namespace Warehouse
{
	partial class 数据备份
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点2");
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiComboTreeView1 = new Sunny.UI.UIComboTreeView();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.backup_button = new Sunny.UI.UIButton();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.uiListBox1 = new Sunny.UI.UIListBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiDatePicker1 = new Sunny.UI.UIDatePicker();
            this.recover = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiRadioButton1 = new Sunny.UI.UIRadioButton();
            this.uiRadioButton2 = new Sunny.UI.UIRadioButton();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiRadioButton2);
            this.uiGroupBox1.Controls.Add(this.uiRadioButton1);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.uiComboTreeView1);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.backup_button);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(110, 53);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(592, 180);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "数据备份";
            // 
            // uiComboTreeView1
            // 
            this.uiComboTreeView1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiComboTreeView1.FillColor = System.Drawing.Color.White;
            this.uiComboTreeView1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboTreeView1.Location = new System.Drawing.Point(184, 95);
            this.uiComboTreeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboTreeView1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboTreeView1.Name = "uiComboTreeView1";
            treeNode1.Name = "一小时";
            treeNode1.Text = "节点0";
            treeNode2.Name = "6小时";
            treeNode2.Text = "节点1";
            treeNode3.Name = "24小时";
            treeNode3.Text = "节点2";
            this.uiComboTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.uiComboTreeView1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboTreeView1.Size = new System.Drawing.Size(194, 39);
            this.uiComboTreeView1.TabIndex = 2;
            this.uiComboTreeView1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(178, 47);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(200, 34);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "自动备份频率：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backup_button
            // 
            this.backup_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backup_button.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.backup_button.Location = new System.Drawing.Point(417, 47);
            this.backup_button.MinimumSize = new System.Drawing.Size(1, 1);
            this.backup_button.Name = "backup_button";
            this.backup_button.Size = new System.Drawing.Size(120, 87);
            this.backup_button.TabIndex = 0;
            this.backup_button.Text = "备份";
            this.backup_button.Click += new System.EventHandler(this.backup_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.uiTitlePanel1);
            this.uiGroupBox2.Controls.Add(this.uiLabel1);
            this.uiGroupBox2.Controls.Add(this.uiDatePicker1);
            this.uiGroupBox2.Controls.Add(this.recover);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(110, 243);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(592, 361);
            this.uiGroupBox2.TabIndex = 1;
            this.uiGroupBox2.Text = "数据恢复";
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uiListBox1);
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(64, 142);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel1.Size = new System.Drawing.Size(300, 192);
            this.uiTitlePanel1.TabIndex = 4;
            this.uiTitlePanel1.Text = "选择要恢复的数据";
            // 
            // uiListBox1
            // 
            this.uiListBox1.FillColor = System.Drawing.Color.White;
            this.uiListBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiListBox1.FormatString = "";
            this.uiListBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiListBox1.Location = new System.Drawing.Point(19, 40);
            this.uiListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiListBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiListBox1.Name = "uiListBox1";
            this.uiListBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiListBox1.Size = new System.Drawing.Size(260, 141);
            this.uiListBox1.TabIndex = 2;
            this.uiListBox1.Text = "uiListBox1";
            this.uiListBox1.ItemClick += new System.EventHandler(this.uiListBox1_ItemClick);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(61, 51);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(282, 37);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "请选择要恢复到的日期：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiDatePicker1
            // 
            this.uiDatePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatePicker1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDatePicker1.Location = new System.Drawing.Point(64, 93);
            this.uiDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker1.MaxLength = 10;
            this.uiDatePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker1.Name = "uiDatePicker1";
            this.uiDatePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker1.Size = new System.Drawing.Size(150, 39);
            this.uiDatePicker1.SymbolDropDown = 61555;
            this.uiDatePicker1.SymbolNormal = 61555;
            this.uiDatePicker1.TabIndex = 1;
            this.uiDatePicker1.Text = "2021-04-04";
            this.uiDatePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker1.Value = new System.DateTime(2021, 4, 4, 11, 56, 49, 428);
            this.uiDatePicker1.ValueChanged += new Sunny.UI.UIDatePicker.OnDateTimeChanged(this.uiDatePicker1_ValueChanged);
            this.uiDatePicker1.Click += new System.EventHandler(this.uiDatePicker1_Click);
            // 
            // recover
            // 
            this.recover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recover.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.recover.Location = new System.Drawing.Point(417, 194);
            this.recover.MinimumSize = new System.Drawing.Size(1, 1);
            this.recover.Name = "recover";
            this.recover.Size = new System.Drawing.Size(127, 97);
            this.recover.TabIndex = 0;
            this.recover.Text = "恢复";
            this.recover.Click += new System.EventHandler(this.recover_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(19, 42);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(144, 39);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "备份方式：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiRadioButton1
            // 
            this.uiRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButton1.Location = new System.Drawing.Point(25, 84);
            this.uiRadioButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton1.Name = "uiRadioButton1";
            this.uiRadioButton1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton1.Size = new System.Drawing.Size(150, 29);
            this.uiRadioButton1.TabIndex = 4;
            this.uiRadioButton1.Text = "手动";
            // 
            // uiRadioButton2
            // 
            this.uiRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButton2.Location = new System.Drawing.Point(25, 120);
            this.uiRadioButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton2.Name = "uiRadioButton2";
            this.uiRadioButton2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton2.Size = new System.Drawing.Size(150, 29);
            this.uiRadioButton2.TabIndex = 5;
            this.uiRadioButton2.Text = "自动";
            this.uiRadioButton2.ValueChanged += new Sunny.UI.UIRadioButton.OnValueChanged(this.uiRadioButton2_ValueChanged);
            // 
            // 数据备份
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "数据备份";
            this.Text = "Form1";
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiTitlePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton backup_button;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIButton recover;
        private Sunny.UI.UIDatePicker uiDatePicker1;
        private Sunny.UI.UIListBox uiListBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UIComboTreeView uiComboTreeView1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIRadioButton uiRadioButton2;
        private Sunny.UI.UIRadioButton uiRadioButton1;
        private Sunny.UI.UILabel uiLabel3;
    }
}

