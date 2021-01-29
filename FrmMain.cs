using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 毕设
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //空事件，不可删除
        private void tsmiAddStudent_Click(object sender, EventArgs e)
        {

        }
        //空事件，不可删除
        private void tsmiManageStudent_Click(object sender, EventArgs e)
        {

        }

        /*
         * 下面为所有注册事件
         */

        //退出
        private void tmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
       
        private void tsbAddStudent_Click(object sender, EventArgs e)
        {
            tsmiAddStudent_Click(null, null);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tsmiManageStudent_Click(null, null);
        }
        private void tsbScoreAnalysis_Click(object sender, EventArgs e)
        {
            tsmiQueryAndAnalysis_Click(null, null);
        }
       

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            tsmiQuery_Click(null, null);
        }
      
      


        //关闭主系统窗口
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否要离开", "离开", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK)
            {
 
                e.Cancel = true;
            }
        }
        //入库操作
        private void tsbInIN_Click(object sender, EventArgs e)
        {

        }
        //浏览官网
        private void Frmweb_Click(object sender, EventArgs e)
        {

        }
        //出库操作
        private void toolOutout_Click(object sender, EventArgs e)
        {

        }
        //在库汇总
        private void tsbAmout_Click(object sender, EventArgs e)
        {

        }
        //系统日志
        private void tsbSyslog_Click(object sender, EventArgs e)
        {

        }
        //修改密码
        private void tmiModifyPwd_Click(object sender, EventArgs e)
        {

        }
        //退出系统
        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //修改密码
        private void tsbModifyPwd_Click(object sender, EventArgs e)
        {
            tmiModifyPwd_Click(null, null);
        }
        //库柜管理
        private void tsmikuguiMan_Click(object sender, EventArgs e)
        {

        }
        //库位管理
        private void toolkuguiMan_Click(object sender, EventArgs e)
        {

        }
        //库位类型管理
        private void toolkuweitypeMan_Click(object sender, EventArgs e)
        {

        }
        //物料类别管理
        private void toolWuliaoMan_Click(object sender, EventArgs e)
        {

        }
        //部门管理
        private void toolDepartMan_Click(object sender, EventArgs e)
        {

        }
        //部门人员管理
        private void toolSysMan_Click(object sender, EventArgs e)
        {

        }
        //供应人管理
        private void toolGongyingMan_Click(object sender, EventArgs e)
        {

        }
        //供应人管理
        private void toolShouhuoMan_Click(object sender, EventArgs e)
        {

        }
        //数据备份
        private void tsmiQueryAndAnalysis_Click(object sender, EventArgs e)
        {
          
        }
        //系统日志
        private void tsmiQuery_Click(object sender, EventArgs e)
        {
           
        }
        //用户管理
        private void toolUserMan_Click(object sender, EventArgs e)
        {

        }     
        //用户注册管理
        private void toolManReg_Click(object sender, EventArgs e)
        {

        }
        //入库登记
        private void tsmi_Card_Click(object sender, EventArgs e)
        {
  
        }
        //出库登记
        private void toolOutout2_Click(object sender, EventArgs e)
        {

        }
        //开柜盘点
        private void toolOpen_Click(object sender, EventArgs e)
        {

        }
        //物料盘点
        private void toolWuliaopan_Click(object sender, EventArgs e)
        {

        }
        //饼状图
        private void toolBing_Click(object sender, EventArgs e)
        {

        }
        //柱状图
        private void toolZhu_Click(object sender, EventArgs e)
        {

        }
        //入库日报
        private void toolIndai_Click(object sender, EventArgs e)
        {

        }
        //出库日报
        private void toolOutdai_Click(object sender, EventArgs e)
        {

        }
        //出入库汇总
        private void toolAmount_Click(object sender, EventArgs e)
        {

        }
        //在库汇总
        private void toolInAmount_Click(object sender, EventArgs e)
        {

        }

    }
}