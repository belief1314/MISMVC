using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class ILCRepository:BaseRepository<ILC>, IILCRepository {
		private DbContext context;
		public ILCRepository( DbContext context ):base(context) {
			this.context = context;
		}
	}
}
