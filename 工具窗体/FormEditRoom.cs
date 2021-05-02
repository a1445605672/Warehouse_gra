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
using Model;
namespace Warehouse.工具窗体
{
    public partial class FormEditRoom : UIEditForm
    {
        public FormEditRoom()
        {
            InitializeComponent();
        }
        public Model.storage storageModel;
        public Model.storage StorageModel
        {
            get
            {
                if (storageModel == null)
                {
                    storageModel = new Model.storage();
                    //房间编号的生成
                    BLL.storage bllstor = new BLL.storage();
                    //从数据库中查询对应几条数据，那么下一次的记录直接加1
                    int num = bllstor.GetRecordCount("1=1");
                    //num自加一次
                    num += 1;
                    //房间根据面积分为 A B C 三个等级
                    // levelA 0-20 平方米
                    // levelB 20-40平方米
                    // levelC >=40平方米
                    int RoomAreaNum = Convert.ToInt32(RoomArea.Text);
                    //LevelA
                    if (0 <= RoomAreaNum && RoomAreaNum <= 20)
                    {
                        storageModel.storage_id = "A" + num + "";
                    }
                    //levelB
                    if (20 <= RoomAreaNum && RoomAreaNum <= 40)
                    {
                        storageModel.storage_id = "B" + num + "";
                    }
                    //levelC
                    else
                    {
                        storageModel.storage_id = "C" + num + "";
                    }
                    //storageModel.storage_id = RoomID.Text.Trim();
                    storageModel.storage_name = RoomName.Text.Trim();
                    storageModel.storage_area = Convert.ToInt32(RoomArea.Text);
                    storageModel.storage_remain_chest = Convert.ToInt32(Chestleft.Text);
                    storageModel.storage_remain_seat = Convert.ToInt32(Locationleft.IntValue);
                    storageModel.storage_comment = backinfo.Text.Trim();
                    storageModel.storage_create_time = DateTime.Now;
                    return storageModel;

                }
                else
                {
                    //storageModel.storage_id = RoomID.Text.Trim();
                    storageModel.storage_name = RoomName.Text.Trim();
                    storageModel.storage_area = RoomArea.IntValue;
                    storageModel.storage_remain_chest = Chestleft.IntValue;
                    storageModel.storage_remain_seat = Locationleft.IntValue;
                    storageModel.storage_comment = backinfo.Text.Trim();
                    return storageModel;
                }
               
            }
            set
            {
            }
            
        }
        //编辑时为文本框赋值
        public bool FuZhi(string id)
        {
            BLL.storage sta = new BLL.storage();
            storageModel = sta.GetModel(id);
            if (storageModel != null)
            {
                RoomID.Text = storageModel.storage_id;
                RoomName.Text = storageModel.storage_name;
                RoomArea.Text = storageModel.storage_area.ToString();
                Locationleft.Text = storageModel.storage_remain_seat.ToString();
                Chestleft.Text = storageModel.storage_remain_chest.ToString();
                backinfo.Text = storageModel.storage_comment;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
    }
   
    
   
}
