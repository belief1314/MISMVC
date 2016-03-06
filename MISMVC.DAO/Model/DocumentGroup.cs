using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISMVC.DAO.Model {
	[Table("misDocumentGroup")]
	public class DocumentGroup {
		[Key]
		public int ID { get; set; }
		[Required]
		[MaxLength( 50 )]
		public String Name { get; set; }
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

		public virtual ICollection<Document> Documents { get; set; }

		public DocumentGroup( ) {
			this.Documents = new List<Document>( );
		}
	}
}
