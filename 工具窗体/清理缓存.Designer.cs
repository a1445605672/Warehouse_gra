
namespace Warehouse.工具窗体
{
	partial class 清理缓存
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
			this.uiLabel1 = new Sunny.UI.UILabel();
			this.SuspendLayout();
			// 
			// uiLabel1
			// 
			this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiLabel1.Location = new System.Drawing.Point(118, 169);
			this.uiLabel1.Name = "uiLabel1";
			this.uiLabel1.Size = new System.Drawing.Size(349, 85);
			this.uiLabel1.TabIndex = 0;
			this.uiLabel1.Text = "用于清理未完成出入库，的假删除数据";
			this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// 清理缓存
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.uiLabel1);
			this.Name = "清理缓存";
			this.Text = "清理缓存";
			this.ResumeLayout(false);

		}

		#endregion

		private Sunny.UI.UILabel uiLabel1;
	}
}