
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
            this.lblTitle.Text = "欢迎进入物料管理系统";
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 664);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1050, 664);
            this.MinimumSize = new System.Drawing.Size(1050, 664);
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