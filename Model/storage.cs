using System;
namespace Model
{
	/// <summary>
	/// storage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class storage
	{
		public storage()
		{}
        #region Model
        private string _storage_id;
        private string _storage_name;
        private DateTime _storage_create_time;
        private decimal? _storage_area;
        private int? _storage_remain_chest;
        private int? _storage_remain_seat;
        private string _storage_comment;
        private string _storage_sx;
        /// <summary>
        /// 
        /// </summary>
        public string storage_id
        {
            set { _storage_id = value; }
            get { return _storage_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string storage_name
        {
            set { _storage_name = value; }
            get { return _storage_name; }
        }
        /// <summary>
        /// on update CURRENT_TIMESTAMP(6)
        /// </summary>
        public DateTime storage_create_time
        {
            set { _storage_create_time = value; }
            get { return _storage_create_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? storage_area
        {
            set { _storage_area = value; }
            get { return _storage_area; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? storage_remain_chest
        {
            set { _storage_remain_chest = value; }
            get { return _storage_remain_chest; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? storage_remain_seat
        {
            set { _storage_remain_seat = value; }
            get { return _storage_remain_seat; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string storage_comment
        {
            set { _storage_comment = value; }
            get { return _storage_comment; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string storage_sx
        {
            set { _storage_sx = value; }
            get { return _storage_sx; }
        }
        #endregion Model

	}
}

