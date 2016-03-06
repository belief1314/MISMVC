using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class DocumentRepository:BaseRepository<Document>,IDocumentRepository {
		private DbContext context;
		public DocumentRepository(DbContext context ) : base(context ) {
			this.context = context;
		}
	}
}
