using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;
namespace Warehouse
{
	public partial class 未完成入库 : UITitlePage
	{
		public 未完成入库()
		{
			InitializeComponent();

			uiDataGridView1.AddColumn("Column1", "Column1").SetFixedMode(400);
			uiDataGridView1.AddColumn("Column2", "Column2").SetFixedMode(400);
			uiDataGridView1.AddColumn("Column3", "Column3").SetFixedMode(400);
			uiDataGridView1.AddColumn("Column4", "Column4").SetFixedMode(400);
			uiDataGridView1.ReadOnly = true;
		}

		private void 未完成入库_Load(object sender, EventArgs e)
		{

		}
	}
}
