
namespace Warehouse.更新数据窗体
{
	partial class UpdataInWarehouseFrm
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
			this.uiButton17 = new Sunny.UI.UIButton();
			this.uiButton13 = new Sunny.UI.UIButton();
			this.DateBox = new Sunny.UI.UIDatePicker();
			this.batchBox = new Sunny.UI.UIComboBox();
			this.ProviderBox = new Sunny.UI.UIComboBox();
			this.staffBox = new Sunny.UI.UITextBox();
			this.InWarehouseAccountBox = new Sunny.UI.UITextBox();
			this.StorageLocationBox = new Sunny.UI.UITextBox();
			this.NumberBox = new Sunny.UI.UITextBox();
			this.uiLabel9 = new Sunny.UI.UILabel();
			this.uiLabel7 = new Sunny.UI.UILabel();
			this.uiLabel8 = new Sunny.UI.UILabel();
			this.uiLabel5 = new Sunny.UI.UILabel();
			this.uiLabel3 = new Sunny.UI.UILabel();
			this.uiLabel4 = new Sunny.UI.UILabel();
			this.uiLabel2 = new Sunny.UI.UILabel();
			this.uiLabel1 = new Sunny.UI.UILabel();
			this.remarkBox = new Sunny.UI.UITextBox();
			this.uiLabel10 = new Sunny.UI.UILabel();
			this.MaterialBox = new Sunny.UI.UITextBox();
			this.PagePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// PagePanel
			// 
			this.PagePanel.Controls.Add(this.MaterialBox);
			this.PagePanel.Controls.Add(this.remarkBox);
			this.PagePanel.Controls.Add(this.uiLabel10);
			this.PagePanel.Controls.Add(this.uiButton17);
			this.PagePanel.Controls.Add(this.uiButton13);
			this.PagePanel.Controls.Add(this.DateBox);
			this.PagePanel.Controls.Add(this.batchBox);
			this.PagePanel.Controls.Add(this.ProviderBox);
			this.PagePanel.Controls.Add(this.staffBox);
			this.PagePanel.Controls.Add(this.InWarehouseAccountBox);
			this.PagePanel.Controls.Add(this.StorageLocationBox);
			this.PagePanel.Controls.Add(this.NumberBox);
			this.PagePanel.Controls.Add(this.uiLabel9);
			this.PagePanel.Controls.Add(this.uiLabel7);
			this.PagePanel.Controls.Add(this.uiLabel8);
			this.PagePanel.Controls.Add(this.uiLabel5);
			this.PagePanel.Controls.Add(this.uiLabel3);
			this.PagePanel.Controls.Add(this.uiLabel4);
			this.PagePanel.Controls.Add(this.uiLabel2);
			this.PagePanel.Controls.Add(this.uiLabel1);
			this.PagePanel.Size = new System.Drawing.Size(466, 437);
			this.PagePanel.Validated += new System.EventHandler(this.PagePanel_Validated);
			// 
			// uiButton17
			// 
			this.uiButton17.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uiButton17.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiButton17.ForeSelectedColor = System.Drawing.Color.Empty;
			this.uiButton17.Location = new System.Drawing.Point(107, 357);
			this.uiButton17.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiButton17.Name = "uiButton17";
			this.uiButton17.Radius = 35;
			this.uiButton17.RectSelectedColor = System.Drawing.Color.Empty;
			this.uiButton17.Size = new System.Drawing.Size(100, 35);
			this.uiButton17.StyleCustomMode = true;
			this.uiButton17.TabIndex = 41;
			this.uiButton17.Text = "修 改";
			this.uiButton17.Click += new System.EventHandler(this.uiButton17_Click);
			// 
			// uiButton13
			// 
			this.uiButton13.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uiButton13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.uiButton13.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.uiButton13.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.uiButton13.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.uiButton13.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiButton13.Location = new System.Drawing.Point(260, 357);
			this.uiButton13.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiButton13.Name = "uiButton13";
			this.uiButton13.Radius = 35;
			this.uiButton13.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.uiButton13.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.uiButton13.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.uiButton13.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.uiButton13.Size = new System.Drawing.Size(100, 35);
			this.uiButton13.Style = Sunny.UI.UIStyle.Red;
			this.uiButton13.StyleCustomMode = true;
			this.uiButton13.TabIndex = 40;
			this.uiButton13.Text = "取 消";
			this.uiButton13.Click += new System.EventHandler(this.uiButton13_Click);
			// 
			// DateBox
			// 
			this.DateBox.FillColor = System.Drawing.Color.White;
			this.DateBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.DateBox.Location = new System.Drawing.Point(201, 229);
			this.DateBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DateBox.MaxLength = 10;
			this.DateBox.MinimumSize = new System.Drawing.Size(63, 0);
			this.DateBox.Name = "DateBox";
			this.DateBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.DateBox.Size = new System.Drawing.Size(150, 29);
			this.DateBox.SymbolDropDown = 61555;
			this.DateBox.SymbolNormal = 61555;
			this.DateBox.TabIndex = 39;
			this.DateBox.Text = "2021-03-20";
			this.DateBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.DateBox.Value = new System.DateTime(2021, 3, 20, 19, 28, 3, 26);
			// 
			// batchBox
			// 
			this.batchBox.DisplayMember = "请选择";
			this.batchBox.FillColor = System.Drawing.Color.White;
			this.batchBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.batchBox.Location = new System.Drawing.Point(201, 193);
			this.batchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.batchBox.MinimumSize = new System.Drawing.Size(63, 0);
			this.batchBox.Name = "batchBox";
			this.batchBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.batchBox.Size = new System.Drawing.Size(150, 29);
			this.batchBox.TabIndex = 38;
			this.batchBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.batchBox.ValueMember = "请选择";
			this.batchBox.DropDown += new System.EventHandler(this.batchBox_DropDown);
			this.batchBox.Validated += new System.EventHandler(this.ProviderBox_Validated);
			// 
			// ProviderBox
			// 
			this.ProviderBox.DisplayMember = "请选择";
			this.ProviderBox.FillColor = System.Drawing.Color.White;
			this.ProviderBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.ProviderBox.Location = new System.Drawing.Point(201, 157);
			this.ProviderBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ProviderBox.MinimumSize = new System.Drawing.Size(63, 0);
			this.ProviderBox.Name = "ProviderBox";
			this.ProviderBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.ProviderBox.Size = new System.Drawing.Size(150, 29);
			this.ProviderBox.TabIndex = 37;
			this.ProviderBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.ProviderBox.ValueMember = "请选择";
			this.ProviderBox.DropDown += new System.EventHandler(this.ProviderBox_DropDown);
			this.ProviderBox.Validated += new System.EventHandler(this.ProviderBox_Validated);
			// 
			// staffBox
			// 
			this.staffBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.staffBox.FillColor = System.Drawing.Color.White;
			this.staffBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.staffBox.Location = new System.Drawing.Point(201, 265);
			this.staffBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.staffBox.Maximum = 2147483647D;
			this.staffBox.Minimum = -2147483648D;
			this.staffBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.staffBox.Name = "staffBox";
			this.staffBox.Padding = new System.Windows.Forms.Padding(5);
			this.staffBox.Size = new System.Drawing.Size(150, 29);
			this.staffBox.TabIndex = 34;
			this.staffBox.Watermark = "请输入经办人编号";
			this.staffBox.Validated += new System.EventHandler(this.PagePanel_Validated);
			// 
			// InWarehouseAccountBox
			// 
			this.InWarehouseAccountBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.InWarehouseAccountBox.FillColor = System.Drawing.Color.White;
			this.InWarehouseAccountBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.InWarehouseAccountBox.Location = new System.Drawing.Point(201, 118);
			this.InWarehouseAccountBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.InWarehouseAccountBox.Maximum = 2147483647D;
			this.InWarehouseAccountBox.Minimum = -2147483648D;
			this.InWarehouseAccountBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.InWarehouseAccountBox.Name = "InWarehouseAccountBox";
			this.InWarehouseAccountBox.Padding = new System.Windows.Forms.Padding(5);
			this.InWarehouseAccountBox.Size = new System.Drawing.Size(150, 29);
			this.InWarehouseAccountBox.TabIndex = 35;
			this.InWarehouseAccountBox.Watermark = "请输入入库量";
			this.InWarehouseAccountBox.Validated += new System.EventHandler(this.PagePanel_Validated);
			// 
			// StorageLocationBox
			// 
			this.StorageLocationBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.StorageLocationBox.Enabled = false;
			this.StorageLocationBox.FillColor = System.Drawing.Color.White;
			this.StorageLocationBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.StorageLocationBox.Location = new System.Drawing.Point(201, 82);
			this.StorageLocationBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.StorageLocationBox.Maximum = 2147483647D;
			this.StorageLocationBox.Minimum = -2147483648D;
			this.StorageLocationBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.StorageLocationBox.Name = "StorageLocationBox";
			this.StorageLocationBox.Padding = new System.Windows.Forms.Padding(5);
			this.StorageLocationBox.ReadOnly = true;
			this.StorageLocationBox.Size = new System.Drawing.Size(150, 29);
			this.StorageLocationBox.TabIndex = 32;
			// 
			// NumberBox
			// 
			this.NumberBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.NumberBox.Enabled = false;
			this.NumberBox.FillColor = System.Drawing.Color.White;
			this.NumberBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.NumberBox.Location = new System.Drawing.Point(201, 10);
			this.NumberBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NumberBox.Maximum = 2147483647D;
			this.NumberBox.Minimum = -2147483648D;
			this.NumberBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.NumberBox.Name = "NumberBox";
			this.NumberBox.Padding = new System.Windows.Forms.Padding(5);
			this.NumberBox.ReadOnly = true;
			this.NumberBox.Size = new System.Drawing.Size(150, 29);
			this.NumberBox.TabIndex = 31;
			// 
			// uiLabel9
			// 
			this.uiLabel9.AutoSize = true;
			this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel9.Location = new System.Drawing.Point(114, 270);
			this.uiLabel9.Name = "uiLabel9";
			this.uiLabel9.Size = new System.Drawing.Size(74, 21);
			this.uiLabel9.TabIndex = 30;
			this.uiLabel9.Text = "经办人：";
			this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel7
			// 
			this.uiLabel7.AutoSize = true;
			this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel7.Location = new System.Drawing.Point(114, 233);
			this.uiLabel7.Name = "uiLabel7";
			this.uiLabel7.Size = new System.Drawing.Size(68, 21);
			this.uiLabel7.TabIndex = 29;
			this.uiLabel7.Text = "日  期：";
			this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel8
			// 
			this.uiLabel8.AutoSize = true;
			this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel8.Location = new System.Drawing.Point(114, 50);
			this.uiLabel8.Name = "uiLabel8";
			this.uiLabel8.Size = new System.Drawing.Size(68, 21);
			this.uiLabel8.TabIndex = 28;
			this.uiLabel8.Text = "物  料：";
			this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel5
			// 
			this.uiLabel5.AutoSize = true;
			this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel5.Location = new System.Drawing.Point(114, 161);
			this.uiLabel5.Name = "uiLabel5";
			this.uiLabel5.Size = new System.Drawing.Size(58, 21);
			this.uiLabel5.TabIndex = 27;
			this.uiLabel5.Text = "供应商";
			this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel3
			// 
			this.uiLabel3.AutoSize = true;
			this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel3.Location = new System.Drawing.Point(114, 122);
			this.uiLabel3.Name = "uiLabel3";
			this.uiLabel3.Size = new System.Drawing.Size(74, 21);
			this.uiLabel3.TabIndex = 25;
			this.uiLabel3.Text = "入库量：";
			this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel4
			// 
			this.uiLabel4.AutoSize = true;
			this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel4.Location = new System.Drawing.Point(114, 86);
			this.uiLabel4.Name = "uiLabel4";
			this.uiLabel4.Size = new System.Drawing.Size(68, 21);
			this.uiLabel4.TabIndex = 24;
			this.uiLabel4.Text = "库  位：";
			this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel2
			// 
			this.uiLabel2.AutoSize = true;
			this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel2.Location = new System.Drawing.Point(114, 197);
			this.uiLabel2.Name = "uiLabel2";
			this.uiLabel2.Size = new System.Drawing.Size(63, 21);
			this.uiLabel2.TabIndex = 23;
			this.uiLabel2.Text = "批 次：";
			this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel1
			// 
			this.uiLabel1.AutoSize = true;
			this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel1.Location = new System.Drawing.Point(114, 14);
			this.uiLabel1.Name = "uiLabel1";
			this.uiLabel1.Size = new System.Drawing.Size(68, 21);
			this.uiLabel1.TabIndex = 22;
			this.uiLabel1.Text = "编  号：";
			this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// remarkBox
			// 
			this.remarkBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.remarkBox.FillColor = System.Drawing.Color.White;
			this.remarkBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.remarkBox.Location = new System.Drawing.Point(201, 301);
			this.remarkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.remarkBox.Maximum = 2147483647D;
			this.remarkBox.Minimum = -2147483648D;
			this.remarkBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.remarkBox.Name = "remarkBox";
			this.remarkBox.Padding = new System.Windows.Forms.Padding(5);
			this.remarkBox.Size = new System.Drawing.Size(150, 29);
			this.remarkBox.TabIndex = 36;
			this.remarkBox.Watermark = "请输入汉字";
			this.remarkBox.Validated += new System.EventHandler(this.PagePanel_Validated);
			// 
			// uiLabel10
			// 
			this.uiLabel10.AutoSize = true;
			this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel10.Location = new System.Drawing.Point(114, 308);
			this.uiLabel10.Name = "uiLabel10";
			this.uiLabel10.Size = new System.Drawing.Size(68, 21);
			this.uiLabel10.TabIndex = 35;
			this.uiLabel10.Text = "备  注：";
			this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MaterialBox
			// 
			this.MaterialBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.MaterialBox.Enabled = false;
			this.MaterialBox.FillColor = System.Drawing.Color.White;
			this.MaterialBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.MaterialBox.Location = new System.Drawing.Point(201, 46);
			this.MaterialBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaterialBox.Maximum = 2147483647D;
			this.MaterialBox.Minimum = -2147483648D;
			this.MaterialBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.MaterialBox.Name = "MaterialBox";
			this.MaterialBox.Padding = new System.Windows.Forms.Padding(5);
			this.MaterialBox.Size = new System.Drawing.Size(150, 29);
			this.MaterialBox.TabIndex = 37;
			// 
			// UpdataInWarehouseFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 472);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "UpdataInWarehouseFrm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "更新";
			this.PagePanel.ResumeLayout(false);
			this.PagePanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private Sunny.UI.UILabel uiLabel10;
		private Sunny.UI.UIButton uiButton17;
		private Sunny.UI.UIButton uiButton13;
		private Sunny.UI.UILabel uiLabel9;
		private Sunny.UI.UILabel uiLabel7;
		private Sunny.UI.UILabel uiLabel8;
		private Sunny.UI.UILabel uiLabel5;
		private Sunny.UI.UILabel uiLabel3;
		private Sunny.UI.UILabel uiLabel4;
		private Sunny.UI.UILabel uiLabel2;
		private Sunny.UI.UILabel uiLabel1;
		public Sunny.UI.UITextBox remarkBox;
		public Sunny.UI.UIDatePicker DateBox;
		public Sunny.UI.UIComboBox batchBox;
		public Sunny.UI.UIComboBox ProviderBox;
		public Sunny.UI.UITextBox staffBox;
		public Sunny.UI.UITextBox InWarehouseAccountBox;
		public Sunny.UI.UITextBox StorageLocationBox;
		public Sunny.UI.UITextBox NumberBox;
		public Sunny.UI.UITextBox MaterialBox;
	}
}