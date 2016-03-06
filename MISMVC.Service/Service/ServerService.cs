using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class ServerService:BaseService<Server>,IServerService {
		private IServerRepository repository;
		public ServerService( IServerRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
