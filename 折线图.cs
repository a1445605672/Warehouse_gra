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
            // 配置LineChart
            option = new UILineOption();
            option.ToolTip.Visible = true;
            // 设置标题
            option.Title = new UITitle();
            option.Title.Text = "在库物料汇总";
            option.Title.SubText = "折线图";

            // 横坐标数据类型
            option.XAxisType = UIAxisType.Value;

            // 设置系列1
            var series = option.AddSeries(new UILineSeries("Line1"));
            float[] x = { 1, 2, 3, 4, 5, 6, 7 };
            float[] y = { 2, 4, 6, 8, 10, 12, 14 };
            for (int i = 0; i < x.Length; i++)
            {
                series.Add(x[i], y[i]);
            }
            // 点的图标
            series.Symbol = UILinePointSymbol.Square;
            // 图标大小
            series.SymbolSize = 4;
            // 折线宽度
            series.SymbolLineWidth = 2;
            // 图标颜色
            series.SymbolColor = Color.Red;


            // 设置系列2
            //series = option.AddSeries(new UILineSeries("Line2", Color.Lime));

            //float[] x2 = { 1, 2, 3, 4, 5, 6, 7 };
            //float[] y2 = { 3, 6, 9, 12, 15, 18, 21 };
            //for (int i = 0; i < x.Length; i++)
            //{
            //    series.Add(x2[i], y2[i]);
            //}
            // 点的图标
            series.Symbol = UILinePointSymbol.Star;
            // 图标大小
            series.SymbolSize = 4;
            // 折线宽度
            series.SymbolLineWidth = 2;
            // 折线颜色
            series.SymbolColor = Color.Red;
            // 平滑曲线
            series.Smooth = true;

            // 设置纵坐标上限红线
            //option.GreaterWarningArea = new UILineWarningArea(3.5);
            // 设置纵坐标下线黄线
            //option.LessWarningArea = new UILineWarningArea(2.2, Color.Gold);
            //option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "上限", Value = 3.5 });
            //option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Gold, Name = "下限", Value = 2.2 });

            // 横坐标名称
            option.XAxis.Name = "事件";
            // 纵坐标名称
            option.YAxis.Name = "数值";
            option.XAxis.AxisLabel.DateTimeFormat = DateTimeEx.DateTimeFormat;
            // 设置竖向的红线
            option.XAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "x上界", Value = 50 });
            option.XAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "x下界", Value = -50 });
            // 更新配置
            uiLineChart1.SetOption(option);
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            // 更新数据
            // 注意，两个系列的长度不要差太多，否则会抛出内存溢出的异常
            UILineSeries serie = option.Series["Line1"];
            // 添加5个点
            for (int i = 0; i < 5; i++)
            {
                double newX = serie.XData[serie.XData.Count - 1] * 1.5;
                double newY = serie.XData[serie.YData.Count - 1] * 1.5;
                serie.Add(newX, newY);
            }
            option.Series["Line1"] = serie;
            uiLineChart1.SetOption(option);
        }
    }
}
