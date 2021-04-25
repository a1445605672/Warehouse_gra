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
using Warehouse.工具窗体;
using Warehouse.表单验证;

namespace Warehouse
{
	
	public partial class UpdataFrm : UITitlePage
	{
		SystemLog log = new SystemLog();
		
		public UpdataFrm()
		{
			InitializeComponent();
		}

		#region 取消
		private void uiButton13_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion


		#region 窗体加载
		private void UpdataFrm_Load(object sender, EventArgs e)
		{
			
		}
		#endregion

		#region 供应商编号
		private void ProviderBox_DropDown(object sender, EventArgs e)
		{
			ProviderBox.Items.Clear();
			BLL.sr_info sr_Info = new BLL.sr_info();
			string provider_sql = "SELECT  sr_name FROM sr_info WHERE sr_type=\'收货商\'";
			DataSet Provider_ds = sr_Info.getDataList(provider_sql);
			int count1 = Provider_ds.Tables[0].Rows.Count;
			for (int i = 0; i < count1; i++)
			{
				ProviderBox.Items.Add(Provider_ds.Tables[0].Rows[i][0].ToString());
			}
		}
		#endregion

		#region 批次编号
		private void batchNumberBox_DropDown(object sender, EventArgs e)
		{
			batchNumberBox.Items.Clear();
			BLL.out_storage out_Storage = new BLL.out_storage();

			//如果有未完成入库的物料，则加载未完成入库的批次编号
			string OutBatchNumber_sql = "select out_batch_id from out_storage where out_if_accomplish=0";
			DataSet OutBatchNumber_ds = out_Storage.getDataList(OutBatchNumber_sql);
			int batchIdCount = OutBatchNumber_ds.Tables[0].Rows.Count;
			for (int i = 0; i < batchIdCount; i++)
			{
				batchNumberBox.Items.Add(OutBatchNumber_ds.Tables[0].Rows[i][0].ToString());
			}
			
		}
		#endregion

		#region 验证下拉框是否有误
		private void ProviderBox_Validated(object sender, EventArgs e)
		{
			
			UIComboBox ComboBox = (UIComboBox)sender;
			
			formAuthentication fa = new formAuthentication();
			
			if (ComboBox.Name=="ProviderBox")
			{
				ProviderBox_DropDown(sender, e);
				if (fa.formAuthentication_Combobox(ComboBox.Text, ComboBox) == false)
				{
					ComboBox.Text = "";
					ShowErrorTip("收货商输入有误，请选择");
				}
			}
			if(ComboBox.Name =="batchNumberBox")
			{
				batchNumberBox_DropDown(sender, e);//加载批次编号
				if (fa.formAuthentication_Combobox(ComboBox.Text, ComboBox) == false)
				{
					ComboBox.Text = "";
					ShowErrorTip("批次编号输入有误，请选择");
				}
			}
			
			
		}

		#endregion

		#region 验证文本框
		private void outWarehouseAmountBox_Validated(object sender, EventArgs e)
		{
			formAuthentication fa = new formAuthentication();
			UITextBox textBox = (UITextBox)sender;
			switch (textBox.Name)
			{ 
				case "outWarehouseAmountBox":
					if(fa.formAuthentication_isIntOrDouble(textBox.Text)==false)
					{
						textBox.Text ="";
						ShowErrorTip("出库量输入有误!");
					}
					break;
				case "staffBox":
					if(fa.staffChrckout(textBox.Text)==false)
					{
						textBox.Text = "";
						ShowErrorTip("经办人不存在!");
					}
					break;
				case "remarkBox":
					if(fa.formAuthentication_remark(textBox.Text)==false)
					{
						textBox.Text = "";
						ShowErrorTip("请输入汉字");
					}
					break;
			}
		}
		#endregion

		private void uiButton17_Click(object sender, EventArgs e)
		{

			string out_Storage_sql = "UPDATE  out_storage SET out_mat_id= ,out_sr_id= ,out_batch_id=,out_data=， out_staff_id=,out_staff_name= WHERE  out_id=";
			if(Materialsbox.Text!="")
			{
			out_Storage_sql+= "out_mat_name=\'"+ Materialsbox.Text + "\',";
			string mat_id_sql= "SELECT mat_id FROM material_info WHERE mat_name=\'"+ Materialsbox.Text + "\'";

			}

			
			
			if (ProviderBox.Text!="")
			{

			}
				log.WriteLog(3, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "未完成入库", "修改物料信息","" );

		}
	}
}
