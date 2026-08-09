using System;
using System.Collections.Generic;
using AllaganLib.GameSheets.Caches;
using CriticalCommonLib.Crafting;
using CriticalCommonLib.Localization;

namespace CriticalCommonLib.Extensions;

public static class IngredientPreferenceTypeExtension
{
    public static HashSet<ItemInfoType> ToItemInfoTypes(this IngredientPreferenceType ingredientPreferenceType)
    {
        switch (ingredientPreferenceType)
        {
            case IngredientPreferenceType.None:
                return [];
            case IngredientPreferenceType.Mining:
                return
                [
                    ItemInfoType.Mining,
                    ItemInfoType.HiddenMining,
                    ItemInfoType.EphemeralMining,
                    ItemInfoType.TimedMining,

                    ItemInfoType.Quarrying,
                    ItemInfoType.HiddenQuarrying,
                    ItemInfoType.EphemeralQuarrying,
                    ItemInfoType.TimedQuarrying
                ];
            case IngredientPreferenceType.Botany:
                return
                [
                    ItemInfoType.Logging,
                    ItemInfoType.HiddenLogging,
                    ItemInfoType.EphemeralLogging,
                    ItemInfoType.TimedLogging,

                    ItemInfoType.Harvesting,
                    ItemInfoType.HiddenHarvesting,
                    ItemInfoType.EphemeralHarvesting,
                    ItemInfoType.TimedHarvesting
                ];
            case IngredientPreferenceType.Fishing:
                return
                [
                    ItemInfoType.Fishing
                ];
            case IngredientPreferenceType.SpearFishing:
                return
                [
                    ItemInfoType.Spearfishing
                ];
            case IngredientPreferenceType.Buy:
                return
                [
                    ItemInfoType.SpecialShop,
                    ItemInfoType.CashShop,
                    ItemInfoType.FateShop,
                    ItemInfoType.GilShop,
                    ItemInfoType.FCShop,
                    ItemInfoType.GCShop,
                    ItemInfoType.CalamitySalvagerShop,
                ];
            case IngredientPreferenceType.Crafting:
                return
                [
                    ItemInfoType.CraftRecipe,
                    ItemInfoType.FreeCompanyCraftRecipe,
                ];
            case IngredientPreferenceType.Marketboard:
                return [];
            case IngredientPreferenceType.Item:
                return
                [
                    ItemInfoType.SpecialShop,
                    ItemInfoType.AnimaShop,
                ];
            case IngredientPreferenceType.Venture:
                return
                [
                    ItemInfoType.BotanyVenture,
                    ItemInfoType.CombatVenture,
                    ItemInfoType.FishingVenture,
                    ItemInfoType.MiningVenture,
                ];
            case IngredientPreferenceType.Reduction:
                return
                [
                    ItemInfoType.Reduction,
                ];
            case IngredientPreferenceType.Duty:
                return
                [
                    ItemInfoType.DungeonBossChest,
                    ItemInfoType.DungeonBossDrop,
                    ItemInfoType.DungeonChest,
                    ItemInfoType.DungeonDrop,
                ];
            case IngredientPreferenceType.ResourceInspection:
                return
                [
                    ItemInfoType.SkybuilderInspection,
                ];
            case IngredientPreferenceType.Gardening:
                return
                [
                    ItemInfoType.Gardening,
                ];
            case IngredientPreferenceType.Desynthesis:
                return
                [
                    ItemInfoType.Desynthesis,
                ];
            case IngredientPreferenceType.Mobs:
                return
                [
                    ItemInfoType.Monster,
                ];
            case IngredientPreferenceType.HouseVendor:
                return
                [
                    ItemInfoType.GilShop,
                ];
            case IngredientPreferenceType.ExplorationVenture:
                return
                [
                    ItemInfoType.BotanyExplorationVenture,
                    ItemInfoType.CombatExplorationVenture,
                    ItemInfoType.FishingExplorationVenture,
                    ItemInfoType.MiningExplorationVenture,
                ];
        }

        return [];
    }
    public static string FormattedName(this IngredientPreferenceType ingredientPreferenceType)
    {
        switch (ingredientPreferenceType)
        {
            case IngredientPreferenceType.Botany:
                return SharedLocalization.Get("Botany");
            case IngredientPreferenceType.Buy:
                return SharedLocalization.Get("Buy from Vendor");
            case IngredientPreferenceType.HouseVendor:
                return SharedLocalization.Get("Buy from House Vendor");
            case IngredientPreferenceType.Crafting:
                return SharedLocalization.Get("Crafting");
            case IngredientPreferenceType.Fishing:
                return SharedLocalization.Get("Fishing");
            case IngredientPreferenceType.SpearFishing:
                return SharedLocalization.Get("Spearfishing");
            case IngredientPreferenceType.Item:
                return SharedLocalization.Get("Item");
            case IngredientPreferenceType.Marketboard:
                return SharedLocalization.Get("Marketboard");
            case IngredientPreferenceType.Mining:
                return SharedLocalization.Get("Mining");
            case IngredientPreferenceType.Venture:
                return SharedLocalization.Get("Venture");
            case IngredientPreferenceType.Duty:
                return SharedLocalization.Get("Duty");
            case IngredientPreferenceType.ExplorationVenture:
                return SharedLocalization.Get("Venture (Exploration)");
            case IngredientPreferenceType.Desynthesis:
                return SharedLocalization.Get("Desynthesis");
            case IngredientPreferenceType.Reduction:
                return SharedLocalization.Get("Reduction");
            case IngredientPreferenceType.ResourceInspection:
                return SharedLocalization.Get("Resource Inspection");
            case IngredientPreferenceType.Gardening:
                return SharedLocalization.Get("Gardening");
            case IngredientPreferenceType.Mobs:
                return SharedLocalization.Get("Monsters");
            case IngredientPreferenceType.Empty:
                return SharedLocalization.Get("Nothing");
        }

        return ingredientPreferenceType.ToString();
    }
}