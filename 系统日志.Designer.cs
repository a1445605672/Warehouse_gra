
namespace Warehouse
{
	partial class 系统日志
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			this.uiPagination1 = new Sunny.UI.UIPagination();
			this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
			this.uiLabel1 = new Sunny.UI.UILabel();
			this.logType = new Sunny.UI.UIComboBox();
			this.logSearchButton = new Sunny.UI.UIButton();
			this.uiLabel2 = new Sunny.UI.UILabel();
			this.uiLabel3 = new Sunny.UI.UILabel();
			this.staffId = new Sunny.UI.UITextBox();
			this.logDate = new Sunny.UI.UIDatePicker();
			this.enter_num = new Sunny.UI.UITextBox();
			this.uiLabel5 = new Sunny.UI.UILabel();
			this.page = new Sunny.UI.UIComboBox();
			this.uiLabel6 = new Sunny.UI.UILabel();
			this.PagePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// PagePanel
			// 
			this.PagePanel.Controls.Add(this.enter_num);
			this.PagePanel.Controls.Add(this.logDate);
			this.PagePanel.Controls.Add(this.staffId);
			this.PagePanel.Controls.Add(this.uiLabel5);
			this.PagePanel.Controls.Add(this.uiLabel3);
			this.PagePanel.Controls.Add(this.uiLabel2);
			this.PagePanel.Controls.Add(this.page);
			this.PagePanel.Controls.Add(this.logSearchButton);
			this.PagePanel.Controls.Add(this.uiLabel6);
			this.PagePanel.Controls.Add(this.logType);
			this.PagePanel.Controls.Add(this.uiLabel1);
			this.PagePanel.Controls.Add(this.uiDataGridView1);
			this.PagePanel.Controls.Add(this.uiPagination1);
			this.PagePanel.Size = new System.Drawing.Size(950, 590);
			// 
			// uiPagination1
			// 
			this.uiPagination1.ActivePage = 20;
			this.uiPagination1.CausesValidation = false;
			this.uiPagination1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.uiPagination1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiPagination1.Location = new System.Drawing.Point(0, 555);
			this.uiPagination1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.uiPagination1.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiPagination1.Name = "uiPagination1";
			this.uiPagination1.PagerCount = 11;
			this.uiPagination1.PageSize = 16;
			this.uiPagination1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
			this.uiPagination1.Size = new System.Drawing.Size(950, 35);
			this.uiPagination1.TabIndex = 5;
			this.uiPagination1.Text = "uiDataGridPage1";
			this.uiPagination1.TotalCount = 40000;
			this.uiPagination1.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.uiPagination1_PageChanged);
			// 
			// uiDataGridView1
			// 
			this.uiDataGridView1.AllowUserToAddRows = false;
			this.uiDataGridView1.AllowUserToDeleteRows = false;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
			this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
			this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.Font = new System.Drawing.Font("微软雅黑", 12F);
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("微软雅黑", 12F);
			dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
			this.uiDataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.uiDataGridView1.EnableHeadersVisualStyles = false;
			this.uiDataGridView1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			this.uiDataGridView1.Location = new System.Drawing.Point(0, 55);
			this.uiDataGridView1.Margin = new System.Windows.Forms.Padding(0);
			this.uiDataGridView1.MultiSelect = false;
			this.uiDataGridView1.Name = "uiDataGridView1";
			this.uiDataGridView1.ReadOnly = true;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle14.Font = new System.Drawing.Font("微软雅黑", 12F);
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
			this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
			this.uiDataGridView1.RowTemplate.Height = 29;
			this.uiDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.uiDataGridView1.SelectedIndex = -1;
			this.uiDataGridView1.ShowGridLine = true;
			this.uiDataGridView1.Size = new System.Drawing.Size(950, 500);
			this.uiDataGridView1.TabIndex = 7;
			// 
			// uiLabel1
			// 
			this.uiLabel1.AutoSize = true;
			this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel1.Location = new System.Drawing.Point(12, 9);
			this.uiLabel1.Name = "uiLabel1";
			this.uiLabel1.Size = new System.Drawing.Size(63, 21);
			this.uiLabel1.TabIndex = 8;
			this.uiLabel1.Text = "类 型：";
			this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// logType
			// 
			this.logType.FillColor = System.Drawing.Color.White;
			this.logType.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.logType.Items.AddRange(new object[] {
            "",
            "查看",
            "插入",
            "删除",
            "修改",
            "出库",
            "入库",
            "系统错误"});
			this.logType.Location = new System.Drawing.Point(75, 5);
			this.logType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.logType.MinimumSize = new System.Drawing.Size(63, 0);
			this.logType.Name = "logType";
			this.logType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.logType.Size = new System.Drawing.Size(150, 29);
			this.logType.TabIndex = 9;
			this.logType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.logType.Watermark = "请选择日志类型";
			// 
			// logSearchButton
			// 
			this.logSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.logSearchButton.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.logSearchButton.Location = new System.Drawing.Point(686, 17);
			this.logSearchButton.MinimumSize = new System.Drawing.Size(1, 1);
			this.logSearchButton.Name = "logSearchButton";
			this.logSearchButton.Radius = 35;
			this.logSearchButton.Size = new System.Drawing.Size(100, 35);
			this.logSearchButton.TabIndex = 57;
			this.logSearchButton.Text = "搜  索";
			this.logSearchButton.Click += new System.EventHandler(this.SearchBut_Click);
			// 
			// uiLabel2
			// 
			this.uiLabel2.AutoSize = true;
			this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel2.Location = new System.Drawing.Point(232, 9);
			this.uiLabel2.Name = "uiLabel2";
			this.uiLabel2.Size = new System.Drawing.Size(63, 21);
			this.uiLabel2.TabIndex = 59;
			this.uiLabel2.Text = "时 间：";
			this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel3
			// 
			this.uiLabel3.AutoSize = true;
			this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel3.Location = new System.Drawing.Point(459, 9);
			this.uiLabel3.Name = "uiLabel3";
			this.uiLabel3.Size = new System.Drawing.Size(58, 21);
			this.uiLabel3.TabIndex = 60;
			this.uiLabel3.Text = "操作员";
			this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// staffId
			// 
			this.staffId.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.staffId.FillColor = System.Drawing.Color.White;
			this.staffId.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.staffId.Location = new System.Drawing.Point(529, 5);
			this.staffId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.staffId.Maximum = 2147483647D;
			this.staffId.Minimum = -2147483648D;
			this.staffId.MinimumSize = new System.Drawing.Size(1, 1);
			this.staffId.Name = "staffId";
			this.staffId.Padding = new System.Windows.Forms.Padding(5);
			this.staffId.Size = new System.Drawing.Size(150, 29);
			this.staffId.TabIndex = 61;
			this.staffId.Watermark = "请输入操作员编号";
			// 
			// logDate
			// 
			this.logDate.CanEmpty = true;
			this.logDate.FillColor = System.Drawing.Color.White;
			this.logDate.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.logDate.Location = new System.Drawing.Point(302, 5);
			this.logDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.logDate.MaxLength = 10;
			this.logDate.MinimumSize = new System.Drawing.Size(63, 0);
			this.logDate.Name = "logDate";
			this.logDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.logDate.Size = new System.Drawing.Size(150, 29);
			this.logDate.SymbolDropDown = 61555;
			this.logDate.SymbolNormal = 61555;
			this.logDate.TabIndex = 62;
			this.logDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.logDate.Value = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
			this.logDate.Watermark = "请选择日期";
			// 
			// enter_num
			// 
			this.enter_num.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.enter_num.FillColor = System.Drawing.Color.White;
			this.enter_num.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.enter_num.Location = new System.Drawing.Point(313, 44);
			this.enter_num.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.enter_num.Maximum = 2147483647D;
			this.enter_num.Minimum = -2147483648D;
			this.enter_num.MinimumSize = new System.Drawing.Size(1, 1);
			this.enter_num.Name = "enter_num";
			this.enter_num.Padding = new System.Windows.Forms.Padding(5);
			this.enter_num.Size = new System.Drawing.Size(150, 29);
			this.enter_num.TabIndex = 68;
			this.enter_num.Watermark = "请输入入库编号";
			// 
			// uiLabel5
			// 
			this.uiLabel5.AutoSize = true;
			this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel5.Location = new System.Drawing.Point(232, 48);
			this.uiLabel5.Name = "uiLabel5";
			this.uiLabel5.Size = new System.Drawing.Size(90, 21);
			this.uiLabel5.TabIndex = 66;
			this.uiLabel5.Text = "入库编号：";
			this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// page
			// 
			this.page.FillColor = System.Drawing.Color.White;
			this.page.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.page.Items.AddRange(new object[] {
            "",
            "首页",
            "房间管理",
            "库柜管理",
            "库位管理",
            "库位类型管理",
            "物料信息管理",
            "物料类别管理",
            "部门管理",
            "部门人员管理",
            "供应商管理",
            "收货商管理",
            "数据备份",
            "系统日志",
            "用户管理",
            "用户注册",
            "入库登记",
            "出库登记",
            "未完成入库",
            "未完成出库",
            "出入库汇总",
            "在库汇总",
            "入库日报",
            "柱状图",
            "折线图",
            "图形化展示"});
			this.page.Location = new System.Drawing.Point(75, 44);
			this.page.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.page.MinimumSize = new System.Drawing.Size(63, 0);
			this.page.Name = "page";
			this.page.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.page.Size = new System.Drawing.Size(150, 29);
			this.page.TabIndex = 64;
			this.page.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.page.Watermark = "请选择页面";
			// 
			// uiLabel6
			// 
			this.uiLabel6.AutoSize = true;
			this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel6.Location = new System.Drawing.Point(12, 48);
			this.uiLabel6.Name = "uiLabel6";
			this.uiLabel6.Size = new System.Drawing.Size(63, 21);
			this.uiLabel6.TabIndex = 63;
			this.uiLabel6.Text = "页 面：";
			this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// 系统日志
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(950, 625);
			this.Name = "系统日志";
			this.Text = "系统日志";
			this.Load += new System.EventHandler(this.系统日志_Load);
			this.PagePanel.ResumeLayout(false);
			this.PagePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Sunny.UI.UIPagination uiPagination1;
		private Sunny.UI.UIDataGridView uiDataGridView1;
		private Sunny.UI.UIComboBox logType;
		private Sunny.UI.UILabel uiLabel1;
		private Sunny.UI.UIButton logSearchButton;
		private Sunny.UI.UITextBox staffId;
		private Sunny.UI.UILabel uiLabel3;
		private Sunny.UI.UILabel uiLabel2;
		private Sunny.UI.UIDatePicker logDate;
		private Sunny.UI.UITextBox enter_num;
		private Sunny.UI.UILabel uiLabel5;
		private Sunny.UI.UIComboBox page;
		private Sunny.UI.UILabel uiLabel6;
	}
}