using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class VacationService:BaseService<Vacation>,IVacationService {
		private IVacationRepository repository;
		public VacationService( IVacationRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
