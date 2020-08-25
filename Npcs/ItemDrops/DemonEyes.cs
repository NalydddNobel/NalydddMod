using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.NPCs.ItemDrops
{
    public class DemonEyes : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.DemonEye || npc.type == NPCID.DemonEye2 || npc.type == NPCID.CataractEye || npc.type == NPCID.CataractEye2 || npc.type == NPCID.DemonEyeOwl || npc.type == NPCID.DemonEyeSpaceship || npc.type == NPCID.DialatedEye || npc.type == NPCID.DialatedEye2 || npc.type == NPCID.GreenEye || npc.type == NPCID.GreenEye2 || npc.type == NPCID.PurpleEye || npc.type == NPCID.PurpleEye2 || npc.type == NPCID.SleepyEye || npc.type == NPCID.SleepyEye2 || npc.type == mod.NPCType("BlackEye") || npc.type == mod.NPCType("OpenEye"))
            {
                if (Main.rand.Next(9) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("crimsoneyes"));
                }
                if (Main.rand.Next(9) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("corrupteyes"));
                }
            }
            if (npc.type == mod.NPCType("BlackEye") || npc.type == mod.NPCType("OpenEye") || npc.type == mod.NPCType("HallowedEye"))
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Lens);
                }
                if (Main.rand.Next(98) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.BlackLens);
                }
            }
            if (npc.type == mod.NPCType("HallowedEye"))
            {
                if (Main.expertMode && Main.rand.Next(5) == 0)
                {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SpectrumLens"));
                }
            }
        }
    }
}