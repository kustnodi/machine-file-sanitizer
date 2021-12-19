namespace MachineFileSanitizer;

static class Utils
{
    public static string SwitchCommas(this string value)
    {
        var len = value.Length;
        return value.Substring(1, len - 2).Replace(",", ":comma:");
    }
}