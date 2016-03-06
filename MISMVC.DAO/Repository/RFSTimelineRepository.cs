using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class RFSTimelineRepository:BaseRepository<RFSTimeline>,IRFSTimelineRepository {
		private DbContext context;
		public RFSTimelineRepository(DbContext context ) : base(context ) {
			this.context = context;
		}
	}
}
