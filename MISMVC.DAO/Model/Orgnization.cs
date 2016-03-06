using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misOrgnization")]
	public class Orgnization {
		[Key]
		public int ID { get; set; }
		[ForeignKey("Employee")]
		[Required]
		public int EmployeeID { get; set; }
		[MaxLength( 100 )]
		public String Portfolio { get; set; }
		[MaxLength( 100 )]
		public String SubPortfolio { get; set; }
		[MaxLength( 100 )]
		public String ChildSubPortfolio { get; set; }
		[MaxLength( 50 )]
		public String PrimarySupportSys { get; set; }
		[MaxLength( 50 )]
		public String SecondarySupportSys { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType(DataType.DateTime)]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }

		public virtual Employee Employee { get; set; }
	}
}
