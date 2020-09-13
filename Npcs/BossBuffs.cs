using Microsoft.Xna.Framework;
using nalydmod.Items.BossSummons;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
namespace nalydmod.NPCs
{
    public class BossBuffs : GlobalNPC
    {
        public static int killTimer;
        public static bool buffedEoC;
        public static int buffedEoCTimer;
        public static bool buffedSkeletron;
        public static bool pureHell;
        public static bool bEoC;
        public static bool bSkeletron;
        public override void AI(NPC npc)
        {
            Player target = Main.player[npc.target];
            if (target.dead)
            {
                buffedEoC = false;
                buffedSkeletron = false;
            }
            if (Main.dayTime)
            {
                buffedEoC = false;
                if (buffedSkeletron)
                {
                    pureHell = true;
                }
            }
            //EoC
            if (npc.type == NPCID.EyeofCthulhu)
            {
                if (CCInfEye.itemBuffedEoC)
                {
                    if (!MyWorld.extraBuffedMode)
                    {
                        npc.lifeMax = 235422;
                        npc.life = 235422;
                    }
                    else
                    {
                        npc.lifeMax = 304455;
                        npc.life = 304455;
                    }
                    CCInfEye.itemBuffedEoC = false;
                    buffedEoC = true;
                }
                if (npc.type == NPCID.EyeofCthulhu && buffedEoC)
                {
                    npc.damage = 562;
                    npc.defense = 66;
                    if (npc.ai[2] == 0 && buffedEoCTimer > 0)
                    {
                        int projectile = Projectile.NewProjectile(npc.Center, npc.velocity * 1f, ProjectileID.EyeLaser, 29, 0, Main.myPlayer);
                        Main.projectile[projectile].timeLeft = 1200;
                        Main.projectile[projectile].velocity.Y += 4;
                        Main.projectile[projectile].velocity.X -= buffedEoCTimer;
                        int projectile2 = Projectile.NewProjectile(npc.Center, npc.velocity * 1f, ProjectileID.EyeLaser, 29, 0, Main.myPlayer);
                        Main.projectile[projectile2].timeLeft = 1200;
                        Main.projectile[projectile2].velocity.Y -= 2;
                        Main.projectile[projectile2].velocity.X += buffedEoCTimer;
                        int projectile3 = Projectile.NewProjectile(npc.Center, npc.velocity * 1f, ProjectileID.EyeLaser, 29, 0, Main.myPlayer);
                        Main.projectile[projectile3].timeLeft = 1200;
                        Main.projectile[projectile3].velocity.Y += 2 + buffedEoCTimer;
                        Main.projectile[projectile3].velocity.X += 2 + buffedEoCTimer;
                        int projectile4 = Projectile.NewProjectile(npc.Center, npc.velocity * 1f, ProjectileID.EyeLaser, 29, 0, Main.myPlayer);
                        Main.projectile[projectile4].timeLeft = 1200;
                        Main.projectile[projectile4].velocity.Y += 2;
                        Main.projectile[projectile4].velocity.X -= 2 - buffedEoCTimer;
                        int projectile5 = Projectile.NewProjectile(npc.Center, npc.velocity * 1f, ProjectileID.EyeLaser, 29, 0, Main.myPlayer);
                        Main.projectile[projectile5].timeLeft = 1200;
                        Main.projectile[projectile5].velocity.Y -= 2 + buffedEoCTimer;
                        Main.projectile[projectile5].velocity.X += 2 - buffedEoCTimer;
                        int projectile6 = Projectile.NewProjectile(npc.Center, npc.velocity * 1f, ProjectileID.EyeLaser, 29, 0, Main.myPlayer);
                        Main.projectile[projectile6].timeLeft = 1200;
                        Main.projectile[projectile6].velocity.Y -= 2;
                        Main.projectile[projectile6].velocity.X -= 2 + buffedEoCTimer;
                        int projectile7 = Projectile.NewProjectile(npc.Center, npc.velocity * 1f, ProjectileID.EyeLaser, 29, 0, Main.myPlayer);
                        Main.projectile[projectile7].timeLeft = 1200;
                        Main.projectile[projectile7].velocity.Y -= buffedEoCTimer;
                        Main.projectile[projectile7].velocity.X += 2;
                        int projectile8 = Projectile.NewProjectile(npc.Center, npc.velocity * 1f, ProjectileID.EyeLaser, 29, 0, Main.myPlayer);
                        Main.projectile[projectile8].timeLeft = 1200;
                        Main.projectile[projectile8].velocity.Y += buffedEoCTimer;
                        Main.projectile[projectile8].velocity.X -= 2;
                        Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
                        direction = direction.RotatedByRandom(MathHelper.ToRadians(4));
                        int projectile9 = Projectile.NewProjectile(npc.Center, direction * 6, ProjectileID.PinkLaser, 40, 0, Main.myPlayer);
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
                    if (npc.ai[1] == 0 && buffedEoCTimer == 0)
                    {
                        buffedEoCTimer = 32;
                        Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
                        int projectile = Projectile.NewProjectile(npc.Center, direction * 16, ProjectileID.PhantasmalEye, 22, 0, Main.myPlayer);
                    }
                    if (npc.ai[2] == 0)
                    {
                        buffedEoCTimer = 24;
                    }
                    buffedEoCTimer--;
                    if (buffedEoCTimer < 0)
                    {
                        buffedEoCTimer = 0;
                    }
                    npc.netUpdate = true;
                }
            }
            if (npc.type == NPCID.SkeletronHead && FFInfSkull.itemBuffedSkeletron)
            {
                npc.lifeMax = 4223455;
                npc.life = 4223455;
                npc.damage = 678;
                npc.defense = 66;
                FFInfSkull.itemBuffedSkeletron = false;
                buffedSkeletron = true;
            }
            if (npc.type == NPCID.ServantofCthulhu && buffedEoC)
            {
                npc.damage = 262;
                npc.defense = 60;
            }
        }
            
        public override void OnHitByItem(NPC npc, Player player, Item item, int damage, float knockback, bool crit)
        {
            if (npc.type == NPCID.EyeofCthulhu && buffedEoC && Main.rand.Next(1270) == 0)
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
            if (npc.type == NPCID.EyeofCthulhu && buffedEoC && Main.rand.Next(630) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
            }
        }
        public override void OnHitByProjectile(NPC npc, Projectile projectile, int damage, float knockback, bool crit)
        {
            if (npc.type == NPCID.EyeofCthulhu && buffedEoC && Main.rand.Next(1270) == 0)
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
            if (npc.type == NPCID.EyeofCthulhu && buffedEoC && Main.rand.Next(630) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Heart);
            }
        }
        public override bool PreNPCLoot(NPC npc)
        {
            if (npc.type == NPCID.EyeofCthulhu && buffedEoC)
            {
                return false;
            }
            if (npc.type == NPCID.SkeletronHead && buffedSkeletron)
            {
                return false;
            }
            return true;
        }

        private void Talk(string message)
        {
            if (bEoC)
            {
                if (Main.netMode != NetmodeID.Server)
                {
                    string text = Language.GetTextValue("Eye of Cthulhu has been defeated", message);
                    Main.NewText(text, 255, 0, 255);
                }
                else
                {
                    NetworkText text = NetworkText.FromKey("Eye of Cthulhu has been defeated", message);
                    NetMessage.BroadcastChatMessage(text, new Color(255, 0, 255));
                }
                bEoC = false;
            }
            if (bSkeletron)
            {
                if (Main.netMode != NetmodeID.Server)
                {
                    string text = Language.GetTextValue("Skeletron has been defeated", message);
                    Main.NewText(text, 255, 0, 255);
                }
                else
                {
                    NetworkText text = NetworkText.FromKey("Skeletron has been defeated", message);
                    NetMessage.BroadcastChatMessage(text, new Color(255, 0, 255));
                }
                bSkeletron = false;
            }
        }
        public override bool SpecialNPCLoot(NPC npc)
        {
            if (npc.type == NPCID.EyeofCthulhu && buffedEoC)
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
                bEoC = true;
                Talk("");
                buffedEoC = false;
                return true;
            }
            if (npc.type == NPCID.SkeletronHead && buffedSkeletron)
            {
                if (!pureHell)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("buffedEoCTreasureBag"));
                    buffedSkeletron = false;
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
                }
                if (pureHell)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GoldStar"));
                    buffedSkeletron = false;
                    pureHell = false;
                }
                bSkeletron = true;
                Talk("");
                return true;
            }
            return false;
        }
    }
}