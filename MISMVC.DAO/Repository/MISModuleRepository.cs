using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class MISModuleRepository:BaseRepository<MISModule>,IMISModuleRepository {
		private DbContext context;
		public MISModuleRepository(DbContext context ):base(context) {
			this.context = context;
		}
	}
}
