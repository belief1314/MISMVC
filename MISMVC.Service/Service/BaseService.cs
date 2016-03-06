using MISMVC.Service.IService;
using System;
using System.Linq;
using System.Linq.Expressions;
using MISMVC.DAO.IRepository;

namespace MISMVC.Service.Service {
	public class BaseService<T> : IBaseService<T> where T : class {
		private IBaseRepository<T> repository;

		public BaseService(IBaseRepository<T> repository ) {
			this.repository = repository;
		}

		public T Add( T model ) {
			return repository.Add( model);
		}

		public bool Delete( T model ) {
			return repository.Delete( model);
		}

		public bool Exists( Expression<Func<T , bool>> anyLambda ) {
			return repository.Exists( anyLambda);
		}

		public T Find( Expression<Func<T , bool>> whereLambda ) {
			return repository.Find( whereLambda );
		}

		public IQueryable<T> Find<S>( Expression<Func<T , bool>> whereLambda , bool isAsc , Expression<Func<T , S>> orderLambda ) {
			return repository.Find<S>( whereLambda , isAsc , orderLambda );
		}

		public IQueryable<T> Find<S>( int pageIndex , int pageSize , out int totalRecord , Expression<Func<T , bool>> whereLambda , bool isAsc , Expression<Func<T , S>> orderLambda ) {
			return repository.Find<S>( pageIndex , pageSize , out totalRecord , whereLambda , isAsc , orderLambda );
		}

		public bool Update( T model ) {
			return repository.Update( model);
		}
	}
}
