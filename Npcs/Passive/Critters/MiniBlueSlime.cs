using Steamworks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Npcs.Enemies.DemonEyes
{
	class MiniBlueSlime : ModNPC
	{
		public override string Texture => "nalydmod/Npcs/Passive/Critters/MiniSlime";
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mini Slime");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
		}
		public override void SetDefaults()
		{
			npc.scale = 1.05f;
			npc.color = Colors.RarityBlue;
			npc.npcSlots = 0.5f;
			npc.catchItem = (short)mod.ItemType("MiniBlueSlimeItem");
			npc.friendly = true;
			npc.width = 12;
			npc.height = 12;
			npc.damage = 0;
			npc.defense = 0;
			npc.lifeMax = 5;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 0f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 1;
			npc.dripping = true;
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
		}
		public override bool? CanBeHitByItem(Player player, Item item)
		{
			return true;
		}
		public override bool? CanBeHitByProjectile(Projectile projectile)
		{
			return true;
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (Main.dayTime == true)
            {
				return SpawnCondition.TownCritter.Chance * 0.18f;
			}
			else return SpawnCondition.TownCritter.Chance * 0f;
		}
	}
}
