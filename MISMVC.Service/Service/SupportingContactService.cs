using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class SupportingContactService:BaseService<SupportingContact>,ISupportingContactService {
		private ISupportingContactRepository repository;
		public SupportingContactService( ISupportingContactRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
