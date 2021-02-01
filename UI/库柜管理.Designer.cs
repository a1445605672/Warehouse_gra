
namespace 毕设
{
	partial class 库柜管理
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

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
			this.SuspendLayout();
			// 
			// skinLabel1
			// 
			this.skinLabel1.AutoSize = true;
			this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
			this.skinLabel1.BorderColor = System.Drawing.Color.White;
			this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.skinLabel1.Location = new System.Drawing.Point(57, 67);
			this.skinLabel1.Name = "skinLabel1";
			this.skinLabel1.Size = new System.Drawing.Size(80, 17);
			this.skinLabel1.TabIndex = 0;
			this.skinLabel1.Text = "我是库柜管理";
			// 
			// 库柜管理
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.skinLabel1);
			this.Name = "库柜管理";
			this.Size = new System.Drawing.Size(1207, 640);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CCWin.SkinControl.SkinLabel skinLabel1;
	}
}
