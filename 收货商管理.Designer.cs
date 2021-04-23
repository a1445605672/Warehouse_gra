
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
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(64, 38);
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
            this.uiComboTreeView1.Location = new System.Drawing.Point(235, 38);
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
            this.uiLabel2.Location = new System.Drawing.Point(69, 107);
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
            this.uiTextBox1.Location = new System.Drawing.Point(235, 107);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.Size = new System.Drawing.Size(150, 34);
            this.uiTextBox1.TabIndex = 3;
            // 
            // 收货商管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiComboTreeView1);
            this.Controls.Add(this.uiLabel1);
            this.Name = "收货商管理";
            this.Text = "收货商管理";
            this.ResumeLayout(false);

		}

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboTreeView uiComboTreeView1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox uiTextBox1;
    }
}