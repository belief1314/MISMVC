using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class WeekRepository:BaseRepository<Week>,IWeekRepository {
		private DbContext context;
		public WeekRepository(DbContext context ):base(context) {
			this.context = context;
		}
	}
}
