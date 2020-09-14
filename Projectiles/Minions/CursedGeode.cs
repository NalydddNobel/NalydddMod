using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Projectiles.Minions
{
    public class CursedGeode : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true;
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
            ProjectileID.Sets.Homing[projectile.type] = true;
        }
        public override void SetDefaults()
        {
            projectile.netImportant = true;
            projectile.width = 32;
            projectile.height = 24;
            projectile.friendly = true;
            projectile.minion = true;
            projectile.netImportant = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 18000;
            projectile.ignoreWater = true;
        }
        public override bool? CanCutTiles()
        {
            return false;
        }

        bool start;
        float red;
        float green;
        float blue;
        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            MyPlayer modPlayer = player.GetModPlayer<MyPlayer>();
            Vector2 idlePosition = player.Center;
            if (player.dead || modPlayer.smallSummon > modPlayer.maxSmallSummon)
            {
                modPlayer.bloodSkull = false;
            }
            if (modPlayer.bloodSkull)
            {
                projectile.timeLeft = 2;
            }
            float minionPositionOffsetX = (10 + projectile.minionPos * 40) * -player.direction;
            idlePosition.X += minionPositionOffsetX;
            Vector2 vectorToIdlePosition = idlePosition - projectile.Center;
            float distanceToIdlePosition = vectorToIdlePosition.Length();
            if (Main.myPlayer == player.whoAmI && distanceToIdlePosition > 2000f)
            {
                projectile.position = idlePosition;
                projectile.velocity *= 0.1f;
                projectile.netUpdate = true;
            }
            float distanceFromTarget = 700f;
            Vector2 targetCenter = projectile.position;
            bool foundTarget = false;
            if (player.HasMinionAttackTargetNPC)
            {
                NPC npc = Main.npc[player.MinionAttackTargetNPC];
                float between = Vector2.Distance(npc.Center, projectile.Center);
                if (between < 2000f)
                {
                    distanceFromTarget = between;
                    targetCenter = npc.Center;
                    foundTarget = true;
                }
            }
            if (!foundTarget)
            {
                for (int i = 0; i < Main.maxNPCs; i++)
                {
                    NPC npc = Main.npc[i];
                    if (npc.CanBeChasedBy())
                    {
                        float between = Vector2.Distance(npc.Center, projectile.Center);
                        bool closest = Vector2.Distance(projectile.Center, targetCenter) > between;
                        bool inRange = between < distanceFromTarget;
                        bool lineOfSight = Collision.CanHitLine(projectile.position, projectile.width, projectile.height, npc.position, npc.width, npc.height);
                        bool closeThroughWall = between < 100f;
                        if (((closest && inRange) || !foundTarget) && (lineOfSight || closeThroughWall))
                        {
                            distanceFromTarget = between;
                            targetCenter = npc.Center;
                            foundTarget = true;
                        }
                    }
                }
            }
            projectile.frameCounter++;
            if (projectile.velocity.X != 0 && projectile.frameCounter == 4)
            {
                projectile.frame += 1;
            }
            else if (projectile.frameCounter >= 24)
            {
                projectile.frameCounter = 0;
                projectile.frame += 2;
            }
            if (projectile.frame >= Main.projFrames[projectile.type])
            {
                projectile.frame = 0;
            }
            if (projectile.velocity.X > 0)
            {

            }
            if (!start)
            {
                red = 0.5f;
                green = 0.5f;
                blue = 0.5f;
                start = true;
            }
            else
            {
                {
                    if (red > 1.5)
                    {
                        red = 1.5f;
                    }
                    red += Main.rand.Next(-1, 2) * 0.01f;
                }
                {
                    if (green > 1.5)
                    {
                        green = 1.5f;
                    }
                    green += Main.rand.Next(-1, 2) * 0.01f;
                }
                {
                    if (blue > 1.5)
                    {
                        blue = 1.5f;
                    }
                    blue += Main.rand.Next(-1, 2) * 0.01f;
                }
            }
            Lighting.AddLight((int)(projectile.position.X / 16f), (int)(projectile.position.Y / 16f), red, green, blue);
        }
    }
}