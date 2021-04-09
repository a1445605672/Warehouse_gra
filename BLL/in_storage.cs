using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Model;
namespace BLL
{
	/// <summary>
	/// in_storage
	/// </summary>
	public partial class in_storage
	{
		private readonly DAL.in_storage dal=new DAL.in_storage();
		public in_storage()
		{}
		#region  BasicMethod

		
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string enter_num)
		{
			return dal.Exists(enter_num);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.in_storage model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.in_storage model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string enter_num)
		{
			
			return dal.Delete(enter_num);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string enter_numlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(enter_numlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.in_storage GetModel(string in_time)
		{
			
			return dal.GetModel(in_time);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.in_storage GetModelByCache(string enter_num)
		{
			
			string CacheKey = "in_storageModel-" + enter_num;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(enter_num);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.in_storage)objModel;
		}

		/// <summary>
		/// 获得数据列表,返回Dataset类型数据
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere,0);
		}
		/// <summary>
		/// 获得数据列表,返回list类型数据
		/// <paramref name="strWhere"/>sql查询语句条件
		/// </summary>
		public List<Model.in_storage> GetModelList(string strWhere)
		{
			
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 
		/// 
		/// <paramref name="dt"/>DataTable</DataTable>
		/// <return>
		/// <List类型>
		/// </return>
		/// </summary>
		public List<Model.in_storage> DataTableToList(DataTable dt)
		{
			List<Model.in_storage> modelList = new List<Model.in_storage>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.in_storage model;
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

