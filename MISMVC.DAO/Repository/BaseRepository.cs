using MISMVC.DAO.IRepository;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MISMVC.DAO.Repository {
	public class BaseRepository<T> : IBaseRepository<T> where T : class {

		private DbContext context;
		public BaseRepository(DbContext context ) {
			this.context = context;
		}

		public T Add( T model ) {
			context.Entry<T>( model ).State = EntityState.Added;
			if( context.SaveChanges( ) > 0 ) {
				return model;
			} else {
				return null;
			}
		}

		public bool Delete( T model ) {
			context.Set<T>( ).Attach( model );
			context.Entry<T>( model ).State = EntityState.Deleted;
			return context.SaveChanges( ) > 0;
		}

		public bool Exists( Expression<Func<T , bool>> whereLambda ) {
			return context.Set<T>( ).Any( whereLambda );
		}

		public T Find( Expression<Func<T , bool>> whereLambda ) {
			return context.Set<T>( ).FirstOrDefault<T>( whereLambda );
		}

		public IQueryable<T> Find<S>( Expression<Func<T , bool>> whereLambda , bool isAsc , Expression<Func<T , S>> orderLambda ) {
			var _list = context.Set<T>( ).Where<T>( whereLambda );
			if( isAsc ) {
				_list = _list.OrderBy<T , S>( orderLambda );
			} else {
				_list = _list.OrderByDescending<T , S>( orderLambda );
			}
			return _list;
		}

		public IQueryable<T> Find<S>( int pageIndex , int pageSize , out int totalRecord , Expression<Func<T , bool>> whereLambda , bool isAsc , Expression<Func<T , S>> orderLambda ) {
			var _list = context.Set<T>( ).Where<T>( whereLambda );

			if( _list == null || _list.Count( ) < 1 ) {
				totalRecord = 0;
				return null;
			}

			totalRecord = _list.Count( );
			if( isAsc ) {
				_list = _list.OrderBy<T , S>( orderLambda ).Skip<T>( ( pageIndex - 1 ) * pageSize ).Take<T>( pageSize );
			} else {
				_list = _list.OrderByDescending<T , S>( orderLambda ).Skip<T>( ( pageIndex - 1 ) * pageSize ).Take<T>( pageSize );
			}
			return _list;
		}

		public bool Update( T model ) {
			context.Set<T>( ).Attach( model );
			context.Entry<T>( model ).State = EntityState.Modified;
			return context.SaveChanges( ) > 0;
		}
	}
}
