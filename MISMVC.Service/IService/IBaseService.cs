using System;
using System.Linq;
using System.Linq.Expressions;

namespace MISMVC.Service.IService {
	public interface IBaseService<T>
    {
		/// <summary>
		/// add record
		/// </summary>
		/// <param name="model">entity</param>
		/// <returns>entity</returns>
		T Add( T model );

		/// <summary>
		/// update record
		/// </summary>
		/// <param name="model">entity</param>
		/// <returns>bool</returns>
		bool Update( T model );

		/// <summary>
		/// delete record
		/// </summary>
		/// <param name="model">entity</param>
		/// <returns>bool</returns>
		bool Delete( T model );

		/// <summary>
		/// 
		/// </summary>
		/// <param name="whereLambda"></param>
		/// <returns></returns>
		T Find( Expression<Func<T , bool>> whereLambda );

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="S"></typeparam>
		/// <param name="whereLambda"></param>
		/// <param name="isAsc"></param>
		/// <param name="orderLambda"></param>
		/// <returns></returns>
		IQueryable<T> Find<S>( Expression<Func<T , bool>> whereLambda , bool isAsc , Expression<Func<T , S>> orderLambda );

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="S"></typeparam>
		/// <param name="pageIndex"></param>
		/// <param name="pageSize"></param>
		/// <param name="totalRecord"></param>
		/// <param name="whereLambda"></param>
		/// <param name="isAsc"></param>
		/// <param name="orderLambda"></param>
		/// <returns></returns>
		IQueryable<T> Find<S>( int pageIndex , int pageSize , out int totalRecord , Expression<Func<T , bool>> whereLambda , bool isAsc , Expression<Func<T , S>> orderLambda );

		/// <summary>
		/// 
		/// </summary>
		/// <param name="anyLambda"></param>
		/// <returns></returns>
		bool Exists( Expression<Func<T , bool>> anyLambda );
	}
}
