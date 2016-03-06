using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class CertRepository:BaseRepository<Cert>,ICertRepository {
		private DbContext context;
		public CertRepository(DbContext context ):base(context) {
			this.context = context;
		}
	}
}
