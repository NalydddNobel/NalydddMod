using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
namespace nalydmod.Npcs.Enemies.Bosses.WaterMage
{
    [AutoloadBossHead]
    class WaterMage : ModNPC
    {
        static int phase;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Mage");
            Main.npcFrameCount[npc.type] = 3;
        }
        public override void SetDefaults()
        {
            npc.width = 40;
            npc.height = 54;
            npc.damage = 20;
            npc.defense = 15;
            npc.lifeMax = 606;
            npc.boss = true;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.teleporting = true;
            npc.value = 60f;
            npc.knockBackResist = 0.22f;
            music = MusicID.Boss1;
        }     
        public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore15"), Main.rand.Next(8, 16) * 0.5f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore15"), Main.rand.Next(7, 12) * 0.5f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore15"), Main.rand.Next(5, 10) * 0.5f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore15"), Main.rand.Next(4, 8) * 0.1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore15"), Main.rand.Next(2, 6) * 0.1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore15"), Main.rand.Next(2, 4) * 0.1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore13"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore14"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore12"), 1f);
            }
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
            if (npc.ai[0] < 1)
            {
                if (Main.netMode != NetmodeID.Server)
                {
                    string text = Language.GetTextValue("Ancient Mage has awoken", Lang.GetNPCNameValue(npc.type));
                    Main.NewText(text, 171, 64, 255);
                }
                else
                {
                    NetworkText text = NetworkText.FromKey("Ancient Mage has awoken", Lang.GetNPCNameValue(npc.type));
                    NetMessage.BroadcastChatMessage(text, new Color(171, 64, 255));
                }
                npc.ai[0]++;
            }
            if (npc.ai[0] < 2)
            {
                npc.velocity.Y--;
                if (npc.velocity.Y < -12)
                {
                    npc.ai[0]++;
                }
            }
        }
        public override void OnHitByItem(Player player, Item item, int damage, float knockback, bool crit)
        {
            npc.ai[1] = 0;
        }
        public override void NPCLoot()
        {
            if (!Main.expertMode)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Meteorite, Main.rand.Next(2, 33));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.MeteoriteBar, Main.rand.Next(2, 11));
            }
            if (Main.expertMode)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Mage1TreasureBag"));
            }
            MyWorld.DownedMage1 = true;
        }
    }
}