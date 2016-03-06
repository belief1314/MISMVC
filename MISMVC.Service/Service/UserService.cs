using MISMVC.DAO.Model;
using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MISMVC.Service.Service {
	public class UserService:BaseService<User>,IUserService {
		private IUserRepository repository;
		private MenuMenuItemService menuService;
		public UserService( IUserRepository repository, MenuMenuItemService menuService ) : base( repository ) {
			this.repository = repository;
			this.menuService = menuService;
		}

		public List<MenuMenuItem> GetUserMenu( User user ) {
			return menuService.Find( m => m.MenuID ==user.Role.MenuID , true , m => m.Sequency ).ToList(); 
		}
	}
}
