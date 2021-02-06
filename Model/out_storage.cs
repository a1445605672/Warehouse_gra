using System;
namespace Model
{
	/// <summary>
	/// out_storage: 出库实体类
	/// </summary>
	[Serializable]
	public partial class out_storage
	{
		public out_storage()
		{}
<<<<<<< HEAD
        #region Model
        private int _out_id;
        private string _out_mat_id;
        private string _out_mat_name;
        private decimal _out_account;
        private string _out_batch_id;
        private DateTime _out_data;
        private string _out_staff_id;
        private string _out_staff_name;
        private int _num;
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
        public int num
        {
            set { _num = value; }
            get { return _num; }
        }
        #endregion Model
=======
		#region Model
		private int _out_id;			//出库id
		private int _out_mat_id;        //物料ID
		private string _out_mat_name;	//物料名称
		private decimal _out_account;   //出库数量
		private int _out_batch_id;		//批次编号
		private DateTime _out_data;		//出库时间
		private int _out_staff_id;		//操作人员ID
		private string _out_staff_name; //操作人员姓名
		/// <summary>
		/// 
		/// </summary>
		public int out_id           //出库id
		{
			set{ _out_id=value;}
			get{return _out_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int out_mat_id           //物料ID
		{
			set{ _out_mat_id=value;}
			get{return _out_mat_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string out_mat_name          //物料名称
		{
			set{ _out_mat_name=value;}
			get{return _out_mat_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal out_account      //出库数量
		{
			set{ _out_account=value;}
			get{return _out_account;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int out_batch_id         //批次编号
		{								
			set{ _out_batch_id=value;}	
			get{return _out_batch_id;}	
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime out_data            //出库时间
		{									
			set{ _out_data=value;}			
			get{return _out_data;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int out_staff_id         //操作人员ID
		{								
			set{ _out_staff_id=value;}
			get{return _out_staff_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string out_staff_name        //操作人员姓名
		{
			set{ _out_staff_name=value;}
			get{return _out_staff_name;}
		}
		#endregion Model
>>>>>>> d1c317dc459ec410ada7d5f683fc7263e8361416

	}
}

