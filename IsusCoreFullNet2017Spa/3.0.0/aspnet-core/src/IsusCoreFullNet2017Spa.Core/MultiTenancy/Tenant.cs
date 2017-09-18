using Abp.MultiTenancy;
using IsusCoreFullNet2017Spa.Authorization.Users;

namespace IsusCoreFullNet2017Spa.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public const string NShkolaTenancyName = "NShkola";
        public const string NShkolaName = "Наша школа";

        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}