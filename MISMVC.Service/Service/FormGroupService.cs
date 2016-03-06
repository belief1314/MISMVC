using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class FormGroupService:BaseService<FormGroup>,IFormGroupService {
		private IFormGroupRepository repository;
		public FormGroupService( IFormGroupRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
