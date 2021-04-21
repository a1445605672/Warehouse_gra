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

namespace Warehouse.工具窗体
{
    public partial class kugui : UIEditForm
    {
        public kugui()
        {
            InitializeComponent();
            BLL.chest bllchest = new BLL.chest();
        }
        public Model.chest chestModel;
        public Model.chest ChestModel
        {
            get 
            {
                if (chestModel == null)
                {
                    //房间编号为库柜所属的仓库
                    chestModel = new Model.chest();
                    //库柜ID,系统自动生成，无需更改
                    //chestModel.chest_id =
                    //库柜名
                    chestModel.chest_name = chestName.Text.Trim();
                    //剩余体积
                    chestModel.chest_remain_volume = tijileft.IntValue;
                    chestModel.chest_remain_seat = kuweileft.IntValue;
                    chestModel.chest_create_time = DateTime.Now;
                    chestModel.chest_type = uiComboBox1.SelectedValue.ToString();
                    //所属房间
                    chestModel.chest_belong_storage = RoomID.Text.Trim();
                    chestModel.chest_sx = txtSuo1.Text.Trim();
                }
                return chestModel;
            }
            set
            {
                
            }
        }
        //库柜类型的加载
        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //ListBox中添加
        private void uiRichTextBox1_Load(object sender, EventArgs e)
        {
            BLL.storage bllstorage = new BLL.storage();
            DataSet ds = new DataSet();
            ds = bllstorage.GetList(0);
            int num = ds.Tables[0].Rows.Count;
            for (int i = 0; i < num; i++)
            {
                uiListBox1.Items.Add(ds.Tables[0].Rows[i][0]);
                //ds.Tables[0].Rows[i][0];  
            }
        }

        private void kugui_Load(object sender, EventArgs e)
        {

        }

        private void uiListBox1_Load(object sender, EventArgs e)
        {
            BLL.storage bllstorage = new BLL.storage();
            DataSet ds = new DataSet();
            ds = bllstorage.GetList(0);
            int num = ds.Tables[0].Rows.Count;
            for (int i = 0; i < num; i++)
            {
                uiListBox1.Items.Add(ds.Tables[0].Rows[i][0]);
                //ds.Tables[0].Rows[i][0];  
            }
        }
    }
}
