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
       
        private int  _log_type;
        private string _log_describe;
        
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
        #endregion Model

	}
}

