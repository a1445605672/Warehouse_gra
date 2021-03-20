using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace Warehouse
{
	
	public partial class UpdataFrm : UITitlePage
	{
		
		public UpdataFrm()
		{
			
			InitializeComponent();

		}

		private void uiButton13_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void UpdataFrm_Load(object sender, EventArgs e)
		{
			
			
			//noWarehouse.mydelegate += new Mydelegate(Add);
		}
		
		
	}
}
