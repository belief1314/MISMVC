using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misID")]
	public class MISID {
	   [Key]
		public int ID { get; set; }
		[ForeignKey("Project")]
		public int? ProjectID { get; set; }
		[MaxLength( 50 )]
		public String Environment { get; set; }
		[ForeignKey("Server")]
		public int? ServerID { get; set; }
		[MaxLength( 50 )]
		public String Name { get; set; }
		[MaxLength( 200 )]
		public String Description { get; set; }
		[MaxLength( 200 )]
		public String AccessRight { get; set; }
		[MaxLength( 50 )]
		public String Owner { get; set; }
		[MaxLength( 50 )]
		public String Status { get; set; }
		[MaxLength( 50 )]
		public String IsApplicationUsing { get; set; }
		[MaxLength( 4000 )]
		public String Remark { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType(DataType.DateTime)]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }

		public virtual Project Project { get; set; }
		public virtual Server Server { get; set; }
	}
}
