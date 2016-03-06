using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class DocumentGroupService:BaseService<DocumentGroup>,IDocumentGroupService {
		private IDocumentGroupRepository repository;
		public DocumentGroupService( IDocumentGroupRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
