using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class TeamRepository:BaseRepository<Team>, ITeamRepository {
		private DbContext context;
		public TeamRepository( DbContext context ):base(context) {
			this.context = context;
		}
	}
}
