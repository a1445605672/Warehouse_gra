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
    public partial class 柱状图 : UITitlePage
    {
        private UIBarOption option;
        public 柱状图()
        {
            InitializeComponent();
            // 配置参数
            option = new UIBarOption();
            // 配置标题
            option.Title = new UITitle();
            // 主标题
            option.Title.Text = "在库物料汇总";
            // 副标题
            option.Title.SubText = "柱状图";

            // 设置图例
            option.Legend = new UILegend();
            // 图例水平布局
            option.Legend.Orient = UIOrient.Horizontal;
            // 图例放置在左上角
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;
            // 两个图例分别是Bar1和Bar2
            option.Legend.AddData("Bar1");
            //option.Legend.AddData("Bar2");

            // 设置系列
            UIBarSeries series = new UIBarSeries();
            // 第一系列Bar1
            series.Name = "数量";
            //进行填充数量（在in_storage中是mat_amount）
            BLL.in_storage bllin = new BLL.in_storage();
            string sql = "SELECT mat_name,SUM(in_amount) AS acount FROM in_storage GROUP BY mat_name";
            DataSet ds = bllin.Getdata1(sql);
            int count1 = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count1; i++)
            {
                series.AddData(Convert.ToInt32(ds.Tables[0].Rows[i][1]));
                option.XAxis.Data.Add(Convert.ToString(ds.Tables[0].Rows[i][0]));
                option.Series.Add(series);

            }
            //series.AddData(2.1);
            //series.AddData(2.1);
            //series.AddData(2.1);
            //series.AddData(2.1);
            //series.AddData(2.1);
            //option.Series.Add(series);

            // 设置第二系列Bar2
            //series = new UIBarSeries();
            //series.Name = "Bar2";
            //series.AddData(1.1);
            //series.AddData(1.1);
            //series.AddData(1.1);
            //series.AddData(1.1);
            //series.AddData(1.1);
            //option.Series.Add(series);

            // 设置横坐标内容
            // 第一系列和第二系列的元素交织分布
            // 所以Mon是指第一和二系列的第一个元素的横坐标
            // Tue指第一和二系列的第二个元素的横坐标

            //填充物料的值
            //option.XAxis.Data.Add("Mon");
            //option.XAxis.Data.Add("Tue");
            //option.XAxis.Data.Add("Wed");
            //option.XAxis.Data.Add("Thu");
            //option.XAxis.Data.Add("Fri");

            // 辅助ToolTip是否可见
            option.ToolTip.Visible = true;
            // Y轴的刻度
            option.YAxis.Scale = true;
            // XY轴的单位
            option.XAxis.Name = "物料名称";
            option.YAxis.Name = "物料数值";
            // 标记处上下限（数值超过了也没事）
            //option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "上限", Value = 12 });
            //option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Gold, Name = "下限", Value = -20 });
            // 更新坐标轴
            BarChart.SetOption(option);
        }
        private void bt2_Click_1(object sender, EventArgs e)
        {
            // 更新数据
            UIBarSeries serie = option.Series[0];
            List<double> datasList = serie.Data;
            double[] datas = datasList.ToArray();
            serie.Clear();
            for (int i = 0; i < datas.Length; i++)
            {
                datas[i] += (i + 1) * 1.1;
                // 没有提供直接修改的方法，所以要清空后，再将新的数据重新装入
                serie.AddData(datas[i]);
            }
            option.Series[0] = serie;
            // 更新
            BarChart.SetOption(option);
        }
    }
}

