using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class OrgnizationService:BaseService<Orgnization>,IOrgnizationService {
		private IOrgnizationRepository repository;
		public OrgnizationService( IOrgnizationRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
