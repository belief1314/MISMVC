using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class SupportingSystemService:BaseService<SupportingSystem>,ISupportingSystemService {
		private ISupportingSystemRepository repository;
		public SupportingSystemService( ISupportingSystemRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
