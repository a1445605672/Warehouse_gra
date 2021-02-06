using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace 毕设
{
	public partial class Master : Skin_Color
	{
		public Master()
		{
			InitializeComponent();
		}




		#region 关闭子窗口 同时关闭父窗口
		private void Master_FormClosing(object sender, FormClosingEventArgs e)
		{
			base.OnClosed(e);
			Application.Exit(e);
		}
		#endregion

		#region  Master窗体加载事件
		private void Master_Load(object sender, EventArgs e)
		{
			#region 下拉框全部是顶层控件

			BasicMenuPanel.BringToFront();
			SystemManagPanel.BringToFront();
			OutIntWarehousePanel.BringToFront();
			StatisticalStatementPanel.BringToFront();

			#endregion
		}
		#endregion

		#region 显示基础信息子菜单
		private void BasicInformBut_MouseEnter(object sender, EventArgs e)
		{
			WorkPanel.Controls.Add(BasicMenuPanel);//重新加载基础信息子菜单
			BasicMenuPanel.BringToFront(); //基础信息子菜单顶层显示
			BasicInformBut.BackColor = Color.Black;     //选基础信息BUt背景变成黑色

			#region  非选择的button变成默认颜色
			HomeBut.BackColor = Color.Transparent;
			SystemManagmentBut.BackColor = Color.Transparent;      //系统管理But
			OutIntWarehouseBut.BackColor = Color.Transparent;      //出入库But
			StatisticalStatementBut.BackColor = Color.Transparent; //统计报表But

			#endregion

			BasicMenuPanel.Visible = true; //基础信息Panel显示

			#region  隐藏Panel


			SystemManagPanel.Visible = false;                //系统管理Panel
			OutIntWarehousePanel.Visible = false;            //出入库Panel
			StatisticalStatementPanel.Visible = false;       //统计报表Panel

			#endregion
		}
		#endregion

		#region  显示系统管理子菜单
		private void SystemManagmentBut_MouseEnter(object sender, EventArgs e)
		{
			WorkPanel.Controls.Add(SystemManagPanel); //重新加载系统管理子菜单
			SystemManagPanel.BringToFront(); //子菜单顶层显示
			SystemManagmentBut.BackColor = Color.Black;  //系统管理But背景变成黑色

			#region  非选择的button变成默认颜色

			HomeBut.BackColor = Color.Transparent;
			BasicInformBut.BackColor = Color.Transparent;           //基础信息But
			OutIntWarehouseBut.BackColor = Color.Transparent;       //出入库But
			StatisticalStatementBut.BackColor = Color.Transparent;  //统计报表But

			#endregion

			SystemManagPanel.Visible = true;    //显示系统管理Panel

			#region  隐藏Panel


			BasicMenuPanel.Visible = false;             //基础信息Panel
			OutIntWarehousePanel.Visible = false;       //出入库Panel
			StatisticalStatementPanel.Visible = false;  //统计报表Panel

			#endregion
		}
		#endregion

		#region 显示出入库子菜单
		private void OutIntWarehouseBut_MouseEnter(object sender, EventArgs e)
		{
			WorkPanel.Controls.Add(OutIntWarehousePanel); //重新加载出入库子菜单
			OutIntWarehousePanel.BringToFront(); //出入库子菜单顶层显示
			OutIntWarehouseBut.BackColor = Color.Black;     //出入库But背景变成黑色


			#region  非选择的button变成默认颜色
			HomeBut.BackColor = Color.Transparent;
			BasicInformBut.BackColor = Color.Transparent;           //基础信息But
			SystemManagmentBut.BackColor = Color.Transparent;       //系统管理But
			StatisticalStatementBut.BackColor = Color.Transparent;  //统计报表But

			#endregion

			OutIntWarehousePanel.Visible = true;        //显示出入库Panel

			#region  隐藏Panel

			BasicMenuPanel.Visible = false;             //基础信息Panel
			SystemManagPanel.Visible = false;           //系统管理Panel
			StatisticalStatementPanel.Visible = false;  //统计报表Panel

			#endregion

		}
		#endregion

		#region 显示统计报表子菜单
		private void StatisticalStatementBut_MouseEnter(object sender, EventArgs e)
		{

			WorkPanel.Controls.Add(StatisticalStatementPanel); //重新加载统计报表子菜单
			StatisticalStatementPanel.BringToFront(); //统计报表子菜单顶层显示

			StatisticalStatementBut.BackColor = Color.Black;     //统计报表But背景变成黑色

			#region  非选择的button变成默认颜色
			HomeBut.BackColor = Color.Transparent;
			BasicInformBut.BackColor = Color.Transparent;           //基础信息But
			OutIntWarehouseBut.BackColor = Color.Transparent;       //出入库But
			SystemManagmentBut.BackColor = Color.Transparent;       //系统管理But

			#endregion

			StatisticalStatementPanel.Visible = true;  //显示统计报表Panel

			#region  隐藏Panel

			BasicMenuPanel.Visible = false;             //基础信息Panel
			SystemManagPanel.Visible = false;           //系统管理Panel
			OutIntWarehousePanel.Visible = false;        //出入库Panel

			#endregion

		}
		#endregion

		#region 显示首页子菜单
		private void HomeBut_MouseEnter(object sender, EventArgs e)
		{

			StatisticalStatementPanel.Visible = false;  //显示统计报表Panel
			BasicMenuPanel.Visible = false;             //基础信息Panel
			SystemManagPanel.Visible = false;           //系统管理Panel
			OutIntWarehousePanel.Visible = false;        //出入库Panel

			HomeBut.BackColor = Color.Black;
			StatisticalStatementBut.BackColor = Color.Transparent;      //统计报表But背景变成黑色
			BasicInformBut.BackColor = Color.Transparent;           //基础信息But
			OutIntWarehouseBut.BackColor = Color.Transparent;       //出入库But
			SystemManagmentBut.BackColor = Color.Transparent;       //系统管理But
		}
		#endregion

		#region 返回首页
		private void HomeBut_Click(object sender, EventArgs e)
		{
			WorkPanel.Controls.Clear();
			WorkPanel.BackgroundImage = Image.FromFile(@"Image\Background.PNG");
		}
		#endregion

		#region 离开子菜单下拉框区域下拉框自动隐藏
		private void WorkPanel_MouseEnter(object sender, EventArgs e)
		{
			StatisticalStatementPanel.Visible = false;  //显示统计报表Panel
			BasicMenuPanel.Visible = false;             //基础信息Panel
			SystemManagPanel.Visible = false;           //系统管理Panel
			OutIntWarehousePanel.Visible = false;        //出入库Panel

			HomeBut.BackColor = Color.Transparent;
			StatisticalStatementBut.BackColor = Color.Transparent;      //统计报表But背景变成黑色
			BasicInformBut.BackColor = Color.Transparent;           //基础信息But
			OutIntWarehouseBut.BackColor = Color.Transparent;       //出入库But
			SystemManagmentBut.BackColor = Color.Transparent;       //系统管理But
		}
		#endregion

		#region 子菜单按钮样式
		private void skinButton5_MouseEnter(object sender, EventArgs e)
		{

			if (sender.Equals(skinButton1)) //库位管理背景色变黑
			{
				skinButton1.BackColor = Color.Black;        //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管
				skinButton3.BackColor = Color.Transparent;  //库位类型管
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent; //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton2)) //部门人员管理背景色变黑
			{

				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Black;        //部门人员管
				skinButton3.BackColor = Color.Transparent;  //库位类型管
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent; //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton3)) //库位类型管理背景色变黑
			{

				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管
				skinButton3.BackColor = Color.Black;        //库位类型管
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent; //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton4)) //库柜管理背景色变黑
			{

				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管
				skinButton3.BackColor = Color.Transparent;  //库位类型管
				skinButton4.BackColor = Color.Black;        //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent; //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton5)) //房间管理背景色变黑
			{
				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管
				skinButton3.BackColor = Color.Transparent;  //库位类型管
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Black;       //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent; //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton6)) //数据备份管理背景色变黑
			{
				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管
				skinButton3.BackColor = Color.Transparent;  //库位类型管
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Black;       //数据备份
				skinButton7.BackColor = Color.Transparent; //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton7)) //系统日志
			{
				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管理
				skinButton3.BackColor = Color.Transparent;  //库位类型管理
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Black;       //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton8)) //用户注册背景色变黑
			{
				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管理
				skinButton3.BackColor = Color.Transparent;  //库位类型管理
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent;       //系统日志
				skinButton8.BackColor = Color.Black; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton9))
			{
				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管理
				skinButton3.BackColor = Color.Transparent;  //库位类型管理
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent;       //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Black;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton10)) //用户管理背景色变黑
			{
				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管理
				skinButton3.BackColor = Color.Transparent;  //库位类型管理
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent;       //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Black;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton11)) //入库登记背景色变黑
			{
				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管理
				skinButton3.BackColor = Color.Transparent;  //库位类型管理
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent;       //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Black;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton12)) //出库背景色变黑
			{
				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管理
				skinButton3.BackColor = Color.Transparent;  //库位类型管理
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent;       //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Black;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton13)) //房间管理背景色变黑
			{
				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管理
				skinButton3.BackColor = Color.Transparent;  //库位类型管理
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent;       //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Black;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton14)) //供应商管理背景色变黑
			{

				skinButton1.BackColor = Color.Transparent; //库位管理
				skinButton2.BackColor = Color.Transparent; //部门人员管理
				skinButton3.BackColor = Color.Transparent; //库位类型管理
				skinButton4.BackColor = Color.Transparent; //库柜管理
				skinButton5.BackColor = Color.Transparent;//房间管理
				skinButton6.BackColor = Color.Transparent;
				skinButton7.BackColor = Color.Transparent;
				skinButton8.BackColor = Color.Transparent;
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;
				skinButton11.BackColor = Color.Transparent;
				skinButton12.BackColor = Color.Transparent;
				skinButton13.BackColor = Color.Transparent;
				skinButton14.BackColor = Color.Black;//供应商管理
				skinButton15.BackColor = Color.Transparent;
				skinButton16.BackColor = Color.Transparent;
				skinButton17.BackColor = Color.Transparent;
				skinButton18.BackColor = Color.Transparent;
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton15)) //未完成入库背景色变黑
			{
				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管理
				skinButton3.BackColor = Color.Transparent;  //库位类型管理
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent;       //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Black;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton16)) //出入库汇总背景色变黑
			{
				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管理
				skinButton3.BackColor = Color.Transparent;  //库位类型管理
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent;       //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Black;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton17)) //在库汇总背景色变黑
			{
				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管理
				skinButton3.BackColor = Color.Transparent;  //库位类型管理
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent;       //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Black;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton18)) //入库日报
			{
				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管理
				skinButton3.BackColor = Color.Transparent;  //库位类型管理
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent;       //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Black;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton19))
			{
				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管理
				skinButton3.BackColor = Color.Transparent;  //库位类型管理
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent;       //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Black;
				skinButton20.BackColor = Color.Transparent;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton20)) //出库日报背景色变黑
			{
				skinButton1.BackColor = Color.Transparent;  //库位管理
				skinButton2.BackColor = Color.Transparent;  //部门人员管理
				skinButton3.BackColor = Color.Transparent;  //库位类型管理
				skinButton4.BackColor = Color.Transparent;  //库柜管理
				skinButton5.BackColor = Color.Transparent; //房间管理
				skinButton6.BackColor = Color.Transparent; //数据备份
				skinButton7.BackColor = Color.Transparent;       //系统日志
				skinButton8.BackColor = Color.Transparent; //用户注册
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;//用户管理
				skinButton11.BackColor = Color.Transparent;//入库登记
				skinButton12.BackColor = Color.Transparent;//出库登记
				skinButton13.BackColor = Color.Transparent;//未完成出库
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;//未完成入库
				skinButton16.BackColor = Color.Transparent;//出入库汇总
				skinButton17.BackColor = Color.Transparent;//在库汇总
				skinButton18.BackColor = Color.Transparent;//入库日报
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Black;//出库日报
				skinButton21.BackColor = Color.Transparent; //收获商管理
			}
			if (sender.Equals(skinButton21)) //供应商管理背景色变黑
			{

				skinButton1.BackColor = Color.Transparent; //库位管理
				skinButton2.BackColor = Color.Transparent; //部门人员管理
				skinButton3.BackColor = Color.Transparent; //库位类型管理
				skinButton4.BackColor = Color.Transparent; //库柜管理
				skinButton5.BackColor = Color.Transparent;//房间管理
				skinButton6.BackColor = Color.Transparent;
				skinButton7.BackColor = Color.Transparent;
				skinButton8.BackColor = Color.Transparent;
				skinButton9.BackColor = Color.Transparent;
				skinButton10.BackColor = Color.Transparent;
				skinButton11.BackColor = Color.Transparent;
				skinButton12.BackColor = Color.Transparent;
				skinButton13.BackColor = Color.Transparent;
				skinButton14.BackColor = Color.Transparent;//供应商管理
				skinButton15.BackColor = Color.Transparent;
				skinButton16.BackColor = Color.Transparent;
				skinButton17.BackColor = Color.Transparent;
				skinButton18.BackColor = Color.Transparent;
				skinButton19.BackColor = Color.Transparent;
				skinButton20.BackColor = Color.Transparent;
				skinButton21.BackColor = Color.Black; //收获商管理
			}

		}
		#endregion

		#region 加载工作窗体
		private void skinButton5_Click(object sender, EventArgs e)
		{
			WorkPanel.BackgroundImage = null;  //workpanel 背景设置为空
			WorkPanel.Controls.Clear();        //清楚工作区的控件

			if (sender.Equals(skinButton1)) //调用库位管理窗口
			{
				用户管理 StaffManage = new 用户管理();
				StaffManage.Dock = DockStyle.Fill;
				StaffManage.Location = new Point(1, 1);
				WorkPanel.Controls.Add(StaffManage);
			}

			if (sender.Equals(skinButton2)) //调用部门人员管理窗口
			{
				部门人员管理 DepartmentStaffManage = new 部门人员管理();
				DepartmentStaffManage.Dock = DockStyle.Fill;
				DepartmentStaffManage.Location = new Point(1, 1);
				WorkPanel.Controls.Add(DepartmentStaffManage);
			}

			if (sender.Equals(skinButton3)) //调用库位管理窗口
			{
				库位类型管理 StorageLocation = new 库位类型管理();
				StorageLocation.Dock = DockStyle.Fill;
				StorageLocation.Location = new Point(1, 1);
				WorkPanel.Controls.Add(StorageLocation);
			}

			if (sender.Equals(skinButton4)) //库柜管理
			{

			}

			if (sender.Equals(skinButton5))//房间管理
			{
				房间管理 房间管理 = new 房间管理();
				房间管理.Dock = DockStyle.Fill;
				房间管理.Location = new Point(1, 1);
				WorkPanel.Controls.Add(房间管理);
			}

			if (sender.Equals(skinButton6))//数据备份
			{
				数据备份 数据备份 = new 数据备份();
				数据备份.Dock = DockStyle.Fill;
				数据备份.Location = new Point(1, 1);
				WorkPanel.Controls.Add(数据备份);

			}
			if (sender.Equals(skinButton7))//系统日志
			{
				系统日志 系统日志 = new 系统日志();
				系统日志.Dock = DockStyle.Fill;
				系统日志.Location = new Point(1, 1);
				WorkPanel.Controls.Add(系统日志);
			}
			if (sender.Equals(skinButton8))//用户注册
			{
				用户管理注册 用户管理注册 = new 用户管理注册();
				用户管理注册.Dock = DockStyle.Fill;
				用户管理注册.Location = new Point(1, 1);
				WorkPanel.Controls.Add(用户管理注册);
			}
			if (sender.Equals(skinButton9))
			{

			}
			if (sender.Equals(skinButton10))//用户管理
			{
				用户管理 用户管理 = new 用户管理();
				用户管理.Dock = DockStyle.Fill;
				用户管理.Location = new Point(1, 1);
				WorkPanel.Controls.Add(用户管理);
			}
			if (sender.Equals(skinButton11))//入库登记
			{
				WorkPanel.BackgroundImage = null;
				WorkPanel.Controls.Clear();
				InWareHouse usercontrol = new InWareHouse();
				usercontrol.Dock = DockStyle.Fill;
				WorkPanel.Controls.Add(usercontrol);
			}
			if (sender.Equals(skinButton12))   //出库登记
			{
				WorkPanel.BackgroundImage = null;
				WorkPanel.Controls.Clear();
				OutWareHouse usercontrol = new OutWareHouse();
				usercontrol.Dock = DockStyle.Fill;
				WorkPanel.Controls.Add(usercontrol);
			}
			if (sender.Equals(skinButton13))  //未完成出库
			{
				未完成出库 未完成出库 = new 未完成出库();
				未完成出库.Dock = DockStyle.Fill;
				未完成出库.Location = new Point(1, 1);
				WorkPanel.Controls.Add(未完成出库);
			}
			if (sender.Equals(skinButton14))  //供应商管理
			{
				供应商管理 供应商管理 = new 供应商管理();
				供应商管理.Dock = DockStyle.Fill;
				供应商管理.Location = new Point(1, 1);
				WorkPanel.Controls.Add(供应商管理);

			}
			if (sender.Equals(skinButton15))  //未完成入库
			{
				未完成入库 未完成入库 = new 未完成入库();
				未完成入库.Dock = DockStyle.Fill;
				未完成入库.Location = new Point(1, 1);
				WorkPanel.Controls.Add(未完成入库);
			}
			if (sender.Equals(skinButton16))  //出入库汇总
			{
				出入库汇总 出入库汇总 = new 出入库汇总();
				出入库汇总.Dock = DockStyle.Fill;
				出入库汇总.Location = new Point(1, 1);
				WorkPanel.Controls.Add(出入库汇总);
			}
			if (sender.Equals(skinButton17))  //在库汇总
			{
				在库汇总 在库汇总 = new 在库汇总();
				在库汇总.Dock = DockStyle.Fill;
				在库汇总.Location = new Point(1, 1);
				WorkPanel.Controls.Add(在库汇总);
			}
			if (sender.Equals(skinButton18))  //入库日报
			{
				入库日报 入库日报 = new 入库日报();
				入库日报.Dock = DockStyle.Fill;
				入库日报.Location = new Point(1, 1);
				WorkPanel.Controls.Add(入库日报);

			}
			if (sender.Equals(skinButton19))
			{

			}
			if (sender.Equals(skinButton20))//出库日报
			{
				出库日报 出库日报 = new 出库日报();
				出库日报.Dock = DockStyle.Fill;
				出库日报.Location = new Point(1, 1);
				WorkPanel.Controls.Add(出库日报);
			}
			if (sender.Equals(skinButton21))//收获商管理
			{
				收货商管理 收获商管理 = new 收货商管理();
				收获商管理.Dock = DockStyle.Fill;
				收获商管理.Location = new Point(1, 1);
				WorkPanel.Controls.Add(收获商管理);
			}
		}

		#endregion

		
	}
}
