using System;
namespace Model
{
	/// <summary>
	/// in_storage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class in_storage
	{
		public in_storage()
		{}
		#region Model
		private int _enter_num;		//入库编号
		private int _mat_id;		//物料ID
		private string _mat_name;	//物料名称
		private DateTime _in_time;	//在库时间
		private int? _sl_id;		//库位编号
		private decimal _in_amount;	//存量
		private decimal _in_weight;	//重量
		private decimal _in_volume;	//体积
		/// <summary>
		/// 
		/// </summary>
		public int enter_num		//入库编号
		{
			set{ _enter_num=value;}
			get{return _enter_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int mat_id		//物料编号
		{
			set{ _mat_id=value;}
			get{return _mat_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mat_name	//物料名称
		{
			set{ _mat_name=value;}
			get{return _mat_name;}
		}
		/// <summary>
		/// on update CURRENT_TIMESTAMP
		/// </summary>
		public DateTime in_time  //在库时间
		{
			set{ _in_time=value;}
			get{return _in_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sl_id
		{
			set{ _sl_id=value;}
			get{return _sl_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal in_amount
		{
			set{ _in_amount=value;}
			get{return _in_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal in_weight
		{
			set{ _in_weight=value;}
			get{return _in_weight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal in_volume
		{
			set{ _in_volume=value;}
			get{return _in_volume;}
		}
		#endregion Model

	}
}

