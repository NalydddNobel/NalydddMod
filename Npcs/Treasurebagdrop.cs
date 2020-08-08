using nalydmod.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.NPCs
{
    public class NpcDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {



                    if (Main.expertMode) //Cultist
                    {
                        if (npc.type == NPCID.CultistBoss)   //this is where you choose the npc you want
                        {
                             //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                            
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Nalydwings"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                            }
                            
                        }
                        if (Main.expertMode) //SolarPillar
                        {
                            if (npc.type == NPCID.LunarTowerSolar)   //this is where you choose the npc you want
                            {
                                if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                                {
                                    {
                                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SolarBar"), 5); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                                    }
                                }
                            }
                            if (npc.type == NPCID.LunarTowerSolar)   //this is where you choose the npc you want
                            {
                                if (Main.rand.Next(4) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                                {
                                    {
                                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SolarBar"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                                    }
                                }
                            }
                            if (npc.type == NPCID.LunarTowerSolar)   //this is where you choose the npc you want
                            {
                                if (Main.rand.Next(8) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                                {
                                    {
                                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SolarBar"), 1);//this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                                    }
                                }
                            }
                            if (Main.expertMode) //Golem
                            {
                                if (npc.type == NPCID.Golem)   //this is where you choose the npc you want
                                {
                                    if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                                    {
                                        {
                                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SolarBar"), 2); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                                        }
                                    }
                                }
                                if (npc.type == NPCID.GolemFistLeft)   //this is where you choose the npc you want
                                {
                                    if (Main.rand.Next(2) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                                    {
                                        {
                                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SolarBar"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                                        }
                                    }
                                }
                                if (npc.type == NPCID.GolemFistRight)   //this is where you choose the npc you want
                                {
                                    if (Main.rand.Next(2) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                                    {
                                        {
                                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SolarBar"), 1);//this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                                        }
                                    }
                                }
                            }
                        }
                    }
               
            
        }
    }
}




