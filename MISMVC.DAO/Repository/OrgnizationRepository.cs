using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class OrgnizationRepository:BaseRepository<Orgnization>, IOrgnizationRepository {
		private DbContext context;
		public OrgnizationRepository( DbContext context ) : base(context ) {
			this.context = context;
		}
	}
}
