using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.NPCs
{
    public class Desert1 : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {

            //Random Passive Enemy Drops
            if (npc.type == NPCID.Scorpion)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"));
                }
            }
            if (npc.type == NPCID.ScorpionBlack)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"));
                }
            }
            if (Main.expertMode)
            {
                if (npc.type == NPCID.Scorpion)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ScorpionTail"));
                }
                if (npc.type == NPCID.ScorpionBlack)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ScorpionTail"));
                }
            }
            if (npc.type == NPCID.FlyingAntlion)
            {
                if (Main.rand.Next(39) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TatteredSwarmerWing"));
                }
            }
            if (npc.type == NPCID.FlyingAntlion)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"));
                }
            }
            if (npc.type == NPCID.FlyingAntlion)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"));
                }
            }
            if (npc.type == NPCID.FlyingAntlion)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"));
                }
            }
            if (npc.type == NPCID.Antlion)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"));
                }
            }
            if (npc.type == NPCID.Antlion)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"));
                }
            }
            if (npc.type == NPCID.Antlion)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"));
                }
            }
            if (npc.type == NPCID.WalkingAntlion)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"));
                }
            }
            if (npc.type == NPCID.WalkingAntlion)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"));
                }
            }
            if (npc.type == NPCID.WalkingAntlion)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"));
                }
            }
            if (npc.type == NPCID.Vulture)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"));
                }
            }
            if (npc.type == NPCID.Vulture)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"));
                }
            }
            if (npc.type == NPCID.Vulture)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"));
                }
            }
        }
    }
}




