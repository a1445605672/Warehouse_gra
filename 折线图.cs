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
    public partial class 折线图 : UITitlePage
    {
        private UILineOption option;
        public 折线图()
        {
            InitializeComponent();
            var option = new UIPieOption();

            //设置Title
            option.Title = new UITitle();
            option.Title.Text = "在库物料汇总";
            option.Title.SubText = "饼状图";
            option.Title.Left = UILeftAlignment.Center;

            //设置ToolTip
            option.ToolTip.Visible = true;

            //设置Legend
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;





            //设置Series
            var series = new UIPieSeries();
            series.Name = "信息详情";
            series.Center = new UICenter(50, 55);
            series.Radius = 70;
            series.Label.Show = true;

            BLL.in_storage bllin = new BLL.in_storage();
            string sql = "SELECT mat_name,SUM(in_amount) AS acount FROM in_storage GROUP BY mat_name";
            DataSet ds = bllin.Getdata1(sql);
            int count1 = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count1; i++)
            {
                option.Legend.AddData(Convert.ToString(ds.Tables[0].Rows[i][0]));
                series.AddData(Convert.ToString(ds.Tables[0].Rows[i][0]), Convert.ToInt32(ds.Tables[0].Rows[i][1]));
                option.Series.Add(series);
            }

            //增加数据
            //series.AddData("2020-05-19", 38);
            //series.AddData("2020-05-20", 21);
            //series.AddData("2020-05-21", 11);
            //series.AddData("2020-05-22", 52);
            //series.AddData("2020-05-23", 23);
            //series.AddData("2020-05-24", 26);
            //series.AddData("2020-05-25", 27);

            //增加Series
            //option.Series.Add(series);

            //设置Option
            uiPieChart1.SetOption(option);
        }
    }
}
