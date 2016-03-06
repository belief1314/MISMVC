using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class EmployeeService:BaseService<Employee>, IEmployeeService {
		private IEmployeeRepository repository;
		public EmployeeService( IEmployeeRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
