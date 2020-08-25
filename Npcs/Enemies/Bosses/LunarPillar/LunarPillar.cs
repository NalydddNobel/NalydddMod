using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Npcs.Enemies.Bosses.LunarPillar
{
    [AutoloadBossHead]
    class LunarPillar : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aequus Pillar");
        }
        public override void SetDefaults()
        {
            npc.CloneDefaults(NPCID.LunarTowerVortex);
            npc.lifeMax = 100000;
            npc.boss = true;
            music = MusicID.TheTowers;
            musicPriority = MusicPriority.BossMedium;
        }
        public override void AI()
        {
            if (MyWorld.LunarPillarPeonsKilled >= 150)
            {
                npc.dontTakeDamage = false;
            }
            else npc.dontTakeDamage = true;
        }
        public override void NPCLoot()
        {
            if (!Main.expertMode)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SolarBar"), Main.rand.Next(0, 25));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("VortexBar"), Main.rand.Next(0, 25));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("NebulaBar"), Main.rand.Next(0, 25));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("StardustBar"), Main.rand.Next(0, 25));
            }
            if (Main.expertMode)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LunarPillarTreasureBag"));
            }
            if (!MyWorld.PostMoonLord2)
            {
                MyWorld.PostMoonLord2 = true;
            }
            MyWorld.PostMoonLord1 = false;
            MyWorld.LunarPillarPeonsKilled = 0;
        }
    }
}