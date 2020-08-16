using nalydmod.Items;
using nalydmod.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.NPCs.ItemDrops.Boss
{
    public class GeodeWormDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == mod.NPCType("GeodeWormHead"))    
            {
                if (Main.expertMode == false)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifeFragment"), Main.rand.Next(10, 20));
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DiamondFragment"), Main.rand.Next(10, 20));
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RubyFragment"), Main.rand.Next(15, 25));
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SapphireFragment"), Main.rand.Next(20, 30));
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("EmeraldFragment"), Main.rand.Next(25, 35));
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TopazFragment"), Main.rand.Next(30, 40));
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AmethystFragment"), Main.rand.Next(25, 35));
                }
                if (Main.expertMode == true)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GeodeTreasureBag"));
                }
            }                                                                                             
        }
    }
}




