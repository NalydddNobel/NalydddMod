using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Npcs.Enemies
{
    class WaterMage: ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Mage");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.RuneWizard];
        }
		public override void SetDefaults()
		{
			npc.width = 21;
			npc.height = 31;
			npc.damage = 5;
			npc.defense = 15;
			npc.lifeMax = 3200;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 60f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 8;
			npc.dripping = true;
			aiType = NPCID.RuneWizard;
			animationType = NPCID.RuneWizard;
			banner = Item.NPCtoBanner(NPCID.WanderingEye);
			bannerItem = Item.BannerToItem(banner);
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.Meteor.Chance * 0.22f;
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
	}
}
