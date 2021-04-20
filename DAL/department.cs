
using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using DBUtility;//Please add references
namespace DAL
{
	/// <summary>
	/// 数据访问类:department
	/// </summary>
	public partial class department
	{
		public department()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string dep_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from department");
            strSql.Append(" where dep_id=@dep_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@dep_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = dep_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.department model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into department(");
            strSql.Append("dep_id,dep_name,dep_principal_name,dep_principal_id,dep_sx)");
            strSql.Append(" values (");
            strSql.Append("@dep_id,@dep_name,@dep_principal_name,@dep_principal_id,@dep_sx)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@dep_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@dep_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@dep_principal_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@dep_principal_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@dep_sx", MySqlDbType.VarChar,64)};
            parameters[0].Value = model.dep_id;
            parameters[1].Value = model.dep_name;
            parameters[2].Value = model.dep_principal_name;
            parameters[3].Value = model.dep_principal_id;
            parameters[4].Value = model.dep_sx;

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
        public bool Update(Model.department model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update department set ");
            strSql.Append("dep_name=@dep_name,");
            strSql.Append("dep_principal_name=@dep_principal_name,");
            strSql.Append("dep_principal_id=@dep_principal_id,");
            strSql.Append("dep_sx=@dep_sx");
            strSql.Append(" where dep_id=@dep_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@dep_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@dep_principal_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@dep_principal_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@dep_sx", MySqlDbType.VarChar,64),
					new MySqlParameter("@dep_id", MySqlDbType.VarChar,128)};
            parameters[0].Value = model.dep_name;
            parameters[1].Value = model.dep_principal_name;
            parameters[2].Value = model.dep_principal_id;
            parameters[3].Value = model.dep_sx;
            parameters[4].Value = model.dep_id;

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
        public bool Delete(string dep_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from department ");
            strSql.Append(" where dep_id=@dep_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@dep_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = dep_id;

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
        public bool DeleteList(string dep_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from department ");
            strSql.Append(" where dep_id in (" + dep_idlist + ")  ");
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
        public Model.department GetModel(string dep_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select dep_id,dep_name,dep_principal_name,dep_principal_id,dep_sx from department ");
            strSql.Append(" where dep_id=@dep_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@dep_id", MySqlDbType.VarChar,128)			};
            parameters[0].Value = dep_id;

            Model.department model = new Model.department();
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


        public Model.department GetModel_Name(string dep_name)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select dep_id,dep_name,dep_principal_name,dep_principal_id,dep_sx from department ");
            strSql.Append(" where dep_name=@dep_name ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@dep_name", MySqlDbType.VarChar,64)          };
            parameters[0].Value = dep_name;

            Model.department model = new Model.department();
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
        public Model.department DataRowToModel(DataRow row)
        {
            Model.department model = new Model.department();
            if (row != null)
            {
                if (row["dep_id"] != null)
                {
                    model.dep_id = row["dep_id"].ToString();
                }
                if (row["dep_name"] != null)
                {
                    model.dep_name = row["dep_name"].ToString();
                }
                if (row["dep_principal_name"] != null)
                {
                    model.dep_principal_name = row["dep_principal_name"].ToString();
                }
                if (row["dep_principal_id"] != null)
                {
                    model.dep_principal_id = row["dep_principal_id"].ToString();
                }
                if (row["dep_sx"] != null)
                {
                    model.dep_sx = row["dep_sx"].ToString();
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
            strSql.Append("select dep_id,dep_name,dep_principal_name,dep_principal_id,dep_sx ");
            strSql.Append(" FROM department ");
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
            strSql.Append("select count(*) FROM department ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            //object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
                strSql.Append("order by T.dep_id desc");
            }
            strSql.Append(")AS Row, T.*  from department T ");
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
            parameters[0].Value = "department";
            parameters[1].Value = "dep_id";
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

