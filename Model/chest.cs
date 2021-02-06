using System;
namespace Model
{
    
    [Serializable]
    public partial class chest
    {
        public chest()
        { }
        #region Model
        private string _chest_id;
        private string _chest_name;
        private decimal? _chest_remain_volume;
        private int? _chest_remain_seat;
        private DateTime? _chest_create_time;
        private string _chest_type;
        private string _chest_belong_storage;
        private string _chest_sx;
        /// <summary>
        /// 
        /// </summary>
        public string chest_id
        {
            set { _chest_id = value; }
            get { return _chest_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string chest_name
        {
            set { _chest_name = value; }
            get { return _chest_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? chest_remain_volume
        {
            set { _chest_remain_volume = value; }
            get { return _chest_remain_volume; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? chest_remain_seat
        {
            set { _chest_remain_seat = value; }
            get { return _chest_remain_seat; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? chest_create_time
        {
            set { _chest_create_time = value; }
            get { return _chest_create_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string chest_type
        {
            set { _chest_type = value; }
            get { return _chest_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string chest_belong_storage
        {
            set { _chest_belong_storage = value; }
            get { return _chest_belong_storage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string chest_sx
        {
            set { _chest_sx = value; }
            get { return _chest_sx; }
        }
        #endregion Model

    }
}

