using nalydmod.Items.Placeables.Special.Decor.Furniture.Special;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Toggles
{
    public class AAextraBuffedModeItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Totem of Experteese");
            Tooltip.SetDefault("Use in order to permanently activate 'Super Buffed Mode'\nIt buffs the enemies, not you\nWhy does every mod have something like this?\nIf unused after the player has been through their first night\nor if the world isn't in Expert Mode, this item does nothing");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SuspiciousLookingEye);
            item.width = 32;
            item.height = 48;
            item.consumable = true;
            item.expert = true;
        }
        public override bool CanUseItem(Player player)
        {
            return !MyWorld.firstNight && !MyWorld.extraBuffedMode && Main.expertMode;
        }
        public override bool UseItem(Player player)
        {
            Main.NewText("The souls of those against you have been awoken from their slumber", 200, 200, 200);
            player.QuickSpawnItem(ModContent.ItemType<AATotemofExperteese>());
            MyWorld.extraBuffedMode = true;
            return true;
        }
    }
}