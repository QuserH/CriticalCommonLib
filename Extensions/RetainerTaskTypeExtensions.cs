using AllaganLib.GameSheets.Model;
using CriticalCommonLib.Localization;


namespace CriticalCommonLib.Extensions
{
    public static class RetainerTaskTypExtensions
    {
        public static string FormattedName(this RetainerTaskType retainerTaskType)
        {
            switch (retainerTaskType)
            {
                case RetainerTaskType.Botanist:
                    return SharedLocalization.Get("Botany");
                case RetainerTaskType.FieldExploration:
                    return SharedLocalization.Get("Field Exploration");
                case RetainerTaskType.HighlandExploration:
                    return SharedLocalization.Get("Highland Exploration");
                case RetainerTaskType.WatersideExploration:
                    return SharedLocalization.Get("Waterside Exploration");
                case RetainerTaskType.WoodlandExploration:
                    return SharedLocalization.Get("Woodland Exploration");
                case RetainerTaskType.Fishing:
                    return SharedLocalization.Get("Fishing");
                case RetainerTaskType.Hunting:
                    return SharedLocalization.Get("Hunting");
                case RetainerTaskType.Mining:
                    return SharedLocalization.Get("Mining");
                case RetainerTaskType.QuickExploration:
                    return SharedLocalization.Get("Quick Exploration");
                case RetainerTaskType.Unknown:
                    return SharedLocalization.Get("Unknown");
            }
            return retainerTaskType.ToString();
        }
    }
}