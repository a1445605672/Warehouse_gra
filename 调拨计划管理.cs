using System;
using System.Collections;
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
	public partial class 调拨计划管理 : UIPage
	{
		public string Mat_id = null;
		//当前所选物品的库存数量
		public decimal Amount = 0;

		List<KeyValuePair<string, double>> list;//存储库位大小

<<<<<<< HEAD:收货商管理.cs
		private Model.enter_storage sssss = new Model.enter_storage();
		private BLL.enter_storage enter_Storage = new BLL.enter_storage();

		public 收货商管理()
=======
		//用于为入库提供信息
		private Model.enter_storage ssss;

		

		private List<Model.storage> departments ;
		private BLL.storage department ;

		private string storage_id;

		public 调拨计划管理()
>>>>>>> 6d4fa88e477090ce5a2ddda0176717d94a959a33:调拨计划管理.cs
		{


			InitializeComponent();

			this.uiComboTreeView2.Enabled = false;
			this.uiTextBox1.Enabled = false;

			this.uiComboTreeView3.Enabled = false;
			this.uiComboTreeView4.Enabled = false;
			this.uiComboTreeView5.Enabled = false;
			this.uiRadioButton1.Checked = true;


			int count = this.uiGroupBox4.Controls.Count;
			for(int i =0; i<count; i++)
            {
				if (this.uiGroupBox4.Controls[i].Name.Contains("Label") || this.uiGroupBox4.Controls[i].Name.Contains("Button"))
                {
					this.uiGroupBox4.Controls[i].Enabled = true;
				}
                else
                {
					this.uiGroupBox4.Controls[i].Enabled = false;
				}
				
            }

			
			Load_mat_type();
		}



		
		//在combotreeview中增加物料信息
		public void Load_mat_type()
		{
			BLL.material_type material_ = new BLL.material_type();
			List<Model.material_type> material_s = material_.GetModelList("");

			//BLL.department dep = new BLL.department();
			//List<Model.department> dep_list = dep.GetModelList("");
			//int length = dep_list.Count;

			for (int i = 0; i < material_s.Count; i++)
			{
				TreeNode tree = new TreeNode();
				tree.Name = material_s[i].type_id.ToString();
				tree.Text = material_s[i].type_name.ToString();
				this.uiComboTreeView1.Nodes.Add(tree);
			}
		}

		//加载仓库信息
		public void Load_Storage_Info()
        {
			BLL.storage storage = new BLL.storage();
			List<Model.storage> storages = storage.GetModelList("");

			for (int i = 0; i < storages.Count; i++)
			{
				TreeNode tree = new TreeNode();
				tree.Name = storages[i].storage_id.ToString();
				tree.Text = storages[i].storage_name.ToString();
				this.uiComboTreeView3.Nodes.Add(tree);
			}

			this.uiRadioButton1.Enabled = true;
			this.uiRadioButton2.Enabled = true;
			this.uiRadioButton2.Checked = true;
			this.uiRadioButton1.Checked = false;

		}

        private void uiComboTreeView1_NodeSelected(object sender, TreeNode node)
        {
            string id = node.Name;
			BLL.material_info mat = new BLL.material_info();
			string Cha_xun = "mat_type_id = " + "\"" + id.Trim() + "\"";

			List<Model.material_info> material_ = new List<Model.material_info> ();
			material_ = mat.GetModelList(Cha_xun);
			this.uiComboTreeView2.Nodes.Clear();
			
			for (int i = 0; i < material_.Count; i++)
			{
				//string treenode = i + "hah";
				TreeNode treenode = new TreeNode();

				treenode.Name = material_[i].mat_id;
				treenode.Text = material_[i].mat_name;

				this.uiComboTreeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[]
		   {
				treenode
		   });

			}
			this.uiComboTreeView2.Enabled = true;

		}

        private void uiComboTreeView2_NodeSelected(object sender, TreeNode node)
        {
			Mat_id = node.Name;
			this.uiTextBox1.Enabled = true;
			BLL.in_storage in_Storage = new BLL.in_storage();
			Model.in_storage in_Storage1 = new Model.in_storage();
			List<Model.in_storage> in_Storages = new List<Model.in_storage>();
			string Cha_xun = "mat_id = " + "\"" + Mat_id.Trim() + "\"";
			in_Storages = in_Storage.GetModelList(Cha_xun);


			//为入库增加值

			  


			int m = in_Storages.Count;
			decimal amount = 0;
			for(int i = 0; i< m; i++)
            {
				amount += in_Storages[i].in_amount;
            }
			Amount = amount;
			uiLedDisplay1.Text = amount + "个";

			//查询在哪个库位
			ArrayList kuweis_name = Select_Kuwei_Name(in_Storages);
			for (int i = 0; i < kuweis_name.Count; i++)
			{
				UILedBulb uILed = new UILedBulb();
				string text = kuweis_name[i].ToString();
				//uILed.Name = storage[i].
				UILabel label = new UILabel();
				label.Text = text;
			    uILed.Blink = true;
				this.flowLayoutPanel3.Controls.Add(label);
				this.flowLayoutPanel3.Controls.Add(uILed);

			}

			//查询在哪个仓库
			string kuwei = in_Storages[0].sl_id;
			string batch = in_Storages[0].enter_num;



			//
			sssss.enter_unit_bulk = in_Storages[0].in_volume.ToString();

			//供应商编号查询
			sssss.supplier_id = in_Storages[0].enter_num;
			sssss.enter_mat_id = in_Storages[0].mat_id;
			sssss.enter_mat_name = in_Storages[0].mat_name;
			sssss.enter_fengji_num = "";

			sssss.enter_date = DateTime.Now.ToString().Trim();
			sssss.enter_agent_id = 工具窗体.Session.staffId;
			sssss.enter_agent_name = 工具窗体.Session.staffName;


			string storage_name = Which_storage(kuwei);
			

			//this.flowLayoutPanel1.Controls.Add()
			//增加仓库信息
			BLL.storage storage = new BLL.storage();
			List<Model.storage> storages = new List<Model.storage>();
			storages = storage.GetModelList("");

			int sta_amount = storages.Count;
			for(int i = 0; i< sta_amount; i++)
            {
				UILedBulb uILed = new UILedBulb();
				string text = storages[i].storage_name;
				//uILed.Name = storage[i].
				UILabel label = new UILabel();
				label.Text = text;
				if(text == storage_name.Trim())
                {
					uILed.Blink = true;
                }
				this.flowLayoutPanel1.Controls.Add(label);
				this.flowLayoutPanel1.Controls.Add(uILed);

			}


			
			//加载仓库数据
			Load_Storage_Info();








		}

		/// <summary>
		/// 通过库位编号查询仓库名
		/// </summary>
		/// <补充>
		///		这里查询的库柜都是按照仓库_1(从1开始按顺序）命名，如果不按这个顺序则查询不到仓库
		/// </补充>
		/// <param name="kuwei">库位编号</param>
		/// <returns></returns>
		private string Which_storage(string kuwei)
        {

			string Cha_xun1 = "sl_id = " + "\"" + kuwei.Trim() + "\"";
			BLL.storagelocation storagelocation = new BLL.storagelocation();
			List<Model.storagelocation> storagelocation1 = new List<Model.storagelocation>();
			storagelocation1 = storagelocation.GetModelList(Cha_xun1);
			string sl_belong_chest = storagelocation1[0].sl_belong_chest;
			string sl_id = storagelocation1[0].sl_id;



			//库位
			UILedBulb light1 = new UILedBulb();
            Label label1 = new Label();
            label1.Text = sl_belong_chest;
			label1.Font = new System.Drawing.Font("微软雅黑", 12F);
			light1.Blink = true;
			//light1.State = UILightState.Blink;
			this.flowLayoutPanel2.Controls.Add(label1);
            this.flowLayoutPanel2.Controls.Add(light1);









            int index = 0;
			index = sl_belong_chest.LastIndexOf("_");
			sl_belong_chest = sl_belong_chest.Substring(0, index);
			return sl_belong_chest;
		}

		//查询不同的库位编号
		public ArrayList Select_Kuwei_Name(List<Model.in_storage> in_Storages)
        {
			int count = in_Storages.Count;

			ArrayList haha = new ArrayList();
			
		 
			haha.Add(in_Storages[0].sl_id.ToString().Trim()) ;

			for(int i =1; i<count; i++)
            {
				
				if(haha.Contains(in_Storages[i].sl_id.ToString().Trim()) != true)
                {
					haha.Add(in_Storages[i].sl_id.ToString().Trim());
                }
				
            }



			return haha;
        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {
			
        }

        private void uiTextBox1_TabStopChanged(object sender, EventArgs e)
        {
			
		}

        private void uiTextBox1_Validated(object sender, EventArgs e)
        {
			
			if(uiTextBox1.Text != null)
			{
				
				decimal w = decimal.Parse(uiTextBox1.Text);
				bool m = Warehouse.表单验证.formAuthentication.ShuZi_fanwei(uiTextBox1.Text);
				if (m != true)
				{
					UIMessageBox.ShowWarning("输入范围须在1至999之间");
					uiTextBox1.Clear();
				}
				else
				{
					if (w > Amount)
					{
						UIMessageBox.ShowWarning("填写数量超过当前库存数量");
						uiTextBox1.Clear();
					}
				}
			}
            else
            {
				UIMessageBox.ShowError("调拨数量不能为空");
            }

			

           


		}

        private void uiTextBox1_MouseLeave(object sender, EventArgs e)
        {
			
        }

        private void uiTextBox1_Validating(object sender, CancelEventArgs e)
        {
		}

        private void uiComboTreeView3_NodeSelected(object sender, TreeNode node)
        {
<<<<<<< HEAD:收货商管理.cs
		
			string storage_id = node.Name.Trim();
=======
			//this.uiComboTreeView4.Enabled = true;
			storage_id = null;
			storage_id = node.Name.Trim();
>>>>>>> 6d4fa88e477090ce5a2ddda0176717d94a959a33:调拨计划管理.cs

			uiRadioButton1.Enabled = true;
			uiRadioButton2.Enabled = true;


            //手动模式
            if (uiRadioButton2.Checked != true)
            {
                


                BLL.chest chest = new BLL.chest();
                List<Model.chest> chests = new List<Model.chest>();
                string Cha_xun = " chest_belong_storage = " + "\"" + storage_id.Trim() + "\"";

                chests = chest.GetModelList(Cha_xun);


                this.uiComboTreeView4.Nodes.Clear();

                for (int i = 0; i < chests.Count; i++)
                {
                    TreeNode treenode = new TreeNode();
                    treenode.Name = chests[i].chest_id;
                    treenode.Text = chests[i].chest_name;
                    this.uiComboTreeView4.Nodes.Add(treenode);
                }


            }
            else
            {
                this.uiComboTreeView4.Enabled = false;
                this.uiComboTreeView5.Enabled = false;

                //第一步 查询哪个库柜还有剩余的库位(默认按着哪个库柜剩余库位最多给予分配)
                //string chest_id =  Find_Remain_Seat(storage_id).Trim();



                //调用入库的代码

            }


        }

		/// <summary>
		/// 寻找当前房间库位最多的库柜
		/// </summary>
		/// <param name="storage_id"></param>
		/// <returns></returns>
		private string Find_Remain_Seat(string storage_id)
        {
			string chest_id;

			BLL.chest chest = new BLL.chest();
			List<Model.chest> chests = new List<Model.chest>();

			string Cha_xun = " chest_belong_storage = " + "\"" + storage_id.Trim() + "\"";

			chests = chest.GetModelList(Cha_xun);

			int [] Pai_xu = new int[chests.Count];
			for(int i =0; i<chests.Count; i++)
            {
				Pai_xu[i] = (int)chests[i].chest_remain_seat;
            }
			int the_max_value = Pai_xu.Max();

			for (int m = 0; m < Pai_xu.Length; m++)
			{
				if (the_max_value == Pai_xu[m])
                {
					 chest_id = chests[m].chest_id;
					return chest_id;
				}
                
            }

			return null;

			
        }

        private void uiComboTreeView5_NodeSelected(object sender, TreeNode node)
        {
<<<<<<< HEAD:收货商管理.cs
			sssss.enter_sl_id = node.Text;
			BLL.storagelocation storagelocation = new BLL.storagelocation();
			List<Model.storagelocation> storagelocation1 = new List<Model.storagelocation>();
			
			string Cha_xun = "sl_remain_bulk = " + "\"" + node.Text.Trim() + "\"";
			storagelocation1 = storagelocation.GetModelList (Cha_xun);

			//string sql="select * from"
			//enter_Storage.getDataList()

			KeyValuePair<string, double> assssss= new KeyValuePair<string, double>(node.Text,Convert.ToDouble(storagelocation1[0].sl_remain_bulk));
			list = new List<KeyValuePair<string, double>>();
			list.Add(assssss);
=======
		    //ssss.enter_sl_id =	node.Text;
>>>>>>> 6d4fa88e477090ce5a2ddda0176717d94a959a33:调拨计划管理.cs


        }

        private void uiComboTreeView4_NodeSelected(object sender, TreeNode node)
        {
			string kugui = node.Name;

			BLL.storagelocation storagelocation = new BLL.storagelocation();
			List<Model.storagelocation> locs = new List<Model.storagelocation>();
		

			string Cha_xun = "sl_belong_chest = " + "\"" + kugui.Trim() + "\"";
			locs = storagelocation.GetModelList(Cha_xun);
			this.uiComboTreeView5.Nodes.Clear();
			for (int i = 0; i < locs.Count; i++)
            {
				TreeNode treeNode = new TreeNode();
				treeNode.Text = locs[i].sl_id;
				this.uiComboTreeView5.Nodes.Add(treeNode);
            }


				 
        }
<<<<<<< HEAD:收货商管理.cs

        private void button1_Click(object sender, EventArgs e)
        {

			string inNum_where = "enter_date=";//入库时间
			string time = "yyyy-MM-dd";
			inNum_where += "'" + DateTime.Now.ToString(time) + "'";
			string inNumber_Sql = "SELECT enter_id FROM enter_storage WHERE    " + inNum_where;
			DataSet inNumber_ds = enter_Storage.getDataList(inNumber_Sql);
			string inNumber = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');//获得今天日期
			inNumber += (inNumber_ds.Tables[0].Rows.Count + 1).ToString().PadLeft(3, '0'); //获得当前行数
			sssss.enter_id = "I" + inNumber;





			


			入库登记 kkkk = new 入库登记();
			Model.in_storage ses = new Model.in_storage();

		   kkkk.inStorageEvent(sssss, ses, list);


        }
    }
=======
>>>>>>> 6d4fa88e477090ce5a2ddda0176717d94a959a33:调拨计划管理.cs


        private void uiRadioButton1_ValueChanged(object sender, bool value)
        {
            //手动模式
            if (uiRadioButton2.Checked != true)
            {
				this.uiComboTreeView3.Enabled = true;
                this.uiComboTreeView4.Enabled = true;
                this.uiComboTreeView5.Enabled = true;


              

            }


        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
			//自动分配模式
            if (uiRadioButton2.Checked)
            {
				int kk = uiTextBox1.Text.ToInt();
				if (kk > 300)
                {
					UIMessageBox.ShowInfo("当前没有足够库位进行入库，请增加库位或联系管理员");
                }
                else
                {
					departments = new List<Model.storage>();
					department = new BLL.storage();
					departments = department.GetModelList("");
					int m = departments.Count;
					List<string> Dep_array = new List<string>();
					for(int i =0;i<m; i++)
                    {
						Dep_array.Add(departments[i].storage_name);
                    }
					Random rd = new Random();
					int f = rd.Next(0, m);

					Amount = Amount - kk;

					uiLedDisplay1.Text = Amount + "个";
					
					UIMessageBox.ShowInfo("调拨入库成功，分配仓库为 " + Dep_array[f].Trim());
                }

            }
            else
            {
				int kk = uiTextBox1.Text.ToInt();
				if (kk > 300)
				{
					UIMessageBox.ShowInfo("当前没有足够库位进行入库，请增加库位或联系管理员");
				}
                else
                {
					Amount = Amount - kk;

					uiLedDisplay1.Text = Amount + "个";

					UIMessageBox.ShowInfo("调拨入库成功，分配仓库为 " + uiComboTreeView3.SelectedNode.Text + "\n" +
						"分配库柜为 " + uiComboTreeView4.SelectedNode.Text + "\n" +
						"分配库位为 " + uiComboTreeView5.SelectedNode.Text + "\n"
						);
				}



			}



        }

        private void uiButton3_Click(object sender, EventArgs e)
        {

        }

        private void uiRadioButton2_ValueChanged(object sender, bool value)
        {
            if (uiRadioButton2.Checked)
            {
				uiRadioButton1.Checked = false;
				uiComboTreeView3.Text = "";
				uiComboTreeView3.Enabled = false;
				uiComboTreeView4.Text = "";
				uiComboTreeView4.Enabled = false;
				uiComboTreeView5.Text = "";
				uiComboTreeView5.Enabled = false;
			}
			
		}
    }





}
