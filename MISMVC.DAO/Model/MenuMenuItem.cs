using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misMenuMenuItem")]
	public class MenuMenuItem {
		[Key]
		public int ID { get; set; }
		[ForeignKey("Menu")]
		[Required]
		public int MenuID { get; set; }
		[ForeignKey( "MenuItem" )]
		[Required]
		public int MenuItemID { get; set; }
		[MaxLength( 50 )]
		public String Access { get; set; }
		public int? Sequency { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType(DataType.MultilineText)]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.MultilineText )]
		public DateTime? ModifyDate { get; set; }


		public virtual Menu Menu { get; set; }
		public virtual MenuItem MenuItem { get; set; }
	}
}
