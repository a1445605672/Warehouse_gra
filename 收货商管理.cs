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
		public 收货商管理()
		{
			InitializeComponent();
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

        }
    }

	
}
