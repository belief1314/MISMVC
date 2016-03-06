using MISMVC.DAO.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MISMVC.Web.Models {
	public class MISContext : DbContext {

		public DbSet<Cert> Certs { get; set; }
		public DbSet<CR> CRs { get; set; }
		public DbSet<Document> Documents { get; set; }
		public DbSet<DocumentGroup> DocumentGroups { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<EmployeeAssessment>EmployeeAssessments { get; set; }
		public DbSet<Firewall> Firewalls { get; set; }
		public DbSet<FormGroup> FormGroups { get; set; }
		public DbSet<ILC> ILCs { get; set; }
		public DbSet<Initiative> Initiatives { get; set; }
		public DbSet<Interview> Interviews { get; set; }
		public DbSet<Menu> Menus { get; set; }
		public DbSet<MenuItem> MenuItems { get; set; }
		public DbSet<MenuMenuItem> MenuMenuitems { get; set; }
		public DbSet<MenuModule> MenuModules { get; set; }
		public DbSet<MISID> MISIDs { get; set; }
		public DbSet<MISModule> MISModules { get; set; }
		public DbSet<Orgnization> Orgnizations { get; set; }
		public DbSet<Project> Projects { get; set; }
		public DbSet<RFS> RFSs { get; set; }
		public DbSet<RFSTimeline> RFSTimelines { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<Server> Servers { get; set; }
		public DbSet<Software> Softwares { get; set; }
		public DbSet<SoftwareGroup> SoftwareGroups { get; set; }
		public DbSet<SupportingContact> SupportingContacts { get; set; }
		public DbSet<SupportingSystem> SupportingSystems { get; set; }
		public DbSet<SysLog> SysLogs { get; set; }
		public DbSet<Team> Teams { get; set; }
		public DbSet<Ticket> Tickets { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Vacation> Vacations { get; set; }
		public DbSet<Week> Weeks { get; set; }

		public MISContext( ) : base( "MISConnection" ) { }

		protected override void OnModelCreating( DbModelBuilder modelBuilder ) {
			base.OnModelCreating( modelBuilder );
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>( );
			Database.SetInitializer<MISContext>( new MISMVCInitializer( ) );
		}
	}
}