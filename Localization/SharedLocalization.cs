using System;

namespace CriticalCommonLib.Localization;

/// <summary>
/// Shared translation hook for CriticalCommonLib code.
/// InventoryTools registers its localization dictionary here so that
/// enum FormattedName() helpers (bag/container names etc.) render in Chinese.
/// Falls back to the original English string when no translator is set.
/// </summary>
public static class SharedLocalization
{
    public static Func<string, string>? Translate { get; set; }

    public static string Get(string english)
    {
        return Translate?.Invoke(english) ?? english;
    }
}
