using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misILC")]
	public class ILC {
		[Key]
		public int ID { get; set; }
		[ForeignKey("RFS")]
		public int? RFSID { get; set; }
		[MaxLength(50)]
		public String SRURNo { get; set; }
		[MaxLength( 500 )]
		[DataType(DataType.MultilineText)]
		public String Description { get; set; }
		[MaxLength( 20 )]
		public String ClaimedWICode { get; set; }
		public Decimal? ClaimedWIHours { get; set; }
		[MaxLength( 20 )]
		public String ClainedWeek { get; set; }
		[ForeignKey("Employee")]
		public int? EmployeeID { get; set; }
		[MaxLength( 20 )]
		public String Role { get; set; }
		public Decimal? IBMHourylRate { get; set; }
		public Decimal? DBSHourlyRate { get; set; }
		[MaxLength( 20 )]
		public String EffectivePeriod { get; set; }
		public Decimal? IBMTotalCost { get; set; }
		public Decimal? DBSTotalCost { get; set; }
		[MaxLength( 20 )]
		public String HourType { get; set; }
		[MaxLength( 4000 )]
		[DataType(DataType.MultilineText)]
		public String Remark { get; set; }
		[ForeignKey("Vacation")]
		public int? VacationID { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }

		public virtual RFS RFS { get; set; }
		public virtual Employee Employee { get; set; }
		public virtual Vacation Vacation { get; set; }
	}
}
