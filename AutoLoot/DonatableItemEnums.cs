using TaleWorlds.Core;

namespace AutoLoot
{
    public static class DonatableItemEnums
    {
        internal static readonly int[] weaponItemTypes =
        {
            (int)ItemObject.ItemTypeEnum.OneHandedWeapon,
            (int)ItemObject.ItemTypeEnum.TwoHandedWeapon,
            (int)ItemObject.ItemTypeEnum.Polearm,
            (int)ItemObject.ItemTypeEnum.Arrows,
            (int)ItemObject.ItemTypeEnum.Bolts,
            (int)ItemObject.ItemTypeEnum.Bow,
            (int)ItemObject.ItemTypeEnum.Crossbow,
            (int)ItemObject.ItemTypeEnum.Thrown,
            (int)ItemObject.ItemTypeEnum.Pistol,
            (int)ItemObject.ItemTypeEnum.Musket,
            (int)ItemObject.ItemTypeEnum.Bullets
        };

        internal static readonly int[] armorItemTypes =
        {
            (int)ItemObject.ItemTypeEnum.Shield,
            (int)ItemObject.ItemTypeEnum.HeadArmor,
            (int)ItemObject.ItemTypeEnum.BodyArmor,
            (int)ItemObject.ItemTypeEnum.LegArmor,
            (int)ItemObject.ItemTypeEnum.HandArmor,
            (int)ItemObject.ItemTypeEnum.ChestArmor,
            (int)ItemObject.ItemTypeEnum.Cape,
            (int)ItemObject.ItemTypeEnum.HorseHarness
        };
    }
}