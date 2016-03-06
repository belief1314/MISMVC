using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class RoleService:BaseService<Role>,IRoleService {
		private IRoleRepository repository;
		public RoleService( IRoleRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
