using Abp.MultiTenancy;
using Isus2017Spa.Authorization.Users;

namespace Isus2017Spa.MultiTenancy
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