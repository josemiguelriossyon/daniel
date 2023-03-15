using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Testeando.AngularJS.EntityFramework;

namespace Testeando.AngularJS.Migrator
{
    [DependsOn(typeof(AngularJSDataModule))]
    public class AngularJSMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AngularJSDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}