using nalydmod.Items.Accessories.AExpert.ABoss;
using nalydmod.Items.Expert.Souls;
using nalydmod.Items.Materials.GemFragments;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
namespace nalydmod.Items.Expert.TreasureBags
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
            item.CloneDefaults(ItemID.EyeOfCthulhuBossBag);

            item.value = Item.buyPrice(0, 13, 12, 53);
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            if (Main.rand.Next(665) == 0)
            {
                player.QuickSpawnItem(ItemID.AngelStatue, 1);
            }
            else
            {
                player.QuickSpawnItem(ItemID.GoldCoin, Main.rand.Next(2, 3));
                player.QuickSpawnItem(ItemID.SilverCoin, Main.rand.Next(0, 100));
                player.QuickSpawnItem(ItemID.CopperCoin, Main.rand.Next(0, 100));
                player.QuickSpawnItem(ItemType<BBBagofGems>());
                player.QuickSpawnItem(ItemType<BBSoulofShime>(), Main.rand.Next(10, 20));
                player.QuickSpawnItem(ItemType<AmethystFragment>(), Main.rand.Next(40, 60));
                player.QuickSpawnItem(ItemType<TopazFragment>(), Main.rand.Next(35, 55));
                player.QuickSpawnItem(ItemType<EmeraldFragment>(), Main.rand.Next(30, 50));
                player.QuickSpawnItem(ItemType<SapphireFragment>(), Main.rand.Next(25, 45));
                player.QuickSpawnItem(ItemType<RubyFragment>(), Main.rand.Next(20, 40));
                player.QuickSpawnItem(ItemType<DiamondFragment>(), Main.rand.Next(15, 35));
                player.QuickSpawnItem(ItemType<LifeFragment>(), Main.rand.Next(10, 30));
                player.QuickSpawnItem(ItemID.Amethyst, Main.rand.Next(0, 3));
                player.QuickSpawnItem(ItemID.Topaz, Main.rand.Next(0, 3));
                if (Main.rand.Next(2) == 0)
                {
                    player.QuickSpawnItem(ItemID.Sapphire);
                }
                if (Main.rand.Next(2) == 0)
                {
                    player.QuickSpawnItem(ItemID.Sapphire);
                }
                if (Main.rand.Next(2) == 0)
                {
                    player.QuickSpawnItem(ItemID.Sapphire);
                }
                if (Main.rand.Next(2) == 0)
                {
                    player.QuickSpawnItem(ItemID.Emerald);
                }
                if (Main.rand.Next(2) == 0)
                {
                    player.QuickSpawnItem(ItemID.Emerald);
                }
                if (Main.rand.Next(2) == 0)
                {
                    player.QuickSpawnItem(ItemID.Emerald);
                }
                if (Main.rand.Next(2) == 0)
                {
                    player.QuickSpawnItem(ItemID.Ruby);
                }
                if (Main.rand.Next(2) == 0)
                {
                    player.QuickSpawnItem(ItemID.Ruby);
                }
                if (Main.rand.Next(2) == 0)
                {
                    player.QuickSpawnItem(ItemID.Diamond);
                }
                if (Main.rand.Next(6) == 0)
                {
                    player.QuickSpawnItem(ItemType<Armor.Vanity.GeodeWormMask>());
                }
                if (Main.rand.Next(14) == 0)
                {
                    player.QuickSpawnItem(ItemType<Placeables.Special.MusicBox.ABMusicBoxboss1>());
                }
            }
        }
        public override int BossBagNPC => NPCType<Npcs.GeodeWormBossImage>();
    }
}