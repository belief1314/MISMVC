using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class MISIDService:BaseService<MISID>,IMISIDService {
		private IMISIDRepository repository;
		public MISIDService( IMISIDRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
