using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class InterviewService:BaseService<Interview>,IInterviewService {
		private IInterviewRepository repository;
		public InterviewService( IInterviewRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
