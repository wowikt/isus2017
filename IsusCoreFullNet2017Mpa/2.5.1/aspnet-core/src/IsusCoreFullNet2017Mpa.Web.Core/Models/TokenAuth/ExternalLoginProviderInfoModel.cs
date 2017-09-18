using Abp.AutoMapper;
using IsusCoreFullNet2017Mpa.Authentication.External;

namespace IsusCoreFullNet2017Mpa.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
