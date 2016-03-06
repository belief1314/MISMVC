using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class SoftwareGroupService:BaseService<SoftwareGroup>,ISoftwareGroupService {
		private ISoftwareGroupRepository repository;
		public SoftwareGroupService( ISoftwareGroupRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
