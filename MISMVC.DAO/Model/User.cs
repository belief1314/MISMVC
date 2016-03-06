using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misUser")]
	public class User {
		[Key]
		public int ID { get; set; }
		[MaxLength( 50 )]
		[Required]
		public String UserName { get; set; }
		[MaxLength( 50 )]
		[Required]
		[DataType(DataType.Password)]
		public String Password { get; set; }
		[ForeignKey("Employee")]
		[Required]
		public int EmployeeID { get; set; }
		[ForeignKey("Role")]
		[Required]
		public int RoleID { get; set; }
		[MaxLength( 200 )]
		[DataType( DataType.MultilineText )]
		public String Description { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }

		public virtual Employee Employee { get; set; }
		public virtual Role Role { get; set; }
	}
}
