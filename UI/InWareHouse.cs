using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace 毕设
{
	public partial class InWareHouse : UserControl
	{
		public InWareHouse()
		{
			InitializeComponent();

			#region   查询条件菜单加载数据
			SelectListBox.Items.Add("我爱你晏传利");
			SelectListBox.Items.Add("你爱我吗");
			SelectListBox.Items.Add("我爱你冯家振");
			SelectListBox.Items.Add("你好");
			SelectListBox.Items.Add("大家好");
			#endregion
			uiDataGridView1.AddColumn("Column1", "Column1");
			uiDataGridView1.AddColumn("Column2", "Column2");
			uiDataGridView1.AddColumn("Column3", "Column3");
			uiDataGridView1.AddColumn("Column4", "Column4");
			uiDataGridView1.ReadOnly = true;

		}

		#region 加载窗体
		private void InWareHouse_Load(object sender, EventArgs e)
		{
			SelectListBox.BringToFront();  //查询条件顶层显示
			string server = "server=81.70.99.35; uid = root; pwd = Nokia500.; database = warehouse";
			string sql = "SELECT* FROM enter_storage";
			MySqlConnection con = new MySqlConnection(server);
			MySqlCommand com = new MySqlCommand(sql, con);
			DataSet ds = new DataSet();
			MySqlDataAdapter da = new MySqlDataAdapter(com);
			da.Fill(ds);
			List<Model.enter_storage> data = new List<Model.enter_storage>();
			for(int i=0;i<ds.Tables[0].Rows.Count;i++)
			{
				Model.enter_storage enter = new Model.enter_storage();
				enter.enter_id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
				enter.enter_batch_id= Convert.ToInt32(ds.Tables[0].Rows[0][0]);
				
	}
			uiDataGridView1.DataSource = ds.Tables[0];
			//BLL.enter_storage enter_Storage = new BLL.enter_storage();
			//DataSet ds= enter_Storage.GetAllList();
		}

		#endregion


		#region   查询条件按钮设置背景
		private void SelectListBut_Click(object sender, EventArgs e)
		{
			SelectListBut.BackgroundImage = Image.FromFile(@"Image\login_inputbtn_down.png");
			SelectListBox.Visible = true;
			

		}
		#endregion

		#region  隐藏查询条件下拉菜单
		private void SelectListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			SelectCondition.Text=SelectListBox.SelectedItem.ToString();
			SelectListBox.Visible = false;
		}

		private void panel1_MouseEnter(object sender, EventArgs e)
		{
			SelectListBox.Visible = false;
			SelectListBut.BackgroundImage = Image.FromFile(@"Image\login_inputbtn_normal.png");
		}
		#endregion 
	}
}
