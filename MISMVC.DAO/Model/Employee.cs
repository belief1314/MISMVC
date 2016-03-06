using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISMVC.DAO.Model {
	[Table("misEmployee")]
	public class Employee {
		[Key]
		public int ID { get; set; }
		[MaxLength( 50 )]
		[Required]
		public String SerialNo { get; set; }
		[MaxLength( 50 )]
		public String ENName { get; set; }
		[MaxLength( 50 )]
		public String CNName { get; set; }
		[MaxLength( 50 )]
		public String CNNamePY { get; set; }
		[MaxLength( 50 )]
		public String OfficeTelNo { get; set; }
		[MaxLength( 50 )]
		public String MobileNo { get; set; }
		[MaxLength( 50 )]
		[DataType(DataType.EmailAddress)]
		public String EmailAddress { get; set; }
		[DataType(DataType.DateTime)]
		public DateTime? OnBoardDate { get; set; }
		[MaxLength( 50 )]
		public String CSPFlag { get; set; }
		[MaxLength( 50 )]
		public String Superior { get; set; }
		[MaxLength( 50 )]
		public String Status { get; set; }
		[MaxLength( 4000 )]
		[DataType(DataType.MultilineText)]
		public String Remark { get; set; }
		[MaxLength( 50 )]
		[DataType( DataType.EmailAddress )]
		public String EmailAddress2 { get; set; }
		[MaxLength( 50 )]
		public String LPToHM_Number { get; set; }
		[MaxLength( 10 )]
		public String LPToHM_ExpiryStartDate { get; set; }
		[MaxLength( 10 )]
		public String LPToHM_ExpiryEndDate { get; set; }
		[MaxLength( 50 )]
		public String HKBizVISA_Status { get; set; }
		[MaxLength( 10 )]
		public String HKBizVISA_ExpiryStartDate { get; set; }
		[MaxLength( 10 )]
		public String HKBizVISA_ExpiryEndDate { get; set; }
		[ForeignKey("Team")]
		public int? TeamID { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }

		public virtual Team Team { get; set; }
	}
}
