
namespace Warehouse
{
	partial class 入库登记
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
			this.SaveBut = new Sunny.UI.UIButton();
			this.OutWarehouseBut = new Sunny.UI.UIButton();
			this.uiLabel10 = new Sunny.UI.UILabel();
			this.remarkBox = new Sunny.UI.UITextBox();
			this.uiLabel9 = new Sunny.UI.UILabel();
			this.staffBox = new Sunny.UI.UITextBox();
			this.uiLabel8 = new Sunny.UI.UILabel();
			this.uiLabel7 = new Sunny.UI.UILabel();
			this.uiLabel6 = new Sunny.UI.UILabel();
			this.uiLabel5 = new Sunny.UI.UILabel();
			this.weightBox = new Sunny.UI.UITextBox();
			this.uiLabel4 = new Sunny.UI.UILabel();
			this.inWarehouseAmount = new Sunny.UI.UITextBox();
			this.uiLabel3 = new Sunny.UI.UILabel();
			this.uiLabel1 = new Sunny.UI.UILabel();
			this.uiLabel2 = new Sunny.UI.UILabel();
			this.InWarwhouseNumberBox = new Sunny.UI.UITextBox();
			this.uiLabel11 = new Sunny.UI.UILabel();
			this.volumeBox = new Sunny.UI.UITextBox();
			this.unitLabel = new Sunny.UI.UILabel();
			this.batchNumberBox = new Sunny.UI.UIComboBox();
			this.ProviderBox = new Sunny.UI.UIComboBox();
			this.Materialsbox = new Sunny.UI.UIComboBox();
			this.edtDate = new Sunny.UI.UIDatePicker();
			this.uiLabel12 = new Sunny.UI.UILabel();
			this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
			this.自动入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.手动入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.批量入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Way = new Sunny.UI.UISymbolButton();
			this.storageLocationBox = new Sunny.UI.UIComboBox();
			this.PagePanel.SuspendLayout();
			this.uiContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// PagePanel
			// 
			this.PagePanel.Controls.Add(this.storageLocationBox);
			this.PagePanel.Controls.Add(this.Way);
			this.PagePanel.Controls.Add(this.uiLabel12);
			this.PagePanel.Controls.Add(this.edtDate);
			this.PagePanel.Controls.Add(this.Materialsbox);
			this.PagePanel.Controls.Add(this.ProviderBox);
			this.PagePanel.Controls.Add(this.batchNumberBox);
			this.PagePanel.Controls.Add(this.unitLabel);
			this.PagePanel.Controls.Add(this.uiLabel11);
			this.PagePanel.Controls.Add(this.volumeBox);
			this.PagePanel.Controls.Add(this.SaveBut);
			this.PagePanel.Controls.Add(this.OutWarehouseBut);
			this.PagePanel.Controls.Add(this.uiLabel10);
			this.PagePanel.Controls.Add(this.remarkBox);
			this.PagePanel.Controls.Add(this.uiLabel9);
			this.PagePanel.Controls.Add(this.staffBox);
			this.PagePanel.Controls.Add(this.uiLabel8);
			this.PagePanel.Controls.Add(this.uiLabel7);
			this.PagePanel.Controls.Add(this.uiLabel6);
			this.PagePanel.Controls.Add(this.uiLabel5);
			this.PagePanel.Controls.Add(this.weightBox);
			this.PagePanel.Controls.Add(this.uiLabel4);
			this.PagePanel.Controls.Add(this.inWarehouseAmount);
			this.PagePanel.Controls.Add(this.uiLabel3);
			this.PagePanel.Controls.Add(this.uiLabel1);
			this.PagePanel.Controls.Add(this.uiLabel2);
			this.PagePanel.Controls.Add(this.InWarwhouseNumberBox);
			this.PagePanel.Size = new System.Drawing.Size(950, 625);
			// 
			// SaveBut
			// 
			this.SaveBut.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SaveBut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.SaveBut.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.SaveBut.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.SaveBut.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.SaveBut.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.SaveBut.Location = new System.Drawing.Point(310, 528);
			this.SaveBut.MinimumSize = new System.Drawing.Size(1, 1);
			this.SaveBut.Name = "SaveBut";
			this.SaveBut.Radius = 35;
			this.SaveBut.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.SaveBut.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.SaveBut.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.SaveBut.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.SaveBut.Size = new System.Drawing.Size(100, 35);
			this.SaveBut.Style = Sunny.UI.UIStyle.Green;
			this.SaveBut.StyleCustomMode = true;
			this.SaveBut.TabIndex = 48;
			this.SaveBut.Text = "保存";
			this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
			// 
			// OutWarehouseBut
			// 
			this.OutWarehouseBut.Cursor = System.Windows.Forms.Cursors.Hand;
			this.OutWarehouseBut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.OutWarehouseBut.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.OutWarehouseBut.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.OutWarehouseBut.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.OutWarehouseBut.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.OutWarehouseBut.Location = new System.Drawing.Point(506, 528);
			this.OutWarehouseBut.MinimumSize = new System.Drawing.Size(1, 1);
			this.OutWarehouseBut.Name = "OutWarehouseBut";
			this.OutWarehouseBut.Radius = 35;
			this.OutWarehouseBut.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.OutWarehouseBut.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.OutWarehouseBut.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.OutWarehouseBut.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.OutWarehouseBut.Size = new System.Drawing.Size(100, 35);
			this.OutWarehouseBut.Style = Sunny.UI.UIStyle.Red;
			this.OutWarehouseBut.StyleCustomMode = true;
			this.OutWarehouseBut.TabIndex = 47;
			this.OutWarehouseBut.Text = "入库";
			this.OutWarehouseBut.Click += new System.EventHandler(this.OutWarehouseBut_Click);
			// 
			// uiLabel10
			// 
			this.uiLabel10.AutoSize = true;
			this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel10.Location = new System.Drawing.Point(306, 448);
			this.uiLabel10.Name = "uiLabel10";
			this.uiLabel10.Size = new System.Drawing.Size(51, 21);
			this.uiLabel10.TabIndex = 46;
			this.uiLabel10.Text = "备 注:";
			this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// remarkBox
			// 
			this.remarkBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.remarkBox.FillColor = System.Drawing.Color.White;
			this.remarkBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.remarkBox.Location = new System.Drawing.Point(385, 444);
			this.remarkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.remarkBox.Maximum = 2147483647D;
			this.remarkBox.Minimum = -2147483648D;
			this.remarkBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.remarkBox.Name = "remarkBox";
			this.remarkBox.Padding = new System.Windows.Forms.Padding(5);
			this.remarkBox.Radius = 10;
			this.remarkBox.Size = new System.Drawing.Size(221, 29);
			this.remarkBox.TabIndex = 45;
			this.remarkBox.Watermark = "请输入汉字";
			this.remarkBox.Validated += new System.EventHandler(this.PagePanel_Validated);
			// 
			// uiLabel9
			// 
			this.uiLabel9.AutoSize = true;
			this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel9.Location = new System.Drawing.Point(306, 411);
			this.uiLabel9.Name = "uiLabel9";
			this.uiLabel9.Size = new System.Drawing.Size(79, 21);
			this.uiLabel9.TabIndex = 44;
			this.uiLabel9.Text = "经办人ID:";
			this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// staffBox
			// 
			this.staffBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.staffBox.FillColor = System.Drawing.Color.White;
			this.staffBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.staffBox.Location = new System.Drawing.Point(385, 407);
			this.staffBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.staffBox.Maximum = 2147483647D;
			this.staffBox.Minimum = -2147483648D;
			this.staffBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.staffBox.Name = "staffBox";
			this.staffBox.Padding = new System.Windows.Forms.Padding(5);
			this.staffBox.Radius = 10;
			this.staffBox.Size = new System.Drawing.Size(221, 29);
			this.staffBox.TabIndex = 43;
			this.staffBox.Watermark = "请输入经办人编号";
			this.staffBox.Validated += new System.EventHandler(this.PagePanel_Validated);
			// 
			// uiLabel8
			// 
			this.uiLabel8.AutoSize = true;
			this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel8.Location = new System.Drawing.Point(306, 374);
			this.uiLabel8.Name = "uiLabel8";
			this.uiLabel8.Size = new System.Drawing.Size(51, 21);
			this.uiLabel8.TabIndex = 42;
			this.uiLabel8.Text = "日 期:";
			this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel7
			// 
			this.uiLabel7.AutoSize = true;
			this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel7.Location = new System.Drawing.Point(306, 337);
			this.uiLabel7.Name = "uiLabel7";
			this.uiLabel7.Size = new System.Drawing.Size(51, 21);
			this.uiLabel7.TabIndex = 40;
			this.uiLabel7.Text = "批 次:";
			this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel6
			// 
			this.uiLabel6.AutoSize = true;
			this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel6.Location = new System.Drawing.Point(306, 300);
			this.uiLabel6.Name = "uiLabel6";
			this.uiLabel6.Size = new System.Drawing.Size(51, 21);
			this.uiLabel6.TabIndex = 38;
			this.uiLabel6.Text = "库 位:";
			this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel5
			// 
			this.uiLabel5.AutoSize = true;
			this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel5.Location = new System.Drawing.Point(306, 263);
			this.uiLabel5.Name = "uiLabel5";
			this.uiLabel5.Size = new System.Drawing.Size(78, 21);
			this.uiLabel5.TabIndex = 36;
			this.uiLabel5.Text = "单位重量:";
			this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// weightBox
			// 
			this.weightBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.weightBox.FillColor = System.Drawing.Color.White;
			this.weightBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.weightBox.Location = new System.Drawing.Point(385, 259);
			this.weightBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.weightBox.Maximum = 2147483647D;
			this.weightBox.Minimum = -2147483648D;
			this.weightBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.weightBox.Name = "weightBox";
			this.weightBox.Padding = new System.Windows.Forms.Padding(5);
			this.weightBox.Radius = 10;
			this.weightBox.Size = new System.Drawing.Size(170, 29);
			this.weightBox.TabIndex = 35;
			this.weightBox.Watermark = "请输入单位重量";
			// 
			// uiLabel4
			// 
			this.uiLabel4.AutoSize = true;
			this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel4.Location = new System.Drawing.Point(306, 226);
			this.uiLabel4.Name = "uiLabel4";
			this.uiLabel4.Size = new System.Drawing.Size(62, 21);
			this.uiLabel4.TabIndex = 34;
			this.uiLabel4.Text = "入库量:";
			this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// inWarehouseAmount
			// 
			this.inWarehouseAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.inWarehouseAmount.FillColor = System.Drawing.Color.White;
			this.inWarehouseAmount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.inWarehouseAmount.Location = new System.Drawing.Point(385, 222);
			this.inWarehouseAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.inWarehouseAmount.Maximum = 2147483647D;
			this.inWarehouseAmount.Minimum = -2147483648D;
			this.inWarehouseAmount.MinimumSize = new System.Drawing.Size(1, 1);
			this.inWarehouseAmount.Name = "inWarehouseAmount";
			this.inWarehouseAmount.Padding = new System.Windows.Forms.Padding(5);
			this.inWarehouseAmount.Radius = 10;
			this.inWarehouseAmount.Size = new System.Drawing.Size(221, 29);
			this.inWarehouseAmount.TabIndex = 33;
			this.inWarehouseAmount.Watermark = "请输入库量";
			this.inWarehouseAmount.Validated += new System.EventHandler(this.PagePanel_Validated);
			// 
			// uiLabel3
			// 
			this.uiLabel3.AutoSize = true;
			this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel3.Location = new System.Drawing.Point(306, 152);
			this.uiLabel3.Name = "uiLabel3";
			this.uiLabel3.Size = new System.Drawing.Size(63, 21);
			this.uiLabel3.TabIndex = 32;
			this.uiLabel3.Text = "物 品：";
			this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel1
			// 
			this.uiLabel1.AutoSize = true;
			this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel1.Location = new System.Drawing.Point(306, 78);
			this.uiLabel1.Name = "uiLabel1";
			this.uiLabel1.Size = new System.Drawing.Size(78, 21);
			this.uiLabel1.TabIndex = 28;
			this.uiLabel1.Text = "入库编号:";
			this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel2
			// 
			this.uiLabel2.AutoSize = true;
			this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel2.Location = new System.Drawing.Point(306, 115);
			this.uiLabel2.Name = "uiLabel2";
			this.uiLabel2.Size = new System.Drawing.Size(74, 21);
			this.uiLabel2.TabIndex = 30;
			this.uiLabel2.Text = "供应商：";
			this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// InWarwhouseNumberBox
			// 
			this.InWarwhouseNumberBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.InWarwhouseNumberBox.Enabled = false;
			this.InWarwhouseNumberBox.FillColor = System.Drawing.Color.White;
			this.InWarwhouseNumberBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.InWarwhouseNumberBox.Location = new System.Drawing.Point(385, 74);
			this.InWarwhouseNumberBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.InWarwhouseNumberBox.Maximum = 2147483647D;
			this.InWarwhouseNumberBox.Minimum = -2147483648D;
			this.InWarwhouseNumberBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.InWarwhouseNumberBox.Name = "InWarwhouseNumberBox";
			this.InWarwhouseNumberBox.Padding = new System.Windows.Forms.Padding(5);
			this.InWarwhouseNumberBox.Radius = 10;
			this.InWarwhouseNumberBox.ReadOnly = true;
			this.InWarwhouseNumberBox.Size = new System.Drawing.Size(221, 29);
			this.InWarwhouseNumberBox.TabIndex = 27;
			this.InWarwhouseNumberBox.Watermark = "水印文字";
			// 
			// uiLabel11
			// 
			this.uiLabel11.AutoSize = true;
			this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel11.Location = new System.Drawing.Point(306, 189);
			this.uiLabel11.Name = "uiLabel11";
			this.uiLabel11.Size = new System.Drawing.Size(78, 21);
			this.uiLabel11.TabIndex = 50;
			this.uiLabel11.Text = "单位体积:";
			this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// volumeBox
			// 
			this.volumeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.volumeBox.FillColor = System.Drawing.Color.White;
			this.volumeBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.volumeBox.Location = new System.Drawing.Point(385, 185);
			this.volumeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.volumeBox.Maximum = 2147483647D;
			this.volumeBox.Minimum = -2147483648D;
			this.volumeBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.volumeBox.Name = "volumeBox";
			this.volumeBox.Padding = new System.Windows.Forms.Padding(5);
			this.volumeBox.Radius = 10;
			this.volumeBox.Size = new System.Drawing.Size(170, 29);
			this.volumeBox.TabIndex = 49;
			this.volumeBox.Watermark = "请输入体积";
			this.volumeBox.Validated += new System.EventHandler(this.PagePanel_Validated);
			// 
			// unitLabel
			// 
			this.unitLabel.AutoSize = true;
			this.unitLabel.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.unitLabel.Location = new System.Drawing.Point(562, 189);
			this.unitLabel.Name = "unitLabel";
			this.unitLabel.Size = new System.Drawing.Size(42, 21);
			this.unitLabel.TabIndex = 51;
			this.unitLabel.Text = "立方";
			this.unitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// batchNumberBox
			// 
			this.batchNumberBox.FillColor = System.Drawing.Color.White;
			this.batchNumberBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.batchNumberBox.Location = new System.Drawing.Point(385, 333);
			this.batchNumberBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.batchNumberBox.MinimumSize = new System.Drawing.Size(63, 0);
			this.batchNumberBox.Name = "batchNumberBox";
			this.batchNumberBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.batchNumberBox.Radius = 10;
			this.batchNumberBox.Size = new System.Drawing.Size(221, 29);
			this.batchNumberBox.TabIndex = 52;
			this.batchNumberBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.batchNumberBox.Watermark = "请选择";
			this.batchNumberBox.Validated += new System.EventHandler(this.ProviderBox_Validated_1);
			// 
			// ProviderBox
			// 
			this.ProviderBox.FillColor = System.Drawing.Color.White;
			this.ProviderBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.ProviderBox.Location = new System.Drawing.Point(385, 111);
			this.ProviderBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ProviderBox.MaxDropDownItems = 5;
			this.ProviderBox.MinimumSize = new System.Drawing.Size(63, 0);
			this.ProviderBox.Name = "ProviderBox";
			this.ProviderBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.ProviderBox.Radius = 10;
			this.ProviderBox.Size = new System.Drawing.Size(221, 29);
			this.ProviderBox.TabIndex = 53;
			this.ProviderBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.ProviderBox.Watermark = "请选择";
			this.ProviderBox.Validated += new System.EventHandler(this.ProviderBox_Validated_1);
			// 
			// Materialsbox
			// 
			this.Materialsbox.FillColor = System.Drawing.Color.White;
			this.Materialsbox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.Materialsbox.Location = new System.Drawing.Point(385, 148);
			this.Materialsbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Materialsbox.MinimumSize = new System.Drawing.Size(63, 0);
			this.Materialsbox.Name = "Materialsbox";
			this.Materialsbox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.Materialsbox.Radius = 10;
			this.Materialsbox.Size = new System.Drawing.Size(221, 29);
			this.Materialsbox.TabIndex = 53;
			this.Materialsbox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.Materialsbox.Watermark = "请选择";
			this.Materialsbox.SelectedIndexChanged += new System.EventHandler(this.Materialsbox_SelectedIndexChanged);
			this.Materialsbox.Validated += new System.EventHandler(this.ProviderBox_Validated_1);
			// 
			// edtDate
			// 
			this.edtDate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
			this.edtDate.FillColor = System.Drawing.Color.White;
			this.edtDate.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.edtDate.Location = new System.Drawing.Point(385, 372);
			this.edtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.edtDate.MaxLength = 10;
			this.edtDate.MinimumSize = new System.Drawing.Size(63, 0);
			this.edtDate.Name = "edtDate";
			this.edtDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.edtDate.Radius = 10;
			this.edtDate.Size = new System.Drawing.Size(221, 29);
			this.edtDate.SymbolDropDown = 61555;
			this.edtDate.SymbolNormal = 61555;
			this.edtDate.TabIndex = 6;
			this.edtDate.Text = "2021-03-04";
			this.edtDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.edtDate.Value = new System.DateTime(2021, 3, 4, 0, 0, 0, 0);
			// 
			// uiLabel12
			// 
			this.uiLabel12.AutoSize = true;
			this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel12.Location = new System.Drawing.Point(562, 263);
			this.uiLabel12.Name = "uiLabel12";
			this.uiLabel12.Size = new System.Drawing.Size(20, 21);
			this.uiLabel12.TabIndex = 54;
			this.uiLabel12.Text = "g";
			this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiContextMenuStrip1
			// 
			this.uiContextMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动入库ToolStripMenuItem,
            this.手动入库ToolStripMenuItem,
            this.批量入库ToolStripMenuItem});
			this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
			this.uiContextMenuStrip1.Size = new System.Drawing.Size(145, 82);
			// 
			// 自动入库ToolStripMenuItem
			// 
			this.自动入库ToolStripMenuItem.Name = "自动入库ToolStripMenuItem";
			this.自动入库ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
			this.自动入库ToolStripMenuItem.Text = "自动入库";
			this.自动入库ToolStripMenuItem.Click += new System.EventHandler(this.自动入库ToolStripMenuItem_Click);
			// 
			// 手动入库ToolStripMenuItem
			// 
			this.手动入库ToolStripMenuItem.Name = "手动入库ToolStripMenuItem";
			this.手动入库ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
			this.手动入库ToolStripMenuItem.Text = "手动入库";
			this.手动入库ToolStripMenuItem.Click += new System.EventHandler(this.手动入库ToolStripMenuItem_Click);
			// 
			// 批量入库ToolStripMenuItem
			// 
			this.批量入库ToolStripMenuItem.Name = "批量入库ToolStripMenuItem";
			this.批量入库ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
			this.批量入库ToolStripMenuItem.Text = "批量入库";
			this.批量入库ToolStripMenuItem.Click += new System.EventHandler(this.批量入库ToolStripMenuItem_Click);
			// 
			// Way
			// 
			this.Way.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Way.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.Way.ForeSelectedColor = System.Drawing.Color.Empty;
			this.Way.Location = new System.Drawing.Point(29, 16);
			this.Way.MinimumSize = new System.Drawing.Size(1, 1);
			this.Way.Name = "Way";
			this.Way.RectSelectedColor = System.Drawing.Color.Empty;
			this.Way.Size = new System.Drawing.Size(100, 35);
			this.Way.StyleCustomMode = true;
			this.Way.Symbol = 61498;
			this.Way.TabIndex = 57;
			this.Way.Text = "入库方式";
			this.Way.Click += new System.EventHandler(this.Way_Click);
			// 
			// storageLocationBox
			// 
			this.storageLocationBox.FillColor = System.Drawing.Color.White;
			this.storageLocationBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.storageLocationBox.Location = new System.Drawing.Point(385, 296);
			this.storageLocationBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.storageLocationBox.MinimumSize = new System.Drawing.Size(63, 0);
			this.storageLocationBox.Name = "storageLocationBox";
			this.storageLocationBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.storageLocationBox.Radius = 10;
			this.storageLocationBox.Size = new System.Drawing.Size(221, 29);
			this.storageLocationBox.TabIndex = 58;
			this.storageLocationBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.storageLocationBox.Watermark = "请选择";
			// 
			// 入库登记
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(950, 660);
			this.Name = "入库登记";
			this.Text = "入库登记";
			this.Load += new System.EventHandler(this.入库登记_Load);
			this.Controls.SetChildIndex(this.PagePanel, 0);
			this.PagePanel.ResumeLayout(false);
			this.PagePanel.PerformLayout();
			this.uiContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Sunny.UI.UIButton SaveBut;
		private Sunny.UI.UIButton OutWarehouseBut;
		private Sunny.UI.UILabel uiLabel10;
		private Sunny.UI.UITextBox remarkBox;
		private Sunny.UI.UILabel uiLabel9;
		private Sunny.UI.UITextBox staffBox;
		private Sunny.UI.UILabel uiLabel8;
		private Sunny.UI.UILabel uiLabel7;
		private Sunny.UI.UILabel uiLabel6;
		private Sunny.UI.UILabel uiLabel5;
		private Sunny.UI.UITextBox weightBox;
		private Sunny.UI.UILabel uiLabel4;
		private Sunny.UI.UITextBox inWarehouseAmount;
		private Sunny.UI.UILabel uiLabel3;
		private Sunny.UI.UILabel uiLabel1;
		private Sunny.UI.UILabel uiLabel2;
		private Sunny.UI.UITextBox InWarwhouseNumberBox;
		private Sunny.UI.UIComboBox Materialsbox;
		private Sunny.UI.UIComboBox ProviderBox;
		private Sunny.UI.UIComboBox batchNumberBox;
		private Sunny.UI.UILabel unitLabel;
		private Sunny.UI.UILabel uiLabel11;
		private Sunny.UI.UITextBox volumeBox;
		private Sunny.UI.UIDatePicker edtDate;
		private Sunny.UI.UILabel uiLabel12;
		private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 自动入库ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 手动入库ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 批量入库ToolStripMenuItem;
		private Sunny.UI.UISymbolButton Way;
		private Sunny.UI.UIComboBox storageLocationBox;
	}
}