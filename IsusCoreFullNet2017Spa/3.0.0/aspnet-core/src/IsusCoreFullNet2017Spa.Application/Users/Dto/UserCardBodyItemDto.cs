using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using IsusCoreFullNet2017Spa.IsusModels.XmlSubModels.IsusUser;
using Abp.AutoMapper;

namespace IsusCoreFullNet2017Spa.Users.Dto
{
    [AutoMapTo(typeof(IsusUserCardBodyItem))]
    public class UserCardBodyItemDto
    {
        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
        public string LastName { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
        public string MiddleName { get; set; }

        [Required]
        public int Gender { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        public string Inn { get; set; }

        public string Strah { get; set; }

        public string Passport { get; set; }

        public string Info { get; set; }

        public string Tel { get; set; }

        public string AddressReg { get; set; }

        public string AddressFact { get; set; }

        public string Contacts { get; set; }
    }
}
