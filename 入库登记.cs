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
using Warehouse.工具窗体;

namespace Warehouse
{
	public partial class 入库登记 : UITitlePage
	{
		BLL.enter_storage enterStoeage = new BLL.enter_storage();
		BLL.sr_info srInfor = new BLL.sr_info();


		BLL.in_storage inStorage = new BLL.in_storage();
		BLL.storagelocation storagelocation = new BLL.storagelocation();

		Model.enter_storage storage = new Model.enter_storage();
		Model.in_storage in_Storage = new Model.in_storage();


		List<KeyValuePair<string, double>> list;//存储库位大小
		List<KeyValuePair<string, double>> inStorageList = new List<KeyValuePair<string, double>>();
		public 入库登记()
		{


			InitializeComponent();
			//初始化数据
			iniData();
		}

		SystemLog log = new SystemLog();
		#region 未完成入库事件
		private void SaveBut_Click(object sender, EventArgs e)
		{
			/*如果批次一样，物品编号也一样，则把这把着两次未完成入库合并到一起
			 *合并需要考虑库位大小是否能够装下合并过后的物品，
			 *若能装下则合并，若不能则生成两个入库编号
			 */
			if
					(Materialsbox.Text == "" || ProviderBox.Text == "" || volumeBox.Text == ""
					|| inWarehouseAmount.Text == "" || weightBox.Text == "" || storageLocationBox.Text == ""
					|| batchNumberBox.Text == "" || staffBox.Text == ""
					)
			{
				ShowSuccessDialog("您输入有误请检查");
				return;
			}

			String supplierIdSql = "SELECT sr_id FROM sr_info WHERE sr_type=\'供货商\' AND sr_name=\'" + ProviderBox.Text + "\'";
			String enter_mat_id_sql = "SELECT mat_id FROM material_info WHERE mat_name=\'" + Materialsbox.Text.Trim() + "\'";
			string staff_name_Sql = "SELECT staff_name FROM staff WHERE staff_id=\'" + staffBox.Text.Trim() + "\'";
			storage.enter_id = InWarwhouseNumberBox.Text.Trim();//入库编号
			storage.enter_sl_id = storageLocationBox.Text.Trim();//库位编号
			storage.enter_amount = inWarehouseAmount.Text.Trim();//入库量
			storage.enter_batch_id = batchNumberBox.Text.Trim();//批次编号
			storage.enter_unit_bulk = volumeBox.Text.Trim();//单位体积
			storage.supplier_id = enterStoeage.getDataList(supplierIdSql).Tables[0].Rows[0][0].ToString();//供应商ID
			storage.enter_mat_id = enterStoeage.getDataList(enter_mat_id_sql).Tables[0].Rows[0][0].ToString();//物料物料id
			storage.enter_mat_name = Materialsbox.Text.Trim();//物料名称
			storage.enter_fengji_num = "";//封记号
			storage.enter_date = edtDate.Text.Trim();//入库时间
			storage.enter_agent_id = staffBox.Text.Trim();//经办人编号
			storage.enter_agent_name = enterStoeage.getDataList(staff_name_Sql).Tables[0].Rows[0][0].ToString(); ;//经办人姓名
			storage.enter_if_accomplish = 0;

			double inStorageAmount = 0;
			if (inStorageList.Count > 1)
			{
				//分库柜进行存放
				for (int i = 0; i < inStorageList.Count - 1; i++)
				{
					storage.enter_id = InWarwhouseNumberBox.Text.Trim() + "_" + i.ToString();//入库编号
					storage.enter_sl_id = inStorageList[i].Key.ToString();//库位编号
					storage.enter_amount = inStorageList[i].Value.ToString();//入库量

					inStorageAmount += Convert.ToDouble(inStorageList[i].Value.ToString());

					enterStoeage.Add(storage);//入库
					storagelocation.Update("UPDATE  storagelocation SET sl_remain_bulk=0 WHERE sl_id=\'" + in_Storage.sl_id + "\'");
				}
				storage.enter_id = InWarwhouseNumberBox.Text.Trim() + "_" + (inStorageList.Count - 1).ToString();//入库编号
				storage.enter_sl_id = inStorageList[inStorageList.Count - 1].Key.ToString();//库位编号
				storage.enter_amount = (Convert.ToDouble(inWarehouseAmount.Text.Trim()) - inStorageAmount).ToString();//入库量

				enterStoeage.Add(storage);//入库
				string Sql = "UPDATE  storagelocation SET sl_remain_bulk=" + (Convert.ToDouble(inStorageList[inStorageList.Count - 1].Value.ToString()) - Convert.ToDouble(storage.enter_amount)).ToString() + " WHERE sl_id=\'" + in_Storage.sl_id + "\'";
				storagelocation.Update(Sql);
			}
			else
			{
				enterStoeage.Add(storage);
				string Sql = "UPDATE  storagelocation SET sl_remain_bulk=" + (Convert.ToDouble(inStorageList[0].Value.ToString()) - Convert.ToDouble(storage.enter_amount)) + " WHERE sl_id=\'" + inStorageList[0].Key.ToString() + "\'";
				storagelocation.Update(Sql);
			}
			
			log.WriteLog(6, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "入库登记", "未完成入库", InWarwhouseNumberBox.Text.Trim());
			ShowSuccessDialog("保存完成，请及时入库");

			//入库编号，批次编号
			inStorageAndBranchNumber();

			//清空数据
			Materialsbox.Text = "";
			ProviderBox.Text = "";
			volumeBox.Text = "";
			inWarehouseAmount.Text = "";
			weightBox.Text = "";
			storageLocationBox.Text = "";
			batchNumberBox.Text = "";
			staffBox.Text = "";
			storageLocationBox.Text = "";

		}
		#endregion

		#region 入库事件
		private void OutWarehouseBut_Click(object sender, EventArgs e)
		{

			/*完成入库解决方案
			 * 
			 * 1.让库柜根据类型不同，大小不同进行升序（空间大小）
			 * 2.根据物品的类型进行选择库柜，选择最能接近本次存储物品大小的库柜，
			 * 3.或者进行分库柜进行存放，生成多次入库编号
			 */


			if
					(Materialsbox.Text == "" || ProviderBox.Text == "" || volumeBox.Text == ""
					|| inWarehouseAmount.Text == "" || weightBox.Text == "" || storageLocationBox.Text == ""
					|| batchNumberBox.Text == "" || staffBox.Text == "" || storageLocationBox.Text == ""
					)
			{
				ShowSuccessDialog("您输入有误，请检查");
				return;
			}
			String supplierIdSql = "SELECT sr_id FROM sr_info WHERE sr_type=\'供货商\' AND sr_name=\'" + ProviderBox.Text + "\'";
			String enter_mat_id_sql = "SELECT mat_id FROM material_info WHERE mat_name=\'" + Materialsbox.Text.Trim() + "\'";
			string staff_name_Sql = "SELECT staff_name FROM staff WHERE staff_id=\'" + staffBox.Text.Trim() + "\'";
			storage.enter_id = InWarwhouseNumberBox.Text.Trim();//入库编号
			storage.enter_sl_id = storageLocationBox.Text.Trim();//库位编号
			storage.enter_amount = inWarehouseAmount.Text.Trim();//入库量
			storage.enter_batch_id = batchNumberBox.Text.Trim();//批次编号
			storage.enter_unit_bulk = volumeBox.Text.Trim();//单位体积
			storage.supplier_id = enterStoeage.getDataList(supplierIdSql).Tables[0].Rows[0][0].ToString();//供应商ID
			storage.enter_mat_id = enterStoeage.getDataList(enter_mat_id_sql).Tables[0].Rows[0][0].ToString();//物料物料id
			storage.enter_mat_name = Materialsbox.Text.Trim();//物料名称
			storage.enter_fengji_num = "";//封记号
			storage.enter_date = edtDate.Text.Trim();//入库时间
			storage.enter_agent_id = staffBox.Text.Trim();//经办人编号
			storage.enter_agent_name = enterStoeage.getDataList(staff_name_Sql).Tables[0].Rows[0][0].ToString(); ;//经办人姓名
			storage.enter_if_accomplish = 1;

			in_Storage.mat_id = storage.enter_mat_id;//物料ID
			in_Storage.mat_name = storage.enter_mat_name;//物料名称
			in_Storage.in_time = Convert.ToDateTime(storage.enter_date);//入库时间
			in_Storage.in_weight = Convert.ToDecimal(weightBox.Text.Trim());
			in_Storage.in_volume = Convert.ToDecimal(storage.enter_unit_bulk);
			in_Storage.enter_num = storage.enter_id;//入库ID
			in_Storage.sl_id = storage.enter_sl_id;//库位编号
			in_Storage.in_amount = Convert.ToDecimal(storage.enter_amount);

			//入库
			inStorageEvent(storage, in_Storage, inStorageList);


			//入库编号，批次编号
			inStorageAndBranchNumber();

			//清空数据
			Materialsbox.Text = "";
			ProviderBox.Text = "";
			volumeBox.Text = "";
			inWarehouseAmount.Text = "";
			weightBox.Text = "";
			storageLocationBox.Text = "";
			batchNumberBox.Text = "";
			staffBox.Text = "";
			storageLocationBox.Text = "";
			
		}
		#endregion

		#region 初始化数据
		public void iniData()
		{
			ShowStatusForm(100, "数据正在初始化......");

			for (int i = 0; i < 10; i++)
				StatusFormStepIt();
			

			for (int i = 0; i < 20; i++)
				StatusFormStepIt();


			#region 供应商模块

			string provider_sql = "SELECT  sr_name FROM sr_info WHERE sr_type=\'供货商\'";
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

			for (int i = 0; i < 10; i++)
				StatusFormStepIt();
			//入库编号，批次编号
			inStorageAndBranchNumber();

			for (int i = 0; i < 20; i++)
				StatusFormStepIt();


			
			for (int i = 0; i < 20; i++)
				StatusFormStepIt();
			#region 获取当前日期
			edtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
			#endregion
			for (int i = 0; i < 20; i++)
				StatusFormStepIt();
			HideStatusForm();
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
			if (combobox.Text == "")//如果下拉框为空则直接返回
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
						return;
					}
					if (inWarehouseAmount.Text != "" && Materialsbox.Text != "" && volumeBox.Text != "")
					{

						//自动推荐入库
						if (storageLocation(Materialsbox.Text, inWarehouseAmount.Text) == null)
						{
							return;
						}
					}
					break;
				//case "storageLocationBox"://验证库位
				//	if (fA.formAuthentication_Combobox(combobox.Text, combobox) == false)
				//	{
				//		storageLocationBox.Text = "";
				//		ShowErrorTip("库位输入有误，请选择");
				//	}
				//	break;
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
			switch (textbox.Name)
			{
				case "volumeBox":
					if (fA.formAuthentication_isIntOrDouble(textbox.Text) == false)
					{
						textbox.Text = "";
						ShowErrorTip("体积输入有误，请输入数字体积");
					}
					if (inWarehouseAmount.Text != "" && Materialsbox.Text != "" && volumeBox.Text != "")
					{
						if (storageLocation(Materialsbox.Text, inWarehouseAmount.Text) == null)
						{
							return;
						}
					}
					break;
				case "inWarehouseAmount":
					if (fA.formAuthentication_isIntOrDouble(textbox.Text) == false)
					{
						textbox.Text = "";
						ShowErrorTip("入库量输入有误，请输入数字体积");
						return;
					}
					if (inWarehouseAmount.Text != "" && Materialsbox.Text != "" && volumeBox.Text != "")
					{
						if (storageLocation(Materialsbox.Text, inWarehouseAmount.Text) == null)
						{
							return;
						}
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


		#region 批量入库
		private void bulkStorage_Click(object sender, EventArgs e)
		{

		}
		#endregion


		#region 自动推荐库位
		/// <summary>
		/// 推荐库位
		/// </summary>
		/// <param name="materiaName">物品名称</param>
		/// <param name="inStorageNumber">入库量</param>
		/// <returns></returns>
		private string storageLocation(string materiaName, string inStorageNumber)
		{
			inStorageList.Clear();
			storageLocationBox.Text = "";
			string storageAreaSQL = "SELECT DISTINCT (storagelocation.sl_remain_bulk) ,storagelocation.sl_id " +
				"FROM storagelocation,StorageMaterialType " +
				"WHERE StorageMaterialType.`mat_id`=(SELECT mat_id FROM  material_info WHERE mat_name=\'" + materiaName + "\') ORDER BY  storagelocation.sl_remain_bulk";
			DataSet ds = enterStoeage.getDataList(storageAreaSQL);
			
			list = new List<KeyValuePair<string, double>>();
			
			if (ds.Tables[0].Rows.Count <= 0)
			{
				ShowSuccessDialog("没有存储此物料的柜子，请添加");
				return null;
			}
			
			KeyValuePair<string, double> keyValuePair;
			
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				double storageArea = Convert.ToDouble(ds.Tables[0].Rows[i][0].ToString());
				string storageLocationId = ds.Tables[0].Rows[i][1].ToString();
				if (storageArea > 0)
				{
					keyValuePair = new KeyValuePair<string, double>(storageLocationId, storageArea);
					list.Add(keyValuePair);
				}

			}

			
			if (list[0].Value < Convert.ToDouble(inStorageNumber))
			{
				if (ShowAskDialog("是否分多个库位进行入库"))
				{//确定事件处理
					double sum = 0;
					for (int i = 0; i < list.Count; i++)
					{
						if(sum == Convert.ToDouble(inStorageNumber))
						{
							break;
						}
						if (sum >Convert.ToDouble(inStorageNumber))
						{
							storageLocationBox.Text += list[i].Key;
							inStorageList.Add(list[i]);
							break;
						}
						else
						{
							sum += list[i].Value;
							storageLocationBox.Text += list[i].Key + ",";
							inStorageList.Add(list[i]);
						}

					}

					if (sum < Convert.ToDouble(inStorageNumber))
					{
						storageLocationBox.Text = "";
						inWarehouseAmount.Text = "";
						ShowSuccessDialog("没有合适的柜子，请添加");
					}
					//设置字体大小
					storageLocationBox.Font = new Font("微软雅黑", 9.0F);
				}
				else
				{
					int i = 0;
					for (; i < list.Count; i++)
					{
						if (Convert.ToDouble(inStorageNumber) < list[i].Value)
						{
							storageLocationBox.Text = list[i].Key;
							inStorageList.Add(list[i]);
							break;
						}
					}
					if (i == list.Count)
					{
						ShowSuccessDialog("没有合适的柜子，请添加");
					}
				}
			}
			else
			{
				storageLocationBox.Text += list[0].Key;
				inStorageList.Add(list[0]);
			}
			return null;
		}

		#endregion


		#region 入库

		/// <summary>
		/// 入库
		/// </summary>
		/// <param name="storage">Model.enter_storage</param>
		/// <param name="in_Storage">Model.in_storage in_Storage</param>
		/// <param name="inStorageList">库位列表，需要查询出入库的库位大小和枯萎编号</param>
		public void inStorageEvent(Model.enter_storage storage, Model.in_storage in_Storage, List<KeyValuePair<string, double>> inStorageList)
		{
			double inStorageAmount = 0;
			if (inStorageList.Count > 1)
			{
				//分库柜进行存放
				for (int i = 0; i < inStorageList.Count - 1; i++)
				{
					storage.enter_id = InWarwhouseNumberBox.Text.Trim() + "_" + i.ToString();//入库编号
					storage.enter_sl_id = inStorageList[i].Key.ToString();//库位编号
					storage.enter_amount = inStorageList[i].Value.ToString();//入库量

					inStorageAmount += Convert.ToDouble(inStorageList[i].Value.ToString());

					in_Storage.enter_num = storage.enter_id;//入库ID
					in_Storage.sl_id = storage.enter_sl_id;//库位编号
					in_Storage.in_amount = Convert.ToDecimal(storage.enter_amount);

					inStorage.Add(in_Storage);
					enterStoeage.Add(storage);//入库
					storagelocation.Update("UPDATE  storagelocation SET sl_remain_bulk=0 WHERE sl_id=\'" + in_Storage.sl_id + "\'");
				}
				storage.enter_id = InWarwhouseNumberBox.Text.Trim() + "_" + (inStorageList.Count - 1).ToString();//入库编号
				storage.enter_sl_id = inStorageList[inStorageList.Count - 1].Key.ToString();//库位编号
				storage.enter_amount = (Convert.ToDouble(inWarehouseAmount.Text.Trim()) - inStorageAmount).ToString();//入库量


				in_Storage.enter_num = storage.enter_id;//入库ID
				in_Storage.sl_id = storage.enter_sl_id;//库位编号
				in_Storage.in_amount = Convert.ToDecimal(storage.enter_amount);

				inStorage.Add(in_Storage);
				enterStoeage.Add(storage);//入库
				string Sql = "UPDATE  storagelocation SET sl_remain_bulk=" + (Convert.ToDouble(inStorageList[inStorageList.Count - 1].Value.ToString()) - Convert.ToDouble(storage.enter_amount)).ToString() + " WHERE sl_id=\'" + in_Storage.sl_id + "\'";
				storagelocation.Update(Sql);
			}
			else
			{
				inStorage.Add(in_Storage);
				enterStoeage.Add(storage);
				string Sql = "UPDATE  storagelocation SET sl_remain_bulk=" + (Convert.ToDouble(inStorageList[0].Value.ToString()) - Convert.ToDouble(storage.enter_amount)) + " WHERE sl_id=\'" + inStorageList[0].Key.ToString() + "\'";
				storagelocation.Update(Sql);
			}
			log.WriteLog(6, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "入库登记", "完成入库", InWarwhouseNumberBox.Text.Trim());
			ShowSuccessDialog("入库已完成，请及时查看");
		}
		#endregion




		#region 生成入库编号，批次编号
		private void inStorageAndBranchNumber()
		{
			#region 生成入库编号
			/*
			 * 生成规则，根据日期生成入库编号，sql语句查询今天入库的条目，然后加一就是新的入库编号
			 */

			string inNum_where = "enter_date=";//入库时间
			string time = "yyyy-MM-dd";
			inNum_where += "'" + DateTime.Now.ToString(time) + "'";
			string inNumber_Sql = "SELECT enter_id FROM enter_storage WHERE    " + inNum_where;
			DataSet inNumber_ds = enterStoeage.getDataList(inNumber_Sql);
			string inNumber = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');//获得今天日期
			inNumber += (inNumber_ds.Tables[0].Rows.Count + 1).ToString().PadLeft(3, '0'); //获得当前行数
			InWarwhouseNumberBox.Text = "I" + inNumber;
			#endregion

			#region 批次编号
			batchNumberBox.Items.Clear();
			//根据今天入库天生成批次编号
			string batchNumber = "I" + DateTime.Now.ToString("yyyy")
				+ DateTime.Now.ToString("MM")
			+ DateTime.Now.ToString("dd")
				+ (inNumber_ds.Tables[0].Rows.Count + 1).ToString().PadLeft(4, '0');
			batchNumberBox.Items.Add(batchNumber);
			//查看是否有未完成入库的批次编号
			BLL.enter_storage batchNumbe = new BLL.enter_storage();
			string batchNumber_Sql = "SELECT distinct(enter_batch_id) FROM enter_storage  WHERE enter_if_accomplish=0";
			DataSet batchNumber_ds = batchNumbe.getDataList(batchNumber_Sql);

			if (batchNumber_ds.Tables[0].Rows.Count != 0)
			{
				for (int i = 0; i < batchNumber_ds.Tables[0].Rows.Count; i++)
					batchNumberBox.Items.Add(batchNumber_ds.Tables[0].Rows[i][0]);
			}
			#endregion

		}


		#endregion

	}





}









