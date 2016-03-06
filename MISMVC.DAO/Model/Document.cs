using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISMVC.DAO.Model {
	[Table("misDocument")]
	public class Document {
		[Key]
		public int ID { get;set; }
		[Required]
		[MaxLength(100)]
		public String FileOriginName { get; set; }
		[Required]
		[MaxLength( 100 )]
		public String FileGUIDName { get; set; }
		[Required]
		[MaxLength( 200 )]
		public String FileSavePath { get; set; }
		[MaxLength( 400 )]
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

		public virtual ICollection<DocumentGroup> DocumentGroups { get; set; }
	}
}
