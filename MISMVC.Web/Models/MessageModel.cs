using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISMVC.Web.Models {
	public class MessageModel {
		public String Code { get; set; }
		public String Status { get; set; }
		public String Message { get; set; }
		public String ControllerName { get; set; }
		public String ActionName { get; set; }
		public String FunctionName { get; set; }
		public String ViewName { get; set; }
	}
}