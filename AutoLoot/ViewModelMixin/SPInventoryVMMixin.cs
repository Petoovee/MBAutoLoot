using System.Linq;
using Bannerlord.UIExtenderEx.Attributes;
using Bannerlord.UIExtenderEx.ViewModels;
using TaleWorlds.CampaignSystem.Inventory;
using TaleWorlds.CampaignSystem.ViewModelCollection.Inventory;

namespace AutoLoot.ViewModelMixin
{
    [ViewModelMixin]
    internal sealed class SPInventoryVMMixin : BaseViewModelMixin<SPInventoryVM>
    {
        public SPInventoryVMMixin(SPInventoryVM inventory) : base(inventory)
        {
            if (InventoryManager.Instance.CurrentMode == InventoryMode.Loot)
            {
                var settings = Settings.Instance;

                if (settings.EnableAutoLoot)
                {
                    var weaponsMinimumValues = new[]
                    {
                        settings.WeaponMinimumTier0,
                        settings.WeaponMinimumTier1,
                        settings.WeaponMinimumTier2,
                        settings.WeaponMinimumTier3,
                        settings.WeaponMinimumTier4,
                        settings.WeaponMinimumTier5,
                        settings.WeaponMinimumTier6
                    };

                    var armorsMinimumValues = new[]
                    {
                        settings.ArmorMinimumTier0,
                        settings.ArmorMinimumTier1,
                        settings.ArmorMinimumTier2,
                        settings.ArmorMinimumTier3,
                        settings.ArmorMinimumTier4,
                        settings.ArmorMinimumTier5,
                        settings.ArmorMinimumTier6
                    };

                    var leftPanel = inventory.LeftItemListVM;
                    var inventoryLogic = InventoryManager.InventoryLogic;
                    foreach (var item in leftPanel)
                        if (item.IsTransferable)
                        {
                            int itemType = item.TypeId;
                            //int itemCost = inventoryLogic.GetCostOfItemRosterElement(item.ItemRosterElement, InventoryLogic.InventorySide.OtherInventory);
                            
                            if (DonatableItemEnums.armorItemTypes.Contains(itemType))
                                continue; // Skip armors below minimum value
                            
                            if (DonatableItemEnums.weaponItemTypes.Contains(itemType))
                                continue; // Skip weapons below minimum value

                            // Move the item to the player inventory using the inventory logic
                            inventoryLogic.AddTransferCommand(
                                TransferCommand.Transfer(
                                    item.ItemCount,
                                    InventoryLogic.InventorySide.OtherInventory,
                                    InventoryLogic.InventorySide.PlayerInventory,
                                    item.ItemRosterElement,
                                    item.ItemType,
                                    item.ItemType,
                                    inventoryLogic.InitialEquipmentCharacter,
                                    !inventory.IsInWarSet
                                )
                            );
                        }
                }
            }
        }
    }
}