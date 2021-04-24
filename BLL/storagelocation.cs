﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Model;
namespace BLL
{
	/// <summary>
	/// storagelocation
	/// </summary>
	public partial class storagelocation
	{
		private readonly DAL.storagelocation dal=new DAL.storagelocation();
		public storagelocation()
		{}
		#region  BasicMethod

		

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string sl_id)
		{
			return dal.Exists(sl_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.storagelocation model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.storagelocation model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据，执行Sql语句
		/// </summary>
		/// <param name="sql">Sql语句</param>
		/// <returns>bool类型判断是否更新成功</returns>
		public bool Update(string sql)
		{
			return dal.Update(sql);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string sl_id)
		{
			
			return dal.Delete(sl_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string sl_idlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(sl_idlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.storagelocation GetModel(string sl_id)
		{
			
			return dal.GetModel(sl_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.storagelocation GetModelByCache(string sl_id)
		{
			
			string CacheKey = "storagelocationModel-" + sl_id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(sl_id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.storagelocation)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.storagelocation> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.storagelocation> DataTableToList(DataTable dt)
		{
			List<Model.storagelocation> modelList = new List<Model.storagelocation>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.storagelocation model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

