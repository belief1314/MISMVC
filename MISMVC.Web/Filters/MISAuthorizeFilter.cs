using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MISMVC.Web.Filters {
	public class MISAuthorizeFilter :ActionFilterAttribute, IActionFilter {
		public override void OnActionExecuted( ActionExecutedContext filterContext ) {
			throw new NotImplementedException( );
		}

		public override void OnActionExecuting( ActionExecutingContext filterContext ) {
			throw new NotImplementedException( );
		}
	}
}