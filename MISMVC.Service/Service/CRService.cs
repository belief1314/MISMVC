using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class CRService:BaseService<CR>,ICRService {
		private ICRRepository repository;
		public CRService( ICRRepository repository ):base(repository){
			this.repository = repository;
		}
	}
}
