using System;
using System.Linq;
using System.Linq.Expressions;

namespace MISMVC.DAO.IRepository {
	public interface IBaseRepository<T>
    {
		T Add( T model );
		bool Update( T model );
		bool Delete( T model );
		T Find( Expression<Func<T , bool>> whereLambda );
		IQueryable<T> Find<S>( Expression<Func<T , bool>> whereLambda , bool isAsc , Expression<Func<T , S>> orderLambda );
		IQueryable<T> Find<S>( int pageIndex , int pageSize , out int totalRecord , Expression<Func<T , bool>> whereLambda , bool isAsc , Expression<Func<T , S>> orderLambda );
		bool Exists( Expression<Func<T , bool>> whereLambda );
	}
}
