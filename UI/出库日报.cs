using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace 毕设
{
    public partial class 出库日报 : UserControl
    {
        public 出库日报()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.log_info m = new Model.log_info();
            m.log_num = 3;
            m.log_type = 5;
            m.log_describe = "888";
            BLL.log_info b = new BLL.log_info();
            b.Add(m);
        }
    }
}
