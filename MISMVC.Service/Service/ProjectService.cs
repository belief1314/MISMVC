using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class ProjectService:BaseService<Project>,IProjectService {
		private IProjectRepository repository;
		public ProjectService( IProjectRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
