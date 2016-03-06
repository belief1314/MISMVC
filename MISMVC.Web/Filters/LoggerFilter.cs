using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MISMVC.Web.Filters {
	public class LoggerFilter:ActionFilterAttribute,IActionFilter {
		public override void OnActionExecuting( ActionExecutingContext filterContext ) {
			base.OnActionExecuting( filterContext );
		}
		public override void OnActionExecuted( ActionExecutedContext filterContext ) {
			base.OnActionExecuted( filterContext );
		}
	}
}