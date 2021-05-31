
namespace Warehouse.工具窗体
{
    partial class Frmaterial
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
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtID = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txtInfo = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txtName = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txtFengdu = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.txtUseFor = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txtSource = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.txtPercent1 = new Sunny.UI.UITextBox();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.txtRich = new Sunny.UI.UITextBox();
            this.comboxState = new Sunny.UI.UIComboBox();
            this.comColor1 = new Sunny.UI.UIComboBox();
            this.comSmell = new Sunny.UI.UIComboBox();
            this.comsuan = new Sunny.UI.UIComboBox();
            this.uiListBox1 = new Sunny.UI.UIListBox();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 678);
            this.pnlBtm.Size = new System.Drawing.Size(623, 55);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(91, 405);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(113, 45);
            this.uiButton1.TabIndex = 3;
            this.uiButton1.Text = "获取类型";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(309, 60);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(136, 46);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "物料编号：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.FillColor = System.Drawing.Color.White;
            this.txtID.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtID.Location = new System.Drawing.Point(438, 60);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Maximum = 2147483647D;
            this.txtID.Minimum = -2147483648D;
            this.txtID.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtID.Name = "txtID";
            this.txtID.Padding = new System.Windows.Forms.Padding(5);
            this.txtID.Size = new System.Drawing.Size(150, 34);
            this.txtID.TabIndex = 5;
            this.txtID.Text = "系统自动生成";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(309, 106);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(136, 46);
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "类型信息：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInfo
            // 
            this.txtInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfo.FillColor = System.Drawing.Color.White;
            this.txtInfo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtInfo.Location = new System.Drawing.Point(438, 111);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInfo.Maximum = 2147483647D;
            this.txtInfo.Minimum = -2147483648D;
            this.txtInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Padding = new System.Windows.Forms.Padding(5);
            this.txtInfo.Size = new System.Drawing.Size(150, 34);
            this.txtInfo.TabIndex = 5;
            this.txtInfo.Text = "左侧选择类型";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(309, 144);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(136, 46);
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "物料名称：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FillColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtName.Location = new System.Drawing.Point(438, 151);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Maximum = 2147483647D;
            this.txtName.Minimum = -2147483648D;
            this.txtName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5);
            this.txtName.Size = new System.Drawing.Size(150, 34);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "请输入物料名称";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(322, 195);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(136, 46);
            this.uiLabel4.TabIndex = 4;
            this.uiLabel4.Text = "丰度：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFengdu
            // 
            this.txtFengdu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFengdu.FillColor = System.Drawing.Color.White;
            this.txtFengdu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtFengdu.Location = new System.Drawing.Point(438, 197);
            this.txtFengdu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFengdu.Maximum = 2147483647D;
            this.txtFengdu.Minimum = -2147483648D;
            this.txtFengdu.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFengdu.Name = "txtFengdu";
            this.txtFengdu.Padding = new System.Windows.Forms.Padding(5);
            this.txtFengdu.Size = new System.Drawing.Size(150, 34);
            this.txtFengdu.TabIndex = 5;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(309, 239);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(136, 46);
            this.uiLabel5.TabIndex = 4;
            this.uiLabel5.Text = "物料状态：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(309, 288);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(136, 46);
            this.uiLabel6.TabIndex = 4;
            this.uiLabel6.Text = "物料颜色：";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(309, 337);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(136, 46);
            this.uiLabel7.TabIndex = 4;
            this.uiLabel7.Text = "物料气味：";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(309, 386);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(136, 46);
            this.uiLabel8.TabIndex = 4;
            this.uiLabel8.Text = "物料用途：";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUseFor
            // 
            this.txtUseFor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUseFor.FillColor = System.Drawing.Color.White;
            this.txtUseFor.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtUseFor.Location = new System.Drawing.Point(438, 393);
            this.txtUseFor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUseFor.Maximum = 2147483647D;
            this.txtUseFor.Minimum = -2147483648D;
            this.txtUseFor.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUseFor.Name = "txtUseFor";
            this.txtUseFor.Padding = new System.Windows.Forms.Padding(5);
            this.txtUseFor.Size = new System.Drawing.Size(150, 34);
            this.txtUseFor.TabIndex = 5;
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel9.Location = new System.Drawing.Point(309, 435);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(136, 46);
            this.uiLabel9.TabIndex = 4;
            this.uiLabel9.Text = "物料来源：";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSource
            // 
            this.txtSource.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSource.FillColor = System.Drawing.Color.White;
            this.txtSource.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSource.Location = new System.Drawing.Point(438, 442);
            this.txtSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSource.Maximum = 2147483647D;
            this.txtSource.Minimum = -2147483648D;
            this.txtSource.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSource.Name = "txtSource";
            this.txtSource.Padding = new System.Windows.Forms.Padding(5);
            this.txtSource.Size = new System.Drawing.Size(150, 34);
            this.txtSource.TabIndex = 5;
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.Location = new System.Drawing.Point(295, 484);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(207, 51);
            this.uiLabel10.TabIndex = 4;
            this.uiLabel10.Text = "物料酸碱度：";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel11.Location = new System.Drawing.Point(295, 533);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(207, 46);
            this.uiLabel11.TabIndex = 4;
            this.uiLabel11.Text = "元素百分比：";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPercent1
            // 
            this.txtPercent1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPercent1.FillColor = System.Drawing.Color.White;
            this.txtPercent1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPercent1.Location = new System.Drawing.Point(438, 540);
            this.txtPercent1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPercent1.Maximum = 2147483647D;
            this.txtPercent1.Minimum = -2147483648D;
            this.txtPercent1.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPercent1.Name = "txtPercent1";
            this.txtPercent1.Padding = new System.Windows.Forms.Padding(5);
            this.txtPercent1.Size = new System.Drawing.Size(150, 34);
            this.txtPercent1.TabIndex = 5;
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel12.Location = new System.Drawing.Point(322, 582);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(136, 46);
            this.uiLabel12.TabIndex = 4;
            this.uiLabel12.Text = "元素量：";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRich
            // 
            this.txtRich.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRich.FillColor = System.Drawing.Color.White;
            this.txtRich.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtRich.Location = new System.Drawing.Point(438, 589);
            this.txtRich.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRich.Maximum = 2147483647D;
            this.txtRich.Minimum = -2147483648D;
            this.txtRich.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRich.Name = "txtRich";
            this.txtRich.Padding = new System.Windows.Forms.Padding(5);
            this.txtRich.Size = new System.Drawing.Size(150, 34);
            this.txtRich.TabIndex = 5;
            // 
            // comboxState
            // 
            this.comboxState.FillColor = System.Drawing.Color.White;
            this.comboxState.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comboxState.Location = new System.Drawing.Point(438, 246);
            this.comboxState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboxState.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboxState.Name = "comboxState";
            this.comboxState.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboxState.Size = new System.Drawing.Size(150, 34);
            this.comboxState.TabIndex = 6;
            this.comboxState.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboxState.Load += new System.EventHandler(this.comboxState_Load);
            // 
            // comColor1
            // 
            this.comColor1.FillColor = System.Drawing.Color.White;
            this.comColor1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comColor1.Location = new System.Drawing.Point(438, 295);
            this.comColor1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comColor1.MinimumSize = new System.Drawing.Size(63, 0);
            this.comColor1.Name = "comColor1";
            this.comColor1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comColor1.Size = new System.Drawing.Size(150, 34);
            this.comColor1.TabIndex = 6;
            this.comColor1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comColor1.Load += new System.EventHandler(this.comColor1_Load);
            // 
            // comSmell
            // 
            this.comSmell.FillColor = System.Drawing.Color.White;
            this.comSmell.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comSmell.Location = new System.Drawing.Point(438, 344);
            this.comSmell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comSmell.MinimumSize = new System.Drawing.Size(63, 0);
            this.comSmell.Name = "comSmell";
            this.comSmell.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comSmell.Size = new System.Drawing.Size(150, 34);
            this.comSmell.TabIndex = 6;
            this.comSmell.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comSmell.Load += new System.EventHandler(this.comSmell_Load);
            // 
            // comsuan
            // 
            this.comsuan.FillColor = System.Drawing.Color.White;
            this.comsuan.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comsuan.Location = new System.Drawing.Point(438, 490);
            this.comsuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comsuan.MinimumSize = new System.Drawing.Size(63, 0);
            this.comsuan.Name = "comsuan";
            this.comsuan.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comsuan.Size = new System.Drawing.Size(150, 34);
            this.comsuan.TabIndex = 7;
            this.comsuan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comsuan.Load += new System.EventHandler(this.comsuan_Load);
            // 
            // uiListBox1
            // 
            this.uiListBox1.FillColor = System.Drawing.Color.White;
            this.uiListBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiListBox1.FormatString = "";
            this.uiListBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiListBox1.Location = new System.Drawing.Point(46, 111);
            this.uiListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiListBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiListBox1.Name = "uiListBox1";
            this.uiListBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiListBox1.Size = new System.Drawing.Size(230, 249);
            this.uiListBox1.TabIndex = 8;
            this.uiListBox1.Text = "uiListBox1";
            this.uiListBox1.Load += new System.EventHandler(this.uiListBox1_Load);
            // 
            // Frmaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 736);
            this.Controls.Add(this.uiListBox1);
            this.Controls.Add(this.comsuan);
            this.Controls.Add(this.comSmell);
            this.Controls.Add(this.comColor1);
            this.Controls.Add(this.comboxState);
            this.Controls.Add(this.txtRich);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.txtPercent1);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.txtUseFor);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.txtFengdu);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiButton1);
            this.Name = "Frmaterial";
            this.Text = "物料管理";
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiButton1, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.txtInfo, 0);
            this.Controls.SetChildIndex(this.uiLabel3, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.Controls.SetChildIndex(this.txtFengdu, 0);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.uiLabel7, 0);
            this.Controls.SetChildIndex(this.uiLabel8, 0);
            this.Controls.SetChildIndex(this.txtUseFor, 0);
            this.Controls.SetChildIndex(this.uiLabel9, 0);
            this.Controls.SetChildIndex(this.txtSource, 0);
            this.Controls.SetChildIndex(this.uiLabel10, 0);
            this.Controls.SetChildIndex(this.uiLabel11, 0);
            this.Controls.SetChildIndex(this.txtPercent1, 0);
            this.Controls.SetChildIndex(this.uiLabel12, 0);
            this.Controls.SetChildIndex(this.txtRich, 0);
            this.Controls.SetChildIndex(this.comboxState, 0);
            this.Controls.SetChildIndex(this.comColor1, 0);
            this.Controls.SetChildIndex(this.comSmell, 0);
            this.Controls.SetChildIndex(this.comsuan, 0);
            this.Controls.SetChildIndex(this.uiListBox1, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtFengdu;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox txtUseFor;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txtSource;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UITextBox txtPercent1;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UITextBox txtRich;
        private Sunny.UI.UIComboBox comboxState;
        private Sunny.UI.UIComboBox comColor1;
        private Sunny.UI.UIComboBox comSmell;
        private Sunny.UI.UIComboBox comsuan;
        public Sunny.UI.UIButton uiButton1;
        public Sunny.UI.UITextBox txtID;
        public Sunny.UI.UITextBox txtInfo;
        public Sunny.UI.UIListBox uiListBox1;
    }
}