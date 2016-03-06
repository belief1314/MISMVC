using MISMVC.Web.Models;
using MISMVC.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MISMVC.Web.Controllers
{
    public class AccountController : Controller
    {
		private AccountService service;

		public AccountController(AccountService service ) {
			this.service = service;
		}
        // GET: Account
		[HttpGet]
        public ActionResult Login()
        {
			HttpCookie cookie1 = Response.Cookies["account"];
			HttpCookie cookie2 = Response.Cookies["pwd"];
			String userName = cookie1.Value;
			String password = cookie2.Value;
			if(!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty( password ) ) {
				AccountViewModel model = new AccountViewModel( );
				model.UserName = userName;
				model.Password = password;
				MessageModel message = new MessageModel( );
				service.Login( model , ref message );
				if( message.Status == "Success" ) {
					return RedirectToActionPermanent( "Index" , "Home" );
				} else {
					ViewBag.Error = message.Message;
					return View( );
				}
			}
			return View();
        }

		[HttpPost]
		public ActionResult Login( FormCollection collection ) {
			try {
				if( ModelState.IsValid ) {
					AccountViewModel model = new AccountViewModel( );
					TryUpdateModel( model , collection );
					MessageModel message = new MessageModel( );
					service.Login( model , ref message );
					if( message.Status == "Success" ) {
						if( model.RememberMe ) {
							HttpCookie cookie1 = new HttpCookie( "account" , model.UserName);
							HttpCookie cookie2 = new HttpCookie( "pwd" , model.Password );
							HttpContext.Response.Cookies.Add(cookie1);
							HttpContext.Response.Cookies.Add( cookie2 );
						}
						return RedirectToActionPermanent( "Index" , "Home" );
					} else {
						ViewBag.Error = message.Message;
						return View( );
					}
				}
			}catch(Exception ex ) {
				ViewBag.Error = ex.Message;
				return View( );
			}
			return View( );
		}

		[HttpGet]
		public ActionResult Logoff( ) {
			service.Logoff( );
			return RedirectToActionPermanent( "Login" );
		}

		public PartialViewResult Menu( ) {
			UserInformation userInfo = HttpContext.Session["userinformation"] as UserInformation;
			if( userInfo == null || userInfo.MenuItems==null || userInfo.MenuModules==null ) {
				return PartialView( );
			} else {
				return PartialView( userInfo );
			}
		}
    }
}