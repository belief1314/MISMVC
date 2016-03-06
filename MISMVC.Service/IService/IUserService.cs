using MISMVC.DAO.Model;
using System.Collections.Generic;

namespace MISMVC.Service.IService {
	public interface IUserService:IBaseService<User> {
		List<MenuMenuItem> GetUserMenu( User user );
	}
}
