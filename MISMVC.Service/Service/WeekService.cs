using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class WeekService:BaseService<Week>,IWeekService {
		private IWeekRepository repository;
		public WeekService( IWeekRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
