using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Isus2017CoreSpa.Localization
{
    public static class Isus2017CoreSpaLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Isus2017CoreSpaConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Isus2017CoreSpaLocalizationConfigurer).GetAssembly(),
                        "Isus2017CoreSpa.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}