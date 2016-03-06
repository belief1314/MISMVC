using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class SupportingContactRepository:BaseRepository<SupportingContact>, ISupportingContactRepository {
		private DbContext context;
		public SupportingContactRepository( DbContext context ):base(context) {
			this.context = context;
		}
	}
}
