using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
	public class SystemLog
	{

		/// <summary>
		/// 写入日志
		/// </summary>
		/// <param name="type">日志类型</param>
		/// <param name="staffname">人物</param>
		/// <param name="time">时间</param>
		/// <param name="where">地点</param>
		/// <param name="Doing">做了什么</param>
		/// <returns></returns>
		public bool WriteLog(int type, string staffname, string time, string where, string Doing)
		{
			string Log = staffname + "," + time + "," + where + "," + Doing;
			BLL.log_info log_Info = new BLL.log_info();


			Model.log_info data = new Model.log_info();
			data.log_type = type;
			data.log_describe = Log;

			if (log_Info.Add(data))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}

}
