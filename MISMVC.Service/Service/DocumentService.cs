using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class DocumentService:BaseService<Document>,IDocumentService {
		private IDocumentRepository repository;
		public DocumentService( IDocumentRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
