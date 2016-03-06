using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class FirewallService:BaseService<Firewall>,IFirewallService {
		private IFirewallRepository repository;
		public FirewallService( IFirewallRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
