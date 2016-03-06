using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class MenuModuleRepository:BaseRepository<MenuModule>,IMenuModuleRepository {
		private DbContext context;
		public MenuModuleRepository(DbContext context ):base(context) {
			this.context = context;
		}
	}
}
