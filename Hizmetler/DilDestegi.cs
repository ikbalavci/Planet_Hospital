using Microsoft.Extensions.Localization;
using System.Reflection;

namespace udemyWeb1.Hizmetler
{
    public class SharedResource
    {

    }
    public class DilDestegi
    {
        private readonly IStringLocalizer _localizer;

        public DilDestegi(IStringLocalizerFactory factory)
        {
            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _localizer = factory.Create(nameof(SharedResource), assemblyName.Name);
        }

        public LocalizedString Getkey(string key)
        {
            return _localizer[key];
        }
    }
}



    