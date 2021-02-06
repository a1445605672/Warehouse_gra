
using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using DBUtility;//Please add references
namespace DAL
{
	/// <summary>
	/// 数据访问类:sr_info
	/// </summary>
	public partial class sr_info
	{
		public sr_info()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string sr_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from sr_info");
            strSql.Append(" where sr_id=@sr_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sr_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = sr_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.sr_info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into sr_info(");
            strSql.Append("sr_id,sr_name,sr_type,sr_resp_name,sr_resp_id,sr_contact_name,sr_contact_phone,sr_place,sr_create_time,sr_update_time,sr_sx)");
            strSql.Append(" values (");
            strSql.Append("@sr_id,@sr_name,@sr_type,@sr_resp_name,@sr_resp_id,@sr_contact_name,@sr_contact_phone,@sr_place,@sr_create_time,@sr_update_time,@sr_sx)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sr_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@sr_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@sr_type", MySqlDbType.VarChar,10),
					new MySqlParameter("@sr_resp_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@sr_resp_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@sr_contact_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@sr_contact_phone", MySqlDbType.VarChar,11),
					new MySqlParameter("@sr_place", MySqlDbType.VarChar,255),
					new MySqlParameter("@sr_create_time", MySqlDbType.DateTime),
					new MySqlParameter("@sr_update_time", MySqlDbType.DateTime),
					new MySqlParameter("@sr_sx", MySqlDbType.VarChar,64)};
            parameters[0].Value = model.sr_id;
            parameters[1].Value = model.sr_name;
            parameters[2].Value = model.sr_type;
            parameters[3].Value = model.sr_resp_name;
            parameters[4].Value = model.sr_resp_id;
            parameters[5].Value = model.sr_contact_name;
            parameters[6].Value = model.sr_contact_phone;
            parameters[7].Value = model.sr_place;
            parameters[8].Value = model.sr_create_time;
            parameters[9].Value = model.sr_update_time;
            parameters[10].Value = model.sr_sx;

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
        public bool Update(Model.sr_info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update sr_info set ");
            strSql.Append("sr_name=@sr_name,");
            strSql.Append("sr_type=@sr_type,");
            strSql.Append("sr_resp_name=@sr_resp_name,");
            strSql.Append("sr_resp_id=@sr_resp_id,");
            strSql.Append("sr_contact_name=@sr_contact_name,");
            strSql.Append("sr_contact_phone=@sr_contact_phone,");
            strSql.Append("sr_place=@sr_place,");
            strSql.Append("sr_create_time=@sr_create_time,");
            strSql.Append("sr_update_time=@sr_update_time,");
            strSql.Append("sr_sx=@sr_sx");
            strSql.Append(" where sr_id=@sr_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sr_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@sr_type", MySqlDbType.VarChar,10),
					new MySqlParameter("@sr_resp_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@sr_resp_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@sr_contact_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@sr_contact_phone", MySqlDbType.VarChar,11),
					new MySqlParameter("@sr_place", MySqlDbType.VarChar,255),
					new MySqlParameter("@sr_create_time", MySqlDbType.DateTime),
					new MySqlParameter("@sr_update_time", MySqlDbType.DateTime),
					new MySqlParameter("@sr_sx", MySqlDbType.VarChar,64),
					new MySqlParameter("@sr_id", MySqlDbType.VarChar,128)};
            parameters[0].Value = model.sr_name;
            parameters[1].Value = model.sr_type;
            parameters[2].Value = model.sr_resp_name;
            parameters[3].Value = model.sr_resp_id;
            parameters[4].Value = model.sr_contact_name;
            parameters[5].Value = model.sr_contact_phone;
            parameters[6].Value = model.sr_place;
            parameters[7].Value = model.sr_create_time;
            parameters[8].Value = model.sr_update_time;
            parameters[9].Value = model.sr_sx;
            parameters[10].Value = model.sr_id;

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
        public bool Delete(string sr_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from sr_info ");
            strSql.Append(" where sr_id=@sr_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sr_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = sr_id;

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
        public bool DeleteList(string sr_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from sr_info ");
            strSql.Append(" where sr_id in (" + sr_idlist + ")  ");
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
        public Model.sr_info GetModel(string sr_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sr_id,sr_name,sr_type,sr_resp_name,sr_resp_id,sr_contact_name,sr_contact_phone,sr_place,sr_create_time,sr_update_time,sr_sx from sr_info ");
            strSql.Append(" where sr_id=@sr_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sr_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = sr_id;

            Model.sr_info model = new Model.sr_info();
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
        public Model.sr_info DataRowToModel(DataRow row)
        {
            Model.sr_info model = new Model.sr_info();
            if (row != null)
            {
                if (row["sr_id"] != null)
                {
                    model.sr_id = row["sr_id"].ToString();
                }
                if (row["sr_name"] != null)
                {
                    model.sr_name = row["sr_name"].ToString();
                }
                if (row["sr_type"] != null)
                {
                    model.sr_type = row["sr_type"].ToString();
                }
                if (row["sr_resp_name"] != null)
                {
                    model.sr_resp_name = row["sr_resp_name"].ToString();
                }
                if (row["sr_resp_id"] != null)
                {
                    model.sr_resp_id = row["sr_resp_id"].ToString();
                }
                if (row["sr_contact_name"] != null)
                {
                    model.sr_contact_name = row["sr_contact_name"].ToString();
                }
                if (row["sr_contact_phone"] != null)
                {
                    model.sr_contact_phone = row["sr_contact_phone"].ToString();
                }
                if (row["sr_place"] != null)
                {
                    model.sr_place = row["sr_place"].ToString();
                }
                if (row["sr_create_time"] != null && row["sr_create_time"].ToString() != "")
                {
                    model.sr_create_time = DateTime.Parse(row["sr_create_time"].ToString());
                }
                if (row["sr_update_time"] != null && row["sr_update_time"].ToString() != "")
                {
                    model.sr_update_time = DateTime.Parse(row["sr_update_time"].ToString());
                }
                if (row["sr_sx"] != null)
                {
                    model.sr_sx = row["sr_sx"].ToString();
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
            strSql.Append("select sr_id,sr_name,sr_type,sr_resp_name,sr_resp_id,sr_contact_name,sr_contact_phone,sr_place,sr_create_time,sr_update_time,sr_sx ");
            strSql.Append(" FROM sr_info ");
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
            strSql.Append("select count(1) FROM sr_info ");
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
                strSql.Append("order by T.sr_id desc");
            }
            strSql.Append(")AS Row, T.*  from sr_info T ");
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
            parameters[0].Value = "sr_info";
            parameters[1].Value = "sr_id";
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

