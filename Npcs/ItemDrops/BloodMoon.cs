using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.NPCs.ItemDrops
{
    public class BloodMoon : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.BloodZombie)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"), Main.rand.Next(3, 17));
            }
            if (npc.type == NPCID.Drippler)
            {
                if (Main.rand.Next(4) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("corrupteyes"));
                }
                if (Main.rand.Next(4) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("crimsoneyes"));
                }
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"), Main.rand.Next(3, 19));
            }
            if (npc.type == NPCID.CorruptBunny)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("corrupteyes"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood2"), Main.rand.Next(3, 8));
            }
            if (npc.type == NPCID.CrimsonBunny)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("crimsoneyes"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood3"), Main.rand.Next(3, 8));
            }
        }
    }
}