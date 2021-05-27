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
		public bool formAuthentication_Combobox(string str, UIComboBox comboBox)
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

		#region
		/// <summary>
		/// 验证数字范围是否在要求的范围内
		/// </summary>
		/// <param name="m">输入验证的数字</param>
		/// <returns></returns>

		public static bool ShuZi_fanwei(string m)
		{
			Regex w = new Regex("[1-9]d{0,2}");

			return w.IsMatch(m);
		}
		#endregion


		/// <summary>
		/// 身份证校验
		/// </summary>
		/// <param name="idNumber"></param>
		/// <returns></returns>
		public static bool CheckIDCard18(string idNumber)
		{
			long n = 0;
			if (long.TryParse(idNumber.Remove(17), out n) == false
				|| n < Math.Pow(10, 16) || long.TryParse(idNumber.Replace('x', '0').Replace('X', '0'), out n) == false)
			{
				return false;//数字验证  
			}
			string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
			if (address.IndexOf(idNumber.Remove(2)) == -1)
			{
				return false;//省份验证  
			}
			string birth = idNumber.Substring(6, 8).Insert(6, "-").Insert(4, "-");
			DateTime time = new DateTime();
			if (DateTime.TryParse(birth, out time) == false)
			{
				return false;//生日验证  
			}
			string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');
			string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
			char[] Ai = idNumber.Remove(17).ToCharArray();
			int sum = 0;
			for (int i = 0; i < 17; i++)
			{
				sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());
			}
			int y = -1;
			Math.DivRem(sum, 11, out y);
			if (arrVarifyCode[y] != idNumber.Substring(17, 1).ToLower())
			{
				return false;//校验码验证  
			}
			return true;//符合GB11643-1999标准  
		}

	}
}
