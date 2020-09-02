using Microsoft.Xna.Framework;
using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Npcs.Enemies.Bosses.WaterMage
{
    [AutoloadBossHead]
    class AncientFlame : ModNPC
    {
        public int rotateTimer;
        public int rotateX;
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 4;
        }
        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 32;
            npc.npcSlots = 4;
            npc.lifeMax = 100;
            npc.damage = 20;
            npc.defense = 22;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.teleporting = true;
            npc.value = 60f;
            npc.knockBackResist = 0.22f;
            music = MusicID.Boss1;
        }
        public override void HitEffect(int hitDirection, double damage)
        {
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
            Player target = Main.player[npc.target];
            npc.ai[0]++;
            npc.ai[1]++;
            npc.ai[2]++;
            npc.position.X = WaterMage.posWaterMageX + rotateX;
            npc.position.Y = WaterMage.posWaterMageY + rotateX;
            if (npc.ai[0] >= 1)
            {
                npc.ai[0] = 0;
                rotateTimer++;
            }
            if (rotateTimer < 360)
            {
                npc.position.X += rotateX * 0.01f;
                rotateX++;
            }
            else if (rotateTimer < 720)
            {
                npc.position.X += rotateX * 0.01f;
                rotateX--;
            }
            if (rotateTimer == 721)
            {
                npc.ai[0] = 0;
            }
            if (rotateX > 180)
            {
                rotateX = 180;
            }
            if (rotateX < -180)
            {
                rotateX = -180;
            }
            if (WaterMage.teleport == 1)
            {
                int dust = Dust.NewDust(npc.position, npc.width, npc.height, DustID.Fire);
                int dust2 = Dust.NewDust(npc.position, npc.width, npc.height, DustID.Fire);
                Main.dust[dust].velocity /= 120f;
                Main.dust[dust2].velocity /= 60f;
                Main.dust[dust].scale = 0.5f;
                Main.dust[dust2].scale = 0.75f;
                Main.dust[dust].color.G = 255;
                Main.dust[dust2].color.G = 255;
                Main.dust[dust].color.R = 0;
                Main.dust[dust2].color.R = 0;
                Main.dust[dust].color.B = 0;
                Main.dust[dust2].color.B = 0;
                Main.dust[dust].alpha = 130;
                Main.dust[dust2].alpha = 100;
                npc.rotation = (float)Math.Atan2(npc.velocity.Y, npc.velocity.X) + 1.57f;
            }
            if (npc.ai[1] > 2)
            {
                npc.ai[1] = 0;
                int dust = Dust.NewDust(npc.position, npc.width, npc.height, DustID.Fire);
                int dust2 = Dust.NewDust(npc.position, npc.width, npc.height, DustID.Fire);
                Main.dust[dust].velocity /= 120f;
                Main.dust[dust2].velocity /= 60f;
                Main.dust[dust].scale = 0.5f;
                Main.dust[dust2].scale = 0.75f;
                Main.dust[dust].color.G = 255;
                Main.dust[dust2].color.G = 255;
                Main.dust[dust].color.R = 0;
                Main.dust[dust2].color.R = 0;
                Main.dust[dust].color.B = 0;
                Main.dust[dust2].color.B = 0;
                Main.dust[dust].alpha = 130;
                Main.dust[dust2].alpha = 100;
                npc.rotation = (float)Math.Atan2(npc.velocity.Y, npc.velocity.X) + 1.57f;
            }
            if (npc.ai[2] < 25)
            {
                npc.frame.Y += 34;
                npc.ai[2] = 0;
            }
            if (npc.frame.Y < 102)
            {
                npc.frame.Y = 0;
            }
            if (!NPC.AnyNPCs(mod.NPCType("WaterMage")))
            {
                npc.active = false;
            }
        }
    }
}