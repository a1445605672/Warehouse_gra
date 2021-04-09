using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Clechart
    {
    }
    public class XAxis
    {
        /// <summary>
        /// 坐标轴类型
        /// </summary>
        public string type { get; set; } = "category";

        /// <summary>
        /// 类目数据
        /// </summary>
        public List<string> data { get; set; }
    }
    public class YAxis
    {
        /// <summary>
        /// 坐标轴类型
        /// </summary>
        public string type { get; set; } = "value";
    }
    public class SeriesItem
    {
        /// <summary>
        /// 每个系列通过 type 决定自己的图表类型
        /// </summary>
        public string type { get; set; }

        public string name { get; set; }

        /// <summary>
        /// 系列中的数据内容数组
        /// </summary>
        public List<int> data { get; set; }
    }
    public class Legend
    {
        /// <summary>
        /// 图例名称
        /// </summary>
        public List<string> data { get; set; }
    }
    public class Title
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string text { get; set; }
    }
    public class Tooltip_echart
    {

    }

    public class Option
    {
        public Legend legend { get; set; }
        public Title title { get; set; }
        public Tooltip_echart tooltip { get; set; }
        /// <summary>
        /// x轴
        /// </summary>
        public XAxis xAxis { get; set; }

        /// <summary>
        /// y轴
        /// </summary>
        public YAxis yAxis { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        public List<SeriesItem> series { get; set; }
        public int animationDuration { get; set; }
    }
}
