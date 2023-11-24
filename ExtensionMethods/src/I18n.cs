using System.Globalization;

namespace ExtensionMethods;

public static class I18n
{
    public static string PtBr(this DateTime date)
    {
        return date.ToString("dd/MM/yyyy");
    }
    public static string PtBr(this double value)
    {
        return value.ToString(new CultureInfo("pt-BR"));
    }
}