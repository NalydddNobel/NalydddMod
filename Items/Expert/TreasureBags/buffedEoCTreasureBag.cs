using nalydmod.Items.Expert.Orbs;
using nalydmod.Items.Expert.Souls;
using nalydmod.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
namespace nalydmod.Items.Expert.TreasureBags
{
    public class buffedEoCTreasureBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("Right Click to open");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
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
            player.QuickSpawnItem(ItemType<orb1Eoc>());
            player.QuickSpawnItem(ItemID.GoldCoin, Main.rand.Next(79, 85));
            player.QuickSpawnItem(ItemID.SilverCoin, Main.rand.Next(0, 100));
            player.QuickSpawnItem(ItemID.CopperCoin, Main.rand.Next(0, 100));
            player.QuickSpawnItem(ItemType<CCSoulofTime>(), Main.rand.Next(25, 50));
            player.QuickSpawnItem(ItemID.Lens, Main.rand.Next(25, 50));
            player.QuickSpawnItem(ItemID.BlackLens, Main.rand.Next(0, 2));
            player.QuickSpawnItem(ItemType<corrupteyes>(), Main.rand.Next(10, 25));
            player.QuickSpawnItem(ItemType<crimsoneyes>(), Main.rand.Next(10, 25));
            player.QuickSpawnItem(ItemID.EyeOfCthulhuBossBag, Main.rand.Next(1, 3));
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ItemID.Binoculars);
            }
        }
    }
}