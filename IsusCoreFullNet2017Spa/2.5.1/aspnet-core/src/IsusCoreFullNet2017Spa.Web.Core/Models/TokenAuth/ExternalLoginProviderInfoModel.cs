using Abp.AutoMapper;
using IsusCoreFullNet2017Spa.Authentication.External;

namespace IsusCoreFullNet2017Spa.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
