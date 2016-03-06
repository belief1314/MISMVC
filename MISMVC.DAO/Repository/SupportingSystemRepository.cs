using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class SupportingSystemRepository:BaseRepository<SupportingSystem>, ISupportingSystemRepository {
		private DbContext context;
		public SupportingSystemRepository( DbContext context ):base(context) {
			this.context = context;
		}
	}
}
