
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
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLedDisplay1 = new Sunny.UI.UILedDisplay();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(3, 43);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(164, 23);
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
            this.uiComboTreeView1.Size = new System.Drawing.Size(150, 34);
            this.uiComboTreeView1.TabIndex = 1;
            this.uiComboTreeView1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboTreeView1.NodeSelected += new Sunny.UI.UIComboTreeView.OnNodeSelected(this.uiComboTreeView1_NodeSelected);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(8, 169);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(159, 23);
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
            this.uiTextBox1.Size = new System.Drawing.Size(150, 34);
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
            this.uiLabel3.Size = new System.Drawing.Size(159, 23);
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
            this.uiComboTreeView2.Size = new System.Drawing.Size(150, 34);
            this.uiComboTreeView2.TabIndex = 6;
            this.uiComboTreeView2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboTreeView2.NodeSelected += new Sunny.UI.UIComboTreeView.OnNodeSelected(this.uiComboTreeView2_NodeSelected);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiLedDisplay1);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(13, 48);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(406, 326);
            this.uiGroupBox1.TabIndex = 7;
            this.uiGroupBox1.Text = "调拨源仓库";
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
            this.uiGroupBox2.Location = new System.Drawing.Point(476, 48);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(382, 326);
            this.uiGroupBox2.TabIndex = 8;
            this.uiGroupBox2.Text = "uiGroupBox2";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(19, 42);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(177, 23);
            this.uiLabel4.TabIndex = 0;
            this.uiLabel4.Text = "在库物品数量：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // 收货商管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 494);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "收货商管理";
            this.Text = "收货商管理";
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
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
    }
}