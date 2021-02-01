using System;
namespace Model
{
	/// <summary>
	/// sr_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sr_info
	{
		public sr_info()
		{}
		#region Model
		private int _sr_id;
		private string _sr_name;
		private string _sr_type;
		private string _sr_resp_name;
		private int? _sr_resp_id;
		private string _sr_contact_name;
		private int? _sr_contact_phone;
		private string _sr_place;
		private DateTime? _sr_create_time;
		private DateTime? _sr_update_time;
		/// <summary>
		/// 
		/// </summary>
		public int sr_id
		{
			set{ _sr_id=value;}
			get{return _sr_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sr_name
		{
			set{ _sr_name=value;}
			get{return _sr_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sr_type
		{
			set{ _sr_type=value;}
			get{return _sr_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sr_resp_name
		{
			set{ _sr_resp_name=value;}
			get{return _sr_resp_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sr_resp_id
		{
			set{ _sr_resp_id=value;}
			get{return _sr_resp_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sr_contact_name
		{
			set{ _sr_contact_name=value;}
			get{return _sr_contact_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sr_contact_phone
		{
			set{ _sr_contact_phone=value;}
			get{return _sr_contact_phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sr_place
		{
			set{ _sr_place=value;}
			get{return _sr_place;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? sr_create_time
		{
			set{ _sr_create_time=value;}
			get{return _sr_create_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? sr_update_time
		{
			set{ _sr_update_time=value;}
			get{return _sr_update_time;}
		}
		#endregion Model

	}
}

