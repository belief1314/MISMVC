using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class EmployeeAssessmentRepository:BaseRepository<EmployeeAssessment>, IEmployeeAssessmentRepository {
		private DbContext context;
		public EmployeeAssessmentRepository( DbContext context ):base(context) {
			this.context = context;
		}
	}
}
