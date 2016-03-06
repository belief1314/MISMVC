using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class VacationRepository:BaseRepository<Vacation>,IVacationRepository {
		private DbContext context;
		public VacationRepository(DbContext context ):base(context) {
			this.context = context;
		}
	}
}
