using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MISMVC.Web.Filters {
	public class ExceptionFilter :IExceptionFilter {
		public void OnException( ExceptionContext filterContext ) {
			throw new NotImplementedException( );
		}
	}
}