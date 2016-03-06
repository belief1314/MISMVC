using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misEmployeeAssessment")]
	public class EmployeeAssessment {
		[Key]
		public int ID { get; set; }
		[ForeignKey("Employee")]
		public int EmployeeID { get; set; }
		[MaxLength( 50 )]
		public String AssessmentType { get; set; }
		[MaxLength( 2000 )]
		[DataType(DataType.MultilineText)]
		public String Description { get; set; }
		[MaxLength( 50 )]
		public String Status { get; set; }
		[MaxLength( 4000 )]
		[DataType(DataType.MultilineText)]
		public String Remark { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }

		public virtual Employee Employee { get; set; }
	}
}
