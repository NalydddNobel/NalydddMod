using Terraria;
using nalydmod.Items.Materials.Expert;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using nalydmod.Items.Materials.GemFragments;
using nalydmod.Items.Materials.GemFragmentsq;
using nalydmod.Items.Materials;
using Terraria.ID;
using nalydmod.Items.Accessories;

namespace nalydmod.Items.TreasureBags
{
    public class GeodeTreasureBag : ModItem
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
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.TryGettingDevArmor();
            player.QuickSpawnItem(ItemType<SoulofShime>(), Main.rand.Next(10, 20));
            player.QuickSpawnItem(ItemType<AmethystFragment>(), Main.rand.Next(40, 60));
            player.QuickSpawnItem(ItemType<TopazFragment>(), Main.rand.Next(35, 55));
            player.QuickSpawnItem(ItemType<EmeraldFragment>(), Main.rand.Next(30, 50));
            player.QuickSpawnItem(ItemType<SapphireFragment>(), Main.rand.Next(25, 45));
            player.QuickSpawnItem(ItemType<RubyFragment>(), Main.rand.Next(20, 40));
            player.QuickSpawnItem(ItemType<DiamondFragment>(), Main.rand.Next(15, 35));
            player.QuickSpawnItem(ItemType<LifeFragment>(), Main.rand.Next(10, 30));
            player.QuickSpawnItem(ItemID.StoneBlock, Main.rand.Next(50, 200));
            player.QuickSpawnItem(ItemID.Amethyst, Main.rand.Next(0, 3));
            player.QuickSpawnItem(ItemID.Topaz, Main.rand.Next(0, 3));
            player.QuickSpawnItem(ItemID.Sapphire, Main.rand.Next(0, 2));
            player.QuickSpawnItem(ItemID.Emerald, Main.rand.Next(0, 2));
            player.QuickSpawnItem(ItemID.Ruby, Main.rand.Next(0, 1));
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ItemID.Ruby, Main.rand.Next(1, 2));
            }
            if (Main.rand.Next(3) == 0)
            {
                player.QuickSpawnItem(ItemType<CrystalShield>());
            }
        }
    }
}