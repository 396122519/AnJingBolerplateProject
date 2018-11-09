using System.Collections.Generic;

namespace AnJingBolerplateProject.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
