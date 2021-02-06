using System;
namespace Model
{
	/// <summary>
	/// storagelocation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class storagelocation
	{
		public storagelocation()
		{}
        #region Model
        private string _sl_id;
        private string _sl_store_type_id;
        private decimal? _sl_store_min;
        private decimal? _sl_store_max;
        private decimal? _sl_store_area;
        private string _sl_comment;
        private decimal? _sl_remain_bulk;
        private string _sl_belong_chest;
        private string _sl_sx;
        /// <summary>
        /// 
        /// </summary>
        public string sl_id
        {
            set { _sl_id = value; }
            get { return _sl_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sl_store_type_id
        {
            set { _sl_store_type_id = value; }
            get { return _sl_store_type_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? sl_store_min
        {
            set { _sl_store_min = value; }
            get { return _sl_store_min; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? sl_store_max
        {
            set { _sl_store_max = value; }
            get { return _sl_store_max; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? sl_store_area
        {
            set { _sl_store_area = value; }
            get { return _sl_store_area; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sl_comment
        {
            set { _sl_comment = value; }
            get { return _sl_comment; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? sl_remain_bulk
        {
            set { _sl_remain_bulk = value; }
            get { return _sl_remain_bulk; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sl_belong_chest
        {
            set { _sl_belong_chest = value; }
            get { return _sl_belong_chest; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sl_sx
        {
            set { _sl_sx = value; }
            get { return _sl_sx; }
        }
        #endregion Model

	}
}

