using CriticalCommonLib.Crafting;
using CriticalCommonLib.Localization;

namespace CriticalCommonLib.Extensions;

public static class CraftGroupTypeExtension
{
    public static string FormattedName(this CraftGroupType craftGroupType)
    {
        switch (craftGroupType)
        {
            case CraftGroupType.Crystals:
                return SharedLocalization.Get("Crystals");
            case CraftGroupType.Currency:
                return SharedLocalization.Get("Currency");
            case CraftGroupType.Output:
                return SharedLocalization.Get("Output");
            case CraftGroupType.Precraft:
                return SharedLocalization.Get("Precraft");
            case CraftGroupType.EverythingElse:
                return SharedLocalization.Get("Gather/Buy");
            case CraftGroupType.Retrieve:
                return SharedLocalization.Get("Retrieve");
            case CraftGroupType.HouseVendors:
                return SharedLocalization.Get("House Vendor");
        }

        return SharedLocalization.Get("Unknown");
    }
    public static string FormattedName(this PrecraftGroupSetting precraftGroupSetting)
    {
        switch (precraftGroupSetting)
        {
            case PrecraftGroupSetting.ByDepth:
                return SharedLocalization.Get("By Depth");
            case PrecraftGroupSetting.Together:
                return SharedLocalization.Get("Together");
            case PrecraftGroupSetting.ByClass:
                return SharedLocalization.Get("By Class");
        }

        return SharedLocalization.Get("Unknown");
    }
}