using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using DBUtility;//Please add references
namespace DAL
{
	/// <summary>
	/// 数据访问类:storage
	/// </summary>
	public partial class storage
	{
		public storage()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string storage_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from storage");
            strSql.Append(" where storage_id=@storage_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@storage_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = storage_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.storage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into storage(");
            strSql.Append("storage_id,storage_name,storage_create_time,storage_area,storage_remain_chest,storage_remain_seat,storage_comment,storage_sx)");
            strSql.Append(" values (");
            strSql.Append("@storage_id,@storage_name,@storage_create_time,@storage_area,@storage_remain_chest,@storage_remain_seat,@storage_comment,@storage_sx)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@storage_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@storage_name", MySqlDbType.VarChar,32),
					new MySqlParameter("@storage_create_time", MySqlDbType.DateTime),
					new MySqlParameter("@storage_area", MySqlDbType.Decimal,10),
					new MySqlParameter("@storage_remain_chest", MySqlDbType.Int32,32),
					new MySqlParameter("@storage_remain_seat", MySqlDbType.Int32,32),
					new MySqlParameter("@storage_comment", MySqlDbType.VarChar,255),
					new MySqlParameter("@storage_sx", MySqlDbType.VarChar,64)};
            parameters[0].Value = model.storage_id;
            parameters[1].Value = model.storage_name;
            parameters[2].Value = model.storage_create_time;
            parameters[3].Value = model.storage_area;
            parameters[4].Value = model.storage_remain_chest;
            parameters[5].Value = model.storage_remain_seat;
            parameters[6].Value = model.storage_comment;
            parameters[7].Value = model.storage_sx;

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
        public bool Update(Model.storage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update storage set ");
            strSql.Append("storage_name=@storage_name,");
            strSql.Append("storage_create_time=@storage_create_time,");
            strSql.Append("storage_area=@storage_area,");
            strSql.Append("storage_remain_chest=@storage_remain_chest,");
            strSql.Append("storage_remain_seat=@storage_remain_seat,");
            strSql.Append("storage_comment=@storage_comment,");
            strSql.Append("storage_sx=@storage_sx");
            strSql.Append(" where storage_id=@storage_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@storage_name", MySqlDbType.VarChar,32),
					new MySqlParameter("@storage_create_time", MySqlDbType.DateTime),
					new MySqlParameter("@storage_area", MySqlDbType.Decimal,10),
					new MySqlParameter("@storage_remain_chest", MySqlDbType.Int32,32),
					new MySqlParameter("@storage_remain_seat", MySqlDbType.Int32,32),
					new MySqlParameter("@storage_comment", MySqlDbType.VarChar,255),
					new MySqlParameter("@storage_sx", MySqlDbType.VarChar,64),
					new MySqlParameter("@storage_id", MySqlDbType.VarChar,128)};
            parameters[0].Value = model.storage_name;
            parameters[1].Value = model.storage_create_time;
            parameters[2].Value = model.storage_area;
            parameters[3].Value = model.storage_remain_chest;
            parameters[4].Value = model.storage_remain_seat;
            parameters[5].Value = model.storage_comment;
            parameters[6].Value = model.storage_sx;
            parameters[7].Value = model.storage_id;

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
        public bool Delete(string storage_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from storage ");
            strSql.Append(" where storage_id=@storage_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@storage_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = storage_id;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string storage_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from storage ");
            strSql.Append(" where storage_id in (" + storage_idlist + ")  ");
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
        public Model.storage GetModel(string storage_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select storage_id,storage_name,storage_create_time,storage_area,storage_remain_chest,storage_remain_seat,storage_comment,storage_sx from storage ");
            strSql.Append(" where storage_id=@storage_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@storage_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = storage_id;

            Model.storage model = new Model.storage();
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
        public Model.storage DataRowToModel(DataRow row)
        {
            Model.storage model = new Model.storage();
            if (row != null)
            {
                if (row["storage_id"] != null)
                {
                    model.storage_id = row["storage_id"].ToString();
                }
                if (row["storage_name"] != null)
                {
                    model.storage_name = row["storage_name"].ToString();
                }
                if (row["storage_create_time"] != null && row["storage_create_time"].ToString() != "")
                {
                    model.storage_create_time = DateTime.Parse(row["storage_create_time"].ToString());
                }
                if (row["storage_area"] != null && row["storage_area"].ToString() != "")
                {
                    model.storage_area = decimal.Parse(row["storage_area"].ToString());
                }
                if (row["storage_remain_chest"] != null && row["storage_remain_chest"].ToString() != "")
                {
                    model.storage_remain_chest = int.Parse(row["storage_remain_chest"].ToString());
                }
                if (row["storage_remain_seat"] != null && row["storage_remain_seat"].ToString() != "")
                {
                    model.storage_remain_seat = int.Parse(row["storage_remain_seat"].ToString());
                }
                if (row["storage_comment"] != null)
                {
                    model.storage_comment = row["storage_comment"].ToString();
                }
                if (row["storage_sx"] != null)
                {
                    model.storage_sx = row["storage_sx"].ToString();
                }
            }
            return model;
        }
        public DataSet GetList(int num)
        {
            string sql = "SELECT storage_name FROM storage WHERE 1=1";
            return DbHelperMySQL.Query(sql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select storage_id,storage_name,storage_create_time,storage_area,storage_remain_chest,storage_remain_seat,storage_comment,storage_sx ");
            strSql.Append(" FROM storage ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 适用于Select语句查询
        /// </summary>
        /// <param name="StrSql"传递sql语句
        /// <returns>返回dataset数据类型</returns>
        public DataSet getDataList(string StrSql)
        {
            return DbHelperMySQL.Query(StrSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM storage ");
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
                strSql.Append("order by T.storage_id desc");
            }
            strSql.Append(")AS Row, T.*  from storage T ");
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
            parameters[0].Value = "storage";
            parameters[1].Value = "storage_id";
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

