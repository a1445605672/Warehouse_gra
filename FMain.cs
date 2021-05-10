using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;
using Warehouse.工具窗体;

namespace Warehouse
{
	public partial class FMain : UIHeaderAsideMainFrame
	{
		SystemLog log = new SystemLog();
		

		public FMain()
		{
			InitializeComponent();
			TreeNode parent = Aside.CreateNode("首页", 61461, 24, 1);
			int pageIndex = 1000;

			//string quan = Quan_xian();
			string quan = "1";

			if(quan == "1")
            {
				TreeNode BasicInform = Aside.CreateNode("基础信息", 61686, 24, pageIndex);
				Aside.CreateChildNode(BasicInform, 61852, 24, "房间管理", ++pageIndex);
				Aside.CreateChildNode(BasicInform, 57484, 24, "库柜管理", ++pageIndex);
				Aside.CreateChildNode(BasicInform, 61517, 24, "库位管理", ++pageIndex);
				Aside.CreateChildNode(BasicInform, 61861, 24, "库位类型管理", ++pageIndex);
				Aside.CreateChildNode(BasicInform, 61497, 24, "物料信息管理", ++pageIndex);
				Aside.CreateChildNode(BasicInform, 61495, 24, "物料类别管理", ++pageIndex);
				Aside.CreateChildNode(BasicInform, 57583, 24, "部门管理", ++pageIndex);
				Aside.CreateChildNode(BasicInform, 61632, 24, "采购退货管理", ++pageIndex);
				Aside.CreateChildNode(BasicInform, 61975, 24, "供收货商管理", ++pageIndex);
				Aside.CreateChildNode(BasicInform, 61976, 24, "调拨计划管理", ++pageIndex);


				pageIndex = 2000;
				TreeNode SystemManagment = Aside.CreateNode("系统管理", 61573, 24, pageIndex);
				Aside.CreateChildNode(SystemManagment, 61888, 24, "数据备份", ++pageIndex);
				Aside.CreateChildNode(SystemManagment, 108, 24, "系统日志", ++pageIndex);
				Aside.CreateChildNode(SystemManagment, 57483, 24, "用户管理", ++pageIndex);
				Aside.CreateChildNode(SystemManagment, 62004, 24, "用户注册", ++pageIndex);


				pageIndex = 3000;
				TreeNode OutIntWarehouse = Aside.CreateNode("出入库管理", 61451, 24, pageIndex);
				Aside.CreateChildNode(OutIntWarehouse, 57489, 24, "入库登记", ++pageIndex);
				Aside.CreateChildNode(OutIntWarehouse, 57490, 24, "出库登记", ++pageIndex);
				Aside.CreateChildNode(OutIntWarehouse, 61526, 24, "未完成出库", ++pageIndex);
				Aside.CreateChildNode(OutIntWarehouse, 61766, 24, "未完成入库", ++pageIndex);
				Aside.CreateChildNode(OutIntWarehouse, 61760, 24, "物料盘点", ++pageIndex);
				Aside.CreateChildNode(OutIntWarehouse, 61760, 24, "库存控制", ++pageIndex);

				pageIndex = 4000;
				TreeNode StatisticalStatementBut = Aside.CreateNode("统计报表", 61950, 24, pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 62029, 24, "入库汇总", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 62059, 24, "出库汇总", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 61665, 24, "在库汇总", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 61932, 24, "出库日报", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 61555, 24, "入库日报", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 61585, 24, "综合统计分析", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 61585, 24, "在库柱状图", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 61585, 24, "在库饼状图", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 61585, 24, "入库折线图", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 61585, 24, "出库动图", ++pageIndex);

				Aside.SelectFirst();
			}
			if(quan == "2")
            {
				pageIndex = 3000;
				TreeNode OutIntWarehouse = Aside.CreateNode("出入库管理", 61451, 24, pageIndex);
				Aside.CreateChildNode(OutIntWarehouse, 57489, 24, "入库登记", ++pageIndex);
				Aside.CreateChildNode(OutIntWarehouse, 57490, 24, "出库登记", ++pageIndex);
				Aside.CreateChildNode(OutIntWarehouse, 61526, 24, "未完成出库", ++pageIndex);
				Aside.CreateChildNode(OutIntWarehouse, 61766, 24, "未完成入库", ++pageIndex);
				Aside.CreateChildNode(OutIntWarehouse, 61760, 24, "物料盘点", ++pageIndex);
				Aside.CreateChildNode(OutIntWarehouse, 61760, 24, "库存控制", ++pageIndex);
				Aside.SelectFirst();
			}
            else
            {
				pageIndex = 4000;
				TreeNode StatisticalStatementBut = Aside.CreateNode("统计报表", 61950, 24, pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 62029, 24, "入库汇总", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 62059, 24, "出库汇总", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 61665, 24, "在库汇总", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 61932, 24, "出库日报", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 61555, 24, "入库日报", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 61585, 24, "综合统计分析", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 61585, 24, "在库柱状图", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 61585, 24, "在库饼状图", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 61585, 24, "入库折线图", ++pageIndex);
				Aside.CreateChildNode(StatisticalStatementBut, 61585, 24, "出库动图", ++pageIndex);

				Aside.SelectFirst();
			}


		}

		private void Aside_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
		{
			string menuText = item.Text;
			uiLabel2.Text = item.Text;
			if (item != null)
			{

				foreach (TabPage tab in MainTabControl.TabPages)
				{
					if (tab.Text == menuText)
					{
						MainTabControl.SelectedTab = tab;
						return;
					}
				}

				switchFrm(menuText);
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



		//页面刷新按钮
		private void UpdateButton_Click(object sender, EventArgs e)
		{
			switchFrm(uiLabel2.Text);
		}

		//根据用户匹配窗体
		private void switchFrm(string text)
		{
			switch (text)
			{
				case "首页":
					LoadMdiForm(MainTabControl, text, typeof(Home));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "首页", "进入首页页面", "");
					break;
				case "房间管理":
					LoadMdiForm(MainTabControl, text, typeof(new_房间管理));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "房间管理", "进入房间管理页面", "");
					break;
				case "库柜管理":
					LoadMdiForm(MainTabControl, text, typeof(new_库柜管理));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "库柜管理", "进入库柜管理页面", "");
					break;
				case "库位管理":
					LoadMdiForm(MainTabControl, text, typeof(库位管理));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "库位管理", "进入库位管理页面", "");
					break;
				case "库位类型管理":
					LoadMdiForm(MainTabControl, text, typeof(库位类型管理));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "库位类型管理", "进入库位类型管理页面", "");
					break;
				case "物料信息管理":
					LoadMdiForm(MainTabControl, text, typeof(物料信息管理));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "物料信息管理", "进入物料信息管理页面", "");
					break;
				case "物料类别管理":
					LoadMdiForm(MainTabControl, text, typeof(物料类别管理));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "物料类别管理", "进入物料类别管理页面", "");
					break;
				case "部门管理":
					LoadMdiForm(MainTabControl, text, typeof(部门管理));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "部门管理", "进入部门管理页面", "");
					break;
				case "采购退货管理":
					LoadMdiForm(MainTabControl, text, typeof(部门人员管理));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "采购退货管理", "进入采购退货管理页面", "");
					break;
				case "供收货商管理":
					LoadMdiForm(MainTabControl, text, typeof(供应商管理));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "供应商管理", "进入供应商管理页面", "");
					break;
				case "库存控制":
					LoadMdiForm(MainTabControl, text, typeof(库存控制));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "库存控制", "进入库存控制页面", "");
					break;
				case "调拨计划管理":
					LoadMdiForm(MainTabControl, text, typeof(收货商管理));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "调拨计划管理", "进入调拨计划管理页面", "");
					break;
				case "数据备份":
					LoadMdiForm(MainTabControl, text, typeof(数据备份));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "数据备份", "进入数据备份页面", "");
					break;
				case "系统日志":
					LoadMdiForm(MainTabControl, text, typeof(系统日志));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "系统日志", "进入系统日志页面", "");
					break;
				case "入库登记":
					LoadMdiForm(MainTabControl, text, typeof(入库登记));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "入库登记", "进入入库登记页面", "");
					break;
				case "出库登记":
					LoadMdiForm(MainTabControl, text, typeof(出库登记));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "出库登记", "进入出库登记页面", "");
					break;
				case "未完成出库":
					LoadMdiForm(MainTabControl, text, typeof(未完成出库));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "未完成出库", "进入未完成出库页面", "");
					break;
				case "未完成入库":
					LoadMdiForm(MainTabControl, text, typeof(未完成入库));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "未完成入库", "进入未完成入库页面", "");
					break;
				case "入库汇总":
					LoadMdiForm(MainTabControl, text, typeof(new_入库汇总));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "入库汇总", "进入入库汇总页面", "");
					break;
				case "出库汇总":
					LoadMdiForm(MainTabControl, text, typeof(new_出库汇总));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "出库汇总", "进入出库汇总页面", "");
					break;
				case "在库汇总":
					LoadMdiForm(MainTabControl, text, typeof(在库汇总));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "在库汇总", "进入在库汇总页面", "");
					break;
				case "出库日报":
					LoadMdiForm(MainTabControl, text, typeof(出库日报));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "出库日报", "进入出库日报页面", "");
					break;
				case "入库日报":
					LoadMdiForm(MainTabControl, text, typeof(入库日报));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "入库日报", "进入入库日报页面", "");
					break;
				case "用户管理":
					LoadMdiForm(MainTabControl, text, typeof(用户管理));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "用户管理", "进入用户管理页面", "");
					break;
				case "在库柱状图":
					LoadMdiForm(MainTabControl, text, typeof(柱状图));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "柱状图", "进入柱状图页面", "");
					break;
				case "在库饼状图":
					LoadMdiForm(MainTabControl, text, typeof(折线图));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "折线图", "进入折线图页面", "");
					break;
				case "入库折线图":
					//LoadMdiForm(MainTabControl, text, typeof(入库折线图));
					//log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "入库折线图", "进入入库折线图页面", "");
					break;
				case "综合统计分析":
					LoadMdiForm(MainTabControl, text, typeof(综合统计分析));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "综合统计分析", "进入综合统计分析页面", "");
					break;
				case "物料盘点":
					LoadMdiForm(MainTabControl, text, typeof(new_物料盘存));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "物料盘存", "进入物料盘存页面", "");
					break;
				case "出库动图":
					LoadMdiForm(MainTabControl, text, typeof(出库动图));
					log.WriteLog(4, Session.staffId, DateTime.Now.ToString("yyyy-MM-dd"), "出库动图", "进入出库动图页面", "");
					break;
				default:
					break;
			}
		}

		#region 关闭主窗口
		private void FMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			FLogin fLogin = new FLogin();

			//彻底退出进程
			System.Environment.Exit(0);
		}
		#endregion

		private void FMain_Load(object sender, EventArgs e)
		{
			userName.Text = Session.staffName;
		}

		private string Quan_xian()
        {
			BLL.staff staff = new BLL.staff();
			Model.staff staff1 = new Model.staff();

			staff1 = staff.GetModel(Session.staffId);
			string quan_xian = staff1.staff_sx;
			return quan_xian;
        }
	}
}
