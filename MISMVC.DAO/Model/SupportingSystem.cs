using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misSupportingSystem")]
	public class SupportingSystem {
		[Key]
		public int ID { get; set; }
		[MaxLength( 50 )]
		public String SystemRank { get; set; }
		[MaxLength( 50 )]
		public String SystemType { get; set; }
		[MaxLength( 50 )]
		public String SystemCode { get; set; }
		[MaxLength( 200 )]
		[DataType(DataType.MultilineText)]
		public String Description { get; set; }
		[MaxLength( 20 )]
		public String Status { get; set; }
		[ForeignKey("Employee")]
		public int? PrimarySupportEmployeeID { get; set; }
		//[ForeignKey( "Employee" )]
		public int? SecondarySupportingEmployeeID { get; set; }
		[MaxLength( 4000 )]
		[DataType( DataType.MultilineText )]
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
