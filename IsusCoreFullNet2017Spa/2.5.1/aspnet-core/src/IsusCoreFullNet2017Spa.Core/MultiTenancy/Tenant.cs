using Abp.MultiTenancy;
using IsusCoreFullNet2017Spa.Authorization.Users;

namespace IsusCoreFullNet2017Spa.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public const string NSchoolTenancyName = "NShkola";

        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}