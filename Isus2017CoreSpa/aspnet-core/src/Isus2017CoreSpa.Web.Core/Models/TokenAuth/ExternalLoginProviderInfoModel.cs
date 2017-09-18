using Abp.AutoMapper;
using Isus2017CoreSpa.Authentication.External;

namespace Isus2017CoreSpa.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
