using MISMVC.DAO.Model;
using MISMVC.Infra;
using MISMVC.Service.IService;
using MISMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISMVC.Web.Services {
	public class AccountService {
		private IUserService service;
		public AccountService(IUserService service) {
			this.service = service;
		}

		public void Login(AccountViewModel model,ref MessageModel message ) {
			User user = service.Find( u => u.UserName == model.UserName );
			List<MenuMenuItem> menuItems = new List<MenuMenuItem>( );
			List<String> menuModules = new List<string>( );
			menuItems.Clear( );
			menuModules.Clear( );
			if( user == null ) {
				message.Message = "User Name not existed";
				message.Status = "Failed";
			} else if( user.Password.ToUpper( ) != Utilities.GetMD5( model.Password ) ) {
				message.Message = "Password is not correct";
				message.Status = "Failed";
			} else {
				message.Status="Success";
				UserInformation userInformation = new UserInformation( );
				menuItems = service.GetUserMenu(user);
				foreach(var item in menuItems ) {
					if( !menuModules.Contains( item.MenuItem.MenuModule.Name ) ) {
						menuModules.Add( item.MenuItem.MenuModule.Name );
					}
				}
				userInformation.MenuItems = menuItems;
				userInformation.UserName = user.UserName;
				userInformation.RoleID = user.RoleID;
				userInformation.MenuModules = menuModules;
				HttpContext.Current.Session["userinformation" ] = userInformation;
			}
		} 

		public void Logoff( ) {
			HttpContext.Current.Session.RemoveAll( );
		}
	}
}