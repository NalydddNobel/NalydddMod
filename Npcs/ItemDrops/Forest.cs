using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.NPCs.ItemDrops
{
    public class Forest1 : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.Guide)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"), Main.rand.Next(0, 5));
            }
            if (npc.type == NPCID.Merchant)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GoldCoin, Main.rand.Next(0, 3));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"), Main.rand.Next(0, 5));
            }
            if (npc.type == NPCID.Squirrel || npc.type == NPCID.SquirrelRed || npc.type == NPCID.Bunny || npc.type == NPCID.BunnySlimed || npc.type == NPCID.BunnyXmas || npc.type == NPCID.PartyBunny || npc.type == NPCID.Bird || npc.type == NPCID.BirdRed || npc.type == NPCID.BirdBlue)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SquirrelGold)
            {

            }
            if (npc.type == NPCID.BunnySlimed)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel);
                }
            }
            if (npc.type == NPCID.GoldBunny)
            {

            }
            if (npc.type == NPCID.GoldBird)
            {

            }
            if (npc.type == NPCID.Worm || npc.type == NPCID.Goldfish)
            {
                if (Main.rand.Next(4) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood"));
                }
            }
            if (npc.type == NPCID.GoldWorm)
            {

            }
        }
    }
}