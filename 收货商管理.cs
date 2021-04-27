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
	public partial class 收货商管理 : UIPage
	{
		public string Mat_id = null;
		//当前所选物品的库存数量
		public decimal Amount = 0;


		public 收货商管理()
		{


			InitializeComponent();

			this.uiComboTreeView2.Enabled = false;
			this.uiTextBox1.Enabled = false;
			
			Load_mat_type();
		}



		

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
			int m = in_Storages.Count;
			decimal amount = 0;
			for(int i = 0; i< m; i++)
            {
				amount += in_Storages[i].in_amount;
            }
			Amount = amount;
			uiLedDisplay1.Text = amount + "个";

			//查询在哪个仓库
			string kuwei = in_Storages[0].sl_id;
			string batch = in_Storages[0].enter_num;

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

			



			

		
        }

		/// <summary>
		/// 通过库位编号查询仓库名
		/// </summary>
		/// <param name="kuwei"></param>
		/// <returns></returns>
		private string Which_storage(string kuwei)
        {
			string Cha_xun1 = "sl_id = " + "\"" + kuwei.Trim() + "\"";
			BLL.storagelocation storagelocation = new BLL.storagelocation();
			List<Model.storagelocation> storagelocation1 = new List<Model.storagelocation>();
			storagelocation1 = storagelocation.GetModelList(Cha_xun1);
			string sl_belong_chest = storagelocation1[0].sl_belong_chest;

			int index = 0;
			index = sl_belong_chest.LastIndexOf("_");
			sl_belong_chest = sl_belong_chest.Substring(0, index);
			return sl_belong_chest;
		}

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {
			
        }

        private void uiTextBox1_TabStopChanged(object sender, EventArgs e)
        {
			
		}

        private void uiTextBox1_Validated(object sender, EventArgs e)
        {
			
			//else
			//{
			//	Model.in_storage in_Storage1 = new Model.in_storage();
			//	BLL.in_storage in_Storage = new BLL.in_storage();
			//	string Cha_xun = "mat_id = " + "\"" + Mat_id.Trim() + "\"";
			//	in_Storage1 = in_Storage.GetModel(Cha_xun);
			//	Console.ReadLine();
			//}

			decimal w = decimal.Parse(uiTextBox1.Text);
            bool m = Warehouse.表单验证.formAuthentication.ShuZi_fanwei(uiTextBox1.Text);
            if (m != true)
            {
                UIMessageBox.ShowWarning("输入范围须在1至999之间");

            }
            else
            {
				if (w > Amount)
				{
					UIMessageBox.ShowWarning("填写数量超过当前库存数量");
				}
			}

           


		}

        private void uiTextBox1_MouseLeave(object sender, EventArgs e)
        {
			
        }

        private void uiTextBox1_Validating(object sender, CancelEventArgs e)
        {
		}
    }

	
}
