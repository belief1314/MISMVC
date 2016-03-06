using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class EmployeeAssessmentService:BaseService<EmployeeAssessment>, IEmployeeAssessmentService {
		private IEmployeeAssessmentRepository repository;
		public EmployeeAssessmentService( IEmployeeAssessmentRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
