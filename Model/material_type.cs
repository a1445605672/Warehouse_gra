using System;
namespace Model
{
	/// <summary>
	/// material_type:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class material_type
	{
		public material_type()
		{}
        #region Model
        private string _type_id;
        private string _type_name;
        private string _type_comment;
        private string _type_sx;
        /// <summary>
        /// 
        /// </summary>
        public string type_id
        {
            set { _type_id = value; }
            get { return _type_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string type_name
        {
            set { _type_name = value; }
            get { return _type_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string type_comment
        {
            set { _type_comment = value; }
            get { return _type_comment; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string type_sx
        {
            set { _type_sx = value; }
            get { return _type_sx; }
        }
        #endregion Model

	}
}

