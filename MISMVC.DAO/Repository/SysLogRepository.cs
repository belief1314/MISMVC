using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class SysLogRepository:BaseRepository<SysLog>, ISysLogRepository {
		private DbContext context;
		public SysLogRepository( DbContext context ):base(context) {
			this.context = context;
		}
	}
}
