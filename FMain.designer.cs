
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
			this.Header.Controls.Add(this.uiImageButton1);
			this.Header.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
			this.Header.Size = new System.Drawing.Size(1200, 71);
			this.Header.Style = Sunny.UI.UIStyle.Custom;
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
			// 
			// FMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 766);
			this.MaximizeBox = false;
			this.Name = "FMain";
			this.Text = "物料管理系统";
			this.Header.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Sunny.UI.UIImageButton uiImageButton1;
	}
}

