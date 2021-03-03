
using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using DBUtility;//Please add references
namespace DAL
{
	/// <summary>
	/// 数据访问类:material_info
	/// </summary>
	public partial class material_info
	{
		public material_info()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string mat_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from material_info");
            strSql.Append(" where mat_id=@mat_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@mat_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = mat_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.material_info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into material_info(");
            strSql.Append("mat_id,mat_name,mat_father_id,mat_create_time,mat_fengdu,mat_state,mat_colour,mat_smell,mat_type,mat_type_id,mat_purpose,mat_source,mat_suanjianxing,mat_yuansuzhanbi,mat_yuansuliang,mat_sx)");
            strSql.Append(" values (");
            strSql.Append("@mat_id,@mat_name,@mat_father_id,@mat_create_time,@mat_fengdu,@mat_state,@mat_colour,@mat_smell,@mat_type,@mat_type_id,@mat_purpose,@mat_source,@mat_suanjianxing,@mat_yuansuzhanbi,@mat_yuansuliang,@mat_sx)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@mat_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@mat_name", MySqlDbType.VarChar,32),
					new MySqlParameter("@mat_father_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@mat_create_time", MySqlDbType.DateTime),
					new MySqlParameter("@mat_fengdu", MySqlDbType.Decimal,16),
					new MySqlParameter("@mat_state", MySqlDbType.VarChar,128),
					new MySqlParameter("@mat_colour", MySqlDbType.VarChar,128),
					new MySqlParameter("@mat_smell", MySqlDbType.VarChar,128),
					new MySqlParameter("@mat_type", MySqlDbType.VarChar,128),
					new MySqlParameter("@mat_type_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@mat_purpose", MySqlDbType.VarChar,255),
					new MySqlParameter("@mat_source", MySqlDbType.VarChar,255),
					new MySqlParameter("@mat_suanjianxing", MySqlDbType.VarChar,255),
					new MySqlParameter("@mat_yuansuzhanbi", MySqlDbType.VarChar,255),
					new MySqlParameter("@mat_yuansuliang", MySqlDbType.VarChar,255),
					new MySqlParameter("@mat_sx", MySqlDbType.VarChar,64)};
            parameters[0].Value = model.mat_id;
            parameters[1].Value = model.mat_name;
            parameters[2].Value = model.mat_father_id;
            parameters[3].Value = model.mat_create_time;
            parameters[4].Value = model.mat_fengdu;
            parameters[5].Value = model.mat_state;
            parameters[6].Value = model.mat_colour;
            parameters[7].Value = model.mat_smell;
            parameters[8].Value = model.mat_type;
            parameters[9].Value = model.mat_type_id;
            parameters[10].Value = model.mat_purpose;
            parameters[11].Value = model.mat_source;
            parameters[12].Value = model.mat_suanjianxing;
            parameters[13].Value = model.mat_yuansuzhanbi;
            parameters[14].Value = model.mat_yuansuliang;
            parameters[15].Value = model.mat_sx;

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
        public bool Update(Model.material_info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update material_info set ");
            strSql.Append("mat_name=@mat_name,");
            strSql.Append("mat_father_id=@mat_father_id,");
            strSql.Append("mat_create_time=@mat_create_time,");
            strSql.Append("mat_fengdu=@mat_fengdu,");
            strSql.Append("mat_state=@mat_state,");
            strSql.Append("mat_colour=@mat_colour,");
            strSql.Append("mat_smell=@mat_smell,");
            strSql.Append("mat_type=@mat_type,");
            strSql.Append("mat_type_id=@mat_type_id,");
            strSql.Append("mat_purpose=@mat_purpose,");
            strSql.Append("mat_source=@mat_source,");
            strSql.Append("mat_suanjianxing=@mat_suanjianxing,");
            strSql.Append("mat_yuansuzhanbi=@mat_yuansuzhanbi,");
            strSql.Append("mat_yuansuliang=@mat_yuansuliang,");
            strSql.Append("mat_sx=@mat_sx");
            strSql.Append(" where mat_id=@mat_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@mat_name", MySqlDbType.VarChar,32),
					new MySqlParameter("@mat_father_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@mat_create_time", MySqlDbType.DateTime),
					new MySqlParameter("@mat_fengdu", MySqlDbType.Decimal,16),
					new MySqlParameter("@mat_state", MySqlDbType.VarChar,128),
					new MySqlParameter("@mat_colour", MySqlDbType.VarChar,128),
					new MySqlParameter("@mat_smell", MySqlDbType.VarChar,128),
					new MySqlParameter("@mat_type", MySqlDbType.VarChar,128),
					new MySqlParameter("@mat_type_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@mat_purpose", MySqlDbType.VarChar,255),
					new MySqlParameter("@mat_source", MySqlDbType.VarChar,255),
					new MySqlParameter("@mat_suanjianxing", MySqlDbType.VarChar,255),
					new MySqlParameter("@mat_yuansuzhanbi", MySqlDbType.VarChar,255),
					new MySqlParameter("@mat_yuansuliang", MySqlDbType.VarChar,255),
					new MySqlParameter("@mat_sx", MySqlDbType.VarChar,64),
					new MySqlParameter("@mat_id", MySqlDbType.VarChar,128)};
            parameters[0].Value = model.mat_name;
            parameters[1].Value = model.mat_father_id;
            parameters[2].Value = model.mat_create_time;
            parameters[3].Value = model.mat_fengdu;
            parameters[4].Value = model.mat_state;
            parameters[5].Value = model.mat_colour;
            parameters[6].Value = model.mat_smell;
            parameters[7].Value = model.mat_type;
            parameters[8].Value = model.mat_type_id;
            parameters[9].Value = model.mat_purpose;
            parameters[10].Value = model.mat_source;
            parameters[11].Value = model.mat_suanjianxing;
            parameters[12].Value = model.mat_yuansuzhanbi;
            parameters[13].Value = model.mat_yuansuliang;
            parameters[14].Value = model.mat_sx;
            parameters[15].Value = model.mat_id;

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
        public bool Delete(string mat_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from material_info ");
            strSql.Append(" where mat_id=@mat_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@mat_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = mat_id;

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
        public bool DeleteList(string mat_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from material_info ");
            strSql.Append(" where mat_id in (" + mat_idlist + ")  ");
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
        public Model.material_info GetModel(string mat_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select mat_id,mat_name,mat_father_id,mat_create_time,mat_fengdu,mat_state,mat_colour,mat_smell,mat_type,mat_type_id,mat_purpose,mat_source,mat_suanjianxing,mat_yuansuzhanbi,mat_yuansuliang,mat_sx from material_info ");
            strSql.Append(" where mat_id=@mat_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@mat_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = mat_id;

            Model.material_info model = new Model.material_info();
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
        public Model.material_info DataRowToModel(DataRow row)
        {
            Model.material_info model = new Model.material_info();
            if (row != null)
            {
                if (row["mat_id"] != null)
                {
                    model.mat_id = row["mat_id"].ToString();
                }
                if (row["mat_name"] != null)
                {
                    model.mat_name = row["mat_name"].ToString();
                }
                if (row["mat_father_id"] != null)
                {
                    model.mat_father_id = row["mat_father_id"].ToString();
                }
                if (row["mat_create_time"] != null && row["mat_create_time"].ToString() != "")
                {
                    model.mat_create_time = DateTime.Parse(row["mat_create_time"].ToString());
                }
                if (row["mat_fengdu"] != null && row["mat_fengdu"].ToString() != "")
                {
                    model.mat_fengdu = decimal.Parse(row["mat_fengdu"].ToString());
                }
                if (row["mat_state"] != null)
                {
                    model.mat_state = row["mat_state"].ToString();
                }
                if (row["mat_colour"] != null)
                {
                    model.mat_colour = row["mat_colour"].ToString();
                }
                if (row["mat_smell"] != null)
                {
                    model.mat_smell = row["mat_smell"].ToString();
                }
                if (row["mat_type"] != null)
                {
                    model.mat_type = row["mat_type"].ToString();
                }
                if (row["mat_type_id"] != null)
                {
                    model.mat_type_id = row["mat_type_id"].ToString();
                }
                if (row["mat_purpose"] != null)
                {
                    model.mat_purpose = row["mat_purpose"].ToString();
                }
                if (row["mat_source"] != null)
                {
                    model.mat_source = row["mat_source"].ToString();
                }
                if (row["mat_suanjianxing"] != null)
                {
                    model.mat_suanjianxing = row["mat_suanjianxing"].ToString();
                }
                if (row["mat_yuansuzhanbi"] != null)
                {
                    model.mat_yuansuzhanbi = row["mat_yuansuzhanbi"].ToString();
                }
                if (row["mat_yuansuliang"] != null)
                {
                    model.mat_yuansuliang = row["mat_yuansuliang"].ToString();
                }
                if (row["mat_sx"] != null)
                {
                    model.mat_sx = row["mat_sx"].ToString();
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
			strSql.Append("select mat_id,mat_name,mat_father_id,mat_create_time,mat_fengdu,mat_state,mat_colour,mat_smell,mat_type,mat_type_id,mat_purpose,mat_source,mat_suanjianxing,mat_yuansuzhanbi,mat_yuansuliang,mat_sx ");
			strSql.Append(" FROM material_info ");
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
            strSql.Append("select count(1) FROM material_info ");
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
                strSql.Append("order by T.mat_id desc");
            }
            strSql.Append(")AS Row, T.*  from material_info T ");
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
            parameters[0].Value = "material_info";
            parameters[1].Value = "mat_id";
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

