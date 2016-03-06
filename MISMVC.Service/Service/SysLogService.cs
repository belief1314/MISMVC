using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class SysLogService:BaseService<SysLog>,ISysLogService {
		private ISysLogRepository repository;
		public SysLogService( ISysLogRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
