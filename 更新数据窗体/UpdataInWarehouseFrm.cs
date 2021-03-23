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
using Warehouse.表单验证;

namespace Warehouse.更新数据窗体
{
	public partial class UpdataInWarehouseFrm : UITitlePage
	{
		public UpdataInWarehouseFrm()
		{
			InitializeComponent();
		}
		#region 取消按钮
		private void uiButton13_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region 修改按钮
		private void uiButton17_Click(object sender, EventArgs e)
		{
			ShowAskDialog("修改成功");
		}
		#endregion

		#region 文本框控件验证
		private void PagePanel_Validated(object sender, EventArgs e)
		{
			UITextBox textbox = (UITextBox)sender;
			if (textbox.Text == "")
			{
				
				return;
			}
			formAuthentication fa = new formAuthentication();
		 switch (textbox.Name)
			{
				case "InWarehouseAccountBox":
					if (fa.formAuthentication_isIntOrDouble(textbox.Text) == false)
						ShowErrorTip("入库量输入有误，请输入整数或小数");
					break;
				case "VolumeBox":
					if (fa.formAuthentication_isIntOrDouble(textbox.Text) == false)
						ShowErrorTip("体积输入有误，请输入整数或小数");
					break;
				case "staffBox":
					if (fa.staffChrckout(textbox.Text) == false)
						ShowErrorTip("经办人不存在");
					break;
				case "remarkBox":
					if (fa.formAuthentication_remark(textbox.Text) == false)
						ShowErrorTip("备注输有误，请输入汉字");
					break;
			
			}
		}
		#endregion

		#region 下拉框控件验证
		private void ProviderBox_Validated(object sender, EventArgs e)
		{
			UIComboBox combox =  (UIComboBox)sender;
			if (combox.Text == "")
			{
				return;
			}
			formAuthentication fa = new formAuthentication();
			switch (combox.Name)
			{
				case "ProviderBox":
					ProviderBox_DropDown(sender, e);
					if (fa.formAuthentication_Combobox(combox.Text, combox) == false)
					{
						ShowErrorTip("供应商输入有误，请选择");
					}
					break;
				case "batchBox":
					batchBox_DropDown(sender, e);
					if (fa.formAuthentication_Combobox(combox.Text, combox) == false)
					{
						ShowErrorTip("批次输入有误，请选择");
					}
					break;
			}
		}
		#endregion

		#region 供应商编号
		private void ProviderBox_DropDown(object sender, EventArgs e)
		{
			ProviderBox.Items.Clear();
			BLL.sr_info srInfor = new BLL.sr_info();
			string provider_sql = "SELECT  sr_name FROM sr_info WHERE sr_type=\'供应商\'";
			DataSet Provider_ds = srInfor.getDataList(provider_sql);
			for (int i = 0; i < Provider_ds.Tables[0].Rows.Count; i++)
			{
				ProviderBox.Items.Add(Provider_ds.Tables[0].Rows[i][0].ToString());
			}
		}
		#endregion

		#region 批次编号
		private void batchBox_DropDown(object sender, EventArgs e)
		{

			batchBox.Items.Clear();


			BLL.enter_storage batchNumbe = new BLL.enter_storage();
			string batchNumber_Sql = "SELECT enter_batch_id FROM enter_storage  WHERE enter_if_accomplish=0";
			DataSet batchNumber_ds = batchNumbe.getDataList(batchNumber_Sql);

			if (batchNumber_ds.Tables[0].Rows.Count != 0)
			{
				for (int i = 0; i < batchNumber_ds.Tables[0].Rows.Count; i++)
					batchBox.Items.Add(batchNumber_ds.Tables[0].Rows[0][0]);
			}
			
		}

		#endregion

		
	}
}
