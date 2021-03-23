using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;
using Sunny.UI;

namespace Warehouse.表单验证
{
	class formAuthentication
	{
		#region 验证数字文本框
		/// <summary>
		/// 验证数字文本框是否为整型或浮点型
		/// </summary>
		/// <param name="str">字符串</param>
		/// <returns></returns>
		public bool formAuthentication_isIntOrDouble(string str)
		{
				try
				{
				
				double d = Convert.ToDouble(str);	
					return true;
				}
			catch
			{
				return false;
			}
		}
		#endregion


		#region 验证下拉框
		/// <summary>
		/// 验证下拉框输入的值是否在下拉框列表内，如果不在则报错
		/// </summary>
		/// <param name="str"></param>
		/// <param name="comboBox"></param>
		/// <returns></returns>
		public bool formAuthentication_Combobox(string str,UIComboBox comboBox)
		{
			if (comboBox.Items.IndexOf(str) >= 0)
			{
				return true;
			}
			
			return false;
		}
		#endregion


		#region 经办人验证
		/// <summary>
		/// 验证经办人身份是否符合
		/// </summary>
		/// <param name="str">字符串</param>
		/// <returns></returns>
		public bool staffChrckout(string str)
		{
			BLL.staff staff = new BLL.staff();
			string staff_Sql = "SELECT *FROM staff WHERE  staff_id=";
			string Where = str.Trim();
			staff_Sql += "\'" + Where + "\'";
			DataSet staff_ds = staff.getDataList(staff_Sql);
			if (staff_ds.Tables[0].Rows.Count == 0)
			{
				return false;
			}
			return true;
		}
		#endregion

		#region 验证备注只能是汉字
		/// <summary>
		/// 验证备注只能是汉字
		/// </summary>
		/// <param name="str">字符串</param>
		/// <returns></returns>
		public bool formAuthentication_remark(string str)
		{
			Regex regex = new Regex("^[\u4e00-\u9fa5]+$");
			return regex.IsMatch(str);

		}
		#endregion

	}
}
