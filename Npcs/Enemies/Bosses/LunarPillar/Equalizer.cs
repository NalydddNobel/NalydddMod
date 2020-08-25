using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Npcs.Enemies.Bosses.LunarPillar
{
    class Equalizer : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
        }
        public override void SetDefaults()
        {
            npc.width = 18;
            npc.height = 40;
            npc.damage = 112;
            npc.defense = 22;
            npc.lifeMax = 3304;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 60;
            npc.knockBackResist = 0.35f;
            npc.aiStyle = 3;
            npc.dripping = true;
            npc.onFire2 = false;
            aiType = NPCID.AngryBones;
            animationType = NPCID.Zombie;
            banner = Item.NPCtoBanner(NPCID.Zombie);
            bannerItem = Item.BannerToItem(banner);
        }
        public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                MyWorld.LunarPillarPeonsKilled = MyWorld.LunarPillarPeonsKilled + 1;
            }
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
        public override void NPCLoot()
        {
            MyWorld.LunarPillarPeonsKilled += 1;
            Item.NewItem(npc.getRect(), ItemID.Bunny);
        }
    }
}