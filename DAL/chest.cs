using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using DBUtility;//Please add references
namespace DAL
{
	/// <summary>
	/// 数据访问类:chest
	/// </summary>
	public partial class chest
	{
		public chest()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("chest_id", "chest"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int chest_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from chest");
			strSql.Append(" where chest_id=@chest_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@chest_id", MySqlDbType.Int32)
			};
			parameters[0].Value = chest_id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.chest model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into chest(");
			strSql.Append("chest_name,chest_remain_volume,chest_remain_seat,chest_create_time,chest_type,chest_belong_storage)");
			strSql.Append(" values (");
			strSql.Append("@chest_name,@chest_remain_volume,@chest_remain_seat,@chest_create_time,@chest_type,@chest_belong_storage)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@chest_name", MySqlDbType.VarChar,32),
					new MySqlParameter("@chest_remain_volume", MySqlDbType.Float,128),
					new MySqlParameter("@chest_remain_seat", MySqlDbType.Int32,32),
					new MySqlParameter("@chest_create_time", MySqlDbType.DateTime),
					new MySqlParameter("@chest_type", MySqlDbType.Int32,32),
					new MySqlParameter("@chest_belong_storage", MySqlDbType.Int32,32)};
			parameters[0].Value = model.chest_name;
			parameters[1].Value = model.chest_remain_volume;
			parameters[2].Value = model.chest_remain_seat;
			parameters[3].Value = model.chest_create_time;
			parameters[4].Value = model.chest_type;
			parameters[5].Value = model.chest_belong_storage;

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
		public bool Update(Model.chest model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update chest set ");
			strSql.Append("chest_name=@chest_name,");
			strSql.Append("chest_remain_volume=@chest_remain_volume,");
			strSql.Append("chest_remain_seat=@chest_remain_seat,");
			strSql.Append("chest_create_time=@chest_create_time,");
			strSql.Append("chest_type=@chest_type,");
			strSql.Append("chest_belong_storage=@chest_belong_storage");
			strSql.Append(" where chest_id=@chest_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@chest_name", MySqlDbType.VarChar,32),
					new MySqlParameter("@chest_remain_volume", MySqlDbType.Float,128),
					new MySqlParameter("@chest_remain_seat", MySqlDbType.Int32,32),
					new MySqlParameter("@chest_create_time", MySqlDbType.DateTime),
					new MySqlParameter("@chest_type", MySqlDbType.Int32,32),
					new MySqlParameter("@chest_belong_storage", MySqlDbType.Int32,32),
					new MySqlParameter("@chest_id", MySqlDbType.Int32,32)};
			parameters[0].Value = model.chest_name;
			parameters[1].Value = model.chest_remain_volume;
			parameters[2].Value = model.chest_remain_seat;
			parameters[3].Value = model.chest_create_time;
			parameters[4].Value = model.chest_type;
			parameters[5].Value = model.chest_belong_storage;
			parameters[6].Value = model.chest_id;

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
		public bool Delete(int chest_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from chest ");
			strSql.Append(" where chest_id=@chest_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@chest_id", MySqlDbType.Int32)
			};
			parameters[0].Value = chest_id;

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
		public bool DeleteList(string chest_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from chest ");
			strSql.Append(" where chest_id in ("+chest_idlist + ")  ");
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
		public Model.chest GetModel(int chest_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select chest_id,chest_name,chest_remain_volume,chest_remain_seat,chest_create_time,chest_type,chest_belong_storage from chest ");
			strSql.Append(" where chest_id=@chest_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@chest_id", MySqlDbType.Int32)
			};
			parameters[0].Value = chest_id;

			Model.chest model=new Model.chest();
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
		public Model.chest DataRowToModel(DataRow row)
		{
			Model.chest model=new Model.chest();
			if (row != null)
			{
				if(row["chest_id"]!=null && row["chest_id"].ToString()!="")
				{
					model.chest_id=int.Parse(row["chest_id"].ToString());
				}
				if(row["chest_name"]!=null)
				{
					model.chest_name=row["chest_name"].ToString();
				}
				if(row["chest_remain_volume"]!=null && row["chest_remain_volume"].ToString()!="")
				{
					model.chest_remain_volume=decimal.Parse(row["chest_remain_volume"].ToString());
				}
				if(row["chest_remain_seat"]!=null && row["chest_remain_seat"].ToString()!="")
				{
					model.chest_remain_seat=int.Parse(row["chest_remain_seat"].ToString());
				}
				if(row["chest_create_time"]!=null && row["chest_create_time"].ToString()!="")
				{
					model.chest_create_time=DateTime.Parse(row["chest_create_time"].ToString());
				}
				if(row["chest_type"]!=null && row["chest_type"].ToString()!="")
				{
					model.chest_type=int.Parse(row["chest_type"].ToString());
				}
				if(row["chest_belong_storage"]!=null && row["chest_belong_storage"].ToString()!="")
				{
					model.chest_belong_storage=int.Parse(row["chest_belong_storage"].ToString());
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
			strSql.Append("select chest_id,chest_name,chest_remain_volume,chest_remain_seat,chest_create_time,chest_type,chest_belong_storage ");
			strSql.Append(" FROM chest ");
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
			strSql.Append("select count(1) FROM chest ");
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
				strSql.Append("order by T.chest_id desc");
			}
			strSql.Append(")AS Row, T.*  from chest T ");
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
			parameters[0].Value = "chest";
			parameters[1].Value = "chest_id";
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

