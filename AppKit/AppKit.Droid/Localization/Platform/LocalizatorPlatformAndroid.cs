namespace AdMaiora.AppKit.Localization
{
    using System;
    using System.Reflection;
    using System.Globalization;

    using AdMaiora.AppKit.IO;

    using Java.Util;

    public class LocalizatorPlatformAndroid : ILocalizatorPlatform
    {
        public FileSystem GetFileSystem()
        {
            return new FileSystem(new FileSystemPlatformAndroid());
        }

        public string GetDeviceUICulture()
        {
            return Locale.Default.ToString().Replace('_', '-');            
        }

        public CultureInfo[] GetInstalledCultures()
        {
            return CultureInfo.GetCultures(CultureTypes.AllCultures);
        }

        public Assembly[] GetAssemblies()
        {
            return AppDomain.CurrentDomain.GetAssemblies();
        }
    }
}