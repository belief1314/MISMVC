using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class MenuRepository:BaseRepository<Menu>,IMenuRepository {
		private DbContext context;
		public MenuRepository(DbContext context ):base(context) {
			this.context = context;
		}
	}
}
