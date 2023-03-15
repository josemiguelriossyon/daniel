using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Testeando.AngularJS.Authorization.Users;
using Testeando.AngularJS.Editions;

namespace Testeando.AngularJS.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore
            ) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore
            )
        {
        }
    }
}