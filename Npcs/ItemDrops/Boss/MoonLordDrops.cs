using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
namespace nalydmod.NPCs.ItemDrops.Boss
{
    public class MoonLordDrops : GlobalNPC
    {
        private void Talk(string message)
        {
            if (Main.netMode != NetmodeID.Server)
            {
                string text = Language.GetTextValue("Creatures of infection are invading", message);
                Main.NewText(text, 255, 0, 255);
            }
            else
            {
                NetworkText text = NetworkText.FromKey("Creatures of infection are invading", message);
                NetMessage.BroadcastChatMessage(text, new Color(255, 0, 255));
            }
        }
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.MoonLordCore)
            {
                if (Main.expertMode == false)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"), (int)Main.rand.NextFloat(5, 12));
                }
                if (Main.expertMode == true)
                {
                    if (!MyWorld.pillarAequusInvasion)
                    {
                        Talk("");
                    }
                    MyWorld.pillarAequusInvasion = true;
                    MyWorld.LunarPillarPeonsKilled = 0;
                }
            }
        }
    }
}