using Abp.MultiTenancy;
using Isus2017CoreSpa.Authorization.Users;

namespace Isus2017CoreSpa.MultiTenancy
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