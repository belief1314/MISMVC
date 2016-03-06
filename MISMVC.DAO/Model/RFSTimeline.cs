using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misRFSTimeline")]
	public class RFSTimeline {
		[Key]
		public int ID { get; set; }
		[ForeignKey("RFS")]
		public int? RFSID { get; set; }
		[DataType(DataType.DateTime)]
		public DateTime? RFSAssignment_Planned { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? RFSAssignment_Actual { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? RFSWorkAuthorization_Planned { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? RFSWorkAuthorization_Actual { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? DesignStart_Planned { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? DesignStart_Actual { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? DesignEnd_Planned { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? DesignEnd_Actual { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CodingStart_Planned { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CodingStart_Actual { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CodingEnd_Planned { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CodingEnd_Actual { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? UTStart_Planned { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? UTStart_Actual { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? UTEnd_Planned { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? UTEnd_Actual { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? SITStart_Planned { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? SITStart_Actual { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? SITEnd_Planned { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? SITEnd_Actual { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? UATStart_Planned { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? UATStart_Actual { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? UATEnd_Planned { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? UATEnd_Actual { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? UATSignoff_Planned { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? UATSignoff_Actual { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? PROD_Planned { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? PROD_Actual { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? RFSClourse_Planned { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? RFSClourse_Actual { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }

		public virtual RFS RFS { get; set; }
	}
}
