using System;
namespace Model
{
	/// <summary>
	/// staff:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class staff
	{
		public staff()
		{}
		#region Model
		private int _staff_id;
		private string _staff_name;
		private string _staff_sex;
		private string _staff_identity_card;
		private int? _staff_phone_number;
		private int? _staff_age;
		private DateTime? _staff_hire_date;
		private int? _staff_belong_dep_id;
		/// <summary>
		/// 
		/// </summary>
		public int staff_id
		{
			set{ _staff_id=value;}
			get{return _staff_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string staff_name
		{
			set{ _staff_name=value;}
			get{return _staff_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string staff_sex
		{
			set{ _staff_sex=value;}
			get{return _staff_sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string staff_identity_card
		{
			set{ _staff_identity_card=value;}
			get{return _staff_identity_card;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? staff_phone_number
		{
			set{ _staff_phone_number=value;}
			get{return _staff_phone_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? staff_age
		{
			set{ _staff_age=value;}
			get{return _staff_age;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? staff_hire_date
		{
			set{ _staff_hire_date=value;}
			get{return _staff_hire_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? staff_belong_dep_id
		{
			set{ _staff_belong_dep_id=value;}
			get{return _staff_belong_dep_id;}
		}
		#endregion Model

	}
}

