using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class InitiativeService:BaseService<Initiative>,IInitiativeService {
		private IInitiativeRepository repository;
		public InitiativeService( IInitiativeRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
