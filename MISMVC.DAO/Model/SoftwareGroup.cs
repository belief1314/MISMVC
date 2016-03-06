using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misSoftwareGroup")]
	public class SoftwareGroup {
		[Key]
		public int ID { get; set; }
		[MaxLength( 50 )]
		public String Name { get; set; }
		[MaxLength( 50 )]
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

		public virtual ICollection<Software> Softwares { get; set; }

		public SoftwareGroup( ) {
			this.Softwares = new List<Software>( );
		}
	}
}
