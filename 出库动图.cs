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
    public partial class 出库动图 : UITitlePage
    {
        public 出库动图()
        {
            InitializeComponent();
            var option = new UIDoughnutOption();

            //设置Title
            option.Title = new UITitle();
            option.Title.Text = "出库动图";
            option.Title.SubText = "详情";
            option.Title.Left = UILeftAlignment.Center;
            //设置ToolTip
            option.ToolTip.Visible = true;

            //设置Legend
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;

           
          
            //设置Series
            var series = new UIDoughnutSeries();
            series.Name = "Star count";
            series.Center = new UICenter(50, 55);
            series.Radius.Inner = 40;
            series.Radius.Outer = 70;
            series.Label.Show = true;
            series.Label.Position = UIPieSeriesLabelPosition.Center;

            BLL.out_storage bllout = new BLL.out_storage();
            string sql = "SELECT out_mat_name,SUM(out_account) AS acount FROM out_storage GROUP BY out_mat_name";
            DataSet ds = bllout.getDataList(sql);
            int count1 = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count1; i++)
            {
                //增加数据
                option.Legend.AddData(Convert.ToString(ds.Tables[0].Rows[i][0]));
                //增加数据
                series.AddData(Convert.ToString(ds.Tables[0].Rows[i][0]),Convert.ToInt32(ds.Tables[0].Rows[i][1]));
            }


            //增加Series
            option.Series.Add(series);

            //设置Option
            uiDoughnutChart1.SetOption(option);

        }
    }
}
