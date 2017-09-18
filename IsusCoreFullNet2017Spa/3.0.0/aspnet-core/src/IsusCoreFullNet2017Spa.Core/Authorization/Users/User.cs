using System;
using Abp.Authorization.Users;
using Abp.Extensions;
using IsusCoreFullNet2017Spa.IsusModels;

namespace IsusCoreFullNet2017Spa.Authorization.Users
{
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress
            };

            user.SetNormalizedNames();

            return user;
        }

        public long? IsusUserId { get; set; }

        public IsusUser IsusUser { get; set; }
    }
}