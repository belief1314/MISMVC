using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class MenuItemService:BaseService<MenuItem>,IMenuItemService {
		private IMenuItemRepository repository;
		public MenuItemService( IMenuItemRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
