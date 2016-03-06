using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misCert")]
    public class Cert
    {
		[Key]
		public int ID { get; set; }
		[ForeignKey("Project")]
		public int? ProjectID { get; set; }
		[MaxLength( 50 )]
		public String Environment { get; set; }
		[MaxLength( 50 )]
		[Required]
		public String Name { get; set; }
		[MaxLength( 100 )]
		public String CertSerialNumber { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ValidityStartDate { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ExpirationDate { get; set; }
		[MaxLength( 50 )]
		public String CertType { get; set; }
		[MaxLength( 50 )]
		public String CrossCert { get; set; }
		[MaxLength( 50 )]
		public String CertStatus { get; set; }
		[ForeignKey("Server")]
		public int ServerID { get; set; }
		[MaxLength(4000)]
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
		public virtual Server Server { get; set; }
    }
}
