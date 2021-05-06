
namespace Warehouse
{
    partial class 入库折线图
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
            this.uiLineChart1 = new Sunny.UI.UILineChart();
            this.uiLine1 = new Sunny.UI.UILine();
            this.PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiLine1);
            this.PagePanel.Controls.Add(this.uiLineChart1);
            // 
            // uiLineChart1
            // 
            this.uiLineChart1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiLineChart1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLineChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiLineChart1.Location = new System.Drawing.Point(28, 41);
            this.uiLineChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLineChart1.Name = "uiLineChart1";
            this.uiLineChart1.Size = new System.Drawing.Size(489, 362);
            this.uiLineChart1.TabIndex = 0;
            this.uiLineChart1.Text = "uiLineChart1";
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(28, 6);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(489, 29);
            this.uiLine1.TabIndex = 1;
            this.uiLine1.Text = "月份入库量";
            // 
            // 入库折线图
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "入库折线图";
            this.Text = "入库折线图";
            this.PagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILineChart uiLineChart1;
    }
}