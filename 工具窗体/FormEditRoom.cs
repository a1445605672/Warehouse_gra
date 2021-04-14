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
                    storageModel.storage_id = RoomID.Text.Trim();
                    storageModel.storage_name = RoomName.Text.Trim();
                    storageModel.storage_area = RoomArea.IntValue;
                    storageModel.storage_remain_chest = Chestleft.IntValue;
                    storageModel.storage_remain_seat = Locationleft.IntValue;
                    storageModel.storage_comment = backinfo.Text.Trim();
                    storageModel.storage_create_time = DateTime.Now;

                }
                return storageModel;
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
