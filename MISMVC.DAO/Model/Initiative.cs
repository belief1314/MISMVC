using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misInitiative")]
	public class Initiative {
		[Key]
		public int ID { get; set; }
		[ForeignKey("Project")]
		public int? ProjectID { get; set; }
		[MaxLength( 500 )]
		[DataType(DataType.MultilineText)]
		public String Description { get; set; }
		public Decimal? HLE { get; set; }
		[DataType(DataType.DateTime)]
		public DateTime? PlannedSRUR { get; set; }
		[DataType(DataType.DateTime)]
		public DateTime? PlannedPROD { get; set; }
		[MaxLength( 4000 )]
		[DataType(DataType.MultilineText)]
		public String Remark { get; set; }
		[MaxLength( 50 )]
		public String Status { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType(DataType.DateTime)]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType(DataType.MultilineText)]
		public DateTime? ModifyDate { get; set; }

		public virtual Project Project { get; set; }
	}
}
