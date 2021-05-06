
using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using DBUtility;//Please add references
namespace DAL
{
	/// <summary>
	/// 数据访问类:log_info
	/// </summary>
	public partial class log_info
	{
		public log_info()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string log_num)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from log_info");
            strSql.Append(" where log_num=@log_num ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@log_num", MySqlDbType.VarChar,128)			};
            parameters[0].Value = log_num;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.log_info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into log_info(");
            strSql.Append("log_type,log_describe,enter_num,log_time,page,staff_id)");
            strSql.Append(" values (");
            strSql.Append("@log_type,@log_describe,@enter_num,@log_time,@page,@staff_id)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@log_type", MySqlDbType.VarChar,128),
					new MySqlParameter("@log_describe", MySqlDbType.VarChar,255),
            new MySqlParameter("@enter_num", MySqlDbType.VarChar,128),
            new MySqlParameter("@log_time", MySqlDbType.VarChar,128),
            new MySqlParameter("@page", MySqlDbType.VarChar,128),
             new MySqlParameter("@staff_id", MySqlDbType.VarChar,128),
            };

            parameters[0].Value = model.log_type;
            parameters[1].Value = model.log_describe;
            parameters[2].Value = model.enter_num;
            parameters[3].Value = model.log_time;
            parameters[4].Value = model.page;
            parameters[5].Value = model.staff_id;


            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.log_info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update log_info set ");
            strSql.Append("log_type=@log_type,");
            strSql.Append("log_describe=@log_describe");

            MySqlParameter[] parameters = {
                    new MySqlParameter("@log_type", MySqlDbType.VarChar,128),
                    new MySqlParameter("@log_describe", MySqlDbType.VarChar,255),};
					
            parameters[0].Value = model.log_type;
            parameters[1].Value = model.log_describe;
           

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string log_num)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from log_info ");
            strSql.Append(" where log_num=@log_num ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@log_num", MySqlDbType.VarChar,128)			};
            parameters[0].Value = log_num;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool delete(string Sql)
		{
            int rows = DbHelperMySQL.ExecuteSql(Sql);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
		}


        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string log_numlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from log_info ");
            strSql.Append(" where log_num in (" + log_numlist + ")  ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.log_info GetModel(string log_num)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select log_num,log_type,log_describe from log_info ");
            strSql.Append(" where log_num=@log_num ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@log_num", MySqlDbType.VarChar,128)			};
            parameters[0].Value = log_num;

            Model.log_info model = new Model.log_info();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.log_info DataRowToModel(DataRow row)
        {
            Model.log_info model = new Model.log_info();
            if (row != null) 
            {
               
                if (row["log_type"] != null)
                {
                    model.log_type =Convert.ToInt32( row["log_type"].ToString());
                }
                if (row["log_describe"] != null)
                {
                    model.log_describe = row["log_describe"].ToString();
                }
                if (row["log_num"] != null)
                {
                    model.log_num = Convert.ToInt32(row["log_num"].ToString());
                }
                
                if (row["enter_num"] != null)
                {
                    model.enter_num = row["enter_num"].ToString();
                }
                if (row["log_time"] != null)
                {
                    model.log_time =Convert.ToDateTime(row["log_time"].ToString()).ToString("yyyy-MM-dd");
                }
                if (row["page"] != null)
                {
                    model.page = row["page"].ToString();
                }
                if (row["staff_id"] != null)
                {
                    model.staff_id = row["staff_id"].ToString();
                }

            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select log_num, log_type,enter_num,log_describe,log_time ,page,staff_id");
            strSql.Append(" FROM log_info ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM log_info ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.log_num desc");
            }
            strSql.Append(")AS Row, T.*  from log_info T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            MySqlParameter[] parameters = {
                    new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
                    new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
                    new MySqlParameter("@PageSize", MySqlDbType.Int32),
                    new MySqlParameter("@PageIndex", MySqlDbType.Int32),
                    new MySqlParameter("@IsReCount", MySqlDbType.Bit),
                    new MySqlParameter("@OrderType", MySqlDbType.Bit),
                    new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "log_info";
            parameters[1].Value = "log_num";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

