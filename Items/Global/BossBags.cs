using nalydmod.Items.Expert;
using nalydmod.Items.Expert.Accessories;
using nalydmod.Items.Expert.Dev;
using nalydmod.Items.Expert.Souls;
using nalydmod.Items.Materials;
using nalydmod.Items.Weapons.Magic;
using nalydmod.Items.Weapons.Magic.Staff;
using nalydmod.Items.Weapons.Melee.Boomerangs;
using nalydmod.Items.Weapons.Melee.Swords.ShortSwords;
using nalydmod.Items.Weapons.Ranged.UsesBullet;
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
                player.QuickSpawnItem(ItemType<BrittleWings>());
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeShortsword>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeShooter>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeSniper>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeTome>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeStaffx>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemID.SlimeStaff);
                }
            }
            if (context == "bossBag" && arg == ItemID.EyeOfCthulhuBossBag)
            {
                player.QuickSpawnItem(ItemType<CCSoulofTime>(), Main.rand.Next(15, 30));
                player.QuickSpawnItem(ItemType<corrupteyes>(), Main.rand.Next(1, 3));
                player.QuickSpawnItem(ItemType<crimsoneyes>(), Main.rand.Next(1, 3));
                player.QuickSpawnItem(ItemType<SpectrumLens>(), Main.rand.Next(1, 3));
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<CursedBeamStaff>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<CrimsonMachete>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeSniper>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeTome>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeStaffx>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemID.SlimeStaff);
                }
            }
            if (context == "bossBag" && arg == ItemID.EaterOfWorldsBossBag)
            {
                player.QuickSpawnItem(ItemType<DDSoulofCrime>(), Main.rand.Next(15, 30));
                player.QuickSpawnItem(ItemType<MassiveWormTooth>(), Main.rand.Next(1, 3));
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeShortsword>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeShooter>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeSniper>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeTome>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeStaffx>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemID.SlimeStaff);
                }
            }
            if (context == "bossBag" && arg == ItemID.BrainOfCthulhuBossBag)
            {
                player.QuickSpawnItem(ItemType<DDSoulofCrime>(), Main.rand.Next(15, 30));
                player.QuickSpawnItem(ItemType<MassiveWormTooth>(), Main.rand.Next(1, 3));
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<CrimsonMachete>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeShooter>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeSniper>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeTome>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeStaffx>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemID.SlimeStaff);
                }
            }
            if (context == "bossBag" && arg == ItemID.SkeletronBossBag)
            {
                player.QuickSpawnItem(ItemType<EESoulofSpine>(), Main.rand.Next(15, 30));
                player.QuickSpawnItem(ItemType<MassiveWormTooth>(), Main.rand.Next(1, 3));
                player.QuickSpawnItem(ItemID.Bone, Main.rand.Next(22, 66));
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<CrimsonMachete>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeShooter>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeSniper>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeTome>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeStaffx>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemID.SlimeStaff);
                }
            }
            if (context == "bossBag" && arg == ItemID.WallOfFleshBossBag)
            {
                player.QuickSpawnItem(ItemType<FFSoulofGrime>(), Main.rand.Next(22, 44));
                player.QuickSpawnItem(ItemType<MassiveWormTooth>(), Main.rand.Next(1, 3));
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<CrimsonMachete>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeShooter>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeSniper>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeTome>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemType<SlimeStaffx>());
                }
                if (Main.rand.Next(5) == 0)
                {
                    player.QuickSpawnItem(ItemID.SlimeStaff);
                }
            }
            if (context == "bossBag" && arg == ItemID.CultistBossBag)
            {
                player.QuickSpawnItem(ItemType<Nalydwings>());
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