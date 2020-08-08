using IL.Terraria.GameContent.Biomes;
using nalydmod.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;

namespace nalydmod.NPCs
{
    public class Desert1 : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {

            //Random Passive Enemy Drops

            if (Main.expertMode)
            {
                if (npc.type == NPCID.Scorpion)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ScorpionTail"));
                }
            }
        }
    }
}




