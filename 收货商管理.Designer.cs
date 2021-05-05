
namespace Warehouse
{
	partial class 收货商管理
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
            this.uiComboTreeView1 = new Sunny.UI.UIComboTreeView();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiComboTreeView2 = new Sunny.UI.UIComboTreeView();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLedDisplay1 = new Sunny.UI.UILedDisplay();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.uiRadioButton2 = new Sunny.UI.UIRadioButton();
            this.uiRadioButton1 = new Sunny.UI.UIRadioButton();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiComboTreeView5 = new Sunny.UI.UIComboTreeView();
            this.uiComboTreeView4 = new Sunny.UI.UIComboTreeView();
            this.uiComboTreeView3 = new Sunny.UI.UIComboTreeView();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            this.uiGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(3, 43);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(199, 37);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = " 选择调拨品类：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboTreeView1
            // 
            this.uiComboTreeView1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiComboTreeView1.FillColor = System.Drawing.Color.White;
            this.uiComboTreeView1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboTreeView1.Location = new System.Drawing.Point(183, 43);
            this.uiComboTreeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboTreeView1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboTreeView1.Name = "uiComboTreeView1";
            this.uiComboTreeView1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboTreeView1.Size = new System.Drawing.Size(150, 39);
            this.uiComboTreeView1.TabIndex = 1;
            this.uiComboTreeView1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboTreeView1.NodeSelected += new Sunny.UI.UIComboTreeView.OnNodeSelected(this.uiComboTreeView1_NodeSelected);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(8, 169);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(194, 39);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "填写调拨数量：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox1.Location = new System.Drawing.Point(183, 169);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.Size = new System.Drawing.Size(150, 39);
            this.uiTextBox1.TabIndex = 3;
            this.uiTextBox1.TextChanged += new System.EventHandler(this.uiTextBox1_TextChanged);
            this.uiTextBox1.TabStopChanged += new System.EventHandler(this.uiTextBox1_TabStopChanged);
            this.uiTextBox1.MouseLeave += new System.EventHandler(this.uiTextBox1_MouseLeave);
            this.uiTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.uiTextBox1_Validating);
            this.uiTextBox1.Validated += new System.EventHandler(this.uiTextBox1_Validated);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(8, 102);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(200, 39);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "选择调拨物品：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboTreeView2
            // 
            this.uiComboTreeView2.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiComboTreeView2.FillColor = System.Drawing.Color.White;
            this.uiComboTreeView2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboTreeView2.Location = new System.Drawing.Point(183, 102);
            this.uiComboTreeView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboTreeView2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboTreeView2.Name = "uiComboTreeView2";
            this.uiComboTreeView2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboTreeView2.Size = new System.Drawing.Size(149, 39);
            this.uiComboTreeView2.TabIndex = 6;
            this.uiComboTreeView2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboTreeView2.NodeSelected += new Sunny.UI.UIComboTreeView.OnNodeSelected(this.uiComboTreeView2_NodeSelected);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.flowLayoutPanel3);
            this.uiGroupBox1.Controls.Add(this.flowLayoutPanel2);
            this.uiGroupBox1.Controls.Add(this.flowLayoutPanel1);
            this.uiGroupBox1.Controls.Add(this.uiLabel14);
            this.uiGroupBox1.Controls.Add(this.uiLabel13);
            this.uiGroupBox1.Controls.Add(this.uiLabel5);
            this.uiGroupBox1.Controls.Add(this.uiLedDisplay1);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(13, 48);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(385, 621);
            this.uiGroupBox1.TabIndex = 7;
            this.uiGroupBox1.Text = "调拨源仓库";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(162, 469);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(207, 80);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(162, 319);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(206, 74);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(163, 99);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 191);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // uiLabel14
            // 
            this.uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel14.Location = new System.Drawing.Point(3, 438);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(154, 48);
            this.uiLabel14.TabIndex = 2;
            this.uiLabel14.Text = "所在库位：";
            this.uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel13
            // 
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel13.Location = new System.Drawing.Point(3, 278);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(154, 48);
            this.uiLabel13.TabIndex = 2;
            this.uiLabel13.Text = "所在库柜：";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(3, 77);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(154, 48);
            this.uiLabel5.TabIndex = 2;
            this.uiLabel5.Text = "所在仓库：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLedDisplay1
            // 
            this.uiLedDisplay1.BackColor = System.Drawing.Color.Black;
            this.uiLedDisplay1.ForeColor = System.Drawing.Color.Lime;
            this.uiLedDisplay1.LedBackColor = System.Drawing.Color.DimGray;
            this.uiLedDisplay1.Location = new System.Drawing.Point(162, 35);
            this.uiLedDisplay1.Name = "uiLedDisplay1";
            this.uiLedDisplay1.Size = new System.Drawing.Size(190, 34);
            this.uiLedDisplay1.TabIndex = 1;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(3, 29);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(184, 40);
            this.uiLabel4.TabIndex = 0;
            this.uiLabel4.Text = "在库物品数量：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.uiTextBox1);
            this.uiGroupBox2.Controls.Add(this.uiLabel1);
            this.uiGroupBox2.Controls.Add(this.uiLabel2);
            this.uiGroupBox2.Controls.Add(this.uiComboTreeView2);
            this.uiGroupBox2.Controls.Add(this.uiComboTreeView1);
            this.uiGroupBox2.Controls.Add(this.uiLabel3);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(430, 64);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(531, 252);
            this.uiGroupBox2.TabIndex = 8;
            this.uiGroupBox2.Text = "源仓库";
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.uiLabel8);
            this.uiGroupBox3.Controls.Add(this.uiLabel7);
            this.uiGroupBox3.Controls.Add(this.uiLabel6);
            this.uiGroupBox3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox3.Location = new System.Drawing.Point(524, 326);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Size = new System.Drawing.Size(437, 253);
            this.uiGroupBox3.TabIndex = 9;
            this.uiGroupBox3.Text = "目的仓库";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(8, 173);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(100, 23);
            this.uiLabel8.TabIndex = 0;
            this.uiLabel8.Text = "uiLabel6";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(14, 113);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(100, 23);
            this.uiLabel7.TabIndex = 0;
            this.uiLabel7.Text = "uiLabel6";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(14, 53);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 23);
            this.uiLabel6.TabIndex = 0;
            this.uiLabel6.Text = "uiLabel6";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.uiRadioButton2);
            this.uiGroupBox4.Controls.Add(this.uiRadioButton1);
            this.uiGroupBox4.Controls.Add(this.uiLabel12);
            this.uiGroupBox4.Controls.Add(this.uiComboTreeView5);
            this.uiGroupBox4.Controls.Add(this.uiComboTreeView4);
            this.uiGroupBox4.Controls.Add(this.uiComboTreeView3);
            this.uiGroupBox4.Controls.Add(this.uiLabel9);
            this.uiGroupBox4.Controls.Add(this.uiLabel10);
            this.uiGroupBox4.Controls.Add(this.uiLabel11);
            this.uiGroupBox4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox4.Location = new System.Drawing.Point(430, 326);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.Size = new System.Drawing.Size(531, 343);
            this.uiGroupBox4.TabIndex = 9;
            this.uiGroupBox4.Text = "目的仓库";
            // 
            // uiRadioButton2
            // 
            this.uiRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButton2.Location = new System.Drawing.Point(274, 123);
            this.uiRadioButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton2.Name = "uiRadioButton2";
            this.uiRadioButton2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton2.Size = new System.Drawing.Size(150, 29);
            this.uiRadioButton2.TabIndex = 4;
            this.uiRadioButton2.Text = "自动";
            // 
            // uiRadioButton1
            // 
            this.uiRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButton1.Location = new System.Drawing.Point(173, 123);
            this.uiRadioButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton1.Name = "uiRadioButton1";
            this.uiRadioButton1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton1.Size = new System.Drawing.Size(94, 29);
            this.uiRadioButton1.TabIndex = 3;
            this.uiRadioButton1.Text = "手动";
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel12.Location = new System.Drawing.Point(1, 114);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(166, 38);
            this.uiLabel12.TabIndex = 2;
            this.uiLabel12.Text = "选择分配方式";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboTreeView5
            // 
            this.uiComboTreeView5.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiComboTreeView5.FillColor = System.Drawing.Color.White;
            this.uiComboTreeView5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboTreeView5.Location = new System.Drawing.Point(187, 232);
            this.uiComboTreeView5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboTreeView5.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboTreeView5.Name = "uiComboTreeView5";
            this.uiComboTreeView5.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboTreeView5.Size = new System.Drawing.Size(150, 39);
            this.uiComboTreeView5.TabIndex = 1;
            this.uiComboTreeView5.Text = " ";
            this.uiComboTreeView5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboTreeView4
            // 
            this.uiComboTreeView4.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiComboTreeView4.FillColor = System.Drawing.Color.White;
            this.uiComboTreeView4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboTreeView4.Location = new System.Drawing.Point(187, 173);
            this.uiComboTreeView4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboTreeView4.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboTreeView4.Name = "uiComboTreeView4";
            this.uiComboTreeView4.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboTreeView4.Size = new System.Drawing.Size(150, 39);
            this.uiComboTreeView4.TabIndex = 1;
            this.uiComboTreeView4.Text = " ";
            this.uiComboTreeView4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboTreeView3
            // 
            this.uiComboTreeView3.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiComboTreeView3.FillColor = System.Drawing.Color.White;
            this.uiComboTreeView3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboTreeView3.Location = new System.Drawing.Point(187, 53);
            this.uiComboTreeView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboTreeView3.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboTreeView3.Name = "uiComboTreeView3";
            this.uiComboTreeView3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboTreeView3.Size = new System.Drawing.Size(150, 39);
            this.uiComboTreeView3.TabIndex = 1;
            this.uiComboTreeView3.Text = " ";
            this.uiComboTreeView3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboTreeView3.NodeSelected += new Sunny.UI.UIComboTreeView.OnNodeSelected(this.uiComboTreeView3_NodeSelected);
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel9.Location = new System.Drawing.Point(3, 232);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(130, 35);
            this.uiLabel9.TabIndex = 0;
            this.uiLabel9.Text = "选择库位";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.Location = new System.Drawing.Point(3, 173);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(153, 37);
            this.uiLabel10.TabIndex = 0;
            this.uiLabel10.Text = "选择库柜";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel11.Location = new System.Drawing.Point(3, 53);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(166, 37);
            this.uiLabel11.TabIndex = 0;
            this.uiLabel11.Text = "选择目的仓库";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 收货商管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 701);
            this.Controls.Add(this.uiGroupBox4);
            this.Controls.Add(this.uiGroupBox3);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "收货商管理";
            this.Text = "收货商管理";
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboTreeView uiComboTreeView1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIComboTreeView uiComboTreeView2;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UILedDisplay uiLedDisplay1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private Sunny.UI.UIRadioButton uiRadioButton2;
        private Sunny.UI.UIRadioButton uiRadioButton1;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UIComboTreeView uiComboTreeView5;
        private Sunny.UI.UIComboTreeView uiComboTreeView4;
        private Sunny.UI.UIComboTreeView uiComboTreeView3;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel13;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Sunny.UI.UILabel uiLabel14;
    }
}