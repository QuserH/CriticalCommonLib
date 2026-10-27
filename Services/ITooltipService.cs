using System;
using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVClientStructs.FFXIV.Client.UI;
using FFXIVClientStructs.FFXIV.Client.UI.Agent;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace CriticalCommonLib.Services;

public interface ITooltipService : IDisposable
{
    void AddTooltipTweak(TooltipService.TooltipTweak tooltipTweak);
    unsafe bool ItemHoveredDetour(AgentItemDetail* a1, InventoryItem** a2, InventoryType* containerid, short* slotid, uint a5, uint slotidint, InventoryItem* a7);
    void Disable();
    unsafe void GenerateItemTooltipDetour(AddonItemDetail* addonItemDetail, NumberArrayData* numberArrayData, StringArrayData* stringArrayData);
}