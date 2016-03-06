using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misMenuModule")]
	public class MenuModule {
		[Key]
		public int ID { get; set; }
		[MaxLength( 50 )]
		public String Name { get; set; }
		[MaxLength( 200 )]
		[DataType(DataType.MultilineText)]
		public String Description { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType( DataType.MultilineText )]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.MultilineText )]
		public DateTime? ModifyDate { get; set; }

		public virtual ICollection<MenuItem> MenuItems { get; set; }
	}
}
