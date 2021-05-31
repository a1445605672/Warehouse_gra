
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
            this.lblTitle.Location = new System.Drawing.Point(32, 31);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Size = new System.Drawing.Size(595, 42);
            this.lblTitle.Text = "欢迎进入物料管理系统";
            // 
            // lblSubText
            // 
            this.lblSubText.Text = "物料管理系统V1.2.1";
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 579);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(900, 579);
            this.MinimumSize = new System.Drawing.Size(900, 579);
            this.Name = "FLogin";
            this.SubText = "物料管理系统V1.2.1";
            this.Text = "Form1";
            this.Title = "欢迎进入物料管理系统";
            this.ButtonLoginClick += new System.EventHandler(this.FLogin_ButtonLoginClick);
            this.ButtonCancelClick += new System.EventHandler(this.FLogin_ButtonCancelClick);
            this.ResumeLayout(false);

		}

		#endregion
	}
}