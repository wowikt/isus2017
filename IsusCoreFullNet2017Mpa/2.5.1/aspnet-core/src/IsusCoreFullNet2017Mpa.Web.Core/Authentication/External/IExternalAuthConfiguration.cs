using System.Collections.Generic;

namespace IsusCoreFullNet2017Mpa.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
