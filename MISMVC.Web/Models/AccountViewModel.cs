using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MISMVC.Web.Models {
	[Serializable]
	public class AccountViewModel {
		[MaxLength(50)]
		[Required]
		public String UserName { get; set; }
		[MaxLength(40)]
		[Required]
		[DataType(DataType.Password)]
		public String Password { get; set; }
		public Boolean RememberMe { get; set; }
	}
}