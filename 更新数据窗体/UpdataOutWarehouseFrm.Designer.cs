
namespace Warehouse
{
	partial class UpdataFrm
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
			this.uiLabel1 = new Sunny.UI.UILabel();
			this.uiLabel2 = new Sunny.UI.UILabel();
			this.uiLabel3 = new Sunny.UI.UILabel();
			this.uiLabel4 = new Sunny.UI.UILabel();
			this.uiLabel5 = new Sunny.UI.UILabel();
			this.uiLabel6 = new Sunny.UI.UILabel();
			this.staffBox = new Sunny.UI.UITextBox();
			this.Materialsbox = new Sunny.UI.UITextBox();
			this.outWarehouseAmountBox = new Sunny.UI.UITextBox();
			this.uiButton13 = new Sunny.UI.UIButton();
			this.uiButton17 = new Sunny.UI.UIButton();
			this.uiLabel7 = new Sunny.UI.UILabel();
			this.ProviderBox = new Sunny.UI.UIComboBox();
			this.uiLabel8 = new Sunny.UI.UILabel();
			this.OutWarwhouseNumberBox = new Sunny.UI.UITextBox();
			this.remarkBox = new Sunny.UI.UITextBox();
			this.uiLabel10 = new Sunny.UI.UILabel();
			this.batchNumberBox = new Sunny.UI.UIComboBox();
			this.edtDate = new Sunny.UI.UIDatePicker();
			this.PagePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// PagePanel
			// 
			this.PagePanel.Controls.Add(this.edtDate);
			this.PagePanel.Controls.Add(this.batchNumberBox);
			this.PagePanel.Controls.Add(this.remarkBox);
			this.PagePanel.Controls.Add(this.uiLabel10);
			this.PagePanel.Controls.Add(this.OutWarwhouseNumberBox);
			this.PagePanel.Controls.Add(this.uiLabel8);
			this.PagePanel.Controls.Add(this.ProviderBox);
			this.PagePanel.Controls.Add(this.uiLabel7);
			this.PagePanel.Controls.Add(this.uiButton17);
			this.PagePanel.Controls.Add(this.uiButton13);
			this.PagePanel.Controls.Add(this.outWarehouseAmountBox);
			this.PagePanel.Controls.Add(this.Materialsbox);
			this.PagePanel.Controls.Add(this.staffBox);
			this.PagePanel.Controls.Add(this.uiLabel6);
			this.PagePanel.Controls.Add(this.uiLabel5);
			this.PagePanel.Controls.Add(this.uiLabel4);
			this.PagePanel.Controls.Add(this.uiLabel3);
			this.PagePanel.Controls.Add(this.uiLabel2);
			this.PagePanel.Controls.Add(this.uiLabel1);
			this.PagePanel.Size = new System.Drawing.Size(482, 484);
			// 
			// uiLabel1
			// 
			this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel1.Location = new System.Drawing.Point(104, 63);
			this.uiLabel1.Name = "uiLabel1";
			this.uiLabel1.Size = new System.Drawing.Size(100, 23);
			this.uiLabel1.TabIndex = 0;
			this.uiLabel1.Text = "出库编号：";
			this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel2
			// 
			this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel2.Location = new System.Drawing.Point(104, 139);
			this.uiLabel2.Name = "uiLabel2";
			this.uiLabel2.Size = new System.Drawing.Size(100, 23);
			this.uiLabel2.TabIndex = 1;
			this.uiLabel2.Text = "物料名称：";
			this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel3
			// 
			this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel3.Location = new System.Drawing.Point(104, 178);
			this.uiLabel3.Name = "uiLabel3";
			this.uiLabel3.Size = new System.Drawing.Size(100, 23);
			this.uiLabel3.TabIndex = 2;
			this.uiLabel3.Text = "出库量：";
			this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel4
			// 
			this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel4.Location = new System.Drawing.Point(104, 217);
			this.uiLabel4.Name = "uiLabel4";
			this.uiLabel4.Size = new System.Drawing.Size(100, 23);
			this.uiLabel4.TabIndex = 3;
			this.uiLabel4.Text = "批次";
			this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel5
			// 
			this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel5.Location = new System.Drawing.Point(104, 256);
			this.uiLabel5.Name = "uiLabel5";
			this.uiLabel5.Size = new System.Drawing.Size(100, 23);
			this.uiLabel5.TabIndex = 4;
			this.uiLabel5.Text = "日期";
			this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel6
			// 
			this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel6.Location = new System.Drawing.Point(104, 295);
			this.uiLabel6.Name = "uiLabel6";
			this.uiLabel6.Size = new System.Drawing.Size(100, 23);
			this.uiLabel6.TabIndex = 5;
			this.uiLabel6.Text = "经办人";
			this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// staffBox
			// 
			this.staffBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.staffBox.FillColor = System.Drawing.Color.White;
			this.staffBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.staffBox.Location = new System.Drawing.Point(211, 288);
			this.staffBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.staffBox.Maximum = 2147483647D;
			this.staffBox.Minimum = -2147483648D;
			this.staffBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.staffBox.Name = "staffBox";
			this.staffBox.Padding = new System.Windows.Forms.Padding(5);
			this.staffBox.Size = new System.Drawing.Size(150, 29);
			this.staffBox.TabIndex = 7;
			this.staffBox.Text = "请输入经办人编号";
			this.staffBox.Watermark = "请输入经办人编号";
			this.staffBox.Validated += new System.EventHandler(this.outWarehouseAmountBox_Validated);
			// 
			// Materialsbox
			// 
			this.Materialsbox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Materialsbox.Enabled = false;
			this.Materialsbox.FillColor = System.Drawing.Color.White;
			this.Materialsbox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.Materialsbox.Location = new System.Drawing.Point(211, 136);
			this.Materialsbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Materialsbox.Maximum = 2147483647D;
			this.Materialsbox.Minimum = -2147483648D;
			this.Materialsbox.MinimumSize = new System.Drawing.Size(1, 1);
			this.Materialsbox.Name = "Materialsbox";
			this.Materialsbox.Padding = new System.Windows.Forms.Padding(5);
			this.Materialsbox.ReadOnly = true;
			this.Materialsbox.Size = new System.Drawing.Size(150, 29);
			this.Materialsbox.TabIndex = 8;
			// 
			// outWarehouseAmountBox
			// 
			this.outWarehouseAmountBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.outWarehouseAmountBox.FillColor = System.Drawing.Color.White;
			this.outWarehouseAmountBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.outWarehouseAmountBox.Location = new System.Drawing.Point(211, 174);
			this.outWarehouseAmountBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.outWarehouseAmountBox.Maximum = 2147483647D;
			this.outWarehouseAmountBox.Minimum = -2147483648D;
			this.outWarehouseAmountBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.outWarehouseAmountBox.Name = "outWarehouseAmountBox";
			this.outWarehouseAmountBox.Padding = new System.Windows.Forms.Padding(5);
			this.outWarehouseAmountBox.Size = new System.Drawing.Size(150, 29);
			this.outWarehouseAmountBox.TabIndex = 7;
			this.outWarehouseAmountBox.Watermark = "请输入出库量";
			this.outWarehouseAmountBox.Validated += new System.EventHandler(this.outWarehouseAmountBox_Validated);
			// 
			// uiButton13
			// 
			this.uiButton13.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uiButton13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.uiButton13.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.uiButton13.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.uiButton13.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.uiButton13.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiButton13.Location = new System.Drawing.Point(261, 402);
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
			this.uiButton13.TabIndex = 18;
			this.uiButton13.Text = "取 消";
			this.uiButton13.Click += new System.EventHandler(this.uiButton13_Click);
			// 
			// uiButton17
			// 
			this.uiButton17.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uiButton17.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiButton17.ForeSelectedColor = System.Drawing.Color.Empty;
			this.uiButton17.Location = new System.Drawing.Point(108, 402);
			this.uiButton17.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiButton17.Name = "uiButton17";
			this.uiButton17.Radius = 35;
			this.uiButton17.RectSelectedColor = System.Drawing.Color.Empty;
			this.uiButton17.Size = new System.Drawing.Size(100, 35);
			this.uiButton17.StyleCustomMode = true;
			this.uiButton17.TabIndex = 19;
			this.uiButton17.Text = "修 改";
			this.uiButton17.Click += new System.EventHandler(this.uiButton17_Click);
			// 
			// uiLabel7
			// 
			this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel7.Location = new System.Drawing.Point(379, 60);
			this.uiLabel7.Name = "uiLabel7";
			this.uiLabel7.Size = new System.Drawing.Size(100, 23);
			this.uiLabel7.TabIndex = 20;
			this.uiLabel7.Text = "物料编号";
			this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.uiLabel7.Visible = false;
			// 
			// ProviderBox
			// 
			this.ProviderBox.FillColor = System.Drawing.Color.White;
			this.ProviderBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.ProviderBox.Location = new System.Drawing.Point(211, 98);
			this.ProviderBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ProviderBox.MaxDropDownItems = 5;
			this.ProviderBox.MinimumSize = new System.Drawing.Size(63, 0);
			this.ProviderBox.Name = "ProviderBox";
			this.ProviderBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.ProviderBox.Size = new System.Drawing.Size(150, 29);
			this.ProviderBox.TabIndex = 55;
			this.ProviderBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.ProviderBox.Watermark = "请选择";
			this.ProviderBox.DropDown += new System.EventHandler(this.ProviderBox_DropDown);
			this.ProviderBox.Validated += new System.EventHandler(this.ProviderBox_Validated);
			// 
			// uiLabel8
			// 
			this.uiLabel8.AutoSize = true;
			this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel8.Location = new System.Drawing.Point(104, 102);
			this.uiLabel8.Name = "uiLabel8";
			this.uiLabel8.Size = new System.Drawing.Size(58, 21);
			this.uiLabel8.TabIndex = 56;
			this.uiLabel8.Text = "收货商";
			this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// OutWarwhouseNumberBox
			// 
			this.OutWarwhouseNumberBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.OutWarwhouseNumberBox.Enabled = false;
			this.OutWarwhouseNumberBox.FillColor = System.Drawing.Color.White;
			this.OutWarwhouseNumberBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.OutWarwhouseNumberBox.Location = new System.Drawing.Point(211, 60);
			this.OutWarwhouseNumberBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.OutWarwhouseNumberBox.Maximum = 2147483647D;
			this.OutWarwhouseNumberBox.Minimum = -2147483648D;
			this.OutWarwhouseNumberBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.OutWarwhouseNumberBox.Name = "OutWarwhouseNumberBox";
			this.OutWarwhouseNumberBox.Padding = new System.Windows.Forms.Padding(5);
			this.OutWarwhouseNumberBox.ReadOnly = true;
			this.OutWarwhouseNumberBox.Size = new System.Drawing.Size(150, 29);
			this.OutWarwhouseNumberBox.TabIndex = 62;
			this.OutWarwhouseNumberBox.Watermark = "水印文字";
			// 
			// remarkBox
			// 
			this.remarkBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.remarkBox.FillColor = System.Drawing.Color.White;
			this.remarkBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.remarkBox.Location = new System.Drawing.Point(211, 326);
			this.remarkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.remarkBox.Maximum = 2147483647D;
			this.remarkBox.Minimum = -2147483648D;
			this.remarkBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.remarkBox.Name = "remarkBox";
			this.remarkBox.Padding = new System.Windows.Forms.Padding(5);
			this.remarkBox.Size = new System.Drawing.Size(150, 29);
			this.remarkBox.TabIndex = 64;
			this.remarkBox.Watermark = "请输入汉字";
			this.remarkBox.Validated += new System.EventHandler(this.outWarehouseAmountBox_Validated);
			// 
			// uiLabel10
			// 
			this.uiLabel10.AutoSize = true;
			this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel10.Location = new System.Drawing.Point(104, 334);
			this.uiLabel10.Name = "uiLabel10";
			this.uiLabel10.Size = new System.Drawing.Size(42, 21);
			this.uiLabel10.TabIndex = 63;
			this.uiLabel10.Text = "备注";
			this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// batchNumberBox
			// 
			this.batchNumberBox.FillColor = System.Drawing.Color.White;
			this.batchNumberBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.batchNumberBox.Location = new System.Drawing.Point(211, 214);
			this.batchNumberBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.batchNumberBox.MinimumSize = new System.Drawing.Size(63, 0);
			this.batchNumberBox.Name = "batchNumberBox";
			this.batchNumberBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.batchNumberBox.Size = new System.Drawing.Size(150, 29);
			this.batchNumberBox.TabIndex = 65;
			this.batchNumberBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.batchNumberBox.Watermark = "请选择";
			this.batchNumberBox.DropDown += new System.EventHandler(this.batchNumberBox_DropDown);
			this.batchNumberBox.Validated += new System.EventHandler(this.ProviderBox_Validated);
			// 
			// edtDate
			// 
			this.edtDate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
			this.edtDate.FillColor = System.Drawing.Color.White;
			this.edtDate.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.edtDate.Location = new System.Drawing.Point(211, 253);
			this.edtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.edtDate.MaxLength = 10;
			this.edtDate.MinimumSize = new System.Drawing.Size(63, 0);
			this.edtDate.Name = "edtDate";
			this.edtDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.edtDate.Size = new System.Drawing.Size(150, 29);
			this.edtDate.SymbolDropDown = 61555;
			this.edtDate.SymbolNormal = 61555;
			this.edtDate.TabIndex = 59;
			this.edtDate.Text = "2021-03-04";
			this.edtDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.edtDate.Value = new System.DateTime(2021, 3, 4, 0, 0, 0, 0);
			// 
			// UpdataFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 519);
			this.Name = "UpdataFrm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "更  新";
			this.Load += new System.EventHandler(this.UpdataFrm_Load);
			this.PagePanel.ResumeLayout(false);
			this.PagePanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Sunny.UI.UILabel uiLabel6;
		private Sunny.UI.UILabel uiLabel5;
		private Sunny.UI.UILabel uiLabel4;
		private Sunny.UI.UILabel uiLabel3;
		private Sunny.UI.UILabel uiLabel2;
		private Sunny.UI.UILabel uiLabel1;
		private Sunny.UI.UIButton uiButton17;
		private Sunny.UI.UIButton uiButton13;
		private Sunny.UI.UILabel uiLabel7;
		public Sunny.UI.UITextBox outWarehouseAmountBox;
		public Sunny.UI.UITextBox Materialsbox;
		public Sunny.UI.UITextBox staffBox;
		private Sunny.UI.UILabel uiLabel8;
		private Sunny.UI.UILabel uiLabel10;
		public Sunny.UI.UIComboBox ProviderBox;
		public Sunny.UI.UITextBox OutWarwhouseNumberBox;
		public Sunny.UI.UITextBox remarkBox;
		public Sunny.UI.UIComboBox batchNumberBox;
		public Sunny.UI.UIDatePicker edtDate;
	}
}