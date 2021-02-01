using System;
namespace Model
{
	/// <summary>
	/// storagelocation_type:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class storagelocation_type
	{
		public storagelocation_type()
		{}
		#region Model
		private int _type_id;
		private decimal? _type_length;
		private decimal? _type_high;
		private decimal? _type_wide;
		/// <summary>
		/// 
		/// </summary>
		public int type_id
		{
			set{ _type_id=value;}
			get{return _type_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? type_length
		{
			set{ _type_length=value;}
			get{return _type_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? type_high
		{
			set{ _type_high=value;}
			get{return _type_high;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? type_wide
		{
			set{ _type_wide=value;}
			get{return _type_wide;}
		}
		#endregion Model

	}
}

