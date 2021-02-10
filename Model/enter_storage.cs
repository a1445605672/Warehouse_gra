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
		private string  _enter_id;				//入库ID
		private string _enter_batch_id;		//批次编号
		private string  _enter_sl_id;			//库位编号
		private decimal? _enter_amount;		//入库量
		private decimal? _enter_unit_bulk;	//单位体积
		private string  _supplier_id;			//供应商编号
		private string  _enter_mat_id;			//物料ID
		private string _enter_mat_name;		//物料名称
		private string  _enter_fengji_num;		//封记ID
		private DateTime? _enter_date;		//入库日期
		private string  _enter_agent_id;		//经办人ID
		private string _enter_agent_name;	//经办人姓名
		private string _enter_comment;		//备注
		/// <summary>
		/// 
		/// </summary>
		public string enter_id                    //入库ID
		{									   
			set{ _enter_id=value;}			   
			get{return _enter_id;}			   
		}									   
		/// <summary>						   
		/// 								   
		/// </summary>						   
		public string enter_batch_id             //批次编号
		{									   
			set{ _enter_batch_id=value;}	   
			get{return _enter_batch_id;}	   
		}									   
		/// <summary>						   
		/// 								   
		/// </summary>						   
		public string enter_sl_id                //库位编号
		{									   
			set{ _enter_sl_id=value;}		   
			get{return _enter_sl_id;}		   
		}									   
		/// <summary>						   
		/// 								   
		/// </summary>						   
		public decimal? enter_amount           //入库量
		{									   
			set{ _enter_amount=value;}		   
			get{return _enter_amount;}		   
		}									   
		/// <summary>						   
		/// 								   
		/// </summary>						   
		public decimal? enter_unit_bulk        //单位体积
		{									   
			set{ _enter_unit_bulk=value;}	   
			get{return _enter_unit_bulk;}	   
		}									   
		/// <summary>						   
		/// 								   
		/// </summary>						   
		public string supplier_id                //供应商编号
		{									   
			set{ _supplier_id=value;}		   
			get{return _supplier_id;}		   
		}									   
		/// <summary>						   
		/// 								   
		/// </summary>						   
		public string enter_mat_id                 //物料ID
		{										
			set{ _enter_mat_id=value;}			
			get{return _enter_mat_id;}			
		}										
		/// <summary>							
		/// 									
		/// </summary>
		public string enter_mat_name            //物料名称
		{										
			set{ _enter_mat_name=value;}		
			get{return _enter_mat_name;}		
		}										
		/// <summary>							
		/// 
		/// </summary>
		public string enter_fengji_num              //封记ID
		{										  
			set{ _enter_fengji_num=value;}		  
			get{return _enter_fengji_num;}		  
		}										  
		/// <summary>
		/// 
		/// </summary>
		public DateTime? enter_date             //入库日期
		{										
			set{ _enter_date=value;}			
			get{return _enter_date;}			
		}
		/// <summary>
		/// 
		/// </summary>
		public string enter_agent_id               //经办人ID
		{										
			set{ _enter_agent_id=value;}		
			get{return _enter_agent_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string enter_agent_name            //经办人姓名
		{										  
			set{ _enter_agent_name=value;}
			get{return _enter_agent_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string enter_comment				//备注
		{
			set{ _enter_comment=value;}
			get{return _enter_comment;}
		}
		#endregion Model

	}
}

