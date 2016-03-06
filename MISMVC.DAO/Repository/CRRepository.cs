using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class CRRepository:BaseRepository<CR>,ICRRepository {
		private DbContext context;
		public CRRepository(DbContext context ):base(context) {
			this.context = context;
		}
	}
}
