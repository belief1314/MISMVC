using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misInterview")]
	public class Interview {
		[Key]
		public int ID { get; set; }
		[MaxLength( 50 )]
		public String CandidateName { get; set; }
		[MaxLength( 50 )]
		public String CandidateCNName { get; set; }
		[MaxLength( 20 )]
		[DataType(DataType.PhoneNumber)]
		public String CandidateMobileNumber { get; set; }
		[MaxLength( 50 )]
		public String Band { get; set; }
		[MaxLength( 50 )]
		public String Vendor { get; set; }
		[MaxLength( 50 )]
		public String VendorContact { get; set; }
		[MaxLength( 20 )]
		[DataType(DataType.PhoneNumber)]
		public String VendorPhone { get; set; }
		[MaxLength( 4000 )]
		[DataType(DataType.MultilineText)]
		public String Remark { get; set; }
		[MaxLength( 20 )]
		public String Status { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType(DataType.DateTime)]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType(DataType.DateTime)]
		public DateTime? ModifyDate { get; set; }
	}
}
