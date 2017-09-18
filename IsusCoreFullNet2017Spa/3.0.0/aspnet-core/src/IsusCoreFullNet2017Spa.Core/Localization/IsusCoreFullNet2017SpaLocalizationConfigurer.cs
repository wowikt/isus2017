using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace IsusCoreFullNet2017Spa.Localization
{
    public static class IsusCoreFullNet2017SpaLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(IsusCoreFullNet2017SpaConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(IsusCoreFullNet2017SpaLocalizationConfigurer).GetAssembly(),
                        "IsusCoreFullNet2017Spa.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}