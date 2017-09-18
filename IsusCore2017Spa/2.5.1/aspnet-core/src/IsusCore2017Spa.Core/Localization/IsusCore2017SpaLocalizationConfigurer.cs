using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace IsusCore2017Spa.Localization
{
    public static class IsusCore2017SpaLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(IsusCore2017SpaConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(IsusCore2017SpaLocalizationConfigurer).GetAssembly(),
                        "IsusCore2017Spa.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}