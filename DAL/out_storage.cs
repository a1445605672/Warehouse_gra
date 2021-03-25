
using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using DBUtility;//Please add references
namespace DAL
{
	/// <summary>
	/// 数据访问类:out_storage
	/// </summary>
	public partial class out_storage
	{
		public out_storage()
		{}
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("num", "out_storage");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int num)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from out_storage");
            strSql.Append(" where num=@num");
            MySqlParameter[] parameters = {
					new MySqlParameter("@num", MySqlDbType.Int32)
			};
            parameters[0].Value = num;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.out_storage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into out_storage(");
            strSql.Append("out_id,out_mat_id,out_mat_name,out_account,out_batch_id,out_data,out_staff_id,out_staff_name,out_if_accomplish,out_sr_id,remark)");
            strSql.Append(" values (");
            strSql.Append("@out_id,@out_mat_id,@out_mat_name,@out_account,@out_batch_id,@out_data,@out_staff_id,@out_staff_name,@out_if_accomplish,@out_sr_id,@remark)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@out_id", MySqlDbType.String ,128),
					new MySqlParameter("@out_mat_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@out_mat_name", MySqlDbType.VarChar,32),
					new MySqlParameter("@out_account", MySqlDbType.Decimal,15),
					new MySqlParameter("@out_batch_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@out_data", MySqlDbType.VarChar,128),
					new MySqlParameter("@out_staff_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@out_staff_name", MySqlDbType.VarChar,64),
            new MySqlParameter("@out_if_accomplish", MySqlDbType.Int32,8),
            new MySqlParameter("@out_sr_id", MySqlDbType.VarChar,128),
            new MySqlParameter("@remark",MySqlDbType.VarChar,128)};

            parameters[0].Value = model.out_id;
            parameters[1].Value = model.out_mat_id;
            parameters[2].Value = model.out_mat_name;
            parameters[3].Value = model.out_account;
            parameters[4].Value = model.out_batch_id;
            parameters[5].Value = model.out_data;
            parameters[6].Value = model.out_staff_id;
            parameters[7].Value = model.out_staff_name;
            parameters[8].Value = model.out_if_accomplish;
            parameters[9].Value = model.out_sr_id;
            parameters[10].Value = model.remark;
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
        public bool Update(Model.out_storage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update out_storage set ");
            strSql.Append("out_id=@out_id,");
            strSql.Append("out_mat_id=@out_mat_id,");
            strSql.Append("out_mat_name=@out_mat_name,");
            strSql.Append("out_account=@out_account,");
            strSql.Append("out_batch_id=@out_batch_id,");
            strSql.Append("out_data=@out_data,");
            strSql.Append("out_staff_id=@out_staff_id,");
            strSql.Append("out_staff_name=@out_staff_name");
            strSql.Append(" where num=@num");
            MySqlParameter[] parameters = {
					new MySqlParameter("@out_id", MySqlDbType.Int32,128),
					new MySqlParameter("@out_mat_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@out_mat_name", MySqlDbType.VarChar,32),
					new MySqlParameter("@out_account", MySqlDbType.Decimal,15),
					new MySqlParameter("@out_batch_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@out_data", MySqlDbType.DateTime),
					new MySqlParameter("@out_staff_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@out_staff_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@num", MySqlDbType.Int32,128)};
            parameters[0].Value = model.out_id;
            parameters[1].Value = model.out_mat_id;
            parameters[2].Value = model.out_mat_name;
            parameters[3].Value = model.out_account;
            parameters[4].Value = model.out_batch_id;
            parameters[5].Value = model.out_data;
            parameters[6].Value = model.out_staff_id;
            parameters[7].Value = model.out_staff_name;
            
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
        /// <param name="Sql">sql语句</param>
        /// <returns>boolean</returns>
        public bool Update(string Sql)
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
        public bool Delete(string out_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from out_storage ");
            strSql.Append(" where  out_id=");
            strSql.Append("\'");
            strSql.Append(out_id);
            strSql.Append("\'");
   //         MySqlParameter[] parameters = {
			//		new MySqlParameter(num, MySqlDbType.String)
			//};
   //         parameters[0].Value = num;

           // int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string out_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from out_storage ");
            strSql.Append(" where num in (" + out_idlist + ")  ");
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
        public Model.out_storage GetModel(int num)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select out_id,out_mat_id,out_mat_name,out_account,out_batch_id,out_data,out_staff_id,out_staff_name,num from out_storage ");
            strSql.Append(" where num=@num");
            MySqlParameter[] parameters = {
					new MySqlParameter("@num", MySqlDbType.Int32)
			};
            parameters[0].Value = num;

            Model.out_storage model = new Model.out_storage();
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
        public Model.out_storage DataRowToModel(DataRow row)
        {
            Model.out_storage model = new Model.out_storage();
            if (row != null)
            {
                if (row["out_id"] != null && row["out_id"].ToString() != "")
                {
                    model.out_id = row["out_id"].ToString();
                }
                if (row["out_mat_id"] != null)
                {
                    model.out_mat_id = row["out_mat_id"].ToString();
                }
                if (row["out_mat_name"] != null)
                {
                    model.out_mat_name = row["out_mat_name"].ToString();
                }
                if (row["out_account"] != null && row["out_account"].ToString() != "")
                {
                    model.out_account = decimal.Parse(row["out_account"].ToString());
                }
                if (row["out_batch_id"] != null)
                {
                    model.out_batch_id = row["out_batch_id"].ToString();
                }
                if (row["out_data"] != null && row["out_data"].ToString() != "")
                {
                    model.out_data = (row["out_data"].ToString());
                }
                if (row["out_staff_id"] != null)
                {
                    model.out_staff_id = row["out_staff_id"].ToString();
                }
                if (row["out_staff_name"] != null)
                {
                    model.out_staff_name = row["out_staff_name"].ToString();
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
            strSql.Append("select out_id,out_mat_id,out_mat_name,out_account,out_batch_id,out_data,out_staff_id,out_staff_name");
            strSql.Append(" FROM out_storage ");
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
            strSql.Append("select count(1) FROM out_storage ");
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
                strSql.Append("order by T.num desc");
            }
            strSql.Append(")AS Row, T.*  from out_storage T ");
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
            parameters[0].Value = "out_storage";
            parameters[1].Value = "num";
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

