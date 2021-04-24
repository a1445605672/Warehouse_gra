
namespace Warehouse
{
	partial class 出库登记
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
			this.uiPagination1 = new Sunny.UI.UIPagination();
			this.uiPanel1 = new Sunny.UI.UIPanel();
			this.InWearhouseNumber = new Sunny.UI.UILabel();
			this.outWarehouseAmountLabel = new Sunny.UI.UILabel();
			this.storageLocationBox = new Sunny.UI.UITextBox();
			this.Materialsbox = new Sunny.UI.UITextBox();
			this.Material_ID_Label = new Sunny.UI.UILabel();
			this.OutWarwhouseNumberBox = new Sunny.UI.UITextBox();
			this.remarkBox = new Sunny.UI.UITextBox();
			this.staffBox = new Sunny.UI.UITextBox();
			this.edtDate = new Sunny.UI.UIDatePicker();
			this.batchNumberBox = new Sunny.UI.UIComboBox();
			this.ProviderBox = new Sunny.UI.UIComboBox();
			this.ReturnBut = new Sunny.UI.UIButton();
			this.SaveBut = new Sunny.UI.UIButton();
			this.OutWarehouseBut = new Sunny.UI.UIButton();
			this.uiLabel10 = new Sunny.UI.UILabel();
			this.uiLabel9 = new Sunny.UI.UILabel();
			this.uiLabel8 = new Sunny.UI.UILabel();
			this.uiLabel7 = new Sunny.UI.UILabel();
			this.uiLabel5 = new Sunny.UI.UILabel();
			this.outWarehouseAmountBox = new Sunny.UI.UITextBox();
			this.uiLabel4 = new Sunny.UI.UILabel();
			this.uiLabel3 = new Sunny.UI.UILabel();
			this.uiLabel1 = new Sunny.UI.UILabel();
			this.uiLabel2 = new Sunny.UI.UILabel();
			this.SelectMaterialsbox = new Sunny.UI.UIComboBox();
			this.uiLabel11 = new Sunny.UI.UILabel();
			this.SearchBut = new Sunny.UI.UIButton();
			this.PagePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
			this.uiPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// PagePanel
			// 
			this.PagePanel.Controls.Add(this.SearchBut);
			this.PagePanel.Controls.Add(this.uiLabel11);
			this.PagePanel.Controls.Add(this.SelectMaterialsbox);
			this.PagePanel.Size = new System.Drawing.Size(950, 42);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// uiDataGridView1
			// 
			this.uiDataGridView1.AllowUserToAddRows = false;
			this.uiDataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
			this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			this.uiDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.uiDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.uiDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.uiDataGridView1.ColumnHeadersHeight = 32;
			this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
			this.uiDataGridView1.Location = new System.Drawing.Point(0, 77);
			this.uiDataGridView1.MultiSelect = false;
			this.uiDataGridView1.Name = "uiDataGridView1";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F);
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.uiDataGridView1.RowHeadersVisible = false;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
			this.uiDataGridView1.RowTemplate.Height = 29;
			this.uiDataGridView1.SelectedIndex = -1;
			this.uiDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.uiDataGridView1.ShowRect = false;
			this.uiDataGridView1.Size = new System.Drawing.Size(950, 544);
			this.uiDataGridView1.TabIndex = 2;
			this.uiDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellContentClick);
			// 
			// uiPagination1
			// 
			this.uiPagination1.CausesValidation = false;
			this.uiPagination1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.uiPagination1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiPagination1.Location = new System.Drawing.Point(0, 621);
			this.uiPagination1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.uiPagination1.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiPagination1.Name = "uiPagination1";
			this.uiPagination1.PagerCount = 11;
			this.uiPagination1.PageSize = 17;
			this.uiPagination1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
			this.uiPagination1.Size = new System.Drawing.Size(950, 39);
			this.uiPagination1.TabIndex = 3;
			this.uiPagination1.Text = "uiDataGridPage1";
			this.uiPagination1.TotalCount = 40000;
			this.uiPagination1.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.uiPagination1_PageChanged);
			// 
			// uiPanel1
			// 
			this.uiPanel1.Controls.Add(this.InWearhouseNumber);
			this.uiPanel1.Controls.Add(this.outWarehouseAmountLabel);
			this.uiPanel1.Controls.Add(this.storageLocationBox);
			this.uiPanel1.Controls.Add(this.Materialsbox);
			this.uiPanel1.Controls.Add(this.Material_ID_Label);
			this.uiPanel1.Controls.Add(this.OutWarwhouseNumberBox);
			this.uiPanel1.Controls.Add(this.remarkBox);
			this.uiPanel1.Controls.Add(this.staffBox);
			this.uiPanel1.Controls.Add(this.edtDate);
			this.uiPanel1.Controls.Add(this.batchNumberBox);
			this.uiPanel1.Controls.Add(this.ProviderBox);
			this.uiPanel1.Controls.Add(this.ReturnBut);
			this.uiPanel1.Controls.Add(this.SaveBut);
			this.uiPanel1.Controls.Add(this.OutWarehouseBut);
			this.uiPanel1.Controls.Add(this.uiLabel10);
			this.uiPanel1.Controls.Add(this.uiLabel9);
			this.uiPanel1.Controls.Add(this.uiLabel8);
			this.uiPanel1.Controls.Add(this.uiLabel7);
			this.uiPanel1.Controls.Add(this.uiLabel5);
			this.uiPanel1.Controls.Add(this.outWarehouseAmountBox);
			this.uiPanel1.Controls.Add(this.uiLabel4);
			this.uiPanel1.Controls.Add(this.uiLabel3);
			this.uiPanel1.Controls.Add(this.uiLabel1);
			this.uiPanel1.Controls.Add(this.uiLabel2);
			this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiPanel1.Location = new System.Drawing.Point(0, 36);
			this.uiPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiPanel1.Name = "uiPanel1";
			this.uiPanel1.Size = new System.Drawing.Size(950, 625);
			this.uiPanel1.TabIndex = 0;
			this.uiPanel1.Text = null;
			// 
			// InWearhouseNumber
			// 
			this.InWearhouseNumber.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.InWearhouseNumber.Location = new System.Drawing.Point(683, 144);
			this.InWearhouseNumber.Name = "InWearhouseNumber";
			this.InWearhouseNumber.Size = new System.Drawing.Size(177, 28);
			this.InWearhouseNumber.TabIndex = 64;
			this.InWearhouseNumber.Text = "入库编号，隐藏显示";
			this.InWearhouseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.InWearhouseNumber.Visible = false;
			// 
			// outWarehouseAmountLabel
			// 
			this.outWarehouseAmountLabel.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.outWarehouseAmountLabel.Location = new System.Drawing.Point(687, 246);
			this.outWarehouseAmountLabel.Name = "outWarehouseAmountLabel";
			this.outWarehouseAmountLabel.Size = new System.Drawing.Size(157, 25);
			this.outWarehouseAmountLabel.TabIndex = 63;
			this.outWarehouseAmountLabel.Text = "出库数量，隐藏显示";
			this.outWarehouseAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.outWarehouseAmountLabel.Visible = false;
			// 
			// storageLocationBox
			// 
			this.storageLocationBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.storageLocationBox.Enabled = false;
			this.storageLocationBox.FillColor = System.Drawing.Color.White;
			this.storageLocationBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.storageLocationBox.Location = new System.Drawing.Point(395, 204);
			this.storageLocationBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.storageLocationBox.Maximum = 2147483647D;
			this.storageLocationBox.Minimum = -2147483648D;
			this.storageLocationBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.storageLocationBox.Name = "storageLocationBox";
			this.storageLocationBox.Padding = new System.Windows.Forms.Padding(5);
			this.storageLocationBox.ReadOnly = true;
			this.storageLocationBox.Size = new System.Drawing.Size(221, 29);
			this.storageLocationBox.TabIndex = 62;
			this.storageLocationBox.Watermark = "水印文字";
			// 
			// Materialsbox
			// 
			this.Materialsbox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Materialsbox.Enabled = false;
			this.Materialsbox.FillColor = System.Drawing.Color.White;
			this.Materialsbox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Materialsbox.Location = new System.Drawing.Point(395, 166);
			this.Materialsbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Materialsbox.Maximum = 2147483647D;
			this.Materialsbox.Minimum = -2147483648D;
			this.Materialsbox.MinimumSize = new System.Drawing.Size(1, 1);
			this.Materialsbox.Name = "Materialsbox";
			this.Materialsbox.Padding = new System.Windows.Forms.Padding(5);
			this.Materialsbox.ReadOnly = true;
			this.Materialsbox.Size = new System.Drawing.Size(221, 29);
			this.Materialsbox.TabIndex = 62;
			this.Materialsbox.Watermark = "水印文字";
			// 
			// Material_ID_Label
			// 
			this.Material_ID_Label.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.Material_ID_Label.Location = new System.Drawing.Point(683, 91);
			this.Material_ID_Label.Name = "Material_ID_Label";
			this.Material_ID_Label.Size = new System.Drawing.Size(177, 28);
			this.Material_ID_Label.TabIndex = 62;
			this.Material_ID_Label.Text = "物料编号，隐藏显示";
			this.Material_ID_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Material_ID_Label.Visible = false;
			// 
			// OutWarwhouseNumberBox
			// 
			this.OutWarwhouseNumberBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.OutWarwhouseNumberBox.Enabled = false;
			this.OutWarwhouseNumberBox.FillColor = System.Drawing.Color.White;
			this.OutWarwhouseNumberBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.OutWarwhouseNumberBox.Location = new System.Drawing.Point(395, 90);
			this.OutWarwhouseNumberBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.OutWarwhouseNumberBox.Maximum = 2147483647D;
			this.OutWarwhouseNumberBox.Minimum = -2147483648D;
			this.OutWarwhouseNumberBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.OutWarwhouseNumberBox.Name = "OutWarwhouseNumberBox";
			this.OutWarwhouseNumberBox.Padding = new System.Windows.Forms.Padding(5);
			this.OutWarwhouseNumberBox.ReadOnly = true;
			this.OutWarwhouseNumberBox.Size = new System.Drawing.Size(221, 29);
			this.OutWarwhouseNumberBox.TabIndex = 61;
			this.OutWarwhouseNumberBox.Watermark = "水印文字";
			// 
			// remarkBox
			// 
			this.remarkBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.remarkBox.FillColor = System.Drawing.Color.White;
			this.remarkBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.remarkBox.Location = new System.Drawing.Point(395, 395);
			this.remarkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.remarkBox.Maximum = 2147483647D;
			this.remarkBox.Minimum = -2147483648D;
			this.remarkBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.remarkBox.Name = "remarkBox";
			this.remarkBox.Padding = new System.Windows.Forms.Padding(5);
			this.remarkBox.Size = new System.Drawing.Size(221, 29);
			this.remarkBox.TabIndex = 60;
			this.remarkBox.Watermark = "请输入汉字";
			this.remarkBox.Validated += new System.EventHandler(this.uiTextBox5_Validated);
			// 
			// staffBox
			// 
			this.staffBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.staffBox.FillColor = System.Drawing.Color.White;
			this.staffBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.staffBox.Location = new System.Drawing.Point(395, 356);
			this.staffBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.staffBox.Maximum = 2147483647D;
			this.staffBox.Minimum = -2147483648D;
			this.staffBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.staffBox.Name = "staffBox";
			this.staffBox.Padding = new System.Windows.Forms.Padding(5);
			this.staffBox.Size = new System.Drawing.Size(221, 29);
			this.staffBox.TabIndex = 59;
			this.staffBox.Watermark = "请输入经办人编号";
			this.staffBox.Validated += new System.EventHandler(this.uiTextBox5_Validated);
			// 
			// edtDate
			// 
			this.edtDate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
			this.edtDate.FillColor = System.Drawing.Color.White;
			this.edtDate.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.edtDate.Location = new System.Drawing.Point(395, 318);
			this.edtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.edtDate.MaxLength = 10;
			this.edtDate.MinimumSize = new System.Drawing.Size(63, 0);
			this.edtDate.Name = "edtDate";
			this.edtDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.edtDate.Size = new System.Drawing.Size(221, 29);
			this.edtDate.SymbolDropDown = 61555;
			this.edtDate.SymbolNormal = 61555;
			this.edtDate.TabIndex = 58;
			this.edtDate.Text = "2021-03-04";
			this.edtDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.edtDate.Value = new System.DateTime(2021, 3, 4, 0, 0, 0, 0);
			// 
			// batchNumberBox
			// 
			this.batchNumberBox.FillColor = System.Drawing.Color.White;
			this.batchNumberBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.batchNumberBox.Location = new System.Drawing.Point(395, 280);
			this.batchNumberBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.batchNumberBox.MinimumSize = new System.Drawing.Size(63, 0);
			this.batchNumberBox.Name = "batchNumberBox";
			this.batchNumberBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.batchNumberBox.Size = new System.Drawing.Size(221, 29);
			this.batchNumberBox.TabIndex = 57;
			this.batchNumberBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.batchNumberBox.Watermark = "请选择";
			this.batchNumberBox.Validated += new System.EventHandler(this.ProviderBox_Validated);
			// 
			// ProviderBox
			// 
			this.ProviderBox.FillColor = System.Drawing.Color.White;
			this.ProviderBox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.ProviderBox.Location = new System.Drawing.Point(395, 128);
			this.ProviderBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ProviderBox.MaxDropDownItems = 5;
			this.ProviderBox.MinimumSize = new System.Drawing.Size(63, 0);
			this.ProviderBox.Name = "ProviderBox";
			this.ProviderBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.ProviderBox.Size = new System.Drawing.Size(221, 29);
			this.ProviderBox.TabIndex = 54;
			this.ProviderBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.ProviderBox.Watermark = "请选择";
			this.ProviderBox.Validated += new System.EventHandler(this.ProviderBox_Validated);
			// 
			// ReturnBut
			// 
			this.ReturnBut.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ReturnBut.FillColor = System.Drawing.Color.White;
			this.ReturnBut.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
			this.ReturnBut.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
			this.ReturnBut.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
			this.ReturnBut.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.ReturnBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
			this.ReturnBut.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			this.ReturnBut.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
			this.ReturnBut.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
			this.ReturnBut.Location = new System.Drawing.Point(3, 41);
			this.ReturnBut.MinimumSize = new System.Drawing.Size(1, 1);
			this.ReturnBut.Name = "ReturnBut";
			this.ReturnBut.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
			this.ReturnBut.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
			this.ReturnBut.ShowFocusLine = true;
			this.ReturnBut.Size = new System.Drawing.Size(100, 35);
			this.ReturnBut.Style = Sunny.UI.UIStyle.White;
			this.ReturnBut.StyleCustomMode = true;
			this.ReturnBut.TabIndex = 27;
			this.ReturnBut.Text = "返回";
			this.ReturnBut.TipsText = "1";
			this.ReturnBut.Click += new System.EventHandler(this.ReturnBut_Click);
			// 
			// SaveBut
			// 
			this.SaveBut.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SaveBut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.SaveBut.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.SaveBut.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.SaveBut.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.SaveBut.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.SaveBut.Location = new System.Drawing.Point(320, 496);
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
			this.SaveBut.TabIndex = 26;
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
			this.OutWarehouseBut.Location = new System.Drawing.Point(516, 496);
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
			this.OutWarehouseBut.TabIndex = 25;
			this.OutWarehouseBut.Text = "出库";
			this.OutWarehouseBut.Click += new System.EventHandler(this.OutWarehouseBut_Click);
			// 
			// uiLabel10
			// 
			this.uiLabel10.AutoSize = true;
			this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel10.Location = new System.Drawing.Point(316, 398);
			this.uiLabel10.Name = "uiLabel10";
			this.uiLabel10.Size = new System.Drawing.Size(42, 21);
			this.uiLabel10.TabIndex = 24;
			this.uiLabel10.Text = "备注";
			this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel9
			// 
			this.uiLabel9.AutoSize = true;
			this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel9.Location = new System.Drawing.Point(316, 360);
			this.uiLabel9.Name = "uiLabel9";
			this.uiLabel9.Size = new System.Drawing.Size(58, 21);
			this.uiLabel9.TabIndex = 22;
			this.uiLabel9.Text = "经办人";
			this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel8
			// 
			this.uiLabel8.AutoSize = true;
			this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel8.Location = new System.Drawing.Point(316, 322);
			this.uiLabel8.Name = "uiLabel8";
			this.uiLabel8.Size = new System.Drawing.Size(42, 21);
			this.uiLabel8.TabIndex = 20;
			this.uiLabel8.Text = "日期";
			this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel7
			// 
			this.uiLabel7.AutoSize = true;
			this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel7.Location = new System.Drawing.Point(316, 284);
			this.uiLabel7.Name = "uiLabel7";
			this.uiLabel7.Size = new System.Drawing.Size(42, 21);
			this.uiLabel7.TabIndex = 18;
			this.uiLabel7.Text = "批次";
			this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel5
			// 
			this.uiLabel5.AutoSize = true;
			this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel5.Location = new System.Drawing.Point(316, 246);
			this.uiLabel5.Name = "uiLabel5";
			this.uiLabel5.Size = new System.Drawing.Size(58, 21);
			this.uiLabel5.TabIndex = 14;
			this.uiLabel5.Text = "出库量";
			this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// outWarehouseAmountBox
			// 
			this.outWarehouseAmountBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.outWarehouseAmountBox.FillColor = System.Drawing.Color.White;
			this.outWarehouseAmountBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.outWarehouseAmountBox.Location = new System.Drawing.Point(395, 242);
			this.outWarehouseAmountBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.outWarehouseAmountBox.Maximum = 2147483647D;
			this.outWarehouseAmountBox.Minimum = -2147483648D;
			this.outWarehouseAmountBox.MinimumSize = new System.Drawing.Size(1, 1);
			this.outWarehouseAmountBox.Name = "outWarehouseAmountBox";
			this.outWarehouseAmountBox.Padding = new System.Windows.Forms.Padding(5);
			this.outWarehouseAmountBox.Size = new System.Drawing.Size(221, 29);
			this.outWarehouseAmountBox.TabIndex = 13;
			this.outWarehouseAmountBox.Watermark = "请输入出库数量";
			this.outWarehouseAmountBox.Validated += new System.EventHandler(this.uiTextBox5_Validated);
			// 
			// uiLabel4
			// 
			this.uiLabel4.AutoSize = true;
			this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel4.Location = new System.Drawing.Point(316, 208);
			this.uiLabel4.Name = "uiLabel4";
			this.uiLabel4.Size = new System.Drawing.Size(42, 21);
			this.uiLabel4.TabIndex = 12;
			this.uiLabel4.Text = "库位";
			this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel3
			// 
			this.uiLabel3.AutoSize = true;
			this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel3.Location = new System.Drawing.Point(316, 170);
			this.uiLabel3.Name = "uiLabel3";
			this.uiLabel3.Size = new System.Drawing.Size(42, 21);
			this.uiLabel3.TabIndex = 10;
			this.uiLabel3.Text = "物品";
			this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel1
			// 
			this.uiLabel1.AutoSize = true;
			this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel1.Location = new System.Drawing.Point(316, 94);
			this.uiLabel1.Name = "uiLabel1";
			this.uiLabel1.Size = new System.Drawing.Size(74, 21);
			this.uiLabel1.TabIndex = 6;
			this.uiLabel1.Text = "出库编号";
			this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel2
			// 
			this.uiLabel2.AutoSize = true;
			this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel2.Location = new System.Drawing.Point(316, 132);
			this.uiLabel2.Name = "uiLabel2";
			this.uiLabel2.Size = new System.Drawing.Size(58, 21);
			this.uiLabel2.TabIndex = 8;
			this.uiLabel2.Text = "收货商";
			this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SelectMaterialsbox
			// 
			this.SelectMaterialsbox.FillColor = System.Drawing.Color.White;
			this.SelectMaterialsbox.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.SelectMaterialsbox.Location = new System.Drawing.Point(261, 7);
			this.SelectMaterialsbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.SelectMaterialsbox.MaxDropDownItems = 5;
			this.SelectMaterialsbox.MinimumSize = new System.Drawing.Size(63, 0);
			this.SelectMaterialsbox.Name = "SelectMaterialsbox";
			this.SelectMaterialsbox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.SelectMaterialsbox.Size = new System.Drawing.Size(221, 29);
			this.SelectMaterialsbox.TabIndex = 54;
			this.SelectMaterialsbox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.SelectMaterialsbox.Watermark = "请选择";
			// 
			// uiLabel11
			// 
			this.uiLabel11.AutoSize = true;
			this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel11.Location = new System.Drawing.Point(200, 11);
			this.uiLabel11.Name = "uiLabel11";
			this.uiLabel11.Size = new System.Drawing.Size(58, 21);
			this.uiLabel11.TabIndex = 55;
			this.uiLabel11.Text = "物品：";
			this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SearchBut
			// 
			this.SearchBut.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SearchBut.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.SearchBut.Location = new System.Drawing.Point(494, 4);
			this.SearchBut.MinimumSize = new System.Drawing.Size(1, 1);
			this.SearchBut.Name = "SearchBut";
			this.SearchBut.Radius = 35;
			this.SearchBut.Size = new System.Drawing.Size(100, 35);
			this.SearchBut.TabIndex = 56;
			this.SearchBut.Text = "搜  索";
			this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
			// 
			// 出库登记
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(950, 660);
			this.Controls.Add(this.uiPanel1);
			this.Controls.Add(this.uiDataGridView1);
			this.Controls.Add(this.uiPagination1);
			this.Name = "出库登记";
			this.Text = "出库";
			this.Load += new System.EventHandler(this.出库_Load);
			this.Controls.SetChildIndex(this.uiPagination1, 0);
			this.Controls.SetChildIndex(this.uiDataGridView1, 0);
			this.Controls.SetChildIndex(this.uiPanel1, 0);
			this.Controls.SetChildIndex(this.PagePanel, 0);
			this.PagePanel.ResumeLayout(false);
			this.PagePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
			this.uiPanel1.ResumeLayout(false);
			this.uiPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ImageList imageList1;
		private Sunny.UI.UIDataGridView uiDataGridView1;
		private Sunny.UI.UIPagination uiPagination1;
		private Sunny.UI.UIPanel uiPanel1;
		private Sunny.UI.UILabel uiLabel1;
		private Sunny.UI.UILabel uiLabel2;
		private Sunny.UI.UILabel uiLabel10;
		private Sunny.UI.UILabel uiLabel9;
		private Sunny.UI.UILabel uiLabel8;
		private Sunny.UI.UILabel uiLabel7;
		private Sunny.UI.UILabel uiLabel5;
		private Sunny.UI.UITextBox outWarehouseAmountBox;
		private Sunny.UI.UILabel uiLabel4;
		private Sunny.UI.UILabel uiLabel3;
		private Sunny.UI.UIButton ReturnBut;
		private Sunny.UI.UIButton SaveBut;
		private Sunny.UI.UIButton OutWarehouseBut;
		private Sunny.UI.UIComboBox SelectMaterialsbox;
		private Sunny.UI.UIButton SearchBut;
		private Sunny.UI.UILabel uiLabel11;
		private Sunny.UI.UIComboBox ProviderBox;
		private Sunny.UI.UIComboBox batchNumberBox;
		private Sunny.UI.UIDatePicker edtDate;
		private Sunny.UI.UITextBox staffBox;
		private Sunny.UI.UITextBox remarkBox;
		private Sunny.UI.UITextBox OutWarwhouseNumberBox;
		private Sunny.UI.UILabel Material_ID_Label;
		private Sunny.UI.UITextBox storageLocationBox;
		private Sunny.UI.UITextBox Materialsbox;
		private Sunny.UI.UILabel outWarehouseAmountLabel;
		private Sunny.UI.UILabel InWearhouseNumber;
	}
}