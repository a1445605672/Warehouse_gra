using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using DBUtility;//Please add references
namespace DAL
{
	/// <summary>
	/// 数据访问类:storagelocation
	/// </summary>
	public partial class storagelocation
	{
		public storagelocation()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string sl_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from storagelocation");
            strSql.Append(" where sl_id=@sl_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sl_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = sl_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.storagelocation model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into storagelocation(");
            strSql.Append("sl_id,sl_store_type_id,sl_store_min,sl_store_max,sl_store_area,sl_comment,sl_remain_bulk,sl_belong_chest,sl_sx)");
            strSql.Append(" values (");
            strSql.Append("@sl_id,@sl_store_type_id,@sl_store_min,@sl_store_max,@sl_store_area,@sl_comment,@sl_remain_bulk,@sl_belong_chest,@sl_sx)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sl_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@sl_store_type_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@sl_store_min", MySqlDbType.Decimal,10),
					new MySqlParameter("@sl_store_max", MySqlDbType.Decimal,10),
					new MySqlParameter("@sl_store_area", MySqlDbType.Decimal,10),
					new MySqlParameter("@sl_comment", MySqlDbType.VarChar,255),
					new MySqlParameter("@sl_remain_bulk", MySqlDbType.Decimal,10),
					new MySqlParameter("@sl_belong_chest", MySqlDbType.VarChar,128),
					new MySqlParameter("@sl_sx", MySqlDbType.VarChar,64)};
            parameters[0].Value = model.sl_id;
            parameters[1].Value = model.sl_store_type_id;
            parameters[2].Value = model.sl_store_min;
            parameters[3].Value = model.sl_store_max;
            parameters[4].Value = model.sl_store_area;
            parameters[5].Value = model.sl_comment;
            parameters[6].Value = model.sl_remain_bulk;
            parameters[7].Value = model.sl_belong_chest;
            parameters[8].Value = model.sl_sx;

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
        public bool Update(Model.storagelocation model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update storagelocation set ");
            strSql.Append("sl_store_type_id=@sl_store_type_id,");
            strSql.Append("sl_store_min=@sl_store_min,");
            strSql.Append("sl_store_max=@sl_store_max,");
            strSql.Append("sl_store_area=@sl_store_area,");
            strSql.Append("sl_comment=@sl_comment,");
            strSql.Append("sl_remain_bulk=@sl_remain_bulk,");
            strSql.Append("sl_belong_chest=@sl_belong_chest,");
            strSql.Append("sl_sx=@sl_sx");
            strSql.Append(" where sl_id=@sl_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sl_store_type_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@sl_store_min", MySqlDbType.Decimal,10),
					new MySqlParameter("@sl_store_max", MySqlDbType.Decimal,10),
					new MySqlParameter("@sl_store_area", MySqlDbType.Decimal,10),
					new MySqlParameter("@sl_comment", MySqlDbType.VarChar,255),
					new MySqlParameter("@sl_remain_bulk", MySqlDbType.Decimal,10),
					new MySqlParameter("@sl_belong_chest", MySqlDbType.VarChar,128),
					new MySqlParameter("@sl_sx", MySqlDbType.VarChar,64),
					new MySqlParameter("@sl_id", MySqlDbType.VarChar,128)};
            parameters[0].Value = model.sl_store_type_id;
            parameters[1].Value = model.sl_store_min;
            parameters[2].Value = model.sl_store_max;
            parameters[3].Value = model.sl_store_area;
            parameters[4].Value = model.sl_comment;
            parameters[5].Value = model.sl_remain_bulk;
            parameters[6].Value = model.sl_belong_chest;
            parameters[7].Value = model.sl_sx;
            parameters[8].Value = model.sl_id;

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
        /// 更新一条数据，执行sql语句
        /// </summary>
        /// <param name="Sql">Sql语句</param>
        /// <returns>boolean值判断执行是否成功</returns>
      public bool  Update(string Sql)
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string sl_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from storagelocation ");
            strSql.Append(" where sl_id=@sl_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sl_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = sl_id;

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
        public bool DeleteList(string sl_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from storagelocation ");
            strSql.Append(" where sl_id in (" + sl_idlist + ")  ");
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
        public Model.storagelocation GetModel(string sl_id)
        {

     //       StringBuilder strSql = new StringBuilder();
     //       strSql.Append("select sl_id,sl_store_type_id,sl_store_min,sl_store_max,sl_store_area,sl_comment,sl_remain_bulk,sl_belong_chest,sl_sx from storagelocation ");
     //       strSql.Append(" where sl_id=@sl_id ");
     //       MySqlParameter[] parameters = {
					//new MySqlParameter("@sl_id", MySqlDbType.VarChar,128)			};
     //       parameters[0].Value = sl_id;

     //       Model.storagelocation model = new Model.storagelocation();
     //       DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
     //       if (ds.Tables[0].Rows.Count > 0)
     //       {
     //           return DataRowToModel(ds.Tables[0].Rows[0]);
     //       }
     //       else
     //       {
     //           return null;
     //       }

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sl_id,sl_store_type_id,sl_store_min,sl_store_max,sl_store_area,sl_comment,sl_remain_bulk,sl_belong_chest,sl_sx from storagelocation ");
            strSql.Append(" where " + sl_id);
            MySqlParameter[] parameters = {
                    new MySqlParameter("@sl_id", MySqlDbType.VarChar,128)           };
            parameters[0].Value = sl_id;

            Model.storagelocation model = new Model.storagelocation();
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
        public Model.storagelocation DataRowToModel(DataRow row)
        {
            Model.storagelocation model = new Model.storagelocation();
            if (row != null)
            {
                if (row["sl_id"] != null)
                {
                    model.sl_id = row["sl_id"].ToString();
                }
                if (row["sl_store_type_id"] != null)
                {
                    model.sl_store_type_id = row["sl_store_type_id"].ToString();
                }
                if (row["sl_store_min"] != null && row["sl_store_min"].ToString() != "")
                {
                    model.sl_store_min = decimal.Parse(row["sl_store_min"].ToString());
                }
                if (row["sl_store_max"] != null && row["sl_store_max"].ToString() != "")
                {
                    model.sl_store_max = decimal.Parse(row["sl_store_max"].ToString());
                }
                if (row["sl_store_area"] != null && row["sl_store_area"].ToString() != "")
                {
                    model.sl_store_area = decimal.Parse(row["sl_store_area"].ToString());
                }
                if (row["sl_comment"] != null)
                {
                    model.sl_comment = row["sl_comment"].ToString();
                }
                if (row["sl_remain_bulk"] != null && row["sl_remain_bulk"].ToString() != "")
                {
                    model.sl_remain_bulk = decimal.Parse(row["sl_remain_bulk"].ToString());
                }
                if (row["sl_belong_chest"] != null)
                {
                    model.sl_belong_chest = row["sl_belong_chest"].ToString();
                }
                if (row["sl_sx"] != null)
                {
                    model.sl_sx = row["sl_sx"].ToString();
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
            strSql.Append("select sl_id,sl_store_type_id,sl_store_min,sl_store_max,sl_store_area,sl_comment,sl_remain_bulk,sl_belong_chest,sl_sx ");
            strSql.Append(" FROM storagelocation ");
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
            strSql.Append("select count(1) FROM storagelocation ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperMySQL.GetSingle(strSql.ToString());
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
                strSql.Append("order by T.sl_id desc");
            }
            strSql.Append(")AS Row, T.*  from storagelocation T ");
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
            parameters[0].Value = "storagelocation";
            parameters[1].Value = "sl_id";
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

