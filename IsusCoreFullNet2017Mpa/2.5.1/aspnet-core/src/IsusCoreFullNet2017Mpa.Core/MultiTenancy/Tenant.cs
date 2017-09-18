using Abp.MultiTenancy;
using IsusCoreFullNet2017Mpa.Authorization.Users;

namespace IsusCoreFullNet2017Mpa.MultiTenancy
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