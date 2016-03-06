using MISMVC.DAO.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MISMVC.Infra;

namespace MISMVC.Web.Models {
	public class MISMVCInitializer: DropCreateDatabaseIfModelChanges<MISContext> {
		public override void InitializeDatabase( MISContext context ) {
			base.InitializeDatabase( context );

			var employee = new Employee {
				SerialNo = "00000001" ,
				ENName = "Admin" ,
				CNName = "Admin" ,
				CNNamePY = "Admin" ,
				CreateDate = DateTime.Now ,
				Creator = "Admin"
			};
			context.Employees.Add( employee );

			var role = new Role {
				Name = "Admin" ,
				CreateDate = DateTime.Now ,
				Creator = "Admin"
			};
			context.Roles.Add( role );

			var user = new User {
				UserName = "Admin" ,
				Password = Utilities.GetMD5( "Admin" ) ,
				EmployeeID = 1 ,
				RoleID = 1 ,
				CreateDate = DateTime.Now ,
				Creator = "Admin"
			};
			context.Users.Add( user );

			context.SaveChanges( );
		}
	}
}