using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
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
            npc.aiStyle = -1;
            npc.lifeMax = 100000;
            npc.boss = true;
            music = MusicID.TheTowers;
            musicPriority = MusicPriority.BossMedium;
        }
        public override void AI()
        {
            npc.ai[0]++;
            npc.ai[2]++;
            if (npc.ai[0] < 360)
            {
                npc.position.Y += npc.ai[1] * 0.01f;
                npc.ai[1]++;
            }
            else if (npc.ai[0] < 720)
            {
                npc.position.Y += npc.ai[1] * 0.01f;
                npc.ai[1]--;
            }
            if (npc.ai[0] == 721)
            {
                npc.ai[0] = 0;
            }
            if (npc.ai[1] > 180)
            {
                npc.ai[1] = 180;
            }
            if (npc.ai[1] < -180)
            {
                npc.ai[1] = -180;
            }
            if (MyWorld.LunarPillarPeonsKilled >= 150)
            {
                npc.dontTakeDamage = false;
            }
            else
            {
                npc.dontTakeDamage = true;
            }
            
        }
        private void Talk(string message)
        {
            if (Main.netMode != NetmodeID.Server)
            {
                string text = Language.GetTextValue("The portals lightyears away have opened up", Lang.GetNPCNameValue(npc.type), message);
                Main.NewText(text, Main.DiscoColor);
            }
            else
            {
                NetworkText text = NetworkText.FromKey("The portals lightyears away have opened up", Lang.GetNPCNameValue(npc.type), message);
                NetMessage.BroadcastChatMessage(text, Main.DiscoColor);
            }
        }
        public override void DrawEffects(ref Color drawColor)
        {
            if (Main.rand.Next(7) == 0)
            {
                int dust = Dust.NewDust(npc.position, npc.width - 30, npc.height - 345, 14);
                int dust2 = Dust.NewDust(npc.position, npc.width - 30, npc.height - 345, 125);
                Main.dust[dust].velocity /= 120f;
                Main.dust[dust2].velocity /= 60f;
                Main.dust[dust].scale = 0.8f;
                Main.dust[dust2].scale = 1.2f;
                Main.dust[dust].alpha = 130;
                Main.dust[dust2].alpha = 100;
                Main.dust[dust].noGravity = false;
                Main.dust[dust2].noGravity = false;
            }
        }
        public override bool CheckActive()
        {
            return false;
        }
        public override void BossLoot(ref string name, ref int potionType)
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LunarPillarTreasureBag"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ManaHeart"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ManaHeart"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ManaHeart"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ManaHeart"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ManaHeart"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ManaHeart"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ManaHeart"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ManaHeart"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ManaHeart"));
            potionType = ItemID.SuperHealingPotion;
        }
    }
}