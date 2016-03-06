using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misServer")]
	public class Server {
		[Key]
		public int ID { get; set; }
		[ForeignKey("Project")]
		public int ProjectID { get; set; }
		[MaxLength( 50 )]
		public String Environment { get; set; }
		[MaxLength( 50 )]
		public String Location { get; set; }
		[MaxLength( 50 )]
		public String OS { get; set; }
		[MaxLength( 50 )]
		public String HostName { get; set; }
		[MaxLength( 400 )]
		[DataType(DataType.MultilineText)]
		public String Description { get; set; }
		[MaxLength( 50 )]
		public String ServerIP { get; set; }
		[MaxLength( 50 )]
		public String PublicIP { get; set; }
		[MaxLength( 50 )]
		public String RebootFrequency { get; set; }
		[MaxLength( 50 )]
		public String RebootTime { get; set; }
		[MaxLength( 50 )]
		public String Status { get; set; }
		[ForeignKey("SoftwareGroup")]
		public int? SoftwareGroupID { get; set; }
		[MaxLength( 50 )]
		public String Is3RDParty { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }

		public virtual Project Project { get; set; }
		public virtual SoftwareGroup SoftwareGroup { get; set; }
	}
}
