
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
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.backup_button = new Sunny.UI.UIButton();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.uiListBox1 = new Sunny.UI.UIListBox();
            this.uiDatePicker1 = new Sunny.UI.UIDatePicker();
            this.recover = new Sunny.UI.UIButton();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
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
            // backup_button
            // 
            this.backup_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backup_button.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.backup_button.Location = new System.Drawing.Point(132, 62);
            this.backup_button.MinimumSize = new System.Drawing.Size(1, 1);
            this.backup_button.Name = "backup_button";
            this.backup_button.Size = new System.Drawing.Size(100, 35);
            this.backup_button.TabIndex = 0;
            this.backup_button.Text = "备份";
            this.backup_button.Click += new System.EventHandler(this.backup_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.uiListBox1);
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
            // uiListBox1
            // 
            this.uiListBox1.FillColor = System.Drawing.Color.White;
            this.uiListBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiListBox1.FormatString = "";
            this.uiListBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiListBox1.Location = new System.Drawing.Point(307, 159);
            this.uiListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiListBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiListBox1.Name = "uiListBox1";
            this.uiListBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiListBox1.Size = new System.Drawing.Size(247, 171);
            this.uiListBox1.TabIndex = 2;
            this.uiListBox1.Text = "uiListBox1";
            this.uiListBox1.ItemClick += new System.EventHandler(this.uiListBox1_ItemClick);
            // 
            // uiDatePicker1
            // 
            this.uiDatePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatePicker1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDatePicker1.Location = new System.Drawing.Point(307, 91);
            this.uiDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker1.MaxLength = 10;
            this.uiDatePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker1.Name = "uiDatePicker1";
            this.uiDatePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker1.Size = new System.Drawing.Size(150, 34);
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
            this.recover.Location = new System.Drawing.Point(132, 91);
            this.recover.MinimumSize = new System.Drawing.Size(1, 1);
            this.recover.Name = "recover";
            this.recover.Size = new System.Drawing.Size(100, 35);
            this.recover.TabIndex = 0;
            this.recover.Text = "恢复";
            this.recover.Click += new System.EventHandler(this.recover_Click);
            // 
            // 数据备份
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "数据备份";
            this.Text = "Form1";
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton backup_button;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIButton recover;
        private Sunny.UI.UIDatePicker uiDatePicker1;
        private Sunny.UI.UIListBox uiListBox1;
    }
}

