using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class DocumentGroupRepository:BaseRepository<DocumentGroup>,IDocumentGroupRepository {
		private DbContext context;
		public DocumentGroupRepository(DbContext context ) :base(context){
			this.context = context;
		}
	}
}
