using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class MISIDRepository:BaseRepository<MISID>,IMISIDRepository {
		private DbContext context;
		public MISIDRepository(DbContext context ):base(context) {
			this.context = context;
		}
	}
}
