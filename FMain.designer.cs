﻿
namespace Warehouse
{
	partial class FMain
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.uiImageButton1 = new Sunny.UI.UIImageButton();
			this.UpdateButton = new Sunny.UI.UISymbolButton();
			this.uiLabel2 = new Sunny.UI.UILabel();
			this.userName = new Sunny.UI.UISymbolButton();
			this.Header.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
			this.SuspendLayout();
			// 
			// Aside
			// 
			this.Aside.ExpandSelectFirst = false;
			this.Aside.LineColor = System.Drawing.Color.Black;
			this.Aside.Location = new System.Drawing.Point(0, 106);
			this.Aside.Size = new System.Drawing.Size(250, 660);
			this.Aside.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.Aside_MenuItemClick);
			// 
			// Header
			// 
			this.Header.BackColor = System.Drawing.Color.Black;
			this.Header.Controls.Add(this.userName);
			this.Header.Controls.Add(this.uiLabel2);
			this.Header.Controls.Add(this.UpdateButton);
			this.Header.Controls.Add(this.uiImageButton1);
			this.Header.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
			this.Header.Size = new System.Drawing.Size(1200, 71);
			this.Header.Style = Sunny.UI.UIStyle.Custom;
			this.Header.Text = "";
			// 
			// uiImageButton1
			// 
			this.uiImageButton1.BackgroundImage = global::Warehouse.Properties.Resources.物料管理;
			this.uiImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.uiImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uiImageButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiImageButton1.Location = new System.Drawing.Point(0, -12);
			this.uiImageButton1.Name = "uiImageButton1";
			this.uiImageButton1.Size = new System.Drawing.Size(348, 104);
			this.uiImageButton1.TabIndex = 0;
			this.uiImageButton1.TabStop = false;
			this.uiImageButton1.Text = null;
			// 
			// UpdateButton
			// 
			this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UpdateButton.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.UpdateButton.Location = new System.Drawing.Point(1142, 29);
			this.UpdateButton.Margin = new System.Windows.Forms.Padding(1);
			this.UpdateButton.MinimumSize = new System.Drawing.Size(1, 1);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.RightTop | Sunny.UI.UICornerRadiusSides.RightBottom)));
			this.UpdateButton.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.UpdateButton.Size = new System.Drawing.Size(58, 42);
			this.UpdateButton.Symbol = 61473;
			this.UpdateButton.TabIndex = 45;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// uiLabel2
			// 
			this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel2.Location = new System.Drawing.Point(510, 29);
			this.uiLabel2.Name = "uiLabel2";
			this.uiLabel2.Size = new System.Drawing.Size(100, 23);
			this.uiLabel2.TabIndex = 47;
			this.uiLabel2.Text = "uiLabel2";
			this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.uiLabel2.Visible = false;
			// 
			// userName
			// 
			this.userName.Cursor = System.Windows.Forms.Cursors.Hand;
			this.userName.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.userName.ForeSelectedColor = System.Drawing.Color.Empty;
			this.userName.Location = new System.Drawing.Point(1040, 29);
			this.userName.Margin = new System.Windows.Forms.Padding(1);
			this.userName.MinimumSize = new System.Drawing.Size(1, 1);
			this.userName.Name = "userName";
			this.userName.RectSelectedColor = System.Drawing.Color.Empty;
			this.userName.Size = new System.Drawing.Size(100, 42);
			this.userName.StyleCustomMode = true;
			this.userName.Symbol = 61447;
			this.userName.TabIndex = 48;
			this.userName.Text = "Query";
			// 
			// FMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 766);
			this.MaximizeBox = false;
			this.Name = "FMain";
			this.Text = "物料管理系统";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FMain_FormClosed);
			this.Load += new System.EventHandler(this.FMain_Load);
			this.Header.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Sunny.UI.UIImageButton uiImageButton1;
		private Sunny.UI.UISymbolButton UpdateButton;
		private Sunny.UI.UILabel uiLabel2;
		private Sunny.UI.UISymbolButton userName;
	}
}

