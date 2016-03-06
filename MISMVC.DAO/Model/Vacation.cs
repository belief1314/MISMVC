using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misVacation")]
	public class Vacation {
		[Key]
		public int ID { get; set; }
		[ForeignKey("Employee")]
		[Required]
		public int EmployeeID { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? PlannedVacationFromDate { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? PlannedVacationToDate { get; set; }
		[MaxLength( 30 )]
		public String VacationType { get; set; }
		[MaxLength( 30 )]
		public String PlannedWeek { get; set; }
		[MaxLength( 20 )]
		public String Status { get; set; }
		[MaxLength( 4000 )]
		[DataType( DataType.MultilineText )]
		public String Remark { get; set; }
		public int? Hours { get; set; }
		[ForeignKey("RFS")]
		public int? RFSID { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }

		public virtual Employee Employee { get; set; }
		public virtual RFS RFS { get; set; }
	}
}
