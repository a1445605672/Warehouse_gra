
namespace Warehouse
{
	partial class FLogin
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
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Location = new System.Drawing.Point(27, 24);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTitle.Size = new System.Drawing.Size(496, 33);
			this.lblTitle.Text = "欢迎进入物料管理系统";
			// 
			// FLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(750, 450);
			this.Name = "FLogin";
			this.Text = "Form1";
			this.Title = "欢迎进入物料管理系统";
			this.ButtonLoginClick += new System.EventHandler(this.FLogin_ButtonLoginClick);
			this.ButtonCancelClick += new System.EventHandler(this.FLogin_ButtonCancelClick);
			this.ResumeLayout(false);

		}

		#endregion
	}
}