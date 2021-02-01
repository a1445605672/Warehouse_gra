
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
			this.AcountLabel = new System.Windows.Forms.Label();
			this.PwdLabel = new System.Windows.Forms.Label();
			this.AcountmenuList = new System.Windows.Forms.ListBox();
			this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
			this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
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
			this.LoginBut.Location = new System.Drawing.Point(173, 268);
			this.LoginBut.Margin = new System.Windows.Forms.Padding(0);
			this.LoginBut.MouseBack = ((System.Drawing.Image)(resources.GetObject("LoginBut.MouseBack")));
			this.LoginBut.Name = "LoginBut";
			this.LoginBut.NormlBack = ((System.Drawing.Image)(resources.GetObject("LoginBut.NormlBack")));
			this.LoginBut.Palace = true;
			this.LoginBut.Size = new System.Drawing.Size(162, 38);
			this.LoginBut.TabIndex = 9;
			this.LoginBut.Text = "登        录";
			this.LoginBut.UseVisualStyleBackColor = false;
			this.LoginBut.Click += new System.EventHandler(this.LoginBut_Click);
			this.LoginBut.MouseEnter += new System.EventHandler(this.LoginBut_MouseEnter);
			// 
			// LoginAcountText
			// 
			this.LoginAcountText.AutoCompleteCustomSource.AddRange(new string[] {
            "123",
            "123456",
            "12345678"});
			this.LoginAcountText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LoginAcountText.Location = new System.Drawing.Point(183, 142);
			this.LoginAcountText.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.LoginAcountText.Multiline = true;
			this.LoginAcountText.Name = "LoginAcountText";
			this.LoginAcountText.Size = new System.Drawing.Size(146, 30);
			this.LoginAcountText.TabIndex = 10;
			this.LoginAcountText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.LoginAcountText.WaterText = "";
			this.LoginAcountText.TextChanged += new System.EventHandler(this.LoginAcountText_TextChanged);
			this.LoginAcountText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginAcountText_MouseUp);
			// 
			// DownMenuBut
			// 
			this.DownMenuBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DownMenuBut.BackgroundImage")));
			this.DownMenuBut.Location = new System.Drawing.Point(332, 142);
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
			this.LoginPassWordText.Location = new System.Drawing.Point(183, 178);
			this.LoginPassWordText.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.LoginPassWordText.Multiline = true;
			this.LoginPassWordText.Name = "LoginPassWordText";
			this.LoginPassWordText.PasswordChar = '*';
			this.LoginPassWordText.Size = new System.Drawing.Size(146, 30);
			this.LoginPassWordText.TabIndex = 12;
			this.LoginPassWordText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.LoginPassWordText.WaterText = "";
			this.LoginPassWordText.TextChanged += new System.EventHandler(this.LoginAcountText_TextChanged);
			// 
			// RememberPassCheckBox
			// 
			this.RememberPassCheckBox.AutoSize = true;
			this.RememberPassCheckBox.BackColor = System.Drawing.Color.Transparent;
			this.RememberPassCheckBox.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.RememberPassCheckBox.DownBack = null;
			this.RememberPassCheckBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.RememberPassCheckBox.Location = new System.Drawing.Point(183, 214);
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
			// AcountLabel
			// 
			this.AcountLabel.BackColor = System.Drawing.Color.White;
			this.AcountLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.AcountLabel.ForeColor = System.Drawing.Color.Gray;
			this.AcountLabel.Location = new System.Drawing.Point(194, 147);
			this.AcountLabel.Name = "AcountLabel";
			this.AcountLabel.Size = new System.Drawing.Size(36, 20);
			this.AcountLabel.TabIndex = 16;
			this.AcountLabel.Text = "账 号";
			// 
			// PwdLabel
			// 
			this.PwdLabel.BackColor = System.Drawing.Color.White;
			this.PwdLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.PwdLabel.ForeColor = System.Drawing.Color.Gray;
			this.PwdLabel.Location = new System.Drawing.Point(194, 183);
			this.PwdLabel.Name = "PwdLabel";
			this.PwdLabel.Size = new System.Drawing.Size(36, 20);
			this.PwdLabel.TabIndex = 17;
			this.PwdLabel.Text = "密 码";
			// 
			// AcountmenuList
			// 
			this.AcountmenuList.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.AcountmenuList.FormattingEnabled = true;
			this.AcountmenuList.ItemHeight = 19;
			this.AcountmenuList.Location = new System.Drawing.Point(183, 170);
			this.AcountmenuList.Name = "AcountmenuList";
			this.AcountmenuList.Size = new System.Drawing.Size(146, 80);
			this.AcountmenuList.TabIndex = 18;
			this.AcountmenuList.SelectedValueChanged += new System.EventHandler(this.AcountmenuList_SelectedValueChanged);
			// 
			// skinLabel1
			// 
			this.skinLabel1.AutoSize = true;
			this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
			this.skinLabel1.BorderColor = System.Drawing.Color.White;
			this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.skinLabel1.Location = new System.Drawing.Point(115, 142);
			this.skinLabel1.Name = "skinLabel1";
			this.skinLabel1.Size = new System.Drawing.Size(52, 27);
			this.skinLabel1.TabIndex = 19;
			this.skinLabel1.Text = "账号";
			// 
			// skinLabel2
			// 
			this.skinLabel2.AutoSize = true;
			this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
			this.skinLabel2.BorderColor = System.Drawing.Color.White;
			this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.skinLabel2.Location = new System.Drawing.Point(115, 178);
			this.skinLabel2.Name = "skinLabel2";
			this.skinLabel2.Size = new System.Drawing.Size(52, 27);
			this.skinLabel2.TabIndex = 20;
			this.skinLabel2.Text = "密码";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(496, 353);
			this.Controls.Add(this.skinLabel2);
			this.Controls.Add(this.skinLabel1);
			this.Controls.Add(this.AcountmenuList);
			this.Controls.Add(this.PwdLabel);
			this.Controls.Add(this.AcountLabel);
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
		private System.Windows.Forms.Label AcountLabel;
		private System.Windows.Forms.Label PwdLabel;
		private System.Windows.Forms.ListBox AcountmenuList;
		private CCWin.SkinControl.SkinLabel skinLabel1;
		private CCWin.SkinControl.SkinLabel skinLabel2;
	}
}