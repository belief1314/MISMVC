using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class SoftwareService:BaseService<Software>,ISoftwareService {
		private ISoftwareRepository repository;
		public SoftwareService( ISoftwareRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
