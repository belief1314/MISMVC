using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class ProjectRepository:BaseRepository<Project>,IProjectRepository {
		private DbContext context;
		public ProjectRepository(DbContext context ) : base(context ) {
			this.context = context;
		}
	}
}
