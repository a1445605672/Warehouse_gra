using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;

namespace Warehouse
{
	public partial class 出库登记 : UITitlePage
    {
		public 出库登记()
		{
			InitializeComponent();


			uiDataGridView1.AddColumn("Column1", "Column1").SetFixedMode(200);
			uiDataGridView1.AddColumn("Column2", "Column2").SetFixedMode(200);
			uiDataGridView1.AddColumn("Column3", "Column3").SetFixedMode(200);
			uiDataGridView1.AddColumn("Column4", "Column4").SetFixedMode(200);
            uiDataGridView1.AddButtonColumn("修改", "修改",20,true);
            DataGridViewButtonColumn but = new DataGridViewButtonColumn();
            but.HeaderText = "修改";
            but.Name = "Update";
            but.DefaultCellStyle.NullValue = "修改";
            uiDataGridView1.Columns.Add(but);

			uiDataGridView1.ReadOnly = true;

            

        }

        

        public class Data
        {
            public string Column1 { get; set; }

            public string Column2 { get; set; }

            public string Column3 { get; set; }

            public bool Column4 { get; set; }

            public override string ToString()
            {
                return Column1;
            }
        }

		private void 出库_Load(object sender, EventArgs e)
		{
            List<Data> datas = new List<Data>();
            for (int i = 0; i < 3650; i++)
            {
                Data data = new Data();
                data.Column1 = "Data" + i.ToString("D2");
                data.Column2 = i.Mod(2) == 0 ? "A" : "B";
                data.Column3 = "编辑";
                data.Column4 = i.Mod(4) == 0;
                datas.Add(data);
            }
            uiPagination1.DataSource = datas;
            uiPagination1.ActivePage = 1;
        }
		private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
		{
            uiDataGridView1.DataSource = pagingSource;
        }
	}
}
