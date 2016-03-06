using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misMenuItem")]
	public class MenuItem {
		[Key]
		public int ID { get; set; }
		[MaxLength( 50 )]
		public String Name { get; set; }
		[MaxLength( 200 )]
		[DataType(DataType.MultilineText)]
		public String Description { get; set; }
		[MaxLength( 500 )]
		public String URL { get; set; }
		[ForeignKey("MenuModule")]
		public int MenuModuleID { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }

		public virtual MenuModule MenuModule { get; set; }
	}
}
