using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class InterviewRepository:BaseRepository<Interview>, IInterviewRepository {
		private DbContext context;
		public InterviewRepository( DbContext context ):base(context) {
			this.context = context;
		}
	}
}
