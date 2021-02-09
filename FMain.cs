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
	public partial class FMain : UIHeaderAsideMainFrame
	{
		public FMain()
		{
			InitializeComponent();
			TreeNode parent = Aside.CreateNode("首页", 61461, 24, 1);
			int pageIndex = 1000;
			TreeNode BasicInform = Aside.CreateNode("基础信息", 61686, 24, pageIndex);
			Aside.CreateChildNode(BasicInform, 61852, 24, "房间管理", ++pageIndex);
			Aside.CreateChildNode(BasicInform, 57484, 24, "库柜管理", ++pageIndex);
			Aside.CreateChildNode(BasicInform, 61517, 24, "库位管理", ++pageIndex);
			Aside.CreateChildNode(BasicInform, 61861, 24, "库位类型管理", ++pageIndex);
			Aside.CreateChildNode(BasicInform, 61497, 24, "物料信息管理", ++pageIndex);
			Aside.CreateChildNode(BasicInform, 61495, 24, "物料类别管理", ++pageIndex);
			Aside.CreateChildNode(BasicInform, 57583, 24, "部门管理", ++pageIndex);
			Aside.CreateChildNode(BasicInform, 61632, 24, "部门人员管理", ++pageIndex);
			Aside.CreateChildNode(BasicInform, 61975, 24, "供应商管理", ++pageIndex);
			Aside.CreateChildNode(BasicInform, 61976, 24, "收货商管理", ++pageIndex);


			pageIndex = 2000;
			TreeNode SystemManagment=Aside.CreateNode("系统管理", 61573, 24, pageIndex);
			Aside.CreateChildNode(SystemManagment, 61888, 24, "数据备份", ++pageIndex);
			Aside.CreateChildNode(SystemManagment, 108, 24, "系统日志", ++pageIndex);
			Aside.CreateChildNode(SystemManagment, 57483, 24, "用户管理", ++pageIndex);
			Aside.CreateChildNode(SystemManagment, 62004, 24, "用户注册", ++pageIndex);


			pageIndex = 3000;
			TreeNode OutIntWarehouse=Aside.CreateNode("出入库管理", 61451, 24, pageIndex);
			Aside.CreateChildNode(OutIntWarehouse, 57489, 24, "入库登记", ++pageIndex);
			Aside.CreateChildNode(OutIntWarehouse, 57490, 24, "出库登记", ++pageIndex);
			Aside.CreateChildNode(OutIntWarehouse, 61526, 24, "未完成出库", ++pageIndex);
			Aside.CreateChildNode(OutIntWarehouse, 61766, 24, "未完成入库", ++pageIndex);


			pageIndex = 4000;
			TreeNode StatisticalStatementBut = Aside.CreateNode("统计报表", 61950, 24, pageIndex);
			Aside.CreateChildNode(StatisticalStatementBut, 62029, 24 ,"出入库汇总", ++pageIndex);
			Aside.CreateChildNode(StatisticalStatementBut, 61665, 24, "在库汇总", ++pageIndex);
			Aside.CreateChildNode(StatisticalStatementBut, 61932,24, "出库日报", ++pageIndex);
			Aside.CreateChildNode(StatisticalStatementBut, 61555,24,"入库日报", ++pageIndex);
			Aside.SelectFirst();
		}

		private void Aside_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
		{
	 		if(item!=null)
			{
				string menuText = item.Text;
				foreach (TabPage tab in MainTabControl.TabPages)
				{
					if (tab.Text == menuText)
					{
						MainTabControl.SelectedTab = tab;
						return;
					}
				}
				switch (menuText)
				{
					case "首页":
						LoadMdiForm(MainTabControl, menuText, typeof(Home));
						break;
					case "房间管理":
						LoadMdiForm(MainTabControl, menuText, typeof(房间管理));
						break;
					case "库柜管理":
						LoadMdiForm(MainTabControl, menuText, typeof(库柜管理));
						break;
					case "库位管理":
						LoadMdiForm(MainTabControl, menuText, typeof(库位管理));
						break;
					case "库位类型管理":
						LoadMdiForm(MainTabControl, menuText, typeof(库位类型管理));
						break;
					case "物料信息管理":
						LoadMdiForm(MainTabControl, menuText, typeof(物料信息管理));
						break;
					case "物料类别管理":
						LoadMdiForm(MainTabControl, menuText, typeof(物料类别管理));
						break;
					case "部门管理":
						LoadMdiForm(MainTabControl, menuText, typeof(部门管理));
						break;
					case "部门人员管理":
						LoadMdiForm(MainTabControl, menuText, typeof(部门人员管理));
						break;
					case "供应商管理":
						LoadMdiForm(MainTabControl, menuText, typeof(供应商管理));
						break;
					case "收货商管理":
						LoadMdiForm(MainTabControl, menuText, typeof(收货商管理));
						break;
					case "数据备份":
						LoadMdiForm(MainTabControl, menuText, typeof(数据备份));
						break;
					case "系统日志":
						LoadMdiForm(MainTabControl, menuText, typeof(系统日志));
						break;
					case "入库登记":
						LoadMdiForm(MainTabControl, menuText, typeof(入库登记));
						break;
					case "出库登记":
						LoadMdiForm(MainTabControl, menuText, typeof(出库登记));
						break;
					case "未完成出库":
						LoadMdiForm(MainTabControl, menuText, typeof(未完成出库));
						break;
					case "未完成入库":
						LoadMdiForm(MainTabControl, menuText, typeof(未完成入库));
						break;
					case "出入库汇总":
						LoadMdiForm(MainTabControl, menuText, typeof(出入库汇总));
						break;
					case "在库汇总":
						LoadMdiForm(MainTabControl, menuText, typeof(在库汇总));
						break;
					case "出库日报":
						LoadMdiForm(MainTabControl, menuText, typeof(出库日报));
						break;
					case "入库日报":
						LoadMdiForm(MainTabControl, menuText, typeof(入库日报));
						break;
					default:
						break;
				}
			}
		}

		private Form LoadMdiForm(TabControl MainTabControl, string menuText, Type formType)
		{
			Form frm = (Form)Activator.CreateInstance(formType);
			frm.Text = menuText;
			frm.FormBorderStyle = FormBorderStyle.None;
			frm.TopLevel = false;
			frm.Dock = DockStyle.Fill;
			TabPage sTabPag = new TabPage(menuText);
			sTabPag.Font = new Font("微软雅黑", 9F);
			sTabPag.Controls.Add(frm);
			MainTabControl.Controls.Add(sTabPag);
			MainTabControl.SelectedTab = sTabPag;
			frm.Show();
			return frm;
		}
	}
}
