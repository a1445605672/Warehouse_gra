
namespace Warehouse
{
    partial class 柱状图
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
            this.BarChart = new Sunny.UI.UIBarChart();
            this.PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.BarChart);
            // 
            // BarChart
            // 
            this.BarChart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BarChart.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.BarChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BarChart.Location = new System.Drawing.Point(137, 29);
            this.BarChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.BarChart.Name = "BarChart";
            this.BarChart.Size = new System.Drawing.Size(498, 362);
            this.BarChart.TabIndex = 0;
            this.BarChart.Text = "uiBarChart1";
            // 
            // 柱状图
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "柱状图";
            this.Text = "柱状图";
            this.PagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIBarChart BarChart;
    }
}