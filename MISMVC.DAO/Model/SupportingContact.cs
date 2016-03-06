using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misSupportingContact")]
	public class SupportingContact {
		[Key]
		public int ID { get; set; }
		[MaxLength( 50 )]
		public String Name { get; set; }
		[MaxLength( 100 )]
		public String Company { get; set; }
		[MaxLength( 50 )]
		public String Department { get; set; }
		[MaxLength( 100 )]
		public String SupportArea { get; set; }
		[MaxLength( 200 )]
		public String SupportAppCode { get; set; }
		[MaxLength( 50 )]
		public String SupportRank { get; set; }
		[MaxLength( 50 )]
		[DataType(DataType.PhoneNumber)]
		public String OfficePhone { get; set; }
		[MaxLength( 50 )]
		[DataType(DataType.PhoneNumber)]
		public String CellPhone { get; set; }
		[MaxLength( 100 )]
		[DataType(DataType.EmailAddress)]
		public String LotusIDAddress { get; set; }
		[MaxLength( 100 )]
		[DataType( DataType.EmailAddress )]
		public String Email1 { get; set; }
		[MaxLength( 100 )]
		[DataType( DataType.EmailAddress )]
		public String Email2 { get; set; }
		[MaxLength( 50 )]
		public String Manager { get; set; }
		[MaxLength( 100 )]
		public String Location { get; set; }
		[MaxLength( 4000 )]
		[DataType(DataType.MultilineText)]
		public String Remark { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType(DataType.DateTime)]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }
	}
}
