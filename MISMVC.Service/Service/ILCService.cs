using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class ILCService:BaseService<ILC>,IILCService {
		private IILCRepository repository;
		public ILCService( IILCRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
