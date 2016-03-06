using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class SoftwareGroupRepository:BaseRepository<SoftwareGroup> ,ISoftwareGroupRepository{
		private DbContext context;
		public SoftwareGroupRepository(DbContext context ) : base( context ) {
			this.context = context;
		}
	}
}
