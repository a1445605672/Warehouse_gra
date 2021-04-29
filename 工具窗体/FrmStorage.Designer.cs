
namespace Warehouse.工具窗体
{
    partial class FrmStorage
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
            this.txtID = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txtMax = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txtMin = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.txtArea = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.txtComment1 = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.txtLeftVo = new Sunny.UI.UITextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.txtBelongto = new Sunny.UI.UITextBox();
            this.uiListBox1 = new Sunny.UI.UIListBox();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 497);
            this.pnlBtm.Size = new System.Drawing.Size(607, 55);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(296, 120);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(111, 39);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "库位ID";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Enabled = false;
            this.txtID.FillColor = System.Drawing.Color.Silver;
            this.txtID.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtID.Location = new System.Drawing.Point(430, 120);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Maximum = 2147483647D;
            this.txtID.Minimum = -2147483648D;
            this.txtID.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtID.Name = "txtID";
            this.txtID.Padding = new System.Windows.Forms.Padding(5);
            this.txtID.Size = new System.Drawing.Size(150, 39);
            this.txtID.Style = Sunny.UI.UIStyle.Custom;
            this.txtID.TabIndex = 3;
            this.txtID.Text = "系统自动生成";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(296, 179);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(127, 50);
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "库位类型";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboBox1.Location = new System.Drawing.Point(430, 179);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 39);
            this.uiComboBox1.TabIndex = 5;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Load += new System.EventHandler(this.uiComboBox1_Load);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(296, 229);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(111, 49);
            this.uiLabel3.TabIndex = 6;
            this.uiLabel3.Text = "库位上限";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.Click += new System.EventHandler(this.uiLabel3_Click);
            // 
            // txtMax
            // 
            this.txtMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMax.FillColor = System.Drawing.Color.White;
            this.txtMax.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtMax.Location = new System.Drawing.Point(430, 229);
            this.txtMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMax.Maximum = 2147483647D;
            this.txtMax.Minimum = -2147483648D;
            this.txtMax.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMax.Name = "txtMax";
            this.txtMax.Padding = new System.Windows.Forms.Padding(5);
            this.txtMax.Size = new System.Drawing.Size(150, 39);
            this.txtMax.TabIndex = 7;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(296, 278);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(111, 39);
            this.uiLabel4.TabIndex = 6;
            this.uiLabel4.Text = "库位下限";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMin
            // 
            this.txtMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMin.FillColor = System.Drawing.Color.White;
            this.txtMin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtMin.Location = new System.Drawing.Point(430, 278);
            this.txtMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMin.Maximum = 2147483647D;
            this.txtMin.Minimum = -2147483648D;
            this.txtMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMin.Name = "txtMin";
            this.txtMin.Padding = new System.Windows.Forms.Padding(5);
            this.txtMin.Size = new System.Drawing.Size(150, 39);
            this.txtMin.TabIndex = 7;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(276, 340);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(147, 34);
            this.uiLabel5.TabIndex = 6;
            this.uiLabel5.Text = "可存放面积";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtArea
            // 
            this.txtArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArea.FillColor = System.Drawing.Color.White;
            this.txtArea.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtArea.Location = new System.Drawing.Point(430, 340);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArea.Maximum = 2147483647D;
            this.txtArea.Minimum = -2147483648D;
            this.txtArea.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtArea.Name = "txtArea";
            this.txtArea.Padding = new System.Windows.Forms.Padding(5);
            this.txtArea.Size = new System.Drawing.Size(150, 39);
            this.txtArea.TabIndex = 7;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(307, 389);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 39);
            this.uiLabel6.TabIndex = 6;
            this.uiLabel6.Text = "备注";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtComment1
            // 
            this.txtComment1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment1.FillColor = System.Drawing.Color.White;
            this.txtComment1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtComment1.Location = new System.Drawing.Point(430, 389);
            this.txtComment1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComment1.Maximum = 2147483647D;
            this.txtComment1.Minimum = -2147483648D;
            this.txtComment1.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtComment1.Name = "txtComment1";
            this.txtComment1.Padding = new System.Windows.Forms.Padding(5);
            this.txtComment1.Size = new System.Drawing.Size(150, 39);
            this.txtComment1.TabIndex = 7;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(296, 438);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(111, 39);
            this.uiLabel7.TabIndex = 6;
            this.uiLabel7.Text = "剩余体积";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLeftVo
            // 
            this.txtLeftVo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLeftVo.FillColor = System.Drawing.Color.White;
            this.txtLeftVo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtLeftVo.Location = new System.Drawing.Point(430, 438);
            this.txtLeftVo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLeftVo.Maximum = 2147483647D;
            this.txtLeftVo.Minimum = -2147483648D;
            this.txtLeftVo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtLeftVo.Name = "txtLeftVo";
            this.txtLeftVo.Padding = new System.Windows.Forms.Padding(5);
            this.txtLeftVo.Size = new System.Drawing.Size(150, 39);
            this.txtLeftVo.TabIndex = 7;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(86, 386);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(112, 52);
            this.uiButton1.TabIndex = 9;
            this.uiButton1.Text = "选择库柜";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(296, 72);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(111, 38);
            this.uiLabel8.TabIndex = 10;
            this.uiLabel8.Text = "所属库柜";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBelongto
            // 
            this.txtBelongto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBelongto.Enabled = false;
            this.txtBelongto.FillColor = System.Drawing.Color.Silver;
            this.txtBelongto.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtBelongto.Location = new System.Drawing.Point(430, 72);
            this.txtBelongto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBelongto.Maximum = 2147483647D;
            this.txtBelongto.Minimum = -2147483648D;
            this.txtBelongto.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBelongto.Name = "txtBelongto";
            this.txtBelongto.Padding = new System.Windows.Forms.Padding(5);
            this.txtBelongto.Size = new System.Drawing.Size(150, 39);
            this.txtBelongto.Style = Sunny.UI.UIStyle.Custom;
            this.txtBelongto.TabIndex = 11;
            this.txtBelongto.Text = "左侧选择库柜";
            // 
            // uiListBox1
            // 
            this.uiListBox1.FillColor = System.Drawing.Color.White;
            this.uiListBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiListBox1.FormatString = "";
            this.uiListBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiListBox1.Location = new System.Drawing.Point(39, 72);
            this.uiListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiListBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiListBox1.Name = "uiListBox1";
            this.uiListBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiListBox1.Size = new System.Drawing.Size(217, 300);
            this.uiListBox1.TabIndex = 12;
            this.uiListBox1.Text = "uiListBox1";
            this.uiListBox1.Load += new System.EventHandler(this.uiListBox1_Load);
            // 
            // FrmStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 555);
            this.Controls.Add(this.uiListBox1);
            this.Controls.Add(this.txtBelongto);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.txtLeftVo);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.txtComment1);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.uiLabel1);
            this.Name = "FrmStorage";
            this.Text = "库位管理";
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.uiComboBox1, 0);
            this.Controls.SetChildIndex(this.uiLabel3, 0);
            this.Controls.SetChildIndex(this.txtMax, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.Controls.SetChildIndex(this.txtMin, 0);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.txtArea, 0);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.txtComment1, 0);
            this.Controls.SetChildIndex(this.uiLabel7, 0);
            this.Controls.SetChildIndex(this.txtLeftVo, 0);
            this.Controls.SetChildIndex(this.uiButton1, 0);
            this.Controls.SetChildIndex(this.uiLabel8, 0);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.txtBelongto, 0);
            this.Controls.SetChildIndex(this.uiListBox1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtID;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtMax;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtMin;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtArea;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox txtComment1;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox txtLeftVo;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox txtBelongto;
        private Sunny.UI.UIListBox uiListBox1;
    }
}