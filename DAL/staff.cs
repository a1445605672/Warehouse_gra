using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using DBUtility;//Please add references
namespace DAL
{
	/// <summary>
	/// 数据访问类:staff
	/// </summary>
	public partial class staff
	{
		public staff()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string staff_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from staff");
            strSql.Append(" where staff_id=@staff_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@staff_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = staff_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.staff model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into staff(");
            strSql.Append("staff_id,staff_name,staff_sex,staff_identity_card,staff_phone_number,staff_age,staff_hire_date,staff_belong_dep_id,staff_sx)");
            strSql.Append(" values (");
            strSql.Append("@staff_id,@staff_name,@staff_sex,@staff_identity_card,@staff_phone_number,@staff_age,@staff_hire_date,@staff_belong_dep_id,@staff_sx)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@staff_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@staff_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@staff_sex", MySqlDbType.VarChar,2),
					new MySqlParameter("@staff_identity_card", MySqlDbType.VarChar,18),
					new MySqlParameter("@staff_phone_number", MySqlDbType.VarChar,11),
					new MySqlParameter("@staff_age", MySqlDbType.Int32,4),
					new MySqlParameter("@staff_hire_date", MySqlDbType.DateTime),
					new MySqlParameter("@staff_belong_dep_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@staff_sx", MySqlDbType.VarChar,64)};
            parameters[0].Value = model.staff_id;
            parameters[1].Value = model.staff_name;
            parameters[2].Value = model.staff_sex;
            parameters[3].Value = model.staff_identity_card;
            parameters[4].Value = model.staff_phone_number;
            parameters[5].Value = model.staff_age;
            parameters[6].Value = model.staff_hire_date;
            parameters[7].Value = model.staff_belong_dep_id;
            parameters[8].Value = model.staff_sx;

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
        public bool Update(Model.staff model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update staff set ");
            strSql.Append("staff_name=@staff_name,");
            strSql.Append("staff_sex=@staff_sex,");
            strSql.Append("staff_identity_card=@staff_identity_card,");
            strSql.Append("staff_phone_number=@staff_phone_number,");
            strSql.Append("staff_age=@staff_age,");
            strSql.Append("staff_hire_date=@staff_hire_date,");
            strSql.Append("staff_belong_dep_id=@staff_belong_dep_id,");
            strSql.Append("staff_sx=@staff_sx");
            strSql.Append(" where staff_id=@staff_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@staff_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@staff_sex", MySqlDbType.VarChar,2),
					new MySqlParameter("@staff_identity_card", MySqlDbType.VarChar,18),
					new MySqlParameter("@staff_phone_number", MySqlDbType.VarChar,11),
					new MySqlParameter("@staff_age", MySqlDbType.Int32,4),
					new MySqlParameter("@staff_hire_date", MySqlDbType.DateTime),
					new MySqlParameter("@staff_belong_dep_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@staff_sx", MySqlDbType.VarChar,64),
					new MySqlParameter("@staff_id", MySqlDbType.VarChar,128)};
            parameters[0].Value = model.staff_name;
            parameters[1].Value = model.staff_sex;
            parameters[2].Value = model.staff_identity_card;
            parameters[3].Value = model.staff_phone_number;
            parameters[4].Value = model.staff_age;
            parameters[5].Value = model.staff_hire_date;
            parameters[6].Value = model.staff_belong_dep_id;
            parameters[7].Value = model.staff_sx;
            parameters[8].Value = model.staff_id;

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
        public bool Delete(string staff_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from staff ");
            strSql.Append(" where staff_id=@staff_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@staff_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = staff_id;

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
        public bool DeleteList(string staff_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from staff ");
            strSql.Append(" where staff_id in (" + staff_idlist + ")  ");
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
        public Model.staff GetModel(string staff_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select staff_id,staff_name,staff_sex,staff_identity_card,staff_phone_number,staff_age,staff_hire_date,staff_belong_dep_id,staff_sx from staff ");
            strSql.Append(" where staff_id=@staff_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@staff_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = staff_id;

            Model.staff model = new Model.staff();
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
        public Model.staff DataRowToModel(DataRow row)
        {
            Model.staff model = new Model.staff();
            if (row != null)
            {
                if (row["staff_id"] != null)
                {
                    model.staff_id = row["staff_id"].ToString();
                }
                if (row["staff_name"] != null)
                {
                    model.staff_name = row["staff_name"].ToString();
                }
                if (row["staff_sex"] != null)
                {
                    model.staff_sex = row["staff_sex"].ToString();
                }
                if (row["staff_identity_card"] != null)
                {
                    model.staff_identity_card = row["staff_identity_card"].ToString();
                }
                if (row["staff_phone_number"] != null)
                {
                    model.staff_phone_number = row["staff_phone_number"].ToString();
                }
                if (row["staff_age"] != null && row["staff_age"].ToString() != "")
                {
                    model.staff_age = int.Parse(row["staff_age"].ToString());
                }
                if (row["staff_hire_date"] != null && row["staff_hire_date"].ToString() != "")
                {
                    model.staff_hire_date = DateTime.Parse(row["staff_hire_date"].ToString());
                }
                if (row["staff_belong_dep_id"] != null)
                {
                    model.staff_belong_dep_id = row["staff_belong_dep_id"].ToString();
                }
                if (row["staff_sx"] != null)
                {
                    model.staff_sx = row["staff_sx"].ToString();
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
            strSql.Append("select staff_id,staff_name,staff_sex,staff_identity_card,staff_phone_number,staff_age,staff_hire_date,staff_belong_dep_id,staff_sx ");
            strSql.Append(" FROM staff ");
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
            strSql.Append("select count(1) FROM staff ");
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
                strSql.Append("order by T.staff_id desc");
            }
            strSql.Append(")AS Row, T.*  from staff T ");
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
            parameters[0].Value = "staff";
            parameters[1].Value = "staff_id";
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

