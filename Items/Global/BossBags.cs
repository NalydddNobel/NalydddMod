using nalydmod.Items.Accessories.AExpert;
using nalydmod.Items.Expert;
using nalydmod.Items.Expert.Souls;
using nalydmod.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
namespace nalydmod.Items.Global
{
    public class BossBags : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (context == "bossBag" && arg == ItemID.KingSlimeBossBag)
            {
                player.QuickSpawnItem(ItemType<AASoulofSlime>(), Main.rand.Next(20, 35));
                player.QuickSpawnItem(ItemType<RoyalGel>(), Main.rand.Next(12, 25));
                player.QuickSpawnItem(ItemType<ABBrittleWings>());
                if (Main.rand.Next(14) == 0)
                {
                    player.QuickSpawnItem(ItemType<Placeables.Special.MusicBox.AAMusicBoxkingslime>());
                }
                if (NPC.downedSlimeKing)
                {
                    if (!MyWorld.openedKingSlimeBag)
                    {
                        Main.NewText("The slimes seek vengence for their fallen king", 95, 240, 189);
                        MyWorld.openedKingSlimeBag = true;
                    }
                    if (MyWorld.extraBuffedMode && !player.GetModPlayer<MyPlayer>().kingSlimeEffect)
                    {
                        player.QuickSpawnItem(ItemType<Expert.Toggles.BBTastySlimeball>());
                    }
                }
            }
            if (context == "bossBag" && arg == ItemID.EyeOfCthulhuBossBag)
            {
                player.QuickSpawnItem(ItemType<CCSoulofTime>(), Main.rand.Next(15, 30));
                player.QuickSpawnItem(ItemType<corrupteyes>(), Main.rand.Next(1, 3));
                player.QuickSpawnItem(ItemType<crimsoneyes>(), Main.rand.Next(1, 3));
                player.QuickSpawnItem(ItemType<SpectrumLens>(), Main.rand.Next(1, 3));
                if (Main.rand.Next(14) == 0)
                {
                    player.QuickSpawnItem(ItemType<Placeables.Special.MusicBox.ACMusicBoxEyeofCuthulu>());
                }
                if (NPC.downedBoss1)
                {
                    if (!MyWorld.openedBoss1Bag)
                    {
                        Main.NewText("The Eye of Cthulhu's minions have gained power", 95, 240, 189);
                        MyWorld.openedBoss1Bag = true;
                    }
                }
            }
            if (context == "bossBag" && arg == ItemID.EaterOfWorldsBossBag)
            {
                player.QuickSpawnItem(ItemType<DDSoulofCrime>(), Main.rand.Next(15, 30));
                player.QuickSpawnItem(ItemType<MassiveWormTooth>(), Main.rand.Next(1, 3));
                if (NPC.downedBoss2)
                {
                    if (!MyWorld.openedBoss2CorruptionBag)
                    {
                        Main.NewText("The Corruption's power over life grows stronger", 95, 240, 189);
                        MyWorld.openedBoss2CorruptionBag = true;
                    }
                }
            }
            if (context == "bossBag" && arg == ItemID.BrainOfCthulhuBossBag)
            {
                player.QuickSpawnItem(ItemType<DDSoulofCrime>(), Main.rand.Next(18, 33));
                player.QuickSpawnItem(ItemType<MassiveWormTooth>(), Main.rand.Next(1, 3));
                if (NPC.downedBoss2)
                {
                    if (!MyWorld.openedBoss2CrimsonBag)
                    {
                        Main.NewText("The Crimson's power over life grows stronger", 95, 240, 189);
                        MyWorld.openedBoss2CrimsonBag = true;
                    }
                }
            }
            if (context == "bossBag" && arg == ItemID.SkeletronBossBag)
            {
                player.QuickSpawnItem(ItemType<EESoulofSpine>(), Main.rand.Next(15, 30));
                if (NPC.downedBoss3)
                {
                    if (!MyWorld.openedBoss3Bag)
                    {
                        Main.NewText("The skeletons outside of the dungeon hear of Skeletron's defeat", 95, 240, 189);
                        MyWorld.openedBoss3Bag = true;
                    }
                }
            }
            if (context == "bossBag" && arg == ItemID.QueenBeeBossBag)
            {
                player.QuickSpawnItem(ItemType<DESoulofBime>(), Main.rand.Next(15, 30));
                if (NPC.downedQueenBee)
                {
                    if (!MyWorld.openedQueenBeeBag)
                    {
                        Main.NewText("The bees seek vengence for their fallen queen", 95, 240, 189);
                        MyWorld.openedQueenBeeBag = true;
                    }
                }
            }
            if (context == "bossBag" && arg == ItemID.WallOfFleshBossBag)
            {
                player.QuickSpawnItem(ItemType<FFSoulofGrime>(), Main.rand.Next(22, 44));
            }
        }
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.KingSlimeBossBag)
            {
                item.value = Item.buyPrice(0, 12, 0, 0);
            }
            if (item.type == ItemID.EyeOfCthulhuBossBag)
            {
                item.value = Item.buyPrice(0, 15, 0, 0);
            }
            if (item.type == ItemID.EaterOfWorldsBossBag)
            {
                item.value = Item.buyPrice(0, 18, 0, 0);
            }
            if (item.type == ItemID.BrainOfCthulhuBossBag)
            {
                item.value = Item.buyPrice(0, 19, 50, 0);
            }
            if (item.type == ItemID.SkeletronBossBag)
            {
                item.value = Item.buyPrice(0, 20, 2, 71);
            }
            if (item.type == ItemID.WallOfFleshBossBag)
            {
                item.value = Item.buyPrice(0, 23, 21, 35);
            }
        }
    }
}