using nalydmod.Items.Weapons.Magic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace nalydmod.Items.Expert.TreasureBags
{
    public class Mage1TreasureBag : ModItem
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
            player.QuickSpawnItem(ItemID.MeteorShot, Main.rand.Next(0, 300));
            player.QuickSpawnItem(ItemID.MeteoriteBar, Main.rand.Next(0, 25));
            player.QuickSpawnItem(ItemID.Meteorite, Main.rand.Next(25, 200));
            if (Main.rand.Next(3) == 0)
            {
                player.QuickSpawnItem(ItemType<CrazyTome>());
            }
            if (Main.rand.Next(3) == 0)
            {
                player.QuickSpawnItem(ItemID.MeteorHamaxe);
            }
            if (Main.rand.Next(3) == 0)
            {
                player.QuickSpawnItem(ItemID.EnchantedSword);
            }
            if (Main.rand.Next(3) == 0)
            {
                player.QuickSpawnItem(ItemID.EnchantedBoomerang);
            }
            if (Main.rand.Next(9) == 0)
            {
                player.QuickSpawnItem(ItemID.SpaceGun);
            }
            if (Main.rand.Next(9) == 0)
            {
                player.QuickSpawnItem(ItemID.MeteorHelmet);
            }
            if (Main.rand.Next(9) == 0)
            {
                player.QuickSpawnItem(ItemID.MeteorSuit);
            }
            if (Main.rand.Next(9) == 0)
            {
                player.QuickSpawnItem(ItemID.MeteorLeggings);
            }
        }
    }
}