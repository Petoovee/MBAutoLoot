using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace AutoLoot
{
    public class Settings : AttributeGlobalSettings<Settings>
    {
        public override string Id => "AutoLoot";
        public override string DisplayName => "Auto Loot";
        public override string FolderName => "AutoLoot";
        public override string FormatType => "json";

        [SettingPropertyBool("Enable Auto Loot", RequireRestart = false,
            HintText = "Enable or disable the auto loot feature.")]
        public bool EnableAutoLoot { get; set; } = true;

        [SettingPropertyInteger("Armor Minimum Value Tier 0", 0, int.MaxValue,
            HintText = "Minimum value for tier 0 armors to be considered for auto loot.")]
        public int ArmorMinimumTier0 { get; set; } = 35;

        [SettingPropertyInteger("Armor Minimum Value Tier 1", 0, int.MaxValue,
            HintText = "Minimum value for tier 1 armors to be considered for auto loot.")]
        public int ArmorMinimumTier1 { get; set; } = 75;

        [SettingPropertyInteger("Armor Minimum Value Tier 2", 0, int.MaxValue,
            HintText = "Minimum value for tier 2 armors to be considered for auto loot.")]
        public int ArmorMinimumTier2 { get; set; } = 150;

        [SettingPropertyInteger("Armor Minimum Value Tier 3", 0, int.MaxValue,
            HintText = "Minimum value for tier 3 armors to be considered for auto loot.")]
        public int ArmorMinimumTier3 { get; set; } = 250;

        [SettingPropertyInteger("Armor Minimum Value Tier 4", 0, int.MaxValue,
            HintText = "Minimum value for tier 4 armors to be considered for auto loot.")]
        public int ArmorMinimumTier4 { get; set; } = 300;

        [SettingPropertyInteger("Armor Minimum Value Tier 5", 0, int.MaxValue,
            HintText = "Minimum value for tier 5 armors to be considered for auto loot.")]
        public int ArmorMinimumTier5 { get; set; } = 300;

        [SettingPropertyInteger("Armor Minimum Value Tier 6", 0, int.MaxValue,
            HintText = "Minimum value for tier 6 armors to be considered for auto loot.")]
        public int ArmorMinimumTier6 { get; set; } = 300;

        [SettingPropertyInteger("Weapon Minimum Value Tier 0", 0, int.MaxValue,
            HintText = "Minimum value for tier 0 weapons to be considered for auto loot.")]
        public int WeaponMinimumTier0 { get; set; } = 35;

        [SettingPropertyInteger("Weapon Minimum Value Tier 1", 0, int.MaxValue,
            HintText = "Minimum value for tier 1 weapons to be considered for auto loot.")]
        public int WeaponMinimumTier1 { get; set; } = 75;

        [SettingPropertyInteger("Weapon Minimum Value Tier 2", 0, int.MaxValue,
            HintText = "Minimum value for tier 2 weapons to be considered for auto loot.")]
        public int WeaponMinimumTier2 { get; set; } = 150;

        [SettingPropertyInteger("Weapon Minimum Value Tier 3", 0, int.MaxValue,
            HintText = "Minimum value for tier 3 weapons to be considered for auto loot.")]
        public int WeaponMinimumTier3 { get; set; } = 250;

        [SettingPropertyInteger("Weapon Minimum Value Tier 4", 0, int.MaxValue,
            HintText = "Minimum value for tier 4 weapons to be considered for auto loot.")]
        public int WeaponMinimumTier4 { get; set; } = 300;

        [SettingPropertyInteger("Weapon Minimum Value Tier 5", 0, int.MaxValue,
            HintText = "Minimum value for tier 5 weapons to be considered for auto loot.")]
        public int WeaponMinimumTier5 { get; set; } = 300;

        [SettingPropertyInteger("Weapon Minimum Value Tier 6", 0, int.MaxValue,
            HintText = "Minimum value for tier 6 weapons to be considered for auto loot.")]
        public int WeaponMinimumTier6 { get; set; } = 300;
    }
}