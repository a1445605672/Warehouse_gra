
namespace Warehouse
{
    partial class 用户管理
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.NewCreate = new Sunny.UI.UIButton();
			this.SearchButton = new Sunny.UI.UISymbolButton();
			this.SearchBox = new Sunny.UI.UITextBox();
			this.uiComboBox1 = new Sunny.UI.UIComboBox();
			this.grid = new Sunny.UI.UIDataGridView();
			this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
			this.MenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_update = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.uiContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.Controls.Add(this.NewCreate, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.SearchButton, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.SearchBox, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.uiComboBox1, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 44);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// NewCreate
			// 
			this.NewCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.NewCreate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NewCreate.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.NewCreate.Location = new System.Drawing.Point(30, 4);
			this.NewCreate.MinimumSize = new System.Drawing.Size(1, 1);
			this.NewCreate.Name = "NewCreate";
			this.NewCreate.Size = new System.Drawing.Size(100, 35);
			this.NewCreate.TabIndex = 1;
			this.NewCreate.Text = "新增";
			this.NewCreate.Click += new System.EventHandler(this.uiButton1_Click);
			// 
			// SearchButton
			// 
			this.SearchButton.CircleRectWidth = 2;
			this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SearchButton.FillColor = System.Drawing.Color.White;
			this.SearchButton.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
			this.SearchButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
			this.SearchButton.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
			this.SearchButton.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.SearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
			this.SearchButton.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			this.SearchButton.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
			this.SearchButton.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
			this.SearchButton.IsCircle = true;
			this.SearchButton.Location = new System.Drawing.Point(703, 3);
			this.SearchButton.MinimumSize = new System.Drawing.Size(1, 1);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
			this.SearchButton.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
			this.SearchButton.Size = new System.Drawing.Size(94, 38);
			this.SearchButton.Style = Sunny.UI.UIStyle.White;
			this.SearchButton.StyleCustomMode = true;
			this.SearchButton.Symbol = 61442;
			this.SearchButton.TabIndex = 26;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// SearchBox
			// 
			this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.SearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SearchBox.FillColor = System.Drawing.Color.White;
			this.SearchBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.SearchBox.Location = new System.Drawing.Point(305, 5);
			this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.SearchBox.Maximum = 2147483647D;
			this.SearchBox.Minimum = -2147483648D;
			this.SearchBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.SearchBox.Name = "SearchBox";
			this.SearchBox.Padding = new System.Windows.Forms.Padding(5);
			this.SearchBox.Size = new System.Drawing.Size(391, 29);
			this.SearchBox.TabIndex = 0;
			// 
			// uiComboBox1
			// 
			this.uiComboBox1.FillColor = System.Drawing.Color.White;
			this.uiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiComboBox1.Items.AddRange(new object[] {
            "部门",
            "员工号",
            "性别"});
			this.uiComboBox1.Location = new System.Drawing.Point(165, 5);
			this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
			this.uiComboBox1.Name = "uiComboBox1";
			this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.uiComboBox1.Size = new System.Drawing.Size(132, 29);
			this.uiComboBox1.TabIndex = 27;
			this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// grid
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
			this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.grid.BackgroundColor = System.Drawing.Color.White;
			this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grid.DefaultCellStyle = dataGridViewCellStyle3;
			this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid.EnableHeadersVisualStyles = false;
			this.grid.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			this.grid.Location = new System.Drawing.Point(0, 44);
			this.grid.Name = "grid";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.grid.RowHeadersWidth = 51;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			this.grid.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.grid.RowTemplate.Height = 29;
			this.grid.SelectedIndex = -1;
			this.grid.ShowGridLine = true;
			this.grid.Size = new System.Drawing.Size(800, 406);
			this.grid.TabIndex = 1;
			this.grid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uiDataGridView1_MouseUp);
			// 
			// uiContextMenuStrip1
			// 
			this.uiContextMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.uiContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Add,
            this.MenuItem_delete,
            this.MenuItem_update});
			this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
			this.uiContextMenuStrip1.Size = new System.Drawing.Size(113, 82);
			// 
			// MenuItem_Add
			// 
			this.MenuItem_Add.Name = "MenuItem_Add";
			this.MenuItem_Add.Size = new System.Drawing.Size(112, 26);
			this.MenuItem_Add.Text = "添加";
			this.MenuItem_Add.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// MenuItem_delete
			// 
			this.MenuItem_delete.Name = "MenuItem_delete";
			this.MenuItem_delete.Size = new System.Drawing.Size(112, 26);
			this.MenuItem_delete.Text = "删除";
			this.MenuItem_delete.Click += new System.EventHandler(this.MenuItem_delete_Click);
			// 
			// MenuItem_update
			// 
			this.MenuItem_update.Name = "MenuItem_update";
			this.MenuItem_update.Size = new System.Drawing.Size(112, 26);
			this.MenuItem_update.Text = "编辑";
			// 
			// 用户管理
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "用户管理";
			this.Text = "用户管理";
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.uiContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UITextBox SearchBox;
        private Sunny.UI.UIButton NewCreate;
        private Sunny.UI.UISymbolButton SearchButton;
        private Sunny.UI.UIDataGridView grid;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Add;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_delete;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_update;
    }
}