using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class SoftwareRepository:BaseRepository<Software>,ISoftwareRepository {
		private DbContext context;
		public SoftwareRepository(DbContext context ) : base( context ) {
			this.context = context;
		}
	}
}
