using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class MenuItemRepository:BaseRepository<MenuItem>,IMenuItemRepository {
		private DbContext context;
		public MenuItemRepository(DbContext context ):base(context) {
			this.context = context;
		}
	}
}
