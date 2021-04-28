
namespace Warehouse.工具窗体
{
    partial class FormEditRoom
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
            this.RoomName = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.RoomID = new Sunny.UI.UITextBox();
            this.Locationleft = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.RoomArea = new Sunny.UI.UITextBox();
            this.Chestleft = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.backinfo = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Size = new System.Drawing.Size(631, 55);
            // 
            // RoomName
            // 
            this.RoomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomName.FillColor = System.Drawing.Color.White;
            this.RoomName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.RoomName.Location = new System.Drawing.Point(236, 115);
            this.RoomName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoomName.Maximum = 2147483647D;
            this.RoomName.Minimum = -2147483648D;
            this.RoomName.MinimumSize = new System.Drawing.Size(1, 1);
            this.RoomName.Name = "RoomName";
            this.RoomName.Padding = new System.Windows.Forms.Padding(5);
            this.RoomName.Size = new System.Drawing.Size(150, 39);
            this.RoomName.TabIndex = 17;
            this.RoomName.Text = " ";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(103, 115);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(126, 39);
            this.uiLabel2.TabIndex = 15;
            this.uiLabel2.Text = " 房间名称:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(106, 67);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(126, 43);
            this.uiLabel1.TabIndex = 16;
            this.uiLabel1.Text = "房间ID:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RoomID
            // 
            this.RoomID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomID.Enabled = false;
            this.RoomID.FillColor = System.Drawing.Color.Silver;
            this.RoomID.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.RoomID.Location = new System.Drawing.Point(236, 66);
            this.RoomID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoomID.Maximum = 2147483647D;
            this.RoomID.Minimum = -2147483648D;
            this.RoomID.MinimumSize = new System.Drawing.Size(1, 1);
            this.RoomID.Name = "RoomID";
            this.RoomID.Padding = new System.Windows.Forms.Padding(5);
            this.RoomID.Size = new System.Drawing.Size(208, 39);
            this.RoomID.Style = Sunny.UI.UIStyle.Custom;
            this.RoomID.TabIndex = 10;
            this.RoomID.Text = "房间编号系统生成";
            // 
            // Locationleft
            // 
            this.Locationleft.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Locationleft.FillColor = System.Drawing.Color.White;
            this.Locationleft.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Locationleft.Location = new System.Drawing.Point(236, 227);
            this.Locationleft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Locationleft.Maximum = 2147483647D;
            this.Locationleft.Minimum = -2147483648D;
            this.Locationleft.MinimumSize = new System.Drawing.Size(1, 1);
            this.Locationleft.Name = "Locationleft";
            this.Locationleft.Padding = new System.Windows.Forms.Padding(5);
            this.Locationleft.Size = new System.Drawing.Size(150, 39);
            this.Locationleft.TabIndex = 21;
            this.Locationleft.Text = " ";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(106, 227);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(123, 34);
            this.uiLabel3.TabIndex = 19;
            this.uiLabel3.Text = " 库位剩余:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(106, 168);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(126, 43);
            this.uiLabel4.TabIndex = 20;
            this.uiLabel4.Text = "房间面积:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RoomArea
            // 
            this.RoomArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomArea.FillColor = System.Drawing.Color.White;
            this.RoomArea.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.RoomArea.Location = new System.Drawing.Point(236, 172);
            this.RoomArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoomArea.Maximum = 2147483647D;
            this.RoomArea.Minimum = -2147483648D;
            this.RoomArea.MinimumSize = new System.Drawing.Size(1, 1);
            this.RoomArea.Name = "RoomArea";
            this.RoomArea.Padding = new System.Windows.Forms.Padding(5);
            this.RoomArea.Size = new System.Drawing.Size(150, 39);
            this.RoomArea.TabIndex = 18;
            // 
            // Chestleft
            // 
            this.Chestleft.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Chestleft.FillColor = System.Drawing.Color.White;
            this.Chestleft.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Chestleft.Location = new System.Drawing.Point(236, 281);
            this.Chestleft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Chestleft.Maximum = 2147483647D;
            this.Chestleft.Minimum = -2147483648D;
            this.Chestleft.MinimumSize = new System.Drawing.Size(1, 1);
            this.Chestleft.Name = "Chestleft";
            this.Chestleft.Padding = new System.Windows.Forms.Padding(5);
            this.Chestleft.Size = new System.Drawing.Size(150, 39);
            this.Chestleft.TabIndex = 23;
            this.Chestleft.Text = " ";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(106, 281);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(123, 34);
            this.uiLabel5.TabIndex = 22;
            this.uiLabel5.Text = "库柜剩余:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backinfo
            // 
            this.backinfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.backinfo.FillColor = System.Drawing.Color.White;
            this.backinfo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.backinfo.Location = new System.Drawing.Point(236, 335);
            this.backinfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backinfo.Maximum = 2147483647D;
            this.backinfo.Minimum = -2147483648D;
            this.backinfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.backinfo.Name = "backinfo";
            this.backinfo.Padding = new System.Windows.Forms.Padding(5);
            this.backinfo.Size = new System.Drawing.Size(353, 39);
            this.backinfo.TabIndex = 25;
            this.backinfo.Text = " ";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(106, 335);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(123, 34);
            this.uiLabel6.TabIndex = 24;
            this.uiLabel6.Text = "备注信息:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormEditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.backinfo);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.Chestleft);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.Locationleft);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.RoomArea);
            this.Controls.Add(this.RoomName);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.RoomID);
            this.Name = "FormEditRoom";
            this.Text = "编辑房间";
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.RoomID, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.RoomName, 0);
            this.Controls.SetChildIndex(this.RoomArea, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.Controls.SetChildIndex(this.uiLabel3, 0);
            this.Controls.SetChildIndex(this.Locationleft, 0);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.Chestleft, 0);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.backinfo, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox RoomName;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox RoomID;
        private Sunny.UI.UITextBox Locationleft;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox RoomArea;
        private Sunny.UI.UITextBox Chestleft;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox backinfo;
        private Sunny.UI.UILabel uiLabel6;
    }
}