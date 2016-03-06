using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class RFSTimelineService:BaseService<RFSTimeline>,IRFSTimelineService {
		private IRFSTimelineRepository repository;
		public RFSTimelineService( IRFSTimelineRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
