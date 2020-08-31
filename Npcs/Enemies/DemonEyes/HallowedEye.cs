using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Npcs.Enemies.DemonEyes
{
    class HallowedEye : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Demon Eye");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.DemonEye];
        }
        public override void SetDefaults()
        {
            npc.width = 38;
            npc.height = 23;
            npc.lifeMax = 188;
            npc.defense = 5;
            npc.damage = 33;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 2222;
            npc.knockBackResist = 0.18f;
            npc.aiStyle = 2;
            npc.dripping = true;
            aiType = NPCID.DemonEye;
            animationType = NPCID.DemonEye;
            banner = Item.NPCtoBanner(NPCID.DemonEye);
            bannerItem = Item.BannerToItem(banner);
            if (Main.hardMode && Main.expertMode && !NPC.downedGolemBoss)
            {
                npc.lifeMax = 244;
                npc.defense = 12;
                npc.damage = 52;
                npc.value = 3333;

            }
            if (Main.hardMode && Main.expertMode && NPC.downedGolemBoss)
            {
                npc.lifeMax = 455;
                npc.defense = 15;
                npc.damage = 77;
                npc.value = 4555;
            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (!Main.dayTime && Main.expertMode)
            {
                return SpawnCondition.OverworldHallow.Chance * 0.3f;
            }
            else return 0;
        }
        public override void NPCLoot()
        {
            if (Main.rand.Next(3) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SpectrumLens"));
            }
            if (NPC.downedGolemBoss)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SpectrumLens"));
            }
        }
        public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ModGore_1"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ModGore_2"), 1f);
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    int dustType = 219;
                    int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
                    Dust dust = Main.dust[dustIndex];
                    dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
                    dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
                    dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
                }
            }
        }
    }
}