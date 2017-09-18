using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using IsusCore2017Spa.Authorization.Users;
using IsusCore2017Spa.Editions;

namespace IsusCore2017Spa.MultiTenancy
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