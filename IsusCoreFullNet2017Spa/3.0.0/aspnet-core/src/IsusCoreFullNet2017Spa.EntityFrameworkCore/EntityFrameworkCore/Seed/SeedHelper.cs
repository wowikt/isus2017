using System;
using System.Transactions;
using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore.Uow;
using Abp.MultiTenancy;
using IsusCoreFullNet2017Spa.EntityFrameworkCore.Seed.Host;
using IsusCoreFullNet2017Spa.EntityFrameworkCore.Seed.Tenants;
using Microsoft.EntityFrameworkCore;

namespace IsusCoreFullNet2017Spa.EntityFrameworkCore.Seed
{
    public static class SeedHelper
    {
        public static void SeedHostDb(IIocResolver iocResolver)
        {
            WithDbContext<IsusCoreFullNet2017SpaDbContext>(iocResolver, SeedHostDb);
        }

        public static void SeedHostDb(IsusCoreFullNet2017SpaDbContext context)
        {
            context.SuppressAutoSetTenantId = true;

            //Host seed
            new InitialHostDbBuilder(context).Create();

            //Default tenant seed (in host database).
            new DefaultTenantBuilder(context).Create();
            new TenantRoleAndUserBuilder(context, 1).Create();

            // NShkola tenant seed
            var tenant = new NShkolaTenantBuilder(context).Create();
            new TenantRoleAndUserBuilder(context, tenant.Id).Create();
        }

        private static void WithDbContext<TDbContext>(IIocResolver iocResolver, Action<TDbContext> contextAction)
            where TDbContext : DbContext
        {
            using (var uowManager = iocResolver.ResolveAsDisposable<IUnitOfWorkManager>())
            {
                using (var uow = uowManager.Object.Begin(TransactionScopeOption.Suppress))
                {
                    var context = uowManager.Object.Current.GetDbContext<TDbContext>(MultiTenancySides.Host);

                    contextAction(context);

                    uow.Complete();
                }
            }
        }
    }
}
