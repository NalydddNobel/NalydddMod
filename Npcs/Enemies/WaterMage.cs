using Microsoft.Xna.Framework;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using nalydmod.Npcs;
using static Terraria.ModLoader.ModContent;
using System.Threading;
using Terraria.ModLoader.Config;
using System;

namespace nalydmod.Npcs.Enemies
{
    class WaterMage: ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Mage");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Necromancer];
        }
		public override void SetDefaults()
		{
			aiType = NPCID.RuneWizard;
			animationType = NPCID.RuneWizard;
			npc.width = 21;
			npc.height = 31;
			npc.damage = 20;
			npc.defense = 15;
			npc.lifeMax = 606;
			npc.boss = true;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 60f;
			npc.knockBackResist = 0.22f;
			npc.aiStyle = 8;
			npc.dripping = true;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = true;
			npc.buffImmune[BuffID.Slimed] = true;
			npc.buffImmune[BuffID.OnFire] = true;
			npc.buffImmune[BuffID.CursedInferno] = true;
			npc.teleportStyle = 2;
			banner = Item.NPCtoBanner(NPCID.RuneWizard);
			bannerItem = Item.BannerToItem(banner);
			music = MusicID.Boss1;
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
			bool alreadySpawned = Terraria.NPC.AnyNPCs(mod.NPCType("WaterMage"));
			if (alreadySpawned == false)
			{
				bool MagicAttract = NPC.downedBoss2 = true;
				if (MagicAttract == true)
				{
					return SpawnCondition.Meteor.Chance * 0.2f;
				}
				else return SpawnCondition.Meteor.Chance * 0.0096f;
			}
			else return 0;

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
			{
				if (Main.rand.Next(1899) == 0)
				{
					Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
					direction = direction.RotatedByRandom(MathHelper.ToRadians(10));

					int projectile = Projectile.NewProjectile(npc.Center, direction * 6, ProjectileID.Fireball, 5, 0, Main.myPlayer);
					Main.projectile[projectile].timeLeft = 300;
					npc.netUpdate = true;
				}
				if (Main.rand.Next(1799) == 0)
				{
					Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
					direction = direction.RotatedByRandom(MathHelper.ToRadians(10));

					int projectile = Projectile.NewProjectile(npc.Center, direction * 12, ProjectileID.CultistBossIceMist, 10, 0, Main.myPlayer);
					Main.projectile[projectile].timeLeft = 300;
					npc.netUpdate = true;
				}
				if (Main.rand.Next(1549) == 0)
				{
					Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
					direction = direction.RotatedByRandom(MathHelper.ToRadians(10));

					int projectile = Projectile.NewProjectile(npc.Center, direction * 2, ProjectileID.LostSoulHostile, 10, 0, Main.myPlayer);
					Main.projectile[projectile].timeLeft = 600;
					npc.netUpdate = true;
				}
				if (Main.rand.Next(1599) == 0)
				{
					Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
					direction = direction.RotatedByRandom(MathHelper.ToRadians(10));

					int projectile = Projectile.NewProjectile(npc.Center, direction * 2, ProjectileID.CursedFlameHostile, 10, 0, Main.myPlayer);
					Main.projectile[projectile].timeLeft = 600;
					npc.netUpdate = true;
				}
				if (Main.rand.Next(1599) == 0)
				{
					Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
					direction = direction.RotatedByRandom(MathHelper.ToRadians(10));

					int projectile = Projectile.NewProjectile(npc.Center, direction * 3, ProjectileID.GoldenShowerHostile, 5, 0, Main.myPlayer);
					Main.projectile[projectile].timeLeft = 600;
					npc.netUpdate = true;
				}
				if (Main.rand.Next(1599) == 0)
				{
					Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
					direction = direction.RotatedByRandom(MathHelper.ToRadians(10));

					int projectile = Projectile.NewProjectile(npc.Center, direction * 3, ProjectileID.InfernoHostileBolt, 10, 0, Main.myPlayer);
					Main.projectile[projectile].timeLeft = 600;
					npc.netUpdate = true;
				}
				if (Main.rand.Next(1599) == 0)
				{
					Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
					direction = direction.RotatedByRandom(MathHelper.ToRadians(10));

					int projectile = Projectile.NewProjectile(npc.Center, direction * 3, ProjectileID.SandnadoHostile, 10, 0, Main.myPlayer);
					Main.projectile[projectile].timeLeft = 1200;
					npc.netUpdate = true;
				}
				if (Main.rand.Next(1899) == 0)
				{
					Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
					direction = direction.RotatedByRandom(MathHelper.ToRadians(10));

					int projectile = Projectile.NewProjectile(npc.Center, direction * 3, ProjectileID.UnholyTridentHostile, 20, 0, Main.myPlayer);
					Main.projectile[projectile].timeLeft = 1200;
					npc.netUpdate = true;
				}
			}
		}
	}
}
