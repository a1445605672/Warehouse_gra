using System;
namespace Model
{
    /// <summary>
    /// department:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class department
    {
        public department()
        { }
        #region Model
        private string _dep_id;
        private string _dep_name;
        private string _dep_principal_name;
        private string _dep_principal_id;
        private string _dep_sx;
        /// <summary>
        /// 
        /// </summary>
        public string dep_id
        {
            set { _dep_id = value; }
            get { return _dep_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dep_name
        {
            set { _dep_name = value; }
            get { return _dep_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dep_principal_name
        {
            set { _dep_principal_name = value; }
            get { return _dep_principal_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dep_principal_id
        {
            set { _dep_principal_id = value; }
            get { return _dep_principal_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dep_sx
        {
            set { _dep_sx = value; }
            get { return _dep_sx; }
        }
        #endregion Model

    }
}

