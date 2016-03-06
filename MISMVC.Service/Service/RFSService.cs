using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class RFSService:BaseService<RFS>,IRFSService {
		private IRFSRepository repository;
		public RFSService( IRFSRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
