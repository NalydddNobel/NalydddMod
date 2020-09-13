using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Npcs.Enemies.Bosses.WaterMage
{
    [AutoloadBossHead]
    class AncientFlame : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 4;
        }
        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 32;
            npc.npcSlots = 0.5f;
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

        }
        public override void AI()
        {

        }
    }
}