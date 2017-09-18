using Abp.AutoMapper;
using IsusCore2017Mpa.Authentication.External;

namespace IsusCore2017Mpa.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
