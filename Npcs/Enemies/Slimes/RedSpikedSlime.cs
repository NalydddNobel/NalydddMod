using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Npcs.Enemies.Slimes
{
    class RedSpikedSlime : ModNPC
    {
        public override string Texture => "nalydmod/Npcs/Enemies/Slimes/BasicSpikedSlime";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Red Spiked Slime");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.SlimeSpiked];
        }
        public override void SetDefaults()
        {
            npc.CloneDefaults(NPCID.SlimeSpiked);
            aiType = NPCID.SlimeSpiked;
            animationType = NPCID.SlimeSpiked;
            npc.lifeMax = 35;
            npc.damage = 12;
            npc.value = 108;
            npc.defense = 4;
            npc.knockBackResist = 1f;
            npc.color = Color.Red;
            banner = Item.NPCtoBanner(NPCID.RedSlime);
            bannerItem = Item.BannerToItem(banner);
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            bool SlimeOutrage = NPC.downedSlimeKing == true;
            if (SlimeOutrage == true)
            {
                return SpawnCondition.Cavern.Chance * 0.05f;
            }
            else return 0;
        }
    }
}
