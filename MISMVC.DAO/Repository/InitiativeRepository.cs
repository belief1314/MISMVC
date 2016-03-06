using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class InitiativeRepository:BaseRepository<Initiative>, IInitiativeRepository {
		private DbContext context;
		public InitiativeRepository( DbContext context ):base(context) {
			this.context = context;
		}
	}
}
