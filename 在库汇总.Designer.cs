
namespace Warehouse
{
	partial class 在库汇总
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtMatName1 = new Sunny.UI.UITextBox();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.uiPagination1 = new Sunny.UI.UIPagination();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.endTime1 = new Sunny.UI.UIDatetimePicker();
            this.startTime1 = new Sunny.UI.UIDatetimePicker();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.comIn_num = new Sunny.UI.UIComboBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.txtMatid1 = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.comStorageNum = new Sunny.UI.UIComboBox();
            this.PagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.comStorageNum);
            this.PagePanel.Controls.Add(this.uiLabel6);
            this.PagePanel.Controls.Add(this.comIn_num);
            this.PagePanel.Controls.Add(this.uiLabel4);
            this.PagePanel.Controls.Add(this.uiButton3);
            this.PagePanel.Controls.Add(this.uiButton1);
            this.PagePanel.Controls.Add(this.uiLabel2);
            this.PagePanel.Controls.Add(this.endTime1);
            this.PagePanel.Controls.Add(this.startTime1);
            this.PagePanel.Controls.Add(this.uiLabel3);
            this.PagePanel.Controls.Add(this.uiPagination1);
            this.PagePanel.Controls.Add(this.uiDataGridView1);
            this.PagePanel.Controls.Add(this.uiButton2);
            this.PagePanel.Controls.Add(this.txtMatid1);
            this.PagePanel.Controls.Add(this.uiLabel5);
            this.PagePanel.Controls.Add(this.txtMatName1);
            this.PagePanel.Controls.Add(this.uiLabel1);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(48, 56);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(127, 39);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "物料名称:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatName1
            // 
            this.txtMatName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatName1.FillColor = System.Drawing.Color.White;
            this.txtMatName1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtMatName1.Location = new System.Drawing.Point(182, 56);
            this.txtMatName1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatName1.Maximum = 2147483647D;
            this.txtMatName1.Minimum = -2147483648D;
            this.txtMatName1.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMatName1.Name = "txtMatName1";
            this.txtMatName1.Padding = new System.Windows.Forms.Padding(5);
            this.txtMatName1.Size = new System.Drawing.Size(154, 39);
            this.txtMatName1.TabIndex = 1;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.Location = new System.Drawing.Point(263, 159);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(89, 35);
            this.uiButton2.TabIndex = 5;
            this.uiButton2.Text = "查询";
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiDataGridView1
            // 
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
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(12, 220);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.uiDataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.uiDataGridView1.RowTemplate.Height = 29;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.ShowGridLine = true;
            this.uiDataGridView1.Size = new System.Drawing.Size(776, 183);
            this.uiDataGridView1.TabIndex = 6;
            this.uiDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellContentClick);
            // 
            // uiPagination1
            // 
            this.uiPagination1.ActivePage = 20;
            this.uiPagination1.CausesValidation = false;
            this.uiPagination1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPagination1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPagination1.Location = new System.Drawing.Point(0, 380);
            this.uiPagination1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPagination1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPagination1.Name = "uiPagination1";
            this.uiPagination1.PagerCount = 11;
            this.uiPagination1.PageSize = 16;
            this.uiPagination1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPagination1.Size = new System.Drawing.Size(800, 35);
            this.uiPagination1.TabIndex = 7;
            this.uiPagination1.Text = "uiDataGridPage1";
            this.uiPagination1.TotalCount = 40000;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(371, 12);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(36, 36);
            this.uiLabel2.TabIndex = 11;
            this.uiLabel2.Text = "--";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // endTime1
            // 
            this.endTime1.DateFormat = "yyyy-MM-dd";
            this.endTime1.FillColor = System.Drawing.Color.White;
            this.endTime1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.endTime1.Location = new System.Drawing.Point(414, 12);
            this.endTime1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endTime1.MaxLength = 10;
            this.endTime1.MinimumSize = new System.Drawing.Size(63, 0);
            this.endTime1.Name = "endTime1";
            this.endTime1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.endTime1.Size = new System.Drawing.Size(182, 39);
            this.endTime1.SymbolDropDown = 61555;
            this.endTime1.SymbolNormal = 61555;
            this.endTime1.TabIndex = 9;
            this.endTime1.Text = "2021-04-19";
            this.endTime1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.endTime1.Value = new System.DateTime(2021, 4, 19, 18, 18, 43, 235);
            // 
            // startTime1
            // 
            this.startTime1.DateFormat = "yyyy-MM-dd ";
            this.startTime1.FillColor = System.Drawing.Color.White;
            this.startTime1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.startTime1.Location = new System.Drawing.Point(182, 12);
            this.startTime1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startTime1.MaxLength = 11;
            this.startTime1.MinimumSize = new System.Drawing.Size(63, 0);
            this.startTime1.Name = "startTime1";
            this.startTime1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.startTime1.Size = new System.Drawing.Size(182, 39);
            this.startTime1.SymbolDropDown = 61555;
            this.startTime1.SymbolNormal = 61555;
            this.startTime1.TabIndex = 10;
            this.startTime1.Text = "2021-04-19 ";
            this.startTime1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.startTime1.Value = new System.DateTime(2021, 4, 19, 18, 18, 43, 235);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(46, 3);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(144, 48);
            this.uiLabel3.TabIndex = 8;
            this.uiLabel3.Text = "出库时间：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(141, 159);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 12;
            this.uiButton1.Text = "重置";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton3.Location = new System.Drawing.Point(372, 159);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(100, 35);
            this.uiButton3.TabIndex = 13;
            this.uiButton3.Text = "导出";
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(386, 56);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(139, 39);
            this.uiLabel4.TabIndex = 14;
            this.uiLabel4.Text = "入库编号：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comIn_num
            // 
            this.comIn_num.FillColor = System.Drawing.Color.White;
            this.comIn_num.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comIn_num.Location = new System.Drawing.Point(515, 56);
            this.comIn_num.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comIn_num.MinimumSize = new System.Drawing.Size(63, 0);
            this.comIn_num.Name = "comIn_num";
            this.comIn_num.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comIn_num.Size = new System.Drawing.Size(150, 39);
            this.comIn_num.TabIndex = 15;
            this.comIn_num.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comIn_num.Load += new System.EventHandler(this.comIn_num_Load);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(48, 105);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(127, 39);
            this.uiLabel5.TabIndex = 0;
            this.uiLabel5.Text = "物料ID:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatid1
            // 
            this.txtMatid1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatid1.FillColor = System.Drawing.Color.White;
            this.txtMatid1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtMatid1.Location = new System.Drawing.Point(182, 105);
            this.txtMatid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatid1.Maximum = 2147483647D;
            this.txtMatid1.Minimum = -2147483648D;
            this.txtMatid1.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMatid1.Name = "txtMatid1";
            this.txtMatid1.Padding = new System.Windows.Forms.Padding(5);
            this.txtMatid1.Size = new System.Drawing.Size(154, 39);
            this.txtMatid1.TabIndex = 1;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(386, 105);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(121, 39);
            this.uiLabel6.TabIndex = 16;
            this.uiLabel6.Text = "库位编号:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comStorageNum
            // 
            this.comStorageNum.FillColor = System.Drawing.Color.White;
            this.comStorageNum.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comStorageNum.Location = new System.Drawing.Point(515, 105);
            this.comStorageNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comStorageNum.MinimumSize = new System.Drawing.Size(63, 0);
            this.comStorageNum.Name = "comStorageNum";
            this.comStorageNum.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comStorageNum.Size = new System.Drawing.Size(150, 39);
            this.comStorageNum.TabIndex = 17;
            this.comStorageNum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comStorageNum.Load += new System.EventHandler(this.comStorageNum_Load);
            // 
            // 在库汇总
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "在库汇总";
            this.Text = "在库汇总";
            this.PagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtMatName1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIPagination uiPagination1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIDatetimePicker endTime1;
        private Sunny.UI.UIDatetimePicker startTime1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIComboBox comIn_num;
        private Sunny.UI.UITextBox txtMatid1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboBox comStorageNum;
    }
}