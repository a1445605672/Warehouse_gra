using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:enter_storage
	/// </summary>
	public partial class enter_storage
	{
		public enter_storage()
		{}
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("enter_id", "enter_storage");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int enter_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from enter_storage");
            strSql.Append(" where enter_id=@enter_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@enter_id", MySqlDbType.Int32,32)			};
            parameters[0].Value = enter_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.enter_storage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into enter_storage(");
            strSql.Append("enter_id,enter_batch_id,enter_sl_id,enter_amount,enter_unit_bulk,supplier_id,enter_mat_id,enter_mat_name,enter_fengji_num,enter_date,enter_agent_id,enter_agent_name,enter_comment)");
            strSql.Append(" values (");
            strSql.Append("@enter_id,@enter_batch_id,@enter_sl_id,@enter_amount,@enter_unit_bulk,@supplier_id,@enter_mat_id,@enter_mat_name,@enter_fengji_num,@enter_date,@enter_agent_id,@enter_agent_name,@enter_comment)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@enter_id", MySqlDbType.Int32,32),
					new MySqlParameter("@enter_batch_id", MySqlDbType.Int32,32),
					new MySqlParameter("@enter_sl_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@enter_amount", MySqlDbType.Decimal,15),
					new MySqlParameter("@enter_unit_bulk", MySqlDbType.Decimal,15),
					new MySqlParameter("@supplier_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@enter_mat_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@enter_mat_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@enter_fengji_num", MySqlDbType.VarChar,128),
					new MySqlParameter("@enter_date", MySqlDbType.DateTime),
					new MySqlParameter("@enter_agent_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@enter_agent_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@enter_comment", MySqlDbType.VarChar,255)};
            parameters[0].Value = model.enter_id;
            parameters[1].Value = model.enter_batch_id;
            parameters[2].Value = model.enter_sl_id;
            parameters[3].Value = model.enter_amount;
            parameters[4].Value = model.enter_unit_bulk;
            parameters[5].Value = model.supplier_id;
            parameters[6].Value = model.enter_mat_id;
            parameters[7].Value = model.enter_mat_name;
            parameters[8].Value = model.enter_fengji_num;
            parameters[9].Value = model.enter_date;
            parameters[10].Value = model.enter_agent_id;
            parameters[11].Value = model.enter_agent_name;
            parameters[12].Value = model.enter_comment;

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
        public bool Update(Model.enter_storage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update enter_storage set ");
            strSql.Append("enter_batch_id=@enter_batch_id,");
            strSql.Append("enter_sl_id=@enter_sl_id,");
            strSql.Append("enter_amount=@enter_amount,");
            strSql.Append("enter_unit_bulk=@enter_unit_bulk,");
            strSql.Append("supplier_id=@supplier_id,");
            strSql.Append("enter_mat_id=@enter_mat_id,");
            strSql.Append("enter_mat_name=@enter_mat_name,");
            strSql.Append("enter_fengji_num=@enter_fengji_num,");
            strSql.Append("enter_date=@enter_date,");
            strSql.Append("enter_agent_id=@enter_agent_id,");
            strSql.Append("enter_agent_name=@enter_agent_name,");
            strSql.Append("enter_comment=@enter_comment");
            strSql.Append(" where enter_id=@enter_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@enter_batch_id", MySqlDbType.Int32,32),
					new MySqlParameter("@enter_sl_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@enter_amount", MySqlDbType.Decimal,15),
					new MySqlParameter("@enter_unit_bulk", MySqlDbType.Decimal,15),
					new MySqlParameter("@supplier_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@enter_mat_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@enter_mat_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@enter_fengji_num", MySqlDbType.VarChar,128),
					new MySqlParameter("@enter_date", MySqlDbType.DateTime),
					new MySqlParameter("@enter_agent_id", MySqlDbType.VarChar,128),
					new MySqlParameter("@enter_agent_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@enter_comment", MySqlDbType.VarChar,255),
					new MySqlParameter("@enter_id", MySqlDbType.Int32,32)};
            parameters[0].Value = model.enter_batch_id;
            parameters[1].Value = model.enter_sl_id;
            parameters[2].Value = model.enter_amount;
            parameters[3].Value = model.enter_unit_bulk;
            parameters[4].Value = model.supplier_id;
            parameters[5].Value = model.enter_mat_id;
            parameters[6].Value = model.enter_mat_name;
            parameters[7].Value = model.enter_fengji_num;
            parameters[8].Value = model.enter_date;
            parameters[9].Value = model.enter_agent_id;
            parameters[10].Value = model.enter_agent_name;
            parameters[11].Value = model.enter_comment;
            parameters[12].Value = model.enter_id;

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
        public bool Delete(int enter_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from enter_storage ");
            strSql.Append(" where enter_id=@enter_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@enter_id", MySqlDbType.Int32,32)			};
            parameters[0].Value = enter_id;

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
        public bool DeleteList(string enter_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from enter_storage ");
            strSql.Append(" where enter_id in (" + enter_idlist + ")  ");
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
        public Model.enter_storage GetModel(int enter_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select enter_id,enter_batch_id,enter_sl_id,enter_amount,enter_unit_bulk,supplier_id,enter_mat_id,enter_mat_name,enter_fengji_num,enter_date,enter_agent_id,enter_agent_name,enter_comment from enter_storage ");
            strSql.Append(" where enter_id=@enter_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@enter_id", MySqlDbType.Int32,32)			};
            parameters[0].Value = enter_id;

            Model.enter_storage model = new Model.enter_storage();
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
        public Model.enter_storage DataRowToModel(DataRow row)
        {
            Model.enter_storage model = new Model.enter_storage();
            if (row != null)
            {
                if (row["enter_id"] != null && row["enter_id"].ToString() != "")
                {
                    model.enter_id = row["enter_id"].ToString();
                }
                if (row["enter_batch_id"] != null && row["enter_batch_id"].ToString() != "")
                {
                    model.enter_batch_id = (row["enter_batch_id"].ToString());
                }
                if (row["enter_sl_id"] != null)
                {
                    model.enter_sl_id = (row["enter_sl_id"].ToString());
                }
                if (row["enter_amount"] != null && row["enter_amount"].ToString() != "")
                {
                    model.enter_amount = decimal.Parse(row["enter_amount"].ToString());
                }
                if (row["enter_unit_bulk"] != null && row["enter_unit_bulk"].ToString() != "")
                {
                    model.enter_unit_bulk = decimal.Parse(row["enter_unit_bulk"].ToString());
                }
                if (row["supplier_id"] != null)
                {
                    model.supplier_id = (row["supplier_id"].ToString());
                }
                if (row["enter_mat_id"] != null)
                {
                    model.enter_mat_id = (row["enter_mat_id"].ToString());
                }
                if (row["enter_mat_name"] != null)
                {
                    model.enter_mat_name = row["enter_mat_name"].ToString();
                }
                if (row["enter_fengji_num"] != null)
                {
                    model.enter_fengji_num = (row["enter_fengji_num"].ToString());
                }
                if (row["enter_date"] != null && row["enter_date"].ToString() != "")
                {
                    model.enter_date = DateTime.Parse(row["enter_date"].ToString());
                }
                if (row["enter_agent_id"] != null)
                {
                    model.enter_agent_id = (row["enter_agent_id"].ToString());
                }
                if (row["enter_agent_name"] != null)
                {
                    model.enter_agent_name = row["enter_agent_name"].ToString();
                }
                if (row["enter_comment"] != null)
                {
                    model.enter_comment = row["enter_comment"].ToString();
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
            strSql.Append("select enter_id,enter_batch_id,enter_sl_id,enter_amount,enter_unit_bulk,supplier_id,enter_mat_id,enter_mat_name,enter_fengji_num,enter_date,enter_agent_id,enter_agent_name,enter_comment ");
            strSql.Append(" FROM enter_storage ");
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
            strSql.Append("select count(1) FROM enter_storage ");
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
                strSql.Append("order by T.enter_id desc");
            }
            strSql.Append(")AS Row, T.*  from enter_storage T ");
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
            parameters[0].Value = "enter_storage";
            parameters[1].Value = "enter_id";
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

