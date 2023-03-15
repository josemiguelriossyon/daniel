using Testeando.AngularJS.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Testeando.AngularJS.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly AngularJSDbContext _context;

        public InitialHostDbBuilder(AngularJSDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
