using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBUtility;
namespace Warehouse
{
    public partial class 综合统计分析 : UITitlePage
    {
        BLL.enter_storage bllenter = new BLL.enter_storage();
        BLL.out_storage bllout = new BLL.out_storage();
        BLL.in_storage bllin = new BLL.in_storage();
        BLL.material_type blltype = new BLL.material_type();
        BLL.log_info blllog = new BLL.log_info();
        BLL.staff bllstaff = new BLL.staff();
        SumCount sum1 = new SumCount();

        public 综合统计分析()
        {
            InitializeComponent();
        }
        //统计分析
        private void uiButton1_Click(object sender, EventArgs e)
        {
            //入库情况查询
            //方法 GetCount(string tablename, string columnname, DateTime start, DateTime end,string datetype)
            DateTime time1 = DateTime.Parse(uiDatePicker1.Value.ToString());
            DateTime time2 = DateTime.Parse(uiDatePicker2.Value.ToString());
            //入库数量
            int recordnum = sum1.GetCount("enter_storage", "enter_amount", time1, time2, "enter_date");
            labEnterNum.Text = Convert.ToString(recordnum);
            //入库体积
            int volumnNum = sum1.GetCount("enter_storage", "enter_unit_bulk", time1, time2, "enter_date");
            labEnterV.Text = Convert.ToString(volumnNum);
            //批次数
            //每次的入库会有重复的批次，这样写的目的是为了消除重复的批次号
            int batchNum = sum1.GetBatNum(time1, time2);
            label124.Text = Convert.ToString(batchNum);
            //入库次数
            label122.Text = Convert.ToString(sum1.GetEnterNum(time1, time2));
            //剩余库柜
            label132.Text = Convert.ToString(sum1.GetChestNum(time1, time2));
            //剩余库位
            label130.Text = Convert.ToString(sum1.GetSeat(time1, time2));
            //合计 总数量
            label113.Text = Convert.ToString(recordnum);


            //出库模块
            lbOutNum.Text = Convert.ToString(sum1.GetCount("out_storage", "out_account", time1, time2, "out_data"));
            //出库次数
            lbOutCi.Text = Convert.ToString(sum1.GetOutNum(time1, time2));

            //在库数量
            lbinSt.Text = Convert.ToString(sum1.GetInData(time1, time2, "in_amount"));
            //在库重量
            lbinWeight.Text = Convert.ToString(sum1.GetInData(time1, time2, "in_weight"));
            //在库体积
            lbinVo.Text = Convert.ToString(sum1.GetInData(time1, time2, "in_volume"));

            //物料种类
            lbtypeNum.Text = Convert.ToString(sum1.GetMatType());
            //系统日志记录
            lbdairyNum.Text = Convert.ToString(sum1.GetDairyNum(time1, time2));
            //仓库员工
            lbStaffNum.Text = Convert.ToString(sum1.GetStaffNum());
        }
    }
}
