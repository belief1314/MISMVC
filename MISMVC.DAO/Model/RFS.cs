using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misRFS")]
	public class RFS {
		[Key]
		public int ID { get; set; }
		[MaxLength( 20 )]
		public String RFSType { get; set; }
		[MaxLength( 100)]
		public String SRURNo { get; set; }
		[MaxLength( 500 )]
		[DataType(DataType.MultilineText)]
		public String Description { get; set; }
		[ForeignKey("Project")]
		public int? ProjectID { get; set; }
		[MaxLength( 50 )]
		public String OwnerSerialNo { get; set; }
		public Decimal? PlannedHours { get; set; }
		public Decimal? PlannedBugget { get; set; }
		public Decimal? ActualClaimedHours { get; set; }
		public Decimal? ActualClaimedBuget { get; set; }
		[MaxLength( 100 )]
		public String OnshoreWI { get; set; }
		[MaxLength( 100 )]
		public String OffshoreWI { get; set; }
		[MaxLength( 50 )]
		public String WIPlannedStart { get; set; }
		[MaxLength( 50 )]
		public String WIPlannedEnd { get; set; }
		[MaxLength( 50 )]
		public String CurrentSDL { get; set; }
		[MaxLength( 50 )]
		public String Status { get; set; }
		[MaxLength(4000)]
		public String Remark { get; set; }
		public int? InitiativeID { get; set; }
		[MaxLength( 50 )]
		public String PTSID { get; set; }
		[DataType( DataType.DateTime)]
		public DateTime? PTSIDExpiredDate { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }

		public virtual Project Project { get; set; }
	}
}
