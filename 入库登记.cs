using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;
using System.Configuration;
using MySql.Data.MySqlClient;
using Warehouse.表单验证;

namespace Warehouse
{
	public partial class 入库登记 : UITitlePage
	{
		public 入库登记()
		{
			InitializeComponent();
			#region 生成入库编号模块
			BLL.enter_storage enterStoeage = new BLL.enter_storage();
			string inNum_where = "enter_date=";
			string time = "yyyy-MM-dd";
			inNum_where += "'" + DateTime.Now.ToString(time) + "'";
			string inNumber_Sql = "SELECT enter_id FROM enter_storage WHERE enter_if_accomplish=1 AND  " + inNum_where;
			DataSet inNumber_ds = enterStoeage.getDataList(inNumber_Sql);
			string inNumber = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');//获得今天日期
			inNumber += (inNumber_ds.Tables[0].Rows.Count + 1).ToString().PadLeft(3, '0'); //获得当前行数
			InWarwhouseNumberBox.Text = "I" + inNumber;
			#endregion

			#region 供应商模块
			BLL.sr_info srInfor = new BLL.sr_info();
			string provider_sql = "SELECT  sr_name FROM sr_info WHERE sr_type=\'供应商\'";
			DataSet Provider_ds = srInfor.getDataList(provider_sql);
			for (int i = 0; i < Provider_ds.Tables[0].Rows.Count; i++)
			{
				ProviderBox.Items.Add(Provider_ds.Tables[0].Rows[i][0].ToString());
			}
			#endregion

			#region 物品模块
			BLL.material_info materialInfo = new BLL.material_info();
			string Material_Sql = "SELECT  mat_name FROM material_info";
			DataSet ds = materialInfo.getDataList(Material_Sql);
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				Materialsbox.Items.Add(ds.Tables[0].Rows[i][0]);
			}
			#endregion

			#region 批次编号
			//根据今天入库天生成批次编号
			string batchNumber = "I" + DateTime.Now.ToString("yyyy")
				+ DateTime.Now.ToString("MM")
			+ DateTime.Now.ToString("dd")
				+ (inNumber_ds.Tables[0].Rows.Count + 1).ToString().PadLeft(4, '0');
			batchNumberBox.Items.Add(batchNumber);
			//查看是否有未完成入库的批次编号
			BLL.enter_storage batchNumbe = new BLL.enter_storage();
			string batchNumber_Sql = "SELECT enter_batch_id FROM enter_storage  WHERE enter_if_accomplish=0";
			DataSet batchNumber_ds = batchNumbe.getDataList(batchNumber_Sql);

			if (batchNumber_ds.Tables[0].Rows.Count != 0)
			{
				for (int i = 0; i < batchNumber_ds.Tables[0].Rows.Count; i++)
					batchNumberBox.Items.Add(batchNumber_ds.Tables[0].Rows[0][0]);
			}
			#endregion

			#region 获取当前日期
			edtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
			#endregion


		}

		#region 未完成入库事件
		private void SaveBut_Click(object sender, EventArgs e)
		{
			#region 获取物品编号
			BLL.material_info material_Info = new BLL.material_info();
			string materialSql = "select mat_id from material_info where mat_name=";
			string materialWhere = "\'" + Materialsbox.Text + "\'";
			materialSql += materialWhere;
			DataSet material_ds = material_Info.getDataList(materialSql);
			#endregion

			#region 获取供应商编号
			BLL.sr_info srInfor = new BLL.sr_info();
			string provider_sql = "SELECT  sr_id FROM sr_info WHERE sr_type=\'供应商\' and sr_name=\'"+ ProviderBox.Text+"\'";
			DataSet Provider_ds = srInfor.getDataList(provider_sql);
			#endregion

			BLL.enter_storage enter_Storage = new BLL.enter_storage();
			Model.enter_storage data = new Model.enter_storage();

			data.enter_id = InWarwhouseNumberBox.Text.Trim();
			data.enter_batch_id = batchNumberBox.Text.Trim();
			data.enter_sl_id = storageLocationBox.Text.Trim();
			data.enter_amount = inWarehouseAmount.Text.Trim();
			data.enter_unit_bulk = volumeBox.Text.Trim();
			data.supplier_id = Provider_ds.Tables[0].Rows[0][0].ToString().Trim();
			data.enter_mat_id = material_ds.Tables[0].Rows[0][0].ToString().Trim();
			data.enter_mat_name = Materialsbox.Text.Trim();
			data.enter_fengji_num = "";
			data.enter_date = Convert.ToDateTime(edtDate.Text.Trim());
			data.enter_agent_id = staffBox.Text.Trim();
			data.enter_comment = remarkBox.Text.Trim();
			data.enter_if_accomplish = 0;
			enter_Storage.Add(data);


			ShowAskDialog("保存完成");
		}
		#endregion

		#region 入库事件
		private void OutWarehouseBut_Click(object sender, EventArgs e)
		{
			
			if
					(Materialsbox.Text == "" || ProviderBox.Text == "" || volumeBox.Text == ""
					|| inWarehouseAmount.Text == "" || weightBox.Text == "" || storageLocationBox.Text == ""
					|| batchNumberBox.Text == "" || staffBox.Text == "" || remarkBox.Text == ""
					)
			{
				ShowAskDialog("您输入的有误请检查");
			}
			ShowAskDialog("我已经入库啦");
		}
		#endregion

		#region  窗体加载事件
		private void 入库登记_Load(object sender, EventArgs e)
		{
			


		}
		#endregion

		#region 和物品关联 选择物品不同单位随之变化
		private void Materialsbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string Material_Sql = "SELECT  mat_state FROM material_info WHERE mat_name=";
			string Material_Where = Materialsbox.Text.ToString();
			Material_Sql += "\'" + Material_Where + "\'";
			BLL.material_info materialInfo = new BLL.material_info();
			DataSet Material_ds = materialInfo.getDataList(Material_Sql);

			switch (Material_ds.Tables[0].Rows[0][0].ToString())
			{
				case "固态":
					unitLabel.Text = "cm" + Convert.ToChar(0x00b3);
					break;
				case "液态":
					unitLabel.Text = "mL";
					break;
				case "气态":
					unitLabel.Text = "cm" + Convert.ToChar(0x00b3);
					break;
			}
		}
		#endregion


		#region  验证下拉框输入是否有误
		private void ProviderBox_Validated_1(object sender, EventArgs e)
		{
			UIComboBox combobox = (UIComboBox)sender;
			if(combobox.Text=="")//如果下拉框为空则直接返回
				return;
			formAuthentication fA = new formAuthentication();
			switch (combobox.Name)
			{
				case "ProviderBox": //验证供应商
					if (fA.formAuthentication_Combobox(combobox.Text, combobox) == false)

					{
						ProviderBox.Text = "";
						ShowErrorTip("供应商输入有误，请选择");
					}
						
					break;
				case "Materialsbox"://验证物品
					if (fA.formAuthentication_Combobox(combobox.Text, combobox) == false)
					{
						Materialsbox.Text = "";
						ShowErrorTip("物品输入有误，请选择");
					}
					break;
				case "storageLocationBox"://验证库位
					if (fA.formAuthentication_Combobox(combobox.Text, combobox) == false)
					{
						storageLocationBox.Text = "";
						ShowErrorTip("库位输入有误，请选择");
					}
					break;
				case "batchNumberBox"://验证批次编号
					if (fA.formAuthentication_Combobox(combobox.Text, combobox) == false)
					{
						batchNumberBox.Text = "";
						ShowErrorTip("批次输入有误，请选择");
					}
					break;
			}
		}
		#endregion

		#region 验证文本框是否有误
		private void PagePanel_Validated(object sender, EventArgs e)
		{
			formAuthentication fA = new formAuthentication();
			UITextBox textbox = (UITextBox)sender;
			if (textbox.Text == "")//如果文本框为空则直接返回
				return;
			switch(textbox.Name)
			{
				case "volumeBox":
					if (fA.formAuthentication_isIntOrDouble(textbox.Text) == false)
					{
						textbox.Text = "";
						ShowErrorTip("体积输入有误，请输入数字体积"); 
					}
					break;
				case "inWarehouseAmount":
					if (fA.formAuthentication_isIntOrDouble(textbox.Text) == false)
					{
						textbox.Text = "";
						ShowErrorTip("入库量输入有误，请输入数字体积");
					}
					break;
				case "weightBox":
					if (fA.formAuthentication_isIntOrDouble(textbox.Text) == false)
					{
						textbox.Text = "";
						ShowErrorTip("重量输入有误，请输入数字体积");
					}
					break;
				case "staffBox":
					if (fA.staffChrckout(textbox.Text) == false)
					{
						textbox.Text = "";
						ShowErrorTip("经办人不存在");
					}
					break;
				case "remarkBox":
					if (fA.formAuthentication_remark(textbox.Text) == false)
					{
						textbox.Text = "";
						ShowErrorTip("请输入汉字");
					}
					break;
			}
		}
		#endregion
	}
}


	


	


	

