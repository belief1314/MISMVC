using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class FirewallRepository:BaseRepository<Firewall>, IFirewallRepository {
		private DbContext context;
		public FirewallRepository( DbContext context ):base(context) {
			this.context = context;
		}
	}
}
