using nalydmod.Items.Expert.Bars;
using nalydmod.Items.Expert.Souls;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace nalydmod.Items.Expert.TreasureBags
{
    public class LunarPillarTreasureBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("Right Click to open");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.consumable = true;
            item.maxStack = 999;
            item.expert = true;
            item.value = Item.buyPrice(1, 15, 34, 19);
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.TryGettingDevArmor();
            player.TryGettingDevArmor();
            player.QuickSpawnItem(ItemID.FragmentNebula, Main.rand.Next(33, 50));
            player.QuickSpawnItem(ItemID.FragmentSolar, Main.rand.Next(33, 50));
            player.QuickSpawnItem(ItemID.FragmentStardust, Main.rand.Next(33, 50));
            player.QuickSpawnItem(ItemID.FragmentVortex, Main.rand.Next(33, 50));
            player.QuickSpawnItem(ItemType<NebulaBar>(), Main.rand.Next(5, 20));
            player.QuickSpawnItem(ItemType<SolarBar>(), Main.rand.Next(5, 20));
            player.QuickSpawnItem(ItemType<StardustBar>(), Main.rand.Next(5, 20));
            player.QuickSpawnItem(ItemType<VortexBar>(), Main.rand.Next(5, 20));
            player.QuickSpawnItem(ItemType<HHSoulofAxiom>(), Main.rand.Next(33, 55));
        }
    }
}