using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISMVC.DAO.Model {
	[Table("misModuel")]
	public class MISModule {
		[Key]
		public int ID { get; set; }
		[ForeignKey("Project")]
		public int? ProjectID { get; set; }
		[MaxLength( 50 )]
		public String Environment { get; set; }
		[ForeignKey("Server")]
		public int? ServerID { get; set; }
		[MaxLength( 200 )]
		public String ModuleName { get; set; }
		[MaxLength( 400 )]
		public String ModulePath { get; set; }
		[MaxLength( 50 )]
		public String ModuleType { get; set; }
		[MaxLength( 100 )]
		public String Rundown { get; set; }
		[MaxLength( 50 )]
		public String RunAsProfileID { get; set; }
		[MaxLength( 50 )]
		public String Flow { get; set; }
		//[ForeignKey("Project")]
		public int? FromProjectID { get; set; }
		//[ForeignKey("Server")]
		public int? FromServerID { get; set; }
		//[ForeignKey( "Project" )]
		public int? ToProjectID { get; set; }
		//[ForeignKey("Server")]
		public int? ToServerID { get; set; }
		[MaxLength( 50 )]
		public String RunAsSSHID { get; set; }
		[MaxLength( 500 )]
		public String SSKeyPath { get; set; }
		[MaxLength( 500 )]
		public String InterfaceFileName { get; set; }
		[MaxLength( 50 )]
		public String Status { get; set; }
		[MaxLength( 4000 )]
		[DataType(DataType.MultilineText)]
		public String Remark { get; set; }

		[MaxLength( 50 )]
		public String Creator { get; set; }
		[DataType(DataType.DateTime)]
		public DateTime? CreateDate { get; set; }
		[MaxLength( 50 )]
		public String Modifier { get; set; }
		[DataType(DataType.DateTime)]
		public DateTime? ModifyDate { get; set; }

		public virtual Project Project { get; set; }
		public virtual Server Server { get; set; }
	}
}
