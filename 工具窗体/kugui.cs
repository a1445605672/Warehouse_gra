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
                //新增
                if (chestModel == null)
                {
                    //房间编号为库柜所属的仓库
                    chestModel = new Model.chest();
                    //库柜ID,系统自动生成，无需更改
                    chestModel.chest_id = chestID.Text.Trim();
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
                    return chestModel;
                }
                //更改
                else
                {
                    //房间编号为库柜所属的仓库
                    //chestModel = new Model.chest();
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
                    return chestModel;
                }
                
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
        //库柜类型加载
        private void uiComboBox1_Load(object sender, EventArgs e)
        {
            BLL.chest_type blltype = new BLL.chest_type();
            uiComboBox1.DataSource = blltype.GetModelList("");
            uiComboBox1.DisplayMember = "type_id";
            uiComboBox1.ValueMember = "type_id";
        }
        //双击进行选择房间
        private void uiButton1_Click(object sender, EventArgs e)
        {
            RoomID.Text = Convert.ToString(uiListBox1.SelectedItem.ToString());
            //根据房间编号生成库柜编号
            //获取库柜数目
            BLL.chest bllchest = new BLL.chest();
            int num = bllchest.GetRecordCount("1=1");
            num += 1;
            //根据房间名字获取房间编号
            BLL.storage bllstorage = new BLL.storage();
            DataSet ds= bllstorage.getDataList("SELECT storage_id FROM storage WHERE storage_name='"+RoomID.Text+ "'");
            //拿到了房间编号
            string RoomValue = ds.Tables[0].Rows[0][0].ToString();
            //对于库柜编号加以实现
            chestID.Text = RoomValue + "chest" + num;
        }
        public bool FuZhi(string id)
        {
            BLL.chest bllchest = new BLL.chest();
            chestModel = bllchest.GetModel(id);
            if (chestModel != null)
            {
                //所属房间
                RoomID.Text = chestModel.chest_belong_storage;
                //库柜编号
                chestID.Text = chestModel.chest_id;
                //库柜名称
                chestName.Text = chestModel.chest_name;
                //剩余体积
                tijileft.Text = Convert.ToString(chestModel.chest_remain_volume);
                //剩余库位
                kuweileft.Text = Convert.ToString(chestModel.chest_remain_seat);
                //库柜类型
                uiComboBox1.SelectedValue = Convert.ToString(chestModel.chest_type);
                //名称缩写
                txtSuo1.Text = chestModel.chest_sx;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
