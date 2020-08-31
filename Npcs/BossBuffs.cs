using Microsoft.Xna.Framework;
using nalydmod.Items.BossSummons;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.NPCs.ItemDrops
{
    public class BossBuffs : GlobalNPC
    {
        public static bool BuffedEoC;
        public static int BuffedEoCTimer;
        public static bool buffedSkeletron;
        public override void AI(NPC npc)
        {
            if (npc.type == NPCID.EyeofCthulhu && InfEye.buffedEoC)
            {
                npc.lifeMax = 175422;
                npc.life = 175422;
                npc.damage = 562;
                npc.defense = 40;
                InfEye.buffedEoC = false;
                BuffedEoC = true;
            }
            if (npc.type == NPCID.ServantofCthulhu && BuffedEoC)
            {
                npc.lifeMax = 75422;
                npc.life = 75422;
                npc.damage = 262;
                npc.defense = 60;
            }
            if (npc.type == NPCID.EyeofCthulhu && BuffedEoC)
            {
                if (npc.ai[2] == 0 && BuffedEoCTimer > 0)
                {
                    int projectile = Projectile.NewProjectile(npc.Center, npc.velocity * 1f, ProjectileID.EyeLaser, 29, 0, Main.myPlayer);
                    Main.projectile[projectile].timeLeft = 1200;
                    Main.projectile[projectile].velocity.Y += 4;
                    Main.projectile[projectile].velocity.X -= BuffedEoCTimer;
                    int projectile2 = Projectile.NewProjectile(npc.Center, npc.velocity * 1f, ProjectileID.EyeLaser, 29, 0, Main.myPlayer);
                    Main.projectile[projectile2].timeLeft = 1200;
                    Main.projectile[projectile2].velocity.Y -= 2;
                    Main.projectile[projectile2].velocity.X += BuffedEoCTimer;
                    int projectile3 = Projectile.NewProjectile(npc.Center, npc.velocity * 1f, ProjectileID.EyeLaser, 29, 0, Main.myPlayer);
                    Main.projectile[projectile3].timeLeft = 1200;
                    Main.projectile[projectile3].velocity.Y += 2 + BuffedEoCTimer;
                    Main.projectile[projectile3].velocity.X += 2 + BuffedEoCTimer;
                    int projectile4 = Projectile.NewProjectile(npc.Center, npc.velocity * 1f, ProjectileID.EyeLaser, 29, 0, Main.myPlayer);
                    Main.projectile[projectile4].timeLeft = 1200;
                    Main.projectile[projectile4].velocity.Y += 2;
                    Main.projectile[projectile4].velocity.X -= 2 - BuffedEoCTimer;
                    int projectile5 = Projectile.NewProjectile(npc.Center, npc.velocity * 1f, ProjectileID.EyeLaser, 29, 0, Main.myPlayer);
                    Main.projectile[projectile5].timeLeft = 1200;
                    Main.projectile[projectile5].velocity.Y -= 2 + BuffedEoCTimer;
                    Main.projectile[projectile5].velocity.X += 2 - BuffedEoCTimer;
                    int projectile6 = Projectile.NewProjectile(npc.Center, npc.velocity * 1f, ProjectileID.EyeLaser, 29, 0, Main.myPlayer);
                    Main.projectile[projectile6].timeLeft = 1200;
                    Main.projectile[projectile6].velocity.Y -= 2;
                    Main.projectile[projectile6].velocity.X -= 2 + BuffedEoCTimer;
                    int projectile7 = Projectile.NewProjectile(npc.Center, npc.velocity * 1f, ProjectileID.EyeLaser, 29, 0, Main.myPlayer);
                    Main.projectile[projectile7].timeLeft = 1200;
                    Main.projectile[projectile7].velocity.Y -= BuffedEoCTimer;
                    Main.projectile[projectile7].velocity.X += 2;
                    int projectile8 = Projectile.NewProjectile(npc.Center, npc.velocity * 1f, ProjectileID.EyeLaser, 29, 0, Main.myPlayer);
                    Main.projectile[projectile8].timeLeft = 1200;
                    Main.projectile[projectile8].velocity.Y += BuffedEoCTimer;
                    Main.projectile[projectile8].velocity.X -= 2;
                    Player target = Main.player[npc.target];
                    Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
                    direction = direction.RotatedByRandom(MathHelper.ToRadians(4));
                    int projectile9 = Projectile.NewProjectile(npc.Center, direction * 6, ProjectileID.PinkLaser, 68, 0, Main.myPlayer);
                    Vector2 direction2 = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
                    direction2 = direction2.RotatedByRandom(MathHelper.ToRadians(2.53f));
                    int projectile10 = Projectile.NewProjectile(npc.Center, direction * 9, ProjectileID.EyeLaser, 35, 0, Main.myPlayer);
                    Main.projectile[projectile10].timeLeft = 1200;
                    Main.projectile[projectile10].velocity.Y += Main.rand.Next(-3, 3);
                    Main.projectile[projectile10].velocity.X -= Main.rand.Next(-3, 3);
                    npc.netUpdate = true;
                    direction2 = direction2.RotatedByRandom(MathHelper.ToRadians(1.23f));
                    int projectile11 = Projectile.NewProjectile(npc.Center, direction * 9, ProjectileID.EyeLaser, 35, 0, Main.myPlayer);
                    Main.projectile[projectile11].timeLeft = 1200;
                    Main.projectile[projectile11].velocity.Y += Main.rand.Next(-4, 4);
                    Main.projectile[projectile11].velocity.X -= Main.rand.Next(-4, 4);
                    npc.netUpdate = true;
                    direction2 = direction2.RotatedByRandom(MathHelper.ToRadians(2.53f));
                    int projectile12 = Projectile.NewProjectile(npc.Center, direction * 9, ProjectileID.EyeLaser, 35, 0, Main.myPlayer);
                    Main.projectile[projectile12].timeLeft = 1200;
                    Main.projectile[projectile12].velocity.Y += Main.rand.Next(-5, 5);
                    Main.projectile[projectile12].velocity.X -= Main.rand.Next(-5, 5);
                    npc.netUpdate = true;
                    direction2 = direction2.RotatedByRandom(MathHelper.ToRadians(1.23f));
                    int projectile13 = Projectile.NewProjectile(npc.Center, direction * 9, ProjectileID.EyeLaser, 35, 0, Main.myPlayer);
                    Main.projectile[projectile13].timeLeft = 1200;
                    Main.projectile[projectile13].velocity.Y += Main.rand.Next(-6, 6);
                    Main.projectile[projectile13].velocity.X -= Main.rand.Next(-6, 6);
                }
                if (npc.ai[1] == 0 && BuffedEoCTimer == 0)
                {
                    BuffedEoCTimer = 32;
                    Player target = Main.player[npc.target];
                    Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
                    int projectile = Projectile.NewProjectile(npc.Center, direction * 16, ProjectileID.PhantasmalEye, 68, 0, Main.myPlayer);
                }
                if (npc.ai[2] == 0)
                {
                    BuffedEoCTimer = 24;
                }
                BuffedEoCTimer--;
                if (BuffedEoCTimer < 0)
                {
                    BuffedEoCTimer = 0;
                }
                npc.netUpdate = true;
            }
        }
        public override void OnHitByItem(NPC npc, Player player, Item item, int damage, float knockback, bool crit)
        {
            if (npc.type == NPCID.EyeofCthulhu && BuffedEoC && Main.rand.Next(63) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
            }
            if (npc.type == NPCID.EyeofCthulhu && BuffedEoC && Main.rand.Next(4) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
            }
        }
        public override void OnHitByProjectile(NPC npc, Projectile projectile, int damage, float knockback, bool crit)
        {
            if (npc.type == NPCID.EyeofCthulhu && BuffedEoC && Main.rand.Next(63) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
            }
            if (npc.type == NPCID.EyeofCthulhu && BuffedEoC && Main.rand.Next(9) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
            }
        }
        public override bool PreNPCLoot(NPC npc)
        {
            if (npc.type == NPCID.EyeofCthulhu && BuffedEoC)
            {
                return false;
            }
            else return true;
        }
        public override bool SpecialNPCLoot(NPC npc)
        {
            if (npc.type == NPCID.EyeofCthulhu && BuffedEoC)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("buffedEoCTreasureBag"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SuperHealingPotion, Main.rand.Next(15, 30));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
                }
                if (!MyWorld.DownedEoC2)
                {
                    MyWorld.DownedEoC2 = true;
                }
                BuffedEoC = false;
                return true;
            }
            else return false;
        }
    }
}