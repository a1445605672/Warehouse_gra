﻿
namespace Warehouse
{
	partial class Home
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
			this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
			this.SuspendLayout();
			// 
			// uiSymbolButton1
			// 
			this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uiSymbolButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiSymbolButton1.Location = new System.Drawing.Point(275, 174);
			this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiSymbolButton1.Name = "uiSymbolButton1";
			this.uiSymbolButton1.Size = new System.Drawing.Size(100, 35);
			this.uiSymbolButton1.TabIndex = 0;
			this.uiSymbolButton1.Text = "工作区";
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.uiSymbolButton1);
			this.Name = "Home";
			this.Text = "Home";
			this.ResumeLayout(false);

		}

		#endregion

		private Sunny.UI.UISymbolButton uiSymbolButton1;
	}
}