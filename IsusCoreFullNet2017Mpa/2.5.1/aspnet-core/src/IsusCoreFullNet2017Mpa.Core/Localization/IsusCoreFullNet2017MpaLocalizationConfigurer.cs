using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace IsusCoreFullNet2017Mpa.Localization
{
    public static class IsusCoreFullNet2017MpaLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(IsusCoreFullNet2017MpaConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(IsusCoreFullNet2017MpaLocalizationConfigurer).GetAssembly(),
                        "IsusCoreFullNet2017Mpa.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}