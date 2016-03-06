using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class MenuService:BaseService<Menu>,IMenuService {
		private IMenuRepository repository;
		public MenuService( IMenuRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
