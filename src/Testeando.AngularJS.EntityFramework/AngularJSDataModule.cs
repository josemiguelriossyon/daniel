using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Testeando.AngularJS.EntityFramework;

namespace Testeando.AngularJS
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(AngularJSCoreModule))]
    public class AngularJSDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AngularJSDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
