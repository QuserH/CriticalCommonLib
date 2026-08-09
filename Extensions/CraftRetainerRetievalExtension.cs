using System;
using CriticalCommonLib.Crafting;
using CriticalCommonLib.Localization;

namespace CriticalCommonLib.Extensions
{
    public static class CraftRetainerRetrievalExtension
    {
        public static string FormattedName(this CraftRetainerRetrieval craftRetainerRetrieval)
        {
            switch (craftRetainerRetrieval)
            {
                case CraftRetainerRetrieval.Yes:
                    return SharedLocalization.Get("Yes");
                case CraftRetainerRetrieval.No:
                    return SharedLocalization.Get("No");
                case CraftRetainerRetrieval.HqOnly:
                    return SharedLocalization.Get("HQ Only");
                case CraftRetainerRetrieval.NqOnly:
                    return SharedLocalization.Get("NQ Only");
                case CraftRetainerRetrieval.CollectableOnly:
                    return SharedLocalization.Get("Collectable Only");
            }
            return craftRetainerRetrieval.ToString();
        }
    }
}