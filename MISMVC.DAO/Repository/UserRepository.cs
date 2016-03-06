using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class UserRepository:BaseRepository<User>, IUserRepository {
		private DbContext context;
		public UserRepository( DbContext context ):base(context) {
			this.context = context;
		}
	}
}
