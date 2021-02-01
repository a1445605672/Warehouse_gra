
using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using DBUtility;//Please add references
namespace DAL
{
	/// <summary>
	/// 数据访问类:chest_type
	/// </summary>
	public partial class chest_type
	{
		public chest_type()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("type_id", "chest_type"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int type_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from chest_type");
			strSql.Append(" where type_id=@type_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@type_id", MySqlDbType.Int32,32)			};
			parameters[0].Value = type_id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.chest_type model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into chest_type(");
			strSql.Append("type_id,type_length,type_high,type_wide)");
			strSql.Append(" values (");
			strSql.Append("@type_id,@type_length,@type_high,@type_wide)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@type_id", MySqlDbType.Int32,32),
					new MySqlParameter("@type_length", MySqlDbType.Decimal,10),
					new MySqlParameter("@type_high", MySqlDbType.Decimal,10),
					new MySqlParameter("@type_wide", MySqlDbType.Decimal,10)};
			parameters[0].Value = model.type_id;
			parameters[1].Value = model.type_length;
			parameters[2].Value = model.type_high;
			parameters[3].Value = model.type_wide;

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
		public bool Update(Model.chest_type model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update chest_type set ");
			strSql.Append("type_length=@type_length,");
			strSql.Append("type_high=@type_high,");
			strSql.Append("type_wide=@type_wide");
			strSql.Append(" where type_id=@type_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@type_length", MySqlDbType.Decimal,10),
					new MySqlParameter("@type_high", MySqlDbType.Decimal,10),
					new MySqlParameter("@type_wide", MySqlDbType.Decimal,10),
					new MySqlParameter("@type_id", MySqlDbType.Int32,32)};
			parameters[0].Value = model.type_length;
			parameters[1].Value = model.type_high;
			parameters[2].Value = model.type_wide;
			parameters[3].Value = model.type_id;

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
		public bool Delete(int type_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from chest_type ");
			strSql.Append(" where type_id=@type_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@type_id", MySqlDbType.Int32,32)			};
			parameters[0].Value = type_id;

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
		public bool DeleteList(string type_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from chest_type ");
			strSql.Append(" where type_id in ("+type_idlist + ")  ");
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
		public Model.chest_type GetModel(int type_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select type_id,type_length,type_high,type_wide from chest_type ");
			strSql.Append(" where type_id=@type_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@type_id", MySqlDbType.Int32,32)			};
			parameters[0].Value = type_id;

			Model.chest_type model=new Model.chest_type();
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
		public Model.chest_type DataRowToModel(DataRow row)
		{
			Model.chest_type model=new Model.chest_type();
			if (row != null)
			{
				if(row["type_id"]!=null && row["type_id"].ToString()!="")
				{
					model.type_id=int.Parse(row["type_id"].ToString());
				}
				if(row["type_length"]!=null && row["type_length"].ToString()!="")
				{
					model.type_length=decimal.Parse(row["type_length"].ToString());
				}
				if(row["type_high"]!=null && row["type_high"].ToString()!="")
				{
					model.type_high=decimal.Parse(row["type_high"].ToString());
				}
				if(row["type_wide"]!=null && row["type_wide"].ToString()!="")
				{
					model.type_wide=decimal.Parse(row["type_wide"].ToString());
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
			strSql.Append("select type_id,type_length,type_high,type_wide ");
			strSql.Append(" FROM chest_type ");
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
			strSql.Append("select count(1) FROM chest_type ");
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
				strSql.Append("order by T.type_id desc");
			}
			strSql.Append(")AS Row, T.*  from chest_type T ");
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
			parameters[0].Value = "chest_type";
			parameters[1].Value = "type_id";
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

