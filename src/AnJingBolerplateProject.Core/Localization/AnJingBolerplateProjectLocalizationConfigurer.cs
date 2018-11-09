using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AnJingBolerplateProject.Localization
{
    public static class AnJingBolerplateProjectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AnJingBolerplateProjectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AnJingBolerplateProjectLocalizationConfigurer).GetAssembly(),
                        "AnJingBolerplateProject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
