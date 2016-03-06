using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class RFSRepository:BaseRepository<RFS>,IRFSRepository {
		private DbContext context;
		public RFSRepository(DbContext context ) : base(context ) {
			this.context = context;
		}
	}
}
