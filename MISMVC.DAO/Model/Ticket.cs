using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misTicket")]
	public class Ticket {
		[Key]
		public int ID { get; set; }
		[ForeignKey("Project")]
		[Required]
		public int ProjectID { get; set; }
		[MaxLength( 50 )]
		[Required]
		public String TicketNo { get; set; }
		[MaxLength( 500 )]
		[DataType(DataType.MultilineText)]
		public String Description { get; set; }
		[MaxLength( 50 )]
		public String TicketType { get; set; }
		[MaxLength( 50 )]
		public String Status { get; set; }
		[MaxLength(4000)]
		[DataType( DataType.MultilineText )]
		public String Remark { get; set; }
		[ForeignKey("Employee")]
		public int? EmployeeID { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }


		public virtual Project Project { get; set; }
		public virtual Employee Employee { get; set; }
	}
}
