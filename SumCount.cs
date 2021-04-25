using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUtility;
namespace Warehouse
{
    public class SumCount
    {
        /// <summary>
        /// 用于得到总数的统计
        /// </summary>
        /// <param name="tablename"></param>
        /// <param name="columnname"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="datetype"></param>
        /// <returns></returns>
        public int GetCount(string tablename, string columnname, DateTime start, DateTime end, string datetype)
        {
            string sql = "SELECT  SUM(" + columnname + ") FROM " + tablename + " WHERE UNIX_TIMESTAMP(" + datetype + ") BETWEEN UNIX_TIMESTAMP('" + start + "') AND UNIX_TIMESTAMP('" + end + "')";
            object obj = DbHelperMySQL.GetSingle(sql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        ///<summary>
        ///用于批次号重复查询
        ///</summary>
        public int GetBatNum(DateTime start, DateTime end)
        {
            string sql = "SELECT COUNT(DISTINCT enter_batch_id) FROM enter_storage WHERE UNIX_TIMESTAMP(enter_date) BETWEEN UNIX_TIMESTAMP('" + start + "') AND UNIX_TIMESTAMP('" + end + "')";
            object obj = DbHelperMySQL.GetSingle(sql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        ///<summary>
        ///用于出库次数查询
        ///</summary>
        public int GetOutNum(DateTime start, DateTime end)
        {
            string sql = "SELECT COUNT(1) FROM out_storage WHERE UNIX_TIMESTAMP(out_data) BETWEEN UNIX_TIMESTAMP('" + start + "') AND UNIX_TIMESTAMP('" + end + "')";
            object obj = DbHelperMySQL.GetSingle(sql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        ///<summary>
        ///用于入库次数查询
        ///</summary>
        public int GetEnterNum(DateTime start, DateTime end)
        {
            string sql = "SELECT COUNT(1) FROM enter_storage WHERE UNIX_TIMESTAMP(enter_date) BETWEEN UNIX_TIMESTAMP('" + start + "') AND UNIX_TIMESTAMP('" + end + "')";
            object obj = DbHelperMySQL.GetSingle(sql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        ///<summary>
        ///用于库柜的数量查询
        ///</summary>
        public int GetChestNum(DateTime start, DateTime end)
        {
            string sql = "SELECT SUM(storage_remain_chest) AS count1 FROM storage WHERE UNIX_TIMESTAMP(storage_create_time) BETWEEN UNIX_TIMESTAMP('" + start + "') AND UNIX_TIMESTAMP('" + end + "')";
            object obj = DbHelperMySQL.GetSingle(sql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        ///<summary>
        ///用于剩余库位的查询
        ///</summary>
        public int GetSeat(DateTime start, DateTime end)
        {
            string sql = "SELECT SUM(storage_remain_seat) AS count1 FROM storage WHERE UNIX_TIMESTAMP(storage_create_time) BETWEEN UNIX_TIMESTAMP('" + start + "') AND UNIX_TIMESTAMP('" + end + "')";
            object obj = DbHelperMySQL.GetSingle(sql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        ///<summary>
        ///用于在库的数量，重量，体积的统计
        ///</summary>
        public int GetInData(DateTime start, DateTime end, string columnname)
        {
            string sql = "SELECT SUM(" + columnname + ") AS count1 FROM in_storage WHERE UNIX_TIMESTAMP(in_time) BETWEEN UNIX_TIMESTAMP('" + start + "') AND UNIX_TIMESTAMP('" + end + "')";
            object obj = DbHelperMySQL.GetSingle(sql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        ///<summary>
        ///获得物料种类
        ///</summary>
        public int GetMatType()
        {
            string sql = "SELECT COUNT(type_id) FROM material_type ";
            object obj = DbHelperMySQL.GetSingle(sql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        ///<summary>
        ///获得日志总数
        ///</summary>
        public int GetDairyNum(DateTime start, DateTime end)
        {
            string sql = "SELECT COUNT(1) FROM log_info WHERE UNIX_TIMESTAMP(log_time) BETWEEN UNIX_TIMESTAMP('" + start + "') AND UNIX_TIMESTAMP('" + end + "')";
            object obj = DbHelperMySQL.GetSingle(sql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        ///<summary>
        ///获得员工总数
        ///</summary>
        public int GetStaffNum()
        {
            string sql = "SELECT COUNT(1) FROM staff";
            object obj = DbHelperMySQL.GetSingle(sql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
    }
}
