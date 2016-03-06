using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class MenuModuleService:BaseService<MenuModule>,IMenuModuleService {
		private IMenuModuleRepository repository;
		public MenuModuleService( IMenuModuleRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
