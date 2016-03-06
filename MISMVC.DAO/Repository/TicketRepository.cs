using MISMVC.DAO.IRepository;
using MISMVC.DAO.Model;
using System.Data.Entity;

namespace MISMVC.DAO.Repository {
	public class TicketRepository:BaseRepository<Ticket>, ITicketRepository {
		private DbContext context;
		public TicketRepository( DbContext context ):base(context) {
			this.context = context;
		}
	}
}
