using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;

namespace MISMVC.Service.Service {
	public class TicketService:BaseService<Ticket>,ITicketService {
		private ITicketRepository repository;
		public TicketService( ITicketRepository repository ) : base( repository ) {
			this.repository = repository;
		}
	}
}
