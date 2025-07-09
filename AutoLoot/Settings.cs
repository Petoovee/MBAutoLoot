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

        [SettingPropertyFloatingInteger("Discard armor - Gold per experience point", 0, 9999,
            HintText = "Discard armors that have low value compared to the experience points they provide.")]
        public float DiscardArmorGoldPerExperiencePoint { get; set; } = 0.5f;

        [SettingPropertyFloatingInteger("Discard weapons - Gold per experience point", 0, 9999,
            HintText = "Discard weapons that have low value compared to the experience points they provide.")]
        public float DiscardWeaponsGoldPerExperiencePoint { get; set; } = 0.5f;

        [SettingPropertyBool("Loot All Items", RequireRestart = false,
            HintText = "Automatically loot all items from defeated enemies.")]
        public bool LootAllItems { get; set; } = true;

        [SettingPropertyBool("Loot Only Valuable Items", RequireRestart = false,
            HintText = "Only loot items that are considered valuable.")]
        public bool LootOnlyValuableItems { get; set; } = false;
    }
}