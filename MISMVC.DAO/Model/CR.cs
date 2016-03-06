using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISMVC.DAO.Model {
	[Table("misCR")]
	public class CR {
		[Key]
		public int ID { get; set; }
		[ForeignKey("Project")]
		public int? ProjectID { get; set; }
		[MaxLength( 20 )]
		public String CRNo { get; set; }
		[MaxLength( 50 )]
		public String CRType { get; set; }
		[MaxLength( 500 )]
		[DataType(DataType.MultilineText)]
		public String Description { get; set; }
		[ForeignKey("RFS")]
		public int ? RFSID { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? LaunchDate { get; set; }
		[MaxLength( 50 )]
		public String Requestor { get; set; }
		[MaxLength( 50 )]
		public String Status { get; set; }
		[MaxLength( 4000 )]
		[DataType(DataType.MultilineText)]
		public String Remark { get; set; }
		[ForeignKey("Ticket")]
		public int? TicketID { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }

		public virtual Project Project { get; set; }
		public virtual RFS RFS { get; set; }
		public virtual Ticket Ticket { get; set; }
	}
}
