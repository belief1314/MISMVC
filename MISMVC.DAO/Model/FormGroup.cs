using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misFormGroup")]
	public class FormGroup {
		[Key]
		public int ID { get; set; }
		[ForeignKey("Project")]
		public int? ProjectID { get; set; }
		[MaxLength( 50 )]
		public String Environment { get; set; }
		[MaxLength( 200 )]
		public String FormName { get; set; }
		[MaxLength( 2000 )]
		public String FormsInventory { get; set; }
		[MaxLength( 200 )]
		public String FormsSupportingBrowser { get; set; }
		[MaxLength( 4000 )]
		public String FormsURL { get; set; }
		[MaxLength( 2000 )]
		public String GroupFunctionName { get; set; }
		[MaxLength( 2000 )]
		public String GroupName { get; set; }
		[MaxLength( 200 )]
		public String GroupID { get; set; }
		[MaxLength( 200 )]
		public String GroupSupportingBrowser { get; set; }
		[MaxLength( 2000 )]
		public String GroupFunctionInventory { get; set; }
		[MaxLength( 4000 )]
		public String GroupURL { get; set; }
		[MaxLength( 4000 )]
		[DataType(DataType.MultilineText)]
		public String Remark { get; set; }
		[MaxLength( 10 )]
		public String OrderSeq { get; set; }
		[MaxLength( 100 )]
		public String InterfaceSystem { get; set; }
		[ForeignKey("Server")]
		public int? ServerID { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType( DataType.DateTime )]
		public DateTime? ModifyDate { get; set; }


		public virtual Project Project { get; set; }
		public virtual Server Server { get; set; }
	}
}
