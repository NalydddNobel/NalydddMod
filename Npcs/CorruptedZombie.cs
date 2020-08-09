using nalydmod.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.NPCs
{
    public class CorruptedZombie : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == mod.NPCType("CorruptedZombie"))
            {
                if (Main.rand.Next(19) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SoulofCrime"));
                }
                if (Main.rand.Next(39) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.CursedFlames);
                }
                if (Main.rand.Next(29) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SoulofNight);
                }
            }
        }
    }
}




