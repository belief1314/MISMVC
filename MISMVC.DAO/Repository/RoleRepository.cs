using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class RoleRepository:BaseRepository<Role>,IRoleRepository {
		private DbContext context;
		public RoleRepository(DbContext context ) : base(context ) {
			this.context = context;
		}
	}
}
