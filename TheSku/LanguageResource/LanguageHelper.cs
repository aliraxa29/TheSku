using System.Globalization;
using System.Reflection;
using System.Resources;

public class LanguageHelper
{
    static ResourceManager _resourceManager;

    static LanguageHelper()
    {
        _resourceManager = new ResourceManager($"TheSku.LanguageResource.{Global.Language}", Assembly.GetExecutingAssembly());
    }

    public static string GetString(string key)
    {
        return _resourceManager.GetString(key, CultureInfo.CurrentCulture);
    }
}