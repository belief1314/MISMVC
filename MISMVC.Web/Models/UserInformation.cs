using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MISMVC.DAO.Model;

namespace MISMVC.Web.Models {

	[Serializable]
	public class UserInformation {
		public String UserName { get; set; }
		public int RoleID { get; set; }
		public List<MenuMenuItem> MenuItems { get; set; }
		public List<String> MenuModules { get; set; }
	}
}