using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class MenuMenuItemRepository:BaseRepository<MenuMenuItem>,IMenuMenuItemRepository {
		private DbContext context;
		public MenuMenuItemRepository(DbContext context ):base(context) {
			this.context = context;
		}
	}
}
