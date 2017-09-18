using Abp.MultiTenancy;
using IsusCore2017Mpa.Authorization.Users;

namespace IsusCore2017Mpa.MultiTenancy
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