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

namespace Warehouse
{
    public partial class 入库折线图 : UITitlePage
    {
        public 入库折线图()
        {
            InitializeComponent();
            UILineOption option = new UILineOption();
            option.ToolTip.Visible = true;
            option.Title = new UITitle();
            option.Title.Text = "入库折线图";
            option.Title.SubText = "入库日期为2021年";
            var series = option.AddSeries(new UILineSeries("Line1"));
            series.Symbol = UILinePointSymbol.Square;
            //series.SymbolSize = 4;
            //series.SymbolLineWidth = 2;
            //series.SymbolColor = Color.Red;

            option.XAxis.Name = "月份";
            option.YAxis.Name = "数值";
            //option.XAxis.AxisLabel.DateTimeFormat = DateTimeEx.DateTimeFormat;

            BLL.enter_storage bllin = new BLL.enter_storage();
            string sql = "SELECT MONTH(enter_date) MONTH,ROUND(SUM(enter_amount)) subtotal FROM enter_storage WHERE YEAR(enter_date) = 2021 GROUP BY MONTH";
            DataSet ds = bllin.getDataList(sql);
            int count1 = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count1; i++)
            {
                series.Add(Convert.ToInt32(ds.Tables[0].Rows[i][0]), Convert.ToInt32(ds.Tables[0].Rows[i][1]));
                //option.Series.Add(series);
                //option.XAxis.Data.Add(Convert.ToString(ds.Tables[0].Rows[i][0]));

            }
            uiLineChart1.SetOption(option);
        }
        //查询
        private void uiButton1_Click(object sender, EventArgs e)
        {
            UILineOption option = new UILineOption();
            option.ToolTip.Visible = true;
            option.Title = new UITitle();
            option.Title.Text = "入库折线图";
            
            var series = option.AddSeries(new UILineSeries("Line1"));
            series.Symbol = UILinePointSymbol.Square;
            //series.SymbolSize = 4;
            //series.SymbolLineWidth = 2;
            //series.SymbolColor = Color.Red;

            option.XAxis.Name = "月份";
            option.YAxis.Name = "数值";
            //option.XAxis.AxisLabel.DateTimeFormat = DateTimeEx.DateTimeFormat;
            //输入的年份
            string year = uiTextBox1.Text.Trim();
            option.Title.SubText = "入库日期为"+year+"年";
            BLL.enter_storage bllin = new BLL.enter_storage();
            string sql = "SELECT MONTH(enter_date) MONTH,ROUND(SUM(enter_amount)) subtotal FROM enter_storage WHERE YEAR(enter_date) = "+year+" GROUP BY MONTH";
            DataSet ds = bllin.getDataList(sql);
            int count1 = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count1; i++)
            {
                series.Add(Convert.ToInt32(ds.Tables[0].Rows[i][0]), Convert.ToInt32(ds.Tables[0].Rows[i][1]));
                //option.Series.Add(series);
                //option.XAxis.Data.Add(Convert.ToString(ds.Tables[0].Rows[i][0]));

            }
            uiLineChart1.SetOption(option);
        }
    }
}
