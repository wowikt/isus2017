﻿using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
