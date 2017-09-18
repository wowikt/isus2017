using Abp.MultiTenancy;
using IsusCore2017Spa.Authorization.Users;

namespace IsusCore2017Spa.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}