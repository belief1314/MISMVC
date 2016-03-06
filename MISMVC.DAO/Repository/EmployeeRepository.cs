using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class EmployeeRepository:BaseRepository<Employee>, IEmployeeRepository {
		private DbContext context;
		public EmployeeRepository( DbContext context ):base(context) {
			this.context = context;
		}
	}
}
