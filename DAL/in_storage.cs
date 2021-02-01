

using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using DBUtility;//Please add references
namespace DAL
{
	/// <summary>
	/// 数据访问类:in_storage
	/// </summary>
	public partial class in_storage
	{
		public in_storage()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("enter_num", "in_storage"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int enter_num)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from in_storage");
			strSql.Append(" where enter_num=@enter_num ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@enter_num", MySqlDbType.Int32,11)			};
			parameters[0].Value = enter_num;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.in_storage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into in_storage(");
			strSql.Append("enter_num,mat_id,mat_name,in_time,sl_id,in_amount,in_weight,in_volume)");
			strSql.Append(" values (");
			strSql.Append("@enter_num,@mat_id,@mat_name,@in_time,@sl_id,@in_amount,@in_weight,@in_volume)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@enter_num", MySqlDbType.Int32,11),
					new MySqlParameter("@mat_id", MySqlDbType.Int32,11),
					new MySqlParameter("@mat_name", MySqlDbType.VarChar,32),
					new MySqlParameter("@in_time", MySqlDbType.DateTime),
					new MySqlParameter("@sl_id", MySqlDbType.Int32,32),
					new MySqlParameter("@in_amount", MySqlDbType.Decimal,15),
					new MySqlParameter("@in_weight", MySqlDbType.Decimal,10),
					new MySqlParameter("@in_volume", MySqlDbType.Decimal,10)};
			parameters[0].Value = model.enter_num;
			parameters[1].Value = model.mat_id;
			parameters[2].Value = model.mat_name;
			parameters[3].Value = model.in_time;
			parameters[4].Value = model.sl_id;
			parameters[5].Value = model.in_amount;
			parameters[6].Value = model.in_weight;
			parameters[7].Value = model.in_volume;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(Model.in_storage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update in_storage set ");
			strSql.Append("mat_id=@mat_id,");
			strSql.Append("mat_name=@mat_name,");
			strSql.Append("in_time=@in_time,");
			strSql.Append("sl_id=@sl_id,");
			strSql.Append("in_amount=@in_amount,");
			strSql.Append("in_weight=@in_weight,");
			strSql.Append("in_volume=@in_volume");
			strSql.Append(" where enter_num=@enter_num ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@mat_id", MySqlDbType.Int32,11),
					new MySqlParameter("@mat_name", MySqlDbType.VarChar,32),
					new MySqlParameter("@in_time", MySqlDbType.DateTime),
					new MySqlParameter("@sl_id", MySqlDbType.Int32,32),
					new MySqlParameter("@in_amount", MySqlDbType.Decimal,15),
					new MySqlParameter("@in_weight", MySqlDbType.Decimal,10),
					new MySqlParameter("@in_volume", MySqlDbType.Decimal,10),
					new MySqlParameter("@enter_num", MySqlDbType.Int32,11)};
			parameters[0].Value = model.mat_id;
			parameters[1].Value = model.mat_name;
			parameters[2].Value = model.in_time;
			parameters[3].Value = model.sl_id;
			parameters[4].Value = model.in_amount;
			parameters[5].Value = model.in_weight;
			parameters[6].Value = model.in_volume;
			parameters[7].Value = model.enter_num;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int enter_num)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from in_storage ");
			strSql.Append(" where enter_num=@enter_num ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@enter_num", MySqlDbType.Int32,11)			};
			parameters[0].Value = enter_num;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string enter_numlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from in_storage ");
			strSql.Append(" where enter_num in ("+enter_numlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
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
		public Model.in_storage GetModel(int enter_num)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select enter_num,mat_id,mat_name,in_time,sl_id,in_amount,in_weight,in_volume from in_storage ");
			strSql.Append(" where enter_num=@enter_num ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@enter_num", MySqlDbType.Int32,11)			};
			parameters[0].Value = enter_num;

			Model.in_storage model=new Model.in_storage();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public Model.in_storage DataRowToModel(DataRow row)
		{
			Model.in_storage model=new Model.in_storage();
			if (row != null)
			{
				if(row["enter_num"]!=null && row["enter_num"].ToString()!="")
				{
					model.enter_num=int.Parse(row["enter_num"].ToString());
				}
				if(row["mat_id"]!=null && row["mat_id"].ToString()!="")
				{
					model.mat_id=int.Parse(row["mat_id"].ToString());
				}
				if(row["mat_name"]!=null)
				{
					model.mat_name=row["mat_name"].ToString();
				}
				if(row["in_time"]!=null && row["in_time"].ToString()!="")
				{
					model.in_time=DateTime.Parse(row["in_time"].ToString());
				}
				if(row["sl_id"]!=null && row["sl_id"].ToString()!="")
				{
					model.sl_id=int.Parse(row["sl_id"].ToString());
				}
				if(row["in_amount"]!=null && row["in_amount"].ToString()!="")
				{
					model.in_amount=decimal.Parse(row["in_amount"].ToString());
				}
				if(row["in_weight"]!=null && row["in_weight"].ToString()!="")
				{
					model.in_weight=decimal.Parse(row["in_weight"].ToString());
				}
				if(row["in_volume"]!=null && row["in_volume"].ToString()!="")
				{
					model.in_volume=decimal.Parse(row["in_volume"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select enter_num,mat_id,mat_name,in_time,sl_id,in_amount,in_weight,in_volume ");
			strSql.Append(" FROM in_storage ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM in_storage ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.enter_num desc");
			}
			strSql.Append(")AS Row, T.*  from in_storage T ");
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
			parameters[0].Value = "in_storage";
			parameters[1].Value = "enter_num";
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

