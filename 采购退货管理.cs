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
    public partial class 采购退货管理 : UIPage
    {

        BLL.material_type material_Type = new BLL.material_type();
        BLL.material_info material_Info = new BLL.material_info();
        BLL.sr_info sr_Info = new BLL.sr_info();
        BLL.staff staff = new BLL.staff();
        BLL.chest chest = new BLL.chest();
        BLL.storagelocation storagelocation = new BLL.storagelocation();

        List<Model.material_type> Material_Type = new List<Model.material_type>();

        List<Model.material_info> material_Infos = new List<Model.material_info>();

        List<Model.sr_info> sr_Infos = new List<Model.sr_info>();

        List<Model.staff> staffs = new List<Model.staff>();

        Model.enter_storage storage = new Model.enter_storage();
        Model.in_storage in_Storage = new Model.in_storage();
        BLL.enter_storage enterStoeage = new BLL.enter_storage();
        BLL.in_storage inStorage = new BLL.in_storage();
        SystemLog log = new SystemLog();
        public 采购退货管理()
        {
            InitializeComponent();

            this.uiDatePicker1.Text = DateTime.Now.ToString();


            //将初始的非lable控件均置为 enable
            int count = this.uiGroupBox1.Controls.Count;
            for (int i = 0; i < count; i++)
            {
                
                if (this.uiGroupBox1.Controls[i].Name.Contains("uiLabel") || this.uiGroupBox1.Controls[i].Name.Contains("uiButton"))
                {
                    this.uiGroupBox1.Controls[i].Enabled = true;
                }
                else
                {
                    this.uiGroupBox1.Controls[i].Enabled = false;
                }
            }
       

            int count1 = this.uiGroupBox2.Controls.Count;
            for (int i = 0; i < count1; i++)
            {
                
                if (this.uiGroupBox2.Controls[i].Name.Contains("uiLabel") || this.uiGroupBox2.Controls[i].Name.Contains("uiButton"))
                {
                    this.uiGroupBox2.Controls[i].Enabled = true;
                }
                else
                {
                    this.uiGroupBox2.Controls[i].Enabled = false;
                }
               
            }

            Load_material_Type();
            Load_sr_Name();
            Load_Staff_Name();
            Load_buyer_Name();

       }


        private void Load_chest_info()
        {

        }


        //加载收货商
        private void Load_buyer_Name()
        {
            this.uiComboTreeView8.Enabled = true;
            this.uiComboTreeView8.Nodes.Clear();
            sr_Infos = sr_Info.GetModelList("");

            for (int i = 0; i < sr_Infos.Count; i++)
            {
                if(sr_Infos[i].sr_type == "收货商")
                {
                    TreeNode treeNode = new TreeNode();
                    treeNode.Name = sr_Infos[i].sr_id.ToString();
                    treeNode.Text = sr_Infos[i].sr_name.ToString();
                    this.uiComboTreeView1.Nodes.Add(treeNode);
                }
                
            }
        }

        /// <summary>
        /// 加载物品类型的下拉信息
        /// </summary>
        private void Load_material_Type()
        {
            this.uiComboTreeView1.Enabled = true;
            this.uiComboTreeView1.Nodes.Clear();
            Material_Type = material_Type.GetModelList("");

            for(int i = 0; i< Material_Type.Count; i++)
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Name = Material_Type[i].type_id.ToString();
                treeNode.Text = Material_Type[i].type_name.ToString();
                this.uiComboTreeView1.Nodes.Add(treeNode);
            }
        }

        private void Load_sr_Name()
        {
            this.uiComboTreeView3.Nodes.Clear();
            sr_Infos = sr_Info.GetModelList("");

            for(int i=0; i<sr_Infos.Count; i++)
            {
                TreeNode tree = new TreeNode();
                tree.Name = sr_Infos[i].sr_id.ToString();
                tree.Text = sr_Infos[i].sr_name.ToString();
                this.uiComboTreeView3.Nodes.Add(tree);
            }
        }

        private void Load_Staff_Name()
        {
            this.ProviderBox.Nodes.Clear();
            staffs = staff.GetModelList("");

            for (int i = 0; i < sr_Infos.Count; i++)
            {
                TreeNode tree = new TreeNode();
                tree.Name = staffs[i].staff_id.ToString();
                tree.Text = staffs[i].staff_name.ToString();
                this.ProviderBox.Nodes.Add(tree);
            }
        }


        private void uiComboTreeView1_NodeSelected(object sender, TreeNode node)
        {

            string id = node.Name;
            string Cha_xun = "mat_type_id = " + "\"" + id.Trim() + "\"";
            material_Infos = material_Info.GetModelList(Cha_xun);
            this.Materialsbox.Nodes.Clear();
            for(int i = 0; i< material_Infos.Count; i++)
            {
                TreeNode treenode = new TreeNode();

                treenode.Name = material_Infos[i].mat_id;
                treenode.Text = material_Infos[i].mat_name;
                this.Materialsbox.Nodes.Add(treenode);
            }
            this.Materialsbox.Enabled = true;
            this.uiTextBox4.Enabled = true;
        }

        private void uiComboTreeView2_NodeSelected(object sender, TreeNode node)
        {
            this.uiComboTreeView3.Enabled = true;
            this.ProviderBox.Enabled = true;

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            //判断数量是否合规


            //输入信息
            //String supplierIdSql = "SELECT sr_id FROM sr_info WHERE sr_type=\'供货商\' AND sr_name=\'" + ProviderBox.Text + "\'";
            //String enter_mat_id_sql = "SELECT mat_id FROM material_info WHERE mat_name=\'" + Materialsbox.Text.Trim() + "\'";
            //string staff_name_Sql = "SELECT staff_name FROM staff WHERE staff_id=\'" + staffBox.Text.Trim() + "\'";
            //storage.enter_id = InWarwhouseNumberBox.Text.Trim();//入库编号
            //storage.enter_sl_id = storageLocationBox.Text.Trim();//库位编号
            //storage.enter_amount = inWarehouseAmount.Text.Trim();//入库量
            //storage.enter_batch_id = batchNumberBox.Text.Trim();//批次编号
            //storage.enter_unit_bulk = volumeBox.Text.Trim();//单位体积
            //storage.supplier_id = enterStoeage.getDataList(supplierIdSql).Tables[0].Rows[0][0].ToString();//供应商ID
            //storage.enter_mat_id = enterStoeage.getDataList(enter_mat_id_sql).Tables[0].Rows[0][0].ToString();//物料物料id
            //storage.enter_mat_name = Materialsbox.Text.Trim();//物料名称
            //storage.enter_fengji_num = "";//封记号
            //storage.enter_date = edtDate.Text.Trim();//入库时间
            //storage.enter_agent_id = staffBox.Text.Trim();//经办人编号
            //storage.enter_agent_name = enterStoeage.getDataList(staff_name_Sql).Tables[0].Rows[0][0].ToString(); ;//经办人姓名
            //storage.enter_if_accomplish = 1;

            ////
            //in_Storage.mat_id = storage.enter_mat_id;//物料ID
            //in_Storage.mat_name = storage.enter_mat_name;//物料名称
            //in_Storage.in_time = Convert.ToDateTime(storage.enter_date);//入库时间
            //in_Storage.in_weight = Convert.ToDecimal(weightBox.Text.Trim());
            //in_Storage.in_volume = Convert.ToDecimal(storage.enter_unit_bulk);
            //in_Storage.enter_num = storage.enter_id;//入库ID
            //in_Storage.sl_id = storage.enter_sl_id;//库位编号
            //in_Storage.in_amount = Convert.ToDecimal(storage.enter_amount);

            ////入库

            //if (inStorageEvent(storage, in_Storage, inStorageList))
            //{
            //    ShowSuccessDialog("入库已完成，请及时查看");
            //}
            ////入库编号，批次编号
            //inStorageAndBranchNumber();

        }

        #region 入库

        /// <summary>
        /// 入库
        /// </summary>
        /// <param name="storage">Model.enter_storage</param>
        /// <param name="in_Storage">Model.in_storage in_Storage</param>
        /// <param name="inStorageList">库位列表，需要查询出入库的库位大小和枯萎编号</param>
        /// <param name="inStorageList">库位列表，需要查询出入库的库位大小和库位编号</param>
        public Boolean inStorageEvent(Model.enter_storage storage, Model.in_storage in_Storage, List<KeyValuePair<string, double>> inStorageList)
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

                if (storagelocation.Update(Sql))
                {
                    log.WriteLog(6, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "入库登记", "完成入库", InWarwhouseNumberBox.Text.Trim());
                    return true;
                }
            }
            else
            {
                inStorage.Add(in_Storage);
                enterStoeage.Add(storage);
                string Sql = "UPDATE  storagelocation SET sl_remain_bulk=" + (Convert.ToDouble(inStorageList[0].Value.ToString()) - Convert.ToDouble(storage.enter_amount)) + " WHERE sl_id=\'" + inStorageList[0].Key.ToString() + "\'";
                if (storagelocation.Update(Sql))
                {
                    log.WriteLog(6, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "入库登记", "完成入库", InWarwhouseNumberBox.Text.Trim());
                    return true;
                }
            }


            return false;
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

        private void uiTextBox4_Validated(object sender, EventArgs e)
        {
            if(uiTextBox4.Text == null)
            {
                UIMessageBox.ShowWarning("采购数量不能为空");
                uiButton1.Enabled = false;
            }
            else
            {
                uiButton1.Enabled = true;
                uiButton2.Enabled = true;
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
           
           
        }

        private void uiComboTreeView8_NodeSelected(object sender, TreeNode node)
        {

        }

        private void uiLabel17_Click(object sender, EventArgs e)
        {

        }

        private void unitLabel_Click(object sender, EventArgs e)
        {

        }

        private void batchNumberBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uiButton3_Click(object sender, EventArgs e)
        {

        }

        private void uiComboTreeView4_NodeSelected(object sender, TreeNode node)
        {

        }
    }
}
