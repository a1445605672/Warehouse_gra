using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Warehouse
{
	public class SystemLog
	{
		BLL.log_info log_Info = new BLL.log_info();
		Model.log_info data = new Model.log_info();
		
		#region 写入日志

		/// <summary>
		/// 写入日志  
		/// </summary>
		/// <param name="type">日志类型 0：系统错误，1：增，2：删，3：改，4查，5：出库，6入库</param>
		/// <param name="staffId">人物</param>
		/// <param name="time">时间</param>
		/// <param name="where">地点</param>
		/// <param name="Doing">做了什么</param>
		/// <param name="page">页面名称</param>
		/// <param name="enter_number">入库编号，和出入库无关的操作，此项可以为空字符串</param>
		/// <returns>1：表示传入字符串不符合规则，-1：表示存储失败 0：表示存储成功</returns>
		public int WriteLog(int type, string staffId, string time, string page, string Doing, string enter_number)
		{
			//判断传入的参数是否符合规则
			if (type >= 6 && type <= 0)
			{
				return 1;
			}
			if (staffId == "" || time == "" ||  Doing == "" || page == "")
			{
				return 1;
			}
			string Log = Doing;
			data.log_type = type;
			data.log_describe = Log;
			data.log_time = time;
			data.page = page;
			data.staff_id = staffId;
			if (enter_number == "")
			{
				data.enter_num = "";
			}
			data.enter_num = enter_number;

			if (log_Info.Add(data))
			{
				return 0;
			}
			else
			{
				return -1;
			}
		}
		#endregion

		#region 读取日志
		public List<Model.log_info> readLog()
		{
			
			return log_Info.GetModelList("");
		}


		#endregion

	}

}
