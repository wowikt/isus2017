using System.Linq;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.MultiTenancy;
using IsusCoreFullNet2017Spa.Authorization;
using IsusCoreFullNet2017Spa.Authorization.Roles;
using IsusCoreFullNet2017Spa.Authorization.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace IsusCoreFullNet2017Spa.EntityFrameworkCore.Seed.Tenants
{
    public class TenantRoleAndUserBuilder
    {
        private readonly IsusCoreFullNet2017SpaDbContext _context;
        private readonly int _tenantId;

        public TenantRoleAndUserBuilder(IsusCoreFullNet2017SpaDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            CreateRolesAndUsers();
        }

        private void CreateRolesAndUsers()
        {
            // Admin role

            var adminRole = _context.Roles.IgnoreQueryFilters()
                .FirstOrDefault(r => r.TenantId == _tenantId && r.Name == StaticRoleNames.Tenants.Admin);
            if (adminRole == null)
            {
                adminRole = _context.Roles
                    .Add(new Role(_tenantId, StaticRoleNames.Tenants.Admin, StaticRoleNames.Tenants.AdminDisplayName)
                    {
                        IsStatic = true
                    }).Entity;
                _context.SaveChanges();

                //Grant all permissions to admin role
                var permissions = PermissionFinder
                    .GetAllPermissions(new IsusCoreFullNet2017SpaAuthorizationProvider())
                    .Where(p => p.MultiTenancySides.HasFlag(MultiTenancySides.Tenant))
                    .ToList();

                foreach (var permission in permissions)
                {
                    _context.Permissions.Add(
                        new RolePermissionSetting
                        {
                            TenantId = _tenantId,
                            Name = permission.Name,
                            IsGranted = true,
                            RoleId = adminRole.Id
                        });
                }

                _context.SaveChanges();
            }

            // Boss role

            var bossRole = _context.Roles.IgnoreQueryFilters()
                .FirstOrDefault(r => r.TenantId == _tenantId && r.Name == StaticRoleNames.Tenants.Boss);
            if (bossRole == null)
            {
                bossRole = _context.Roles
                    .Add(new Role(_tenantId, StaticRoleNames.Tenants.Boss, StaticRoleNames.Tenants.BossDisplayName)
                    {
                        IsStatic = true
                    }).Entity;
                _context.SaveChanges();

                //Grant all permissions to boss role
                var permissions = PermissionFinder
                    .GetAllPermissions(new IsusCoreFullNet2017SpaAuthorizationProvider())
                    .Where(p => p.MultiTenancySides.HasFlag(MultiTenancySides.Tenant))
                    .ToList();

                foreach (var permission in permissions)
                {
                    _context.Permissions.Add(
                        new RolePermissionSetting
                        {
                            TenantId = _tenantId,
                            Name = permission.Name,
                            IsGranted = true,
                            RoleId = bossRole.Id
                        });
                }

                _context.SaveChanges();
            }

            // Developer role

            var developerRole = _context.Roles.IgnoreQueryFilters()
                .FirstOrDefault(r => r.TenantId == _tenantId && r.Name == StaticRoleNames.Tenants.Developer);
            if (developerRole == null)
            {
                developerRole = _context.Roles
                    .Add(new Role(_tenantId, StaticRoleNames.Tenants.Developer,
                        StaticRoleNames.Tenants.DeveloperDisplayName)
                    {
                        IsStatic = true
                    }).Entity;
                _context.SaveChanges();

                //Grant all permissions to developer role
                var permissions = PermissionFinder
                    .GetAllPermissions(new IsusCoreFullNet2017SpaAuthorizationProvider())
                    .Where(p => p.MultiTenancySides.HasFlag(MultiTenancySides.Tenant))
                    .ToList();

                foreach (var permission in permissions)
                {
                    _context.Permissions.Add(
                        new RolePermissionSetting
                        {
                            TenantId = _tenantId,
                            Name = permission.Name,
                            IsGranted = true,
                            RoleId = developerRole.Id
                        });
                }

                _context.SaveChanges();
            }

            // Parent role

            var parentRole = _context.Roles.IgnoreQueryFilters()
                .FirstOrDefault(r => r.TenantId == _tenantId && r.Name == StaticRoleNames.Tenants.Parent);
            if (parentRole == null)
            {
                parentRole = _context.Roles
                    .Add(new Role(_tenantId, StaticRoleNames.Tenants.Parent, StaticRoleNames.Tenants.ParentDisplayName)
                    {
                        IsStatic = true
                    }).Entity;
                _context.SaveChanges();
            }

            // Pupil role

            var pupilRole = _context.Roles.IgnoreQueryFilters()
                .FirstOrDefault(r => r.TenantId == _tenantId && r.Name == StaticRoleNames.Tenants.Pupil);
            if (pupilRole == null)
            {
                pupilRole = _context.Roles
                    .Add(new Role(_tenantId, StaticRoleNames.Tenants.Pupil, StaticRoleNames.Tenants.PupilDisplayName)
                    {
                        IsStatic = true
                    }).Entity;
                _context.SaveChanges();
            }

            // Teacher role

            var teacherRole = _context.Roles.IgnoreQueryFilters()
                .FirstOrDefault(r => r.TenantId == _tenantId && r.Name == StaticRoleNames.Tenants.Teacher);
            if (teacherRole == null)
            {
                teacherRole = _context.Roles
                    .Add(new Role(_tenantId, StaticRoleNames.Tenants.Teacher, StaticRoleNames.Tenants.TeacherDisplayName)
                    {
                        IsStatic = true
                    }).Entity;
                _context.SaveChanges();
            }

            //admin user

            var adminUser = _context.Users.IgnoreQueryFilters().FirstOrDefault(u => u.TenantId == _tenantId && u.UserName == AbpUserBase.AdminUserName);
            if (adminUser == null)
            {
                adminUser = User.CreateTenantAdminUser(_tenantId, "admin@defaulttenant.com");
                adminUser.Password = new PasswordHasher<User>(new OptionsWrapper<PasswordHasherOptions>(new PasswordHasherOptions())).HashPassword(adminUser, "123qwe");
                adminUser.IsEmailConfirmed = true;
                adminUser.IsActive = true;

                _context.Users.Add(adminUser);
                _context.SaveChanges();

                //Assign Admin role to admin user
                _context.UserRoles.Add(new UserRole(_tenantId, adminUser.Id, adminRole.Id));
                _context.SaveChanges();

                //User account of admin user
                if (_tenantId == 1)
                {
                    _context.UserAccounts.Add(new UserAccount
                    {
                        TenantId = _tenantId,
                        UserId = adminUser.Id,
                        UserName = AbpUserBase.AdminUserName,
                        EmailAddress = adminUser.EmailAddress
                    });
                    _context.SaveChanges();
                }
            }
        }
    }
}
