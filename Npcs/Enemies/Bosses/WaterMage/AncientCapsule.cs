using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
namespace nalydmod.Npcs.Enemies.Bosses.WaterMage
{
    [AutoloadBossHead]
    class AncientCapsule : ModNPC
    {
        public override void SetDefaults()
        {
            npc.width = 64;
            npc.height = 32;
            npc.npcSlots = 4;
            npc.lifeMax = 100;
            npc.defense = 20;
            npc.HitSound = SoundID.NPCHit15;
            npc.DeathSound = SoundID.NPCDeath43;
            npc.knockBackResist = 0;
            npc.aiStyle = -1;
        }
        public override void PostDraw(SpriteBatch spriteBatch, Color drawColor)
        {
            Texture2D texture = mod.GetTexture("Npcs/Enemies/Bosses/WaterMage/AncientCapsuleGlow");
            spriteBatch.Draw
            (
                texture,
                new Vector2
                (
                    npc.position.X - Main.screenPosition.X,
                    npc.position.Y - Main.screenPosition.Y + 4
                ),
                new Rectangle(0, 0, texture.Width, texture.Height),
                Color.White
            );
        }
        public override void DrawEffects(ref Color drawColor)
        {
            Lighting.AddLight(npc.position, 0f, 0.5f, 0f);
        }
        public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("AncientMage"));
            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (!NPC.AnyNPCs(mod.NPCType("WaterMage")) && !NPC.AnyNPCs(mod.NPCType("AncientCapsule")))
            {
                if (NPC.downedBoss2 && !MyWorld.DownedMage1)
                {
                    return SpawnCondition.Meteor.Chance * 0.25f;
                }
                else return SpawnCondition.Meteor.Chance * 0.0096f;
            }
            else return 0;
        }
        public override void AI()
        {
            if (npc.ai[0] < 1)
            {
                if (Main.netMode != NetmodeID.Server)
                {
                    string text = Language.GetTextValue("A suspious looking capsule appears nearby...", Lang.GetNPCNameValue(npc.type));
                    Main.NewText(text, 171, 64, 255);
                }
                else
                {
                    NetworkText text = NetworkText.FromKey("A suspious looking capsule appears nearby the meteorite...", Lang.GetNPCNameValue(npc.type));
                    NetMessage.BroadcastChatMessage(text, new Color(171, 64, 255));
                }
                npc.ai[0]++;
            }
            if (Main.rand.Next(6) == 0)
            {
                int dust = Dust.NewDust(npc.position * Main.rand.Next(1, 2), npc.width, npc.height, mod.DustType("AncientDust"));
                Main.dust[dust].scale = Main.rand.Next(6, 12) * .1f;
                Main.dust[dust].velocity.X *= (Main.rand.Next(-2, 2) - npc.life) * .1f;
                Main.dust[dust].velocity.Y = -npc.life * .1f;
                Main.dust[dust].alpha = 130;
            }
        }
    }
}