using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Npcs.Enemies.Zombies
{
    class CorruptedZombie : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Corrupted Zombie");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
        }
        public override void SetDefaults()
        {
            npc.width = 18;
            npc.height = 40;
            npc.damage = 45;
            npc.defense = 3;
            npc.lifeMax = 180;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 60f;
            npc.knockBackResist = 0.35f;
            npc.aiStyle = 3;
            npc.dripping = true;
            npc.onFire2 = false;
            aiType = NPCID.AngryBones;
            animationType = NPCID.Zombie;
            banner = Item.NPCtoBanner(NPCID.Zombie);
            bannerItem = Item.BannerToItem(banner);
        }
        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CursedSparks"), Main.rand.Next(0, 4));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood2"), Main.rand.Next(0, 8));
            if (Main.rand.Next(12) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SoulofNight);
            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (Main.dayTime == false)
            {
                return SpawnCondition.Corruption.Chance * 0.3f;
            }
            else return 0;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void HitEffect(int hitDirection, double damage)
        {
            for (int i = 0; i < 10; i++)
            {
                int dustType = 220;
                int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
                Dust dust = Main.dust[dustIndex];
                dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
                dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
                dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
            }
        }
    }
}