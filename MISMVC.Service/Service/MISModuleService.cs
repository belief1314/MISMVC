using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class MISModuleService:BaseService<MISModule>,IMISModuleService {
		private IMISModuleRepository repository;
		public MISModuleService( IMISModuleRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
