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
    public partial class 库存控制 : UITitlePage
    {
        public 库存控制()
        {
            InitializeComponent();
            //库存控制思路：
            //1、根据物料ID对于在库物料的重量进行求和
            //2、构建一个  物料ID-上限-下限表，每一个物料ID都会有上下限
            //3、如果在库求和  超出或者小于上下限，进行提示
        }
    }
}
