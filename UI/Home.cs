using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace 毕设
{
	public partial class Home : Master
	{
		public Home()
		{
			InitializeComponent();
		}

		private void Home_Load(object sender, EventArgs e)
		{
			WorkPanel.BackgroundImage = Image.FromFile(@"Image\Background.PNG");
		}
	}
}
