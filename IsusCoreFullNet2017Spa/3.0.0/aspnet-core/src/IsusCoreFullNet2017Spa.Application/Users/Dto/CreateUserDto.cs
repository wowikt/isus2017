using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using IsusCoreFullNet2017Spa.Authorization.Users;
using IsusCoreFullNet2017Spa.IsusModels;

namespace IsusCoreFullNet2017Spa.Users.Dto
{
    [AutoMapTo(typeof(IsusUser))]
    public class CreateUserDto : IShouldNormalize
    {
        [Required]
        [StringLength(AbpUserBase.MaxUserNameLength)]
        public string AccountName { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxSurnameLength)]
        public string Surname { get; set; }

        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string Email { get; set; }

        public bool IsActive { get; set; }

        public string[] RoleNames { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        [DisableAuditing]
        public string Password { get; set; }

        public void Normalize()
        {
            if (RoleNames == null)
            {
                RoleNames = new string[0];
            }
        }

        public UserCardDto UserCard { get; set; }

        public bool? IsDeveloper { get; set; }

        public bool? IsAdmin { get; set; }

        public bool? IsBoss { get; set; }

        public bool? AccountValid { get; set; }

        public bool? SurplusIsTeacher { get; set; }

        public bool? IsDeleted { get; set; }
    }
}