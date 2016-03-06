using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class ServerRepository:BaseRepository<Server>,IServerRepository {
		private DbContext context;
		public ServerRepository(DbContext context ) : base(context ) {
			this.context = context;
		}
	}
}
