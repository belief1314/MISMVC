using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class MenuMenuItemService:BaseService<MenuMenuItem>,IMenuMenuItemService {
		private IMenuMenuItemRepository repository;
		public MenuMenuItemService( IMenuMenuItemRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
