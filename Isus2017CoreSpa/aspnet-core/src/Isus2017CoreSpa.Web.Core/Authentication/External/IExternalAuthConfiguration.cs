using System.Collections.Generic;

namespace Isus2017CoreSpa.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
