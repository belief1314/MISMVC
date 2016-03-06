using MISMVC.DAO.IRepository;
using MISMVC.Service.IService;
using MISMVC.DAO.Repository;
using MISMVC.Service.Service;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Mvc;

namespace MISMVC.Web.Models {
	public class NinjectDependencyResolver : IDependencyResolver {

		private IKernel kernel;

		public NinjectDependencyResolver(IKernel kernel ) {
			this.kernel = kernel;
			AddBindings( );
		}

		public object GetService( Type serviceType ) {
			return kernel.TryGet( serviceType );
		}

		public IEnumerable<object> GetServices( Type serviceType ) {
			return kernel.GetAll( serviceType );
		}

		public void AddBindings( ) {
			kernel.Bind<ICertService>( ).To<CertService>( );
			kernel.Bind<ICRService>( ).To<CRService>( );
			kernel.Bind<IDocumentGroupService>( ).To<DocumentGroupService>( );
			kernel.Bind<IDocumentService>( ).To<DocumentService>( );
			kernel.Bind<IEmployeeService>( ).To<EmployeeService>( );
			kernel.Bind<IEmployeeAssessmentService>( ).To<EmployeeAssessmentService>( );
			kernel.Bind<IFirewallService>( ).To<FirewallService>( );
			kernel.Bind<IFormGroupService>( ).To<FormGroupService>( );
			kernel.Bind<IILCService>( ).To<ILCService>( );
			kernel.Bind<InitiativeService>( ).To<InitiativeService>( );
			kernel.Bind<IInterviewService>( ).To<InterviewService>( );
			kernel.Bind<IMenuService>( ).To<MenuService>( );
			kernel.Bind<IMenuItemService>( ).To<MenuItemService>( );
			kernel.Bind<IMenuModuleService>( ).To<MenuModuleService>( );
			kernel.Bind<IMenuMenuItemService>( ).To<MenuMenuItemService>( );
			kernel.Bind<IMISIDService>( ).To<MISIDService>( );
			kernel.Bind<IMISModuleService>( ).To<MISModuleService>( );
			kernel.Bind<IOrgnizationService>( ).To<OrgnizationService>( );
			kernel.Bind<IProjectService>( ).To<ProjectService>( );
			kernel.Bind<IRFSService>( ).To<RFSService>( );
			kernel.Bind<IRFSTimelineService>( ).To<RFSTimelineService>( );
			kernel.Bind<IRoleService>( ).To<RoleService>( );
			kernel.Bind<IServerService>( ).To<ServerService>( );
			kernel.Bind<ISoftwareService>( ).To<SoftwareService>( );
			kernel.Bind<ISoftwareGroupService>( ).To<SoftwareGroupService>( );
			kernel.Bind<ISupportingContactService>( ).To<SupportingContactService>( );
			kernel.Bind<ISupportingSystemService>( ).To<SupportingSystemService>( );
			kernel.Bind<ISysLogService>( ).To<SysLogService>( );
			kernel.Bind<ITeamService>( ).To<TeamService>( );
			kernel.Bind<ITicketService>( ).To<TicketService>( );
			kernel.Bind<IUserService>( ).To<UserService>( );
			kernel.Bind<IVacationService>( ).To<VacationService>( );
			kernel.Bind<IWeekService>( ).To<WeekService>( );

			kernel.Bind<ICertRepository>( ).To<CertRepository>( );
			kernel.Bind<ICRRepository>( ).To<CRRepository>( );
			kernel.Bind<IDocumentGroupRepository>( ).To<DocumentGroupRepository>( );
			kernel.Bind<IDocumentRepository>( ).To<DocumentRepository>( );
			kernel.Bind<IEmployeeRepository>( ).To<EmployeeRepository>( );
			kernel.Bind<IEmployeeAssessmentRepository>( ).To<EmployeeAssessmentRepository>( );
			kernel.Bind<IFirewallRepository>( ).To<FirewallRepository>( );
			kernel.Bind<IFormGroupRepository>( ).To<FormGroupRepository>( );
			kernel.Bind<IILCRepository>( ).To<ILCRepository>( );
			kernel.Bind<InitiativeRepository>( ).To<InitiativeRepository>( );
			kernel.Bind<IInterviewRepository>( ).To<InterviewRepository>( );
			kernel.Bind<IMenuRepository>( ).To<MenuRepository>( );
			kernel.Bind<IMenuItemRepository>( ).To<MenuItemRepository>( );
			kernel.Bind<IMenuModuleRepository>( ).To<MenuModuleRepository>( );
			kernel.Bind<IMenuMenuItemRepository>( ).To<MenuMenuItemRepository>( );
			kernel.Bind<IMISIDRepository>( ).To<MISIDRepository>( );
			kernel.Bind<IMISModuleRepository>( ).To<MISModuleRepository>( );
			kernel.Bind<IOrgnizationRepository>( ).To<OrgnizationRepository>( );
			kernel.Bind<IProjectRepository>( ).To<ProjectRepository>( );
			kernel.Bind<IRFSRepository>( ).To<RFSRepository>( );
			kernel.Bind<IRFSTimelineRepository>( ).To<RFSTimelineRepository>( );
			kernel.Bind<IRoleRepository>( ).To<RoleRepository>( );
			kernel.Bind<IServerRepository>( ).To<ServerRepository>( );
			kernel.Bind<ISoftwareRepository>( ).To<SoftwareRepository>( );
			kernel.Bind<ISoftwareGroupRepository>( ).To<SoftwareGroupRepository>( );
			kernel.Bind<ISupportingContactRepository>( ).To<SupportingContactRepository>( );
			kernel.Bind<ISupportingSystemRepository>( ).To<SupportingSystemRepository>( );
			kernel.Bind<ISysLogRepository>( ).To<SysLogRepository>( );
			kernel.Bind<ITeamRepository>( ).To<TeamRepository>( );
			kernel.Bind<ITicketRepository>( ).To<TicketRepository>( );
			kernel.Bind<IUserRepository>( ).To<UserRepository>( );
			kernel.Bind<IVacationRepository>( ).To<VacationRepository>( );
			kernel.Bind<IWeekRepository>( ).To<WeekRepository>( );

			kernel.Bind<DbContext>( ).To<MISContext>( );
		}
	}
}