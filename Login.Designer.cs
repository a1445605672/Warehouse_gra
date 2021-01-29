
namespace 毕设
{
	partial class Login
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.LoginBut = new CCWin.SkinControl.SkinButton();
			this.LoginAcountText = new CCWin.SkinControl.SkinWaterTextBox();
			this.DownMenuBut = new System.Windows.Forms.Button();
			this.LoginPassWordText = new CCWin.SkinControl.SkinWaterTextBox();
			this.RememberPassCheckBox = new CCWin.SkinControl.SkinCheckBox();
			this.SuspendLayout();
			// 
			// LoginBut
			// 
			this.LoginBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.LoginBut.BackColor = System.Drawing.Color.Transparent;
			this.LoginBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.LoginBut.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
			this.LoginBut.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
			this.LoginBut.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.LoginBut.DownBack = ((System.Drawing.Image)(resources.GetObject("LoginBut.DownBack")));
			this.LoginBut.DrawType = CCWin.SkinControl.DrawStyle.Img;
			this.LoginBut.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.LoginBut.ForeColor = System.Drawing.Color.Black;
			this.LoginBut.Location = new System.Drawing.Point(167, 275);
			this.LoginBut.Margin = new System.Windows.Forms.Padding(0);
			this.LoginBut.MouseBack = ((System.Drawing.Image)(resources.GetObject("LoginBut.MouseBack")));
			this.LoginBut.Name = "LoginBut";
			this.LoginBut.NormlBack = ((System.Drawing.Image)(resources.GetObject("LoginBut.NormlBack")));
			this.LoginBut.Palace = true;
			this.LoginBut.Size = new System.Drawing.Size(162, 38);
			this.LoginBut.TabIndex = 9;
			this.LoginBut.Text = "登        录";
			this.LoginBut.UseVisualStyleBackColor = false;
			// 
			// LoginAcountText
			// 
			this.LoginAcountText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LoginAcountText.Location = new System.Drawing.Point(167, 149);
			this.LoginAcountText.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.LoginAcountText.Multiline = true;
			this.LoginAcountText.Name = "LoginAcountText";
			this.LoginAcountText.Size = new System.Drawing.Size(146, 30);
			this.LoginAcountText.TabIndex = 10;
			this.LoginAcountText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.LoginAcountText.WaterText = "账号";
			// 
			// DownMenuBut
			// 
			this.DownMenuBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DownMenuBut.BackgroundImage")));
			this.DownMenuBut.Location = new System.Drawing.Point(316, 149);
			this.DownMenuBut.Name = "DownMenuBut";
			this.DownMenuBut.Size = new System.Drawing.Size(25, 30);
			this.DownMenuBut.TabIndex = 11;
			this.DownMenuBut.UseVisualStyleBackColor = true;
			this.DownMenuBut.Leave += new System.EventHandler(this.DownMenuBut_Leave);
			this.DownMenuBut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DownMenuBut_MouseUp);
			// 
			// LoginPassWordText
			// 
			this.LoginPassWordText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LoginPassWordText.Location = new System.Drawing.Point(167, 185);
			this.LoginPassWordText.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.LoginPassWordText.Multiline = true;
			this.LoginPassWordText.Name = "LoginPassWordText";
			this.LoginPassWordText.Size = new System.Drawing.Size(146, 30);
			this.LoginPassWordText.TabIndex = 12;
			this.LoginPassWordText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.LoginPassWordText.WaterText = "密码";
			// 
			// RememberPassCheckBox
			// 
			this.RememberPassCheckBox.AutoSize = true;
			this.RememberPassCheckBox.BackColor = System.Drawing.Color.Transparent;
			this.RememberPassCheckBox.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.RememberPassCheckBox.DownBack = null;
			this.RememberPassCheckBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.RememberPassCheckBox.Location = new System.Drawing.Point(167, 221);
			this.RememberPassCheckBox.MouseBack = null;
			this.RememberPassCheckBox.Name = "RememberPassCheckBox";
			this.RememberPassCheckBox.NormlBack = null;
			this.RememberPassCheckBox.SelectedDownBack = null;
			this.RememberPassCheckBox.SelectedMouseBack = null;
			this.RememberPassCheckBox.SelectedNormlBack = null;
			this.RememberPassCheckBox.Size = new System.Drawing.Size(75, 21);
			this.RememberPassCheckBox.TabIndex = 13;
			this.RememberPassCheckBox.Text = "记住密码";
			this.RememberPassCheckBox.UseVisualStyleBackColor = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(496, 353);
			this.Controls.Add(this.RememberPassCheckBox);
			this.Controls.Add(this.LoginPassWordText);
			this.Controls.Add(this.DownMenuBut);
			this.Controls.Add(this.LoginAcountText);
			this.Controls.Add(this.LoginBut);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "Login";
			this.ShowDrawIcon = false;
			this.ShowIcon = false;
			this.Text = "登录";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CCWin.SkinControl.SkinButton LoginBut;
		private CCWin.SkinControl.SkinWaterTextBox LoginAcountText;
		private System.Windows.Forms.Button DownMenuBut;
		private CCWin.SkinControl.SkinWaterTextBox LoginPassWordText;
		private CCWin.SkinControl.SkinCheckBox RememberPassCheckBox;
	}
}