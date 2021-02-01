using System;
namespace Model
{
	/// <summary>
	/// material_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class material_info
	{
		public material_info()
		{}
		#region Model
		private int _mat_id;
		private string _mat_name;
		private int _mat_father_id;
		private DateTime? _mat_create_time;
		private decimal? _mat_fengdu;
		private int _mat_state;
		private int _mat_colour;
		private int _mat_smell;
		private int _mat_type;
		private int _mat_type_id;
		private string _mat_purpose;
		private string _mat_source;
		private string _mat_suanjianxing;
		private string _mat_yuansuzhanbi;
		private string _mat_yuansuliang;
		/// <summary>
		/// 
		/// </summary>
		public int mat_id
		{
			set{ _mat_id=value;}
			get{return _mat_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mat_name
		{
			set{ _mat_name=value;}
			get{return _mat_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int mat_father_id
		{
			set{ _mat_father_id=value;}
			get{return _mat_father_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? mat_create_time
		{
			set{ _mat_create_time=value;}
			get{return _mat_create_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? mat_fengdu
		{
			set{ _mat_fengdu=value;}
			get{return _mat_fengdu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int mat_state
		{
			set{ _mat_state=value;}
			get{return _mat_state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int mat_colour
		{
			set{ _mat_colour=value;}
			get{return _mat_colour;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int mat_smell
		{
			set{ _mat_smell=value;}
			get{return _mat_smell;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int mat_type
		{
			set{ _mat_type=value;}
			get{return _mat_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int mat_type_id
		{
			set{ _mat_type_id=value;}
			get{return _mat_type_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mat_purpose
		{
			set{ _mat_purpose=value;}
			get{return _mat_purpose;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mat_source
		{
			set{ _mat_source=value;}
			get{return _mat_source;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mat_suanjianxing
		{
			set{ _mat_suanjianxing=value;}
			get{return _mat_suanjianxing;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mat_yuansuzhanbi
		{
			set{ _mat_yuansuzhanbi=value;}
			get{return _mat_yuansuzhanbi;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mat_yuansuliang
		{
			set{ _mat_yuansuliang=value;}
			get{return _mat_yuansuliang;}
		}
		#endregion Model

	}
}

