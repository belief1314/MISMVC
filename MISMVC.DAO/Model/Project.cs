using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misProject")]
	public class Project {
		[Key]
		public int ID { get; set; }
		[MaxLength( 50 )]
		public String ProjectCode { get; set; }

		[Required]
		[MaxLength( 50 )]
		public String Name { get; set; }
		[MaxLength( 400 )]
		[DataType(DataType.MultilineText)]
		public String Description { get; set; }
		[ForeignKey("DocumentGroup")]
		public int DocumentGroupID { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }	
		
		public virtual DocumentGroup DocumentGroup { get; set; } 
	}
}
