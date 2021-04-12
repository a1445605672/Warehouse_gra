
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.uiPagination1 = new Sunny.UI.UIPagination();
			this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
			this.uiLabel1 = new Sunny.UI.UILabel();
			this.logType = new Sunny.UI.UIComboBox();
			this.logSearchButton = new Sunny.UI.UIButton();
			this.uiLabel2 = new Sunny.UI.UILabel();
			this.uiLabel3 = new Sunny.UI.UILabel();
			this.staffId = new Sunny.UI.UITextBox();
			this.logDate = new Sunny.UI.UIDatePicker();
			this.PagePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// PagePanel
			// 
			this.PagePanel.Controls.Add(this.logDate);
			this.PagePanel.Controls.Add(this.staffId);
			this.PagePanel.Controls.Add(this.uiLabel3);
			this.PagePanel.Controls.Add(this.uiLabel2);
			this.PagePanel.Controls.Add(this.logSearchButton);
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
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
			this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
			this.uiDataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.uiDataGridView1.EnableHeadersVisualStyles = false;
			this.uiDataGridView1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			this.uiDataGridView1.Location = new System.Drawing.Point(0, 49);
			this.uiDataGridView1.MultiSelect = false;
			this.uiDataGridView1.Name = "uiDataGridView1";
			this.uiDataGridView1.ReadOnly = true;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F);
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
			this.uiDataGridView1.RowTemplate.Height = 29;
			this.uiDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.uiDataGridView1.SelectedIndex = -1;
			this.uiDataGridView1.ShowGridLine = true;
			this.uiDataGridView1.Size = new System.Drawing.Size(950, 506);
			this.uiDataGridView1.TabIndex = 7;
			// 
			// uiLabel1
			// 
			this.uiLabel1.AutoSize = true;
			this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel1.Location = new System.Drawing.Point(12, 25);
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
			this.logType.Location = new System.Drawing.Point(75, 21);
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
			this.logSearchButton.Location = new System.Drawing.Point(686, 18);
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
			this.uiLabel2.Location = new System.Drawing.Point(232, 25);
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
			this.uiLabel3.Location = new System.Drawing.Point(459, 25);
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
			this.staffId.Location = new System.Drawing.Point(529, 21);
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
			this.logDate.Location = new System.Drawing.Point(302, 21);
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
			this.logDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
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
	}
}