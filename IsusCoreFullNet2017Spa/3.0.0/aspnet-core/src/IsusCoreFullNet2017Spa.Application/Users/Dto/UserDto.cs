using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using IsusCoreFullNet2017Spa.Authorization.Users;
using IsusCoreFullNet2017Spa.IsusModels;

namespace IsusCoreFullNet2017Spa.Users.Dto
{
    [AutoMapFrom(typeof(IsusUser))]
    public class UserDto : EntityDto<long>
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

        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string Email { get; set; }

        public bool IsActive { get; set; }

        public string FullName { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public DateTime CreationTime { get; set; }

        public string[] RoleNames { get; set; }

        public bool? IsDeveloper { get; set; }

        public bool? IsAdmin { get; set; }

        public bool? IsBoss { get; set; }

        public bool? AccountValid { get; set; }

        public bool? SurplusIsTeacher { get; set; }

        public bool? IsDeleted { get; set; }

        public UserCardDto UserCard { get; set; }
    }
}