
namespace Warehouse
{
    partial class new_入库汇总
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.startTime1 = new Sunny.UI.UIDatetimePicker();
            this.endTime1 = new Sunny.UI.UIDatetimePicker();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.comMatName = new Sunny.UI.UIComboBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.comStaffName = new Sunny.UI.UIComboBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.comStorage = new Sunny.UI.UIComboBox();
            this.comBatch = new Sunny.UI.UIComboBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.grid = new Sunny.UI.UIDataGridView();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiPagination1 = new Sunny.UI.UIPagination();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.PagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiButton3);
            this.PagePanel.Controls.Add(this.uiPagination1);
            this.PagePanel.Controls.Add(this.uiButton2);
            this.PagePanel.Controls.Add(this.uiButton1);
            this.PagePanel.Controls.Add(this.grid);
            this.PagePanel.Controls.Add(this.comBatch);
            this.PagePanel.Controls.Add(this.comStorage);
            this.PagePanel.Controls.Add(this.uiLabel6);
            this.PagePanel.Controls.Add(this.uiLabel5);
            this.PagePanel.Controls.Add(this.comStaffName);
            this.PagePanel.Controls.Add(this.uiLabel4);
            this.PagePanel.Controls.Add(this.comMatName);
            this.PagePanel.Controls.Add(this.uiLabel3);
            this.PagePanel.Controls.Add(this.uiLabel2);
            this.PagePanel.Controls.Add(this.endTime1);
            this.PagePanel.Controls.Add(this.startTime1);
            this.PagePanel.Controls.Add(this.uiLabel1);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(32, 17);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(144, 48);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "入库时间：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startTime1
            // 
            this.startTime1.DateFormat = "yyyy-MM-dd ";
            this.startTime1.FillColor = System.Drawing.Color.White;
            this.startTime1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.startTime1.Location = new System.Drawing.Point(183, 26);
            this.startTime1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startTime1.MaxLength = 11;
            this.startTime1.MinimumSize = new System.Drawing.Size(63, 0);
            this.startTime1.Name = "startTime1";
            this.startTime1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.startTime1.Size = new System.Drawing.Size(182, 39);
            this.startTime1.SymbolDropDown = 61555;
            this.startTime1.SymbolNormal = 61555;
            this.startTime1.TabIndex = 1;
            this.startTime1.Text = "2021-04-19 ";
            this.startTime1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.startTime1.Value = new System.DateTime(2021, 4, 19, 18, 18, 43, 235);
            // 
            // endTime1
            // 
            this.endTime1.DateFormat = "yyyy-MM-dd";
            this.endTime1.FillColor = System.Drawing.Color.White;
            this.endTime1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.endTime1.Location = new System.Drawing.Point(415, 26);
            this.endTime1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endTime1.MaxLength = 10;
            this.endTime1.MinimumSize = new System.Drawing.Size(63, 0);
            this.endTime1.Name = "endTime1";
            this.endTime1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.endTime1.Size = new System.Drawing.Size(182, 39);
            this.endTime1.SymbolDropDown = 61555;
            this.endTime1.SymbolNormal = 61555;
            this.endTime1.TabIndex = 1;
            this.endTime1.Text = "2021-04-19";
            this.endTime1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.endTime1.Value = new System.DateTime(2021, 4, 19, 18, 18, 43, 235);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(372, 26);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(36, 36);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "--";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(32, 70);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(144, 51);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "物品名称:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comMatName
            // 
            this.comMatName.FillColor = System.Drawing.Color.White;
            this.comMatName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comMatName.Location = new System.Drawing.Point(183, 80);
            this.comMatName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comMatName.MinimumSize = new System.Drawing.Size(63, 0);
            this.comMatName.Name = "comMatName";
            this.comMatName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comMatName.Size = new System.Drawing.Size(150, 39);
            this.comMatName.TabIndex = 4;
            this.comMatName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comMatName.Load += new System.EventHandler(this.comMatName_Load);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(32, 119);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(144, 51);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "经办人:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comStaffName
            // 
            this.comStaffName.FillColor = System.Drawing.Color.White;
            this.comStaffName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comStaffName.Location = new System.Drawing.Point(183, 129);
            this.comStaffName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comStaffName.MinimumSize = new System.Drawing.Size(63, 0);
            this.comStaffName.Name = "comStaffName";
            this.comStaffName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comStaffName.Size = new System.Drawing.Size(150, 39);
            this.comStaffName.TabIndex = 4;
            this.comStaffName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comStaffName.Load += new System.EventHandler(this.comStaffName_Load);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(386, 70);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(144, 51);
            this.uiLabel5.TabIndex = 3;
            this.uiLabel5.Text = "库位编号:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.Click += new System.EventHandler(this.uiLabel5_Click);
            // 
            // comStorage
            // 
            this.comStorage.FillColor = System.Drawing.Color.White;
            this.comStorage.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comStorage.Location = new System.Drawing.Point(516, 75);
            this.comStorage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comStorage.MinimumSize = new System.Drawing.Size(63, 0);
            this.comStorage.Name = "comStorage";
            this.comStorage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comStorage.Size = new System.Drawing.Size(150, 39);
            this.comStorage.TabIndex = 4;
            this.comStorage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comStorage.Load += new System.EventHandler(this.comStorage_Load);
            // 
            // comBatch
            // 
            this.comBatch.FillColor = System.Drawing.Color.White;
            this.comBatch.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comBatch.Location = new System.Drawing.Point(516, 128);
            this.comBatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comBatch.MinimumSize = new System.Drawing.Size(63, 0);
            this.comBatch.Name = "comBatch";
            this.comBatch.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comBatch.Size = new System.Drawing.Size(150, 39);
            this.comBatch.TabIndex = 5;
            this.comBatch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comBatch.Load += new System.EventHandler(this.comBatch_Load);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(344, 119);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(186, 53);
            this.uiLabel6.TabIndex = 3;
            this.uiLabel6.Text = "入库批次编号:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.Click += new System.EventHandler(this.uiLabel5_Click);
            // 
            // grid
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle13;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.grid.Location = new System.Drawing.Point(38, 228);
            this.grid.Name = "grid";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.grid.RowHeadersWidth = 62;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.grid.RowTemplate.Height = 29;
            this.grid.SelectedIndex = -1;
            this.grid.ShowGridLine = true;
            this.grid.Size = new System.Drawing.Size(762, 175);
            this.grid.TabIndex = 6;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(233, 176);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 7;
            this.uiButton1.Text = "重置";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.Location = new System.Drawing.Point(362, 176);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 7;
            this.uiButton2.Text = "查询";
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiPagination1
            // 
            this.uiPagination1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPagination1.Location = new System.Drawing.Point(38, 411);
            this.uiPagination1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPagination1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPagination1.Name = "uiPagination1";
            this.uiPagination1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPagination1.Size = new System.Drawing.Size(1139, 35);
            this.uiPagination1.TabIndex = 8;
            this.uiPagination1.Text = "uiPagination1";
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton3.Location = new System.Drawing.Point(497, 176);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(100, 35);
            this.uiButton3.TabIndex = 9;
            this.uiButton3.Text = "导出";
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // new_入库汇总
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "new_入库汇总";
            this.Text = "入库汇总";
            this.PagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDatetimePicker endTime1;
        private Sunny.UI.UIDatetimePicker startTime1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIComboBox comMatName;
        private Sunny.UI.UIComboBox comStaffName;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIComboBox comStorage;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboBox comBatch;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIDataGridView grid;
        private Sunny.UI.UIPagination uiPagination1;
        private Sunny.UI.UIButton uiButton3;
    }
}