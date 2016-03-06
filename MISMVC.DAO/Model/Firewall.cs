using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misFirewall")]
	public class Firewall {
		[Key]
		public int ID { get; set; }
		[MaxLength( 50 )]
		public String Name { get; set; }
		public int? ProjectID { get; set; }
		[MaxLength( 20 )]
		public String Environment { get; set; }
		[MaxLength( 50 )]
		public String FirewallType { get; set; }
		[MaxLength( 2000 )]
		public String SourceIP { get; set; }
		[MaxLength( 2000 )]
		public String SourceHostname { get; set; }
		[MaxLength( 50 )]
		public String SourceServerLocation { get; set; }
		[MaxLength( 2000 )]
		public String DestinationIP { get; set; }
		[MaxLength( 2000 )]
		public String DestinationHostname { get; set; }
		[MaxLength( 50 )]
		public String DestinationLocation { get; set; }
		[MaxLength( 50 )]
		public String Protocal { get; set; }
		[MaxLength( 50 )]
		public String PortNumber { get; set; }
		[MaxLength( 50 )]
		public String Validity { get; set; }
		[MaxLength( 50 )]
		public String ExpiryYearMonth { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? LastRenewDate { get; set; }
		[MaxLength( 10 )]
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

		public virtual Project Project { get; set; }
	}
}
