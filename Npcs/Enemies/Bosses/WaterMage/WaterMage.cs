using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Npcs.Enemies.Bosses.WaterMage
{
    [AutoloadBossHead]
    class WaterMage : ModNPC
    {
        public int projChoice;
        public short chosen;
        public short chosen2;
        public int chosen3;
        public int chosen4;
        public static int teleport;
        public static float posWaterMageX;
        public static float posWaterMageY;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Mage");
            Main.npcFrameCount[npc.type] = 3;
        }
        public override void SetDefaults()
        {
            npc.width = 40;
            npc.height = 54;
            npc.damage = 20;
            npc.defense = 15;
            npc.lifeMax = 606;
            npc.boss = true;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.teleporting = true;
            npc.value = 60f;
            npc.knockBackResist = 0.22f;
            music = MusicID.Boss1;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (!NPC.AnyNPCs(mod.NPCType("WaterMage")))
            {
                if (NPC.downedBoss2 && !MyWorld.DownedMage1)
                {
                    return SpawnCondition.Meteor.Chance * 0.1f;
                }
                else return SpawnCondition.Meteor.Chance * 0.0096f;
            }
            else return 0;
        }
        public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore15"), Main.rand.Next(8, 16) * 0.1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore15"), Main.rand.Next(7, 12) * 0.1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore15"), Main.rand.Next(5, 10) * 0.1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore15"), Main.rand.Next(4, 8) * 0.1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore15"), Main.rand.Next(2, 6) * 0.1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore15"), Main.rand.Next(2, 4) * 0.1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore13"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore14"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore12"), 1f);
            }
            for (int i = 0; i < 10; i++)
            {
                int dustType = 43;
                int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
                Dust dust = Main.dust[dustIndex];
                dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
                dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
                dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.30f;
            }
        }
        public override void AI()
        {
            posWaterMageX = npc.position.X;
            posWaterMageY = npc.position.Y;
            projChoice = (int)Main.rand.NextFloat(1, 4);
            Player target = Main.player[npc.target];
            npc.ai[0]++;
            npc.ai[1]++;
            npc.ai[2]++;
            if (npc.ai[0] == 120)
            {
                switch (projChoice)
                {
                    case 1:
                        chosen = 6;
                        chosen2 = ProjectileID.Fireball;
                        chosen3 = 5;
                        chosen4 = 300;
                        break;
                    case 2:
                        chosen = 2;
                        chosen2 = ProjectileID.LostSoulHostile;
                        chosen3 = 10;
                        chosen4 = 600;
                        break;
                    case 3:
                        chosen = 2;
                        chosen2 = ProjectileID.CursedFlameHostile;
                        chosen3 = 16;
                        chosen4 = 600;
                        break;
                    case 4:
                        chosen = 2;
                        chosen2 = ProjectileID.UnholyTridentHostile;
                        chosen3 = 10;
                        chosen4 = 600;
                        break;
                }
                Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
                direction = direction.RotatedByRandom(MathHelper.ToRadians(10));
                int projectile = Projectile.NewProjectile(npc.Center, direction * chosen, chosen2, chosen3, 0, Main.myPlayer);
                Main.projectile[projectile].timeLeft = chosen4;
                npc.netUpdate = true;
            }

            if (npc.ai[0] > 120 && npc.ai[0] < 149)
            {
                npc.frame.Y = 56;
            }
            if (npc.ai[0] == 150)
            {
                switch (projChoice)
                {
                    case 1:
                        chosen = 6;
                        chosen2 = ProjectileID.Fireball;
                        chosen3 = 5;
                        chosen4 = 300;
                        break;
                    case 2:
                        chosen = 2;
                        chosen2 = ProjectileID.LostSoulHostile;
                        chosen3 = 10;
                        chosen4 = 600;
                        break;
                    case 3:
                        chosen = 2;
                        chosen2 = ProjectileID.CursedFlameHostile;
                        chosen3 = 16;
                        chosen4 = 600;
                        break;
                    case 4:
                        chosen = 2;
                        chosen2 = ProjectileID.UnholyTridentHostile;
                        chosen3 = 10;
                        chosen4 = 600;
                        break;
                }
                Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
                direction = direction.RotatedByRandom(MathHelper.ToRadians(10));
                int projectile = Projectile.NewProjectile(npc.Center, direction * chosen, chosen2, chosen3, 0, Main.myPlayer);
                Main.projectile[projectile].timeLeft = chosen4;
                npc.netUpdate = true;
            }
            if (npc.ai[0] > 150 && npc.ai[0] < 210)
            {
                npc.frame.Y = 112;
            }
            if (npc.ai[0] < 120 || npc.ai[0] > 211)
            {
                npc.dontTakeDamage = false;
                npc.frame.Y = 0;
            }
            else npc.dontTakeDamage = true;
            if (npc.ai[1] > 480)
            {
                npc.position.X = target.Center.X - 64;
                npc.position.Y = target.Center.Y - 64;
                npc.ai[0] = 0;
                npc.ai[1] = 0;
                npc.ai[3]++;
                teleport = 1;
            }
            if (npc.ai[2] > 900)
            {
                npc.ai[0] = 0;
                npc.ai[1] = 0;
                npc.ai[2] = 0;
                npc.ai[3]++;
                teleport = 1;
            }
            if (npc.ai[2] == 5)
            {
                teleport = 0;
            }
            if (npc.ai[3] == 3)
            {
                int random = Main.rand.Next(66, 122);
                npc.ai[3] = 0;
                int flame = NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, ModContent.NPCType<AncientFlame>());
                Main.npc[flame].lifeMax = random;
                Main.npc[flame].life = random;
            }
        }
        public override void OnHitByItem(Player player, Item item, int damage, float knockback, bool crit)
        {
            npc.ai[1] = 0;
        }
        public override void NPCLoot()
        {
            if (!Main.expertMode)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Meteorite, Main.rand.Next(2, 33));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.MeteoriteBar, Main.rand.Next(2, 11));
            }
            if (Main.expertMode)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Mage1TreasureBag"));
            }
            MyWorld.DownedMage1 = true;
        }
    }
}