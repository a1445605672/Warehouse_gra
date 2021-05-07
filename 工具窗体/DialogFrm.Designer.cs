
namespace Warehouse.工具窗体
{
	partial class DialogFrm
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
			this.uiButton17 = new Sunny.UI.UIButton();
			this.uiButton13 = new Sunny.UI.UIButton();
			this.uiLabel1 = new Sunny.UI.UILabel();
			this.uiLabel2 = new Sunny.UI.UILabel();
			this.Date1 = new Sunny.UI.UIDatePicker();
			this.Date2 = new Sunny.UI.UIDatePicker();
			this.PagePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// PagePanel
			// 
			this.PagePanel.Controls.Add(this.Date2);
			this.PagePanel.Controls.Add(this.Date1);
			this.PagePanel.Controls.Add(this.uiLabel2);
			this.PagePanel.Controls.Add(this.uiLabel1);
			this.PagePanel.Controls.Add(this.uiButton17);
			this.PagePanel.Controls.Add(this.uiButton13);
			this.PagePanel.Size = new System.Drawing.Size(521, 203);
			this.PagePanel.Text = "";
			this.PagePanel.Click += new System.EventHandler(this.PagePanel_Click);
			// 
			// uiButton17
			// 
			this.uiButton17.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uiButton17.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiButton17.ForeSelectedColor = System.Drawing.Color.Empty;
			this.uiButton17.Location = new System.Drawing.Point(124, 141);
			this.uiButton17.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiButton17.Name = "uiButton17";
			this.uiButton17.Radius = 35;
			this.uiButton17.RectSelectedColor = System.Drawing.Color.Empty;
			this.uiButton17.Size = new System.Drawing.Size(100, 35);
			this.uiButton17.StyleCustomMode = true;
			this.uiButton17.TabIndex = 43;
			this.uiButton17.Text = "删 除";
			this.uiButton17.Click += new System.EventHandler(this.uiButton17_Click);
			// 
			// uiButton13
			// 
			this.uiButton13.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uiButton13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.uiButton13.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.uiButton13.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.uiButton13.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.uiButton13.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiButton13.Location = new System.Drawing.Point(277, 141);
			this.uiButton13.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiButton13.Name = "uiButton13";
			this.uiButton13.Radius = 35;
			this.uiButton13.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.uiButton13.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.uiButton13.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.uiButton13.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.uiButton13.Size = new System.Drawing.Size(100, 35);
			this.uiButton13.Style = Sunny.UI.UIStyle.Red;
			this.uiButton13.StyleCustomMode = true;
			this.uiButton13.TabIndex = 42;
			this.uiButton13.Text = "取 消";
			this.uiButton13.Click += new System.EventHandler(this.uiButton13_Click);
			// 
			// uiLabel1
			// 
			this.uiLabel1.AutoSize = true;
			this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel1.Location = new System.Drawing.Point(65, 31);
			this.uiLabel1.Name = "uiLabel1";
			this.uiLabel1.Size = new System.Drawing.Size(74, 21);
			this.uiLabel1.TabIndex = 44;
			this.uiLabel1.Text = "开始时间";
			this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiLabel2
			// 
			this.uiLabel2.AutoSize = true;
			this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel2.Location = new System.Drawing.Point(65, 85);
			this.uiLabel2.Name = "uiLabel2";
			this.uiLabel2.Size = new System.Drawing.Size(74, 21);
			this.uiLabel2.TabIndex = 45;
			this.uiLabel2.Text = "结束时间";
			this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Date1
			// 
			this.Date1.FillColor = System.Drawing.Color.White;
			this.Date1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.Date1.Location = new System.Drawing.Point(160, 31);
			this.Date1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Date1.MaxLength = 10;
			this.Date1.MinimumSize = new System.Drawing.Size(63, 0);
			this.Date1.Name = "Date1";
			this.Date1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.Date1.Size = new System.Drawing.Size(150, 29);
			this.Date1.SymbolDropDown = 61555;
			this.Date1.SymbolNormal = 61555;
			this.Date1.TabIndex = 46;
			this.Date1.Text = "2021-04-28";
			this.Date1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.Date1.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
			// 
			// Date2
			// 
			this.Date2.FillColor = System.Drawing.Color.White;
			this.Date2.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.Date2.Location = new System.Drawing.Point(160, 85);
			this.Date2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Date2.MaxLength = 10;
			this.Date2.MinimumSize = new System.Drawing.Size(63, 0);
			this.Date2.Name = "Date2";
			this.Date2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
			this.Date2.Size = new System.Drawing.Size(150, 29);
			this.Date2.SymbolDropDown = 61555;
			this.Date2.SymbolNormal = 61555;
			this.Date2.TabIndex = 47;
			this.Date2.Text = "2021-04-28";
			this.Date2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.Date2.Value = new System.DateTime(2021, 4, 28, 20, 3, 38, 872);
			// 
			// DialogFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 238);
			this.Name = "DialogFrm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "删除";
			this.Load += new System.EventHandler(this.DialogFrm_Load);
			this.PagePanel.ResumeLayout(false);
			this.PagePanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Sunny.UI.UILabel uiLabel1;
		private Sunny.UI.UIButton uiButton17;
		private Sunny.UI.UIButton uiButton13;
		private Sunny.UI.UILabel uiLabel2;
		private Sunny.UI.UIDatePicker Date2;
		private Sunny.UI.UIDatePicker Date1;
	}
}