using System;
namespace Model
{
    /// <summary>
    /// out_storage:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class out_storage
    {
        public out_storage()
        { }
        #region Model
        private int _out_id;
        private string _out_mat_id;
        private string _out_mat_name;
        private decimal _out_account;
        private string _out_batch_id;
        private DateTime _out_data;
        private string _out_staff_id;
        private string _out_staff_name;
        /// <summary>
        /// 
        /// </summary>
        public int out_id
        {
            set { _out_id = value; }
            get { return _out_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string out_mat_id
        {
            set { _out_mat_id = value; }
            get { return _out_mat_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string out_mat_name
        {
            set { _out_mat_name = value; }
            get { return _out_mat_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal out_account
        {
            set { _out_account = value; }
            get { return _out_account; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string out_batch_id
        {
            set { _out_batch_id = value; }
            get { return _out_batch_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime out_data
        {
            set { _out_data = value; }
            get { return _out_data; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string out_staff_id
        {
            set { _out_staff_id = value; }
            get { return _out_staff_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string out_staff_name
        {
            set { _out_staff_name = value; }
            get { return _out_staff_name; }
        }
        /// <summary>
        /// auto_increment
        /// </summary>
        
        #endregion Model

    }
}

