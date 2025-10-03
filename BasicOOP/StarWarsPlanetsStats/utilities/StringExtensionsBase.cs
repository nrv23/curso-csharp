public static class StringExtensionsBase
{
    public static int? ToIntOrNull(this string? value) => int.TryParse(value, out int intValue) ? intValue : null;
    public static long? ToLongOrNull(this string? value) => long.TryParse(value, out long intValue) ? intValue : null;
}