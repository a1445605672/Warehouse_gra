using System;
namespace Model
{
	/// <summary>
	/// enter_storage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class enter_storage
	{
		public enter_storage()
		{}
        #region Model
        private int _enter_id;
        private int? _enter_batch_id;
        private string _enter_sl_id;
        private decimal? _enter_amount;
        private decimal? _enter_unit_bulk;
        private string _supplier_id;
        private string _enter_mat_id;
        private string _enter_mat_name;
        private string _enter_fengji_num;
        private DateTime? _enter_date;
        private string _enter_agent_id;
        private string _enter_agent_name;
        private string _enter_comment;
        /// <summary>
        /// 
        /// </summary>
        public int enter_id
        {
            set { _enter_id = value; }
            get { return _enter_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? enter_batch_id
        {
            set { _enter_batch_id = value; }
            get { return _enter_batch_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string enter_sl_id
        {
            set { _enter_sl_id = value; }
            get { return _enter_sl_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? enter_amount
        {
            set { _enter_amount = value; }
            get { return _enter_amount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? enter_unit_bulk
        {
            set { _enter_unit_bulk = value; }
            get { return _enter_unit_bulk; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string supplier_id
        {
            set { _supplier_id = value; }
            get { return _supplier_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string enter_mat_id
        {
            set { _enter_mat_id = value; }
            get { return _enter_mat_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string enter_mat_name
        {
            set { _enter_mat_name = value; }
            get { return _enter_mat_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string enter_fengji_num
        {
            set { _enter_fengji_num = value; }
            get { return _enter_fengji_num; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? enter_date
        {
            set { _enter_date = value; }
            get { return _enter_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string enter_agent_id
        {
            set { _enter_agent_id = value; }
            get { return _enter_agent_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string enter_agent_name
        {
            set { _enter_agent_name = value; }
            get { return _enter_agent_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string enter_comment
        {
            set { _enter_comment = value; }
            get { return _enter_comment; }
        }
        #endregion Model

	}
}

