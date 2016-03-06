using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class CertService:BaseService<Cert>,ICertService {
		private ICertRepository repository;
		public CertService( ICertRepository repository ):base(repository){
			this.repository = repository;
		}
	}
}
