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

namespace Warehouse.工具窗体
{
	public partial class DialogFrm : UITitlePage
	{
		public DialogFrm()
		{
			InitializeComponent();
		}

		private void PagePanel_Click(object sender, EventArgs e)
		{

		}

		private void DialogFrm_Load(object sender, EventArgs e)
		{
			Date2.Text = DateTime.Now.ToString("yyyy-MM-dd");
		}

		//取消
		private void uiButton13_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		//删除
		private void uiButton17_Click(object sender, EventArgs e)
		{
			if(Convert.ToDateTime(Date1.Text)> Convert.ToDateTime(Date2.Text))
			{
				ShowAskDialog("您输入有误，请重新输入");
				return;
			}

			BLL.log_info  log_info= new BLL.log_info();
			string deleteSql= "delete from log_info where log_time<=\'"+Date2.Text+ "\' and log_time>=\'"+ Date1.Text+"\'";
			log_info.delete(deleteSql);
			this.Close();
		}
	}
}
