using OSPSuite.Core;
using OSPSuite.Core.Reporting;
using OSPSuite.Infrastructure.Services;
using OSPSuite.Utility.Container;

namespace OSPSuite.Infrastructure
{
   public class InfrastructureRegister : Register
   {
      public override void RegisterInContainer(IContainer container)
      {
         container.AddScanner(scan =>
         {
            scan.AssemblyContainingType<InfrastructureRegister>();
            scan.ExcludeType<ReportTemplateRepository>();

            scan.WithConvention(new OSPSuiteRegistrationConvention(registerConcreteType: true));
         });

         container.Register<IReportTemplateRepository, ReportTemplateRepository>(LifeStyle.Singleton);
      }
   }
}