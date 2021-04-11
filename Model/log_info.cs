using System;
namespace Model
{
	/// <summary>
	/// log_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class log_info
	{
		public log_info()
		{}
        #region Model
        private int _log_num;
        private int  _log_type;
        private string _log_describe;
        private string _enter_num;
        private string _log_time;
        private string _page;
        private string _staff_id;
        

        public int log_num
		{ set { _log_num = value; }
            get { return  _log_num; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int  log_type
        {
            set { _log_type = value; }
            get { return _log_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string log_describe
        {
            set { _log_describe = value; }
            get { return _log_describe; }
        }

        public string enter_num
		{
			set { _enter_num = value; }
			get { return _enter_num; }
		}

        public string log_time
		{
			set { _log_time = value; }
			get { return _log_time; }
        }

             public string page
        { 
            set { _page = value; }
			get { return _page; }
		}
        public string staff_id
		{
			set { _staff_id = value; }
			get { return  _staff_id; }
		}

        #endregion Model

	}
}

