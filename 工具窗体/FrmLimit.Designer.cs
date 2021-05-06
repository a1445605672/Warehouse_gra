
namespace Warehouse.工具窗体
{
    partial class FrmLimit
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
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiTextBox3 = new Sunny.UI.UITextBox();
            this.uiTextBox4 = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Size = new System.Drawing.Size(388, 55);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(99, 75);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(126, 54);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "物料ID：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboBox1.Location = new System.Drawing.Point(207, 75);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 39);
            this.uiComboBox1.TabIndex = 3;
            this.uiComboBox1.Text = "先选择ID";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            this.uiComboBox1.Load += new System.EventHandler(this.uiComboBox1_Load);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(80, 114);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(145, 68);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "物料名称：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(80, 168);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(129, 43);
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "库存上限:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(80, 211);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(129, 43);
            this.uiLabel4.TabIndex = 4;
            this.uiLabel4.Text = "库存下限:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(129, 254);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(80, 43);
            this.uiLabel5.TabIndex = 4;
            this.uiLabel5.Text = "备注:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox1.Location = new System.Drawing.Point(207, 169);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.Size = new System.Drawing.Size(150, 39);
            this.uiTextBox1.TabIndex = 5;
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.FillColor = System.Drawing.Color.White;
            this.uiTextBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox2.Location = new System.Drawing.Point(207, 218);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.Maximum = 2147483647D;
            this.uiTextBox2.Minimum = -2147483648D;
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox2.Size = new System.Drawing.Size(150, 39);
            this.uiTextBox2.TabIndex = 5;
            // 
            // uiTextBox3
            // 
            this.uiTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox3.FillColor = System.Drawing.Color.White;
            this.uiTextBox3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox3.Location = new System.Drawing.Point(207, 267);
            this.uiTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox3.Maximum = 2147483647D;
            this.uiTextBox3.Minimum = -2147483648D;
            this.uiTextBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox3.Name = "uiTextBox3";
            this.uiTextBox3.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox3.Size = new System.Drawing.Size(150, 39);
            this.uiTextBox3.TabIndex = 5;
            // 
            // uiTextBox4
            // 
            this.uiTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox4.FillColor = System.Drawing.Color.White;
            this.uiTextBox4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox4.Location = new System.Drawing.Point(207, 122);
            this.uiTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox4.Maximum = 2147483647D;
            this.uiTextBox4.Minimum = -2147483648D;
            this.uiTextBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox4.Name = "uiTextBox4";
            this.uiTextBox4.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox4.Size = new System.Drawing.Size(150, 39);
            this.uiTextBox4.TabIndex = 6;
            // 
            // FrmLimit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.uiTextBox4);
            this.Controls.Add(this.uiTextBox3);
            this.Controls.Add(this.uiTextBox2);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.uiLabel1);
            this.Name = "FrmLimit";
            this.Text = "库存控制";
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.uiComboBox1, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.uiLabel3, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.uiTextBox1, 0);
            this.Controls.SetChildIndex(this.uiTextBox2, 0);
            this.Controls.SetChildIndex(this.uiTextBox3, 0);
            this.Controls.SetChildIndex(this.uiTextBox4, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UITextBox uiTextBox4;
    }
}