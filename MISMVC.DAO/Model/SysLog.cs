using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misSysLog")]
	public class SysLog {
		[Key]
		public int ID { get; set; }
		[MaxLength( 50 )]
		public String UserOperationKey { get; set; }
		[ForeignKey("User")]
		public int? UserID { get; set; }
		[MaxLength( 1 )]
		public String Type { get; set; }
		[MaxLength( 2 )]
		public String Action { get; set; }
		[MaxLength( 50 )]
		public String ControlID { get; set; }
		[MaxLength( 50 )]
		public String ControlText { get; set; }
		[MaxLength( 1000 )]
		[DataType( DataType.MultilineText )]
		public String Details { get; set; }
		[MaxLength( 1000 )]
		public String Result { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? OccurredTime { get; set; }
		[MaxLength( 50 )]
		public String PageID { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }


		public virtual User User { get; set; }
	}
}
