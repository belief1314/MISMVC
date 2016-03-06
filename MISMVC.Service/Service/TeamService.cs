using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class TeamService:BaseService<Team>,ITeamService {
		private ITeamRepository repository;
		public TeamService( ITeamRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
