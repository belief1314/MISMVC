using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class FormGroupRepository:BaseRepository<FormGroup>, IFormGroupRepository {
		private DbContext context;
		public FormGroupRepository( DbContext context ):base(context) {
			this.context = context;
		}
	}
}
