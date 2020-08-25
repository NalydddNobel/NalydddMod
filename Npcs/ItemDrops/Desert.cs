using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.NPCs.ItemDrops
{
    public class Desert1 : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.Scorpion || npc.type == NPCID.ScorpionBlack)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"));
                }
            }
            if (Main.expertMode)
            {
                if (npc.type == NPCID.Scorpion || npc.type == NPCID.ScorpionBlack)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ScorpionTail"));
                }
            }
            if (npc.type == NPCID.FlyingAntlion)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"), Main.rand.Next(0, 3));
                if (Main.rand.Next(39) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TatteredSwarmerWing"));
                }
            }
            if (npc.type == NPCID.Antlion)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"), Main.rand.Next(0, 3));
            }
            if (npc.type == NPCID.WalkingAntlion)
            { 
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"), Main.rand.Next(0, 3));
            }
            if (npc.type == NPCID.Vulture)
            {               
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"), Main.rand.Next(0, 3));               
            }
        }
    }
}