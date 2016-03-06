using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misMenu")]
	public class Menu {
		[Key]
		public int ID { get; set; }
		[MaxLength( 50 )]
		public String Name { get; set; }
		[MaxLength( 200 )]
		[DataType(DataType.MultilineText)]
		public String Description { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }

		public virtual ICollection<MenuMenuItem> MenuMenuItems { get; set; }
	}
}
