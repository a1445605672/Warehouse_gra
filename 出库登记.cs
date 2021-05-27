using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;
using Warehouse.表单验证;
using Warehouse.工具窗体;

namespace Warehouse
{
	public partial class 出库登记 : UITitlePage
	{

		BLL.in_storage instorage = new BLL.in_storage();
		BLL.sr_info sr_Info = new BLL.sr_info();
		BLL.out_storage out_Storage = new BLL.out_storage();
		BLL.in_storage in_storage = new BLL.in_storage();
		Model.out_storage out_storage = new Model.out_storage();

		SystemLog log = new SystemLog();
		public 出库登记()
		{
			
			InitializeComponent();

			iniData();
			staffBox.Text = Session.staffId;
		}


		#region  窗体加载事件
		private void 出库_Load(object sender, EventArgs e)
		{
		}
		#endregion

		#region 翻页事件
		private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
		{
			uiDataGridView1.DataSource = pagingSource;
		}
		#endregion

		#region 点击datagridview的按钮事件
		private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Materialsbox.Text = "";
			storageLocationBox.Text = "";
			Material_ID_Label.Text = "";
			//判断点击的按钮 且行数大于0
			if (uiDataGridView1.Columns[e.ColumnIndex].Name == "OutWarehouse" && e.RowIndex >= 0)
			{
				//出库，批次编号
				outStorageAndBranchNumber();

				Materialsbox.Text = uiDataGridView1.CurrentRow.Cells[4].Value.ToString();//获取当前行的行的物品你名称
				storageLocationBox.Text = uiDataGridView1.CurrentRow.Cells[6].Value.ToString();//获取当前行的库物编号
				Material_ID_Label.Text = uiDataGridView1.CurrentRow.Cells[3].Value.ToString();  //获取当前行的行的物料ID
				outWarehouseAmountLabel.Text= uiDataGridView1.CurrentRow.Cells[7].Value.ToString();
				InWearhouseNumber.Text= uiDataGridView1.CurrentRow.Cells[2].Value.ToString();//入库编号
			    //Material_ID_Label.Text = uiDataGridView1.CurrentRow.Cells[5].Value.ToString();//物料编号隐藏
				
				uiPanel1.Visible = true;
			}
		}
		#endregion

		#region 返回按钮事件
		private void ReturnBut_Click(object sender, EventArgs e)
		{
			uiPanel1.Visible = false;
		}
		#endregion

		#region 未完成出库事件
		private void SaveBut_Click(object sender, EventArgs e)
		{

			//验证文本框是否有空
			if (ProviderBox.Text == "" || outWarehouseAmountBox.Text == "" || batchNumberBox.Text == "" || staffBox.Text == "") 
			{
				ShowErrorTip("物料信息请填写完整！");
				return;
			}
			BLL.staff staff = new BLL.staff();
			string sql = "select staff_name from staff where staff_id=" + "\'" + staffBox.Text.Trim() + "\'";
			
			Model.out_storage data = new Model.out_storage();
			data.enter_id = InWearhouseNumber.Text.Trim();
			data.out_id = OutWarwhouseNumberBox.Text.Trim();
			data.out_mat_id = Material_ID_Label.Text.Trim();
			data.out_mat_name = Materialsbox.Text.Trim();
			data.out_account =Convert.ToDecimal( outWarehouseAmountBox.Text.Trim());
			data.out_batch_id = batchNumberBox.Text.Trim();
			data.out_data = edtDate.Text.Trim();
			data.out_staff_id = staffBox.Text.Trim();
			data.out_staff_name = staff.getDataList(sql).Tables[0].Rows[0][0].ToString();
			data.out_if_accomplish = 0;
			data.out_sr_id = storageLocationBox.Text.Trim();
			data.remark = remarkBox.Text;
			BLL.out_storage out_storage = new BLL.out_storage();
			if(out_storage.Add(data))
			{
				log.WriteLog(6, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "出库登记", "未完成出库", InWearhouseNumber.Text.Trim());
				ShowSuccessDialog("保存成功");
				uiPanel1.Visible = false;
			}
		}
		#endregion

		#region 出库完成事件
		private void OutWarehouseBut_Click(object sender, EventArgs e)
		{
			//查询物料id
			string mat_id_Sql= "SELECT  mat_id FROM material_info WHERE mat_name=\'"+ Materialsbox.Text.Trim() + "\'";//
			//经办人姓名
			string staff_name_Sql = "SELECT staff_name FROM staff WHERE staff_id=\'" + staffBox.Text.Trim() + "\'";
			//收货商id
			string sr_id_Sql = "SELECT sr_id FROM sr_info WHERE sr_type=\'收货商\' AND sr_name=\'" + ProviderBox.Text.Trim() + "\'";

			out_storage.out_id = OutWarwhouseNumberBox.Text.Trim();//出库编号
			out_storage.out_mat_id = out_Storage.getDataList(mat_id_Sql).Tables[0].Rows[0][0].ToString();//物料id
			out_storage.out_mat_name = Materialsbox.Text.Trim();//物料名称
			out_storage.out_account =Convert.ToDecimal( outWarehouseAmountBox.Text.Trim());//出库量
			out_storage.out_batch_id = batchNumberBox.Text.Trim();//批次编号
			out_storage.out_data = edtDate.Text.Trim();//入库时间
			out_storage.out_staff_id = staffBox.Text.Trim();//经办人编号
			out_storage.out_staff_name = out_Storage.getDataList(staff_name_Sql).Tables[0].Rows[0][0].ToString();//经办人姓名
			out_storage.out_if_accomplish = 1;
			out_storage.out_sr_id = out_Storage.getDataList(sr_id_Sql).Tables[0].Rows[0][0].ToString();//收货商id
			out_storage.remark = remarkBox.Text.Trim();//备注
			out_storage.enter_id = InWearhouseNumber.Text.Trim();//入库编号



			outStorage(out_storage);
			ShowSuccessDialog("出库完成，请即时查看");
			//返回到数据页
			uiPanel1.Visible = false;
			loadInstorageData();
			//出库编号，批次
			outStorageAndBranchNumber();
			batchNumberBox.Text = "";//批次
			staffBox.Text = "";//经办人
			Materialsbox.Text="";//物料名称
			remarkBox.Text="";//备注
			ProviderBox.Text = "";//收货商

		}


		#endregion

		#region 搜索按钮事件
		private void SearchBut_Click(object sender, EventArgs e)
		{
			List<Model.in_storage> datas = new List<Model.in_storage>();
			BLL.in_storage instorage = new BLL.in_storage();
			string Sql_where = "mat_name LIKE \'%" + SelectMaterialsbox.Text.Trim() + "%\'";//"mat_name=" +"\'"+ Materialsbox.Text.Trim()+"\'";
			datas = instorage.GetModelList(Sql_where);
			if (datas.Count == 0)
			{
				ShowAskDialog("搜索结果为空！");
				return;
			}
			else
			{
				log.WriteLog(6, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "出库登记", "搜索在"+ SelectMaterialsbox .Text+ "在库物料", "");
				uiPagination1.DataSource = datas;//绑定到在库数据绑定到datagridview
				uiPagination1.ActivePage = 1;
			}
		}
		#endregion

		#region 验证下拉框是否有误
		private void ProviderBox_Validated(object sender, EventArgs e)
		{
			UIComboBox combobox = (UIComboBox)sender;
			if (combobox.Text == "")//如果下拉框为空则直接返回
				return;
			formAuthentication fA = new formAuthentication();
			switch (combobox.Name)
			{
				case "ProviderBox": //验证收货商
					if (fA.formAuthentication_Combobox(combobox.Text, combobox) == false)
					{
						combobox.Text = "";
						ShowErrorTip("收货商输入有误，请选择");
					}

					break;
				case "batchNumberBox"://验证批次编号
					if (fA.formAuthentication_Combobox(combobox.Text, combobox) == false)
					{
						combobox.Text = "";
						ShowErrorTip("批次编号输入有误，请选择");
					}
					break;
			}
		}
		#endregion

		#region  验证文本框是否有误
		private void uiTextBox5_Validated(object sender, EventArgs e)
		{
			formAuthentication fA = new formAuthentication();
			UITextBox textbox = (UITextBox)sender;
			if (textbox.Text == "")//如果文本框为空则直接返回
				return;
			switch (textbox.Name)
			{
				case "outWarehouseAmountBox":
					if(Convert.ToDouble(textbox.Text)>Convert.ToDouble(outWarehouseAmountLabel.Text)|| Convert.ToDouble(textbox.Text)<=0)
						{
						textbox.Text = "";
						ShowErrorTip("出库量不在有效范围内");
						return;
					}
					if (fA.formAuthentication_isIntOrDouble(textbox.Text) == false)
					{
						textbox.Text = "";
						ShowErrorTip("出库量输入有误，请输入阿拉伯数字");
						return;
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

		#region 初始化数据
		private void iniData()
		{
			ShowStatusForm(100, "数据加载中......");//滚动条
			uiPanel1.BringToFront(); //panel 顶层显示
			uiPanel1.Visible = false;  //隐藏表单panel
			for (int i = 0; i < 10; i++)
				StatusFormStepIt();
			#region  datagridview添加列
			//第一个参数是列表头，第二个参数用于绑定数据
			uiDataGridView1.AddColumn("入库编号", "enter_num").SetFixedMode(130);
			uiDataGridView1.AddColumn("物料ID", "mat_id").SetFixedMode(150);
			uiDataGridView1.AddColumn("物料名称", "mat_name").SetFixedMode(160);
			uiDataGridView1.AddColumn("入库时间", "in_time").SetFixedMode(130);
			uiDataGridView1.AddColumn("库位编号", "sl_id").SetFixedMode(100);
			uiDataGridView1.AddColumn("存量", "in_amount").SetFixedMode(60);
			uiDataGridView1.AddColumn("重量", "in_weight").SetFixedMode(60);
			uiDataGridView1.AddColumn("体积", "in_volume").SetFixedMode(60);
			uiDataGridView1.ReadOnly = true;
			#endregion
			for (int i = 0; i < 20; i++)
				StatusFormStepIt();
			#region   datagridview添加两个按钮
			DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
			but1.SetFixedMode(50); //设置单元格大小
			but1.HeaderText = "出库";     //设置列表头名称
			but1.Name = "OutWarehouse";     //指定按钮的名字
			but1.DefaultCellStyle.NullValue = "手动";
			uiDataGridView1.Columns.Add(but1);

			DataGridViewButtonColumn but = new DataGridViewButtonColumn();
			but.SetFixedMode(50);
			but.HeaderText = "";
			but.Name = "AutoOtWarehouse";
			but.DefaultCellStyle.NullValue = "自动";
			//but.Visible = false;//控件先隐藏 
			uiDataGridView1.Columns.Add(but);
			#endregion

			loadInstorageData();


			#region 收货商

			string provider_sql = "SELECT  sr_name FROM sr_info WHERE sr_type=\'收货商\'";
			DataSet Provider_ds = sr_Info.getDataList(provider_sql);
			int count1 = Provider_ds.Tables[0].Rows.Count;
			for (int i = 0; i < count1; i++)
			{
				ProviderBox.Items.Add(Provider_ds.Tables[0].Rows[i][0].ToString());
			}
			#endregion
			for (int i = 0; i < 10; i++)
				StatusFormStepIt(); 

			#region 日期
			edtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
			#endregion

			for (int i = 0; i < 30; i++)
				StatusFormStepIt();
			
			for (int i = 0; i < 20; i++)
				StatusFormStepIt();
			HideStatusForm();
		}
		#endregion

		#region 加载在库数据，绑定到datagridview
		private void loadInstorageData()
		{
			
			List<Model.in_storage> datas = new List<Model.in_storage>();
			datas = instorage.GetModelList("");
			uiPagination1.DataSource = datas;//绑定到在库数据绑定到datagridview
			uiPagination1.ActivePage = 1;
			for (int i = 0; i < datas.Count; i++)
			{
				if (SelectMaterialsbox.Items.Contains(datas[i].mat_name) != true)
					SelectMaterialsbox.Items.Add(datas[i].mat_name);//绑定到Materialsbox（物品）中
			}
			
		}
		#endregion

		#region 生成出库，批次编号

		private void outStorageAndBranchNumber()
		{
			#region 出库编号

			string OutWarehouseNumber_sql = "select * from out_storage Where out_data="
			+ "\'" + DateTime.Now.ToString("yyyy-MM-dd") + "\'";
			DataSet OutWarehouseNumber_ds = out_Storage.getDataList(OutWarehouseNumber_sql);
			int count = OutWarehouseNumber_ds.Tables[0].Rows.Count + 1;
			OutWarwhouseNumberBox.Text = "O" + DateTime.Now.ToString("yyyy")
				+ DateTime.Now.ToString("MM")
				+ DateTime.Now.ToString("dd")
				+ count.ToString().PadLeft(3, '0');

			#endregion
			#region 批次编号
			//
			batchNumberBox.Items.Clear();
			string BatchNumber = "O" + DateTime.Now.ToString("yyyy")
				+ DateTime.Now.ToString("MM")
				+ DateTime.Now.ToString("dd")
				+ (count).ToString().PadLeft(3, '0');
			batchNumberBox.Items.Add(BatchNumber);

			//如果有未完成入库的物料，则加载未完成入库的批次编号
			string OutBatchNumber_sql = "select out_batch_id from out_storage where out_if_accomplish=0";
			DataSet OutBatchNumber_ds = out_Storage.getDataList(OutBatchNumber_sql);
			int batchIdCount = OutBatchNumber_ds.Tables[0].Rows.Count;
			for (int i = 0; i < batchIdCount; i++)
			{
				batchNumberBox.Items.Add(OutBatchNumber_ds.Tables[0].Rows[i][0].ToString());
			}
			#endregion
		}

		#endregion


		#region  出库
		/// <summary>
		/// 出库事件
		/// </summary>
		/// <param name="out_storage">Model.out_storage</param>
		/// <returns>Boolean</returns>
		public Boolean outStorage(Model.out_storage out_storage)
		{
			Boolean status=false;
			//更新在库表
			string Sql = "UPDATE in_storage SET in_amount=in_amount-" + out_storage.out_account + " WHERE enter_num=\'" + out_storage.enter_id + "\'";
			//更新库位存量
			string storagelocation_sql = "UPDATE storagelocation SET sl_remain_bulk = sl_remain_bulk +" + out_storage.out_account + " WHERE sl_id =\'" + storageLocationBox.Text.Trim() + "\'";

			out_Storage.Add(out_storage);
			//更新在库表
			if (in_storage.Update(Sql))
			{

				if (in_storage.Update("DELETE FROM in_storage WHERE in_amount<=0"))
				{
					//更新库位存量
					if (in_storage.Update(storagelocation_sql))
					{
						status = true;

					}
				}
				log.WriteLog(6, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "出库登记", "完成出库", InWearhouseNumber.Text.Trim());
				return true;
			}else
			{
				return false;
			}
			
		}
        #endregion

        private void Materialsbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
	
