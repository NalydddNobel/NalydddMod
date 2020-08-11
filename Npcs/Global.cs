using IL.Terraria.GameContent.Biomes;
using nalydmod.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;

namespace nalydmod.NPCs
{
    public class Global : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {

            //Global Drops

            //Expert
            
            if (Main.expertMode)
            {
                if (Main.rand.Next(99) == 0)
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SlimyBar"));
                    }
                }
            }
            
            //Hardmode
            
            if (Main.hardMode)
            {
                if (Main.expertMode)
                {
                    if (Main.rand.Next(199) == 0)
                    {
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SpectrumLens"));
                        }
                    }
                } 
            }

            //Random Passive Enemy Drops

            if (Main.expertMode)
            {
                if (Main.rand.Next(19) == 0)
                {
                    if (npc.type == NPCID.Worm)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MassiveWormTooth"));
                    }
                }
            }

            //Random Enemy Drops (PreHardmode) (NormalDifficulty)

            //Slimes
    
            if (Main.rand.Next(44) == 0)
            {
                if (npc.type == NPCID.GreenSlime)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }          
                if (npc.type == NPCID.BlueSlime)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }
                if (npc.type == NPCID.RedSlime)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }
                if (npc.type == NPCID.YellowSlime)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }
                if (npc.type == NPCID.JungleSlime)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }
                if (npc.type == NPCID.IceSlime)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }
                if (npc.type == NPCID.ArmedZombieSlimed)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }
            }
            if (Main.rand.Next(39) == 0)
            {
                if (npc.type == NPCID.PurpleSlime)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }
                if (npc.type == NPCID.BlackSlime)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }
            }
            if (Main.rand.Next(29) == 0)
            {
                if (npc.type == NPCID.SpikedIceSlime)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }
                if (npc.type == NPCID.SandSlime)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }
            }
            if (Main.rand.Next(9) == 0)
            {
                if (npc.type == NPCID.MotherSlime)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }
            }
            if (Main.rand.Next(4) == 0)
            {
                if (npc.type == NPCID.BabySlime)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }
            }
            if (Main.rand.Next(5) == 0)
            {
                if (npc.type == NPCID.SlimeSpiked)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }
            }
            if (Main.rand.Next(19) == 0)
            {
                if (npc.type == NPCID.SpikedJungleSlime)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }
            }
            
            if (Main.rand.Next(99) == 0)
            {
                if (npc.type == NPCID.SmallSlimedZombie)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }
            }
            if (Main.rand.Next(89) == 0)
            {
                if (npc.type == NPCID.BigSlimedZombie)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                }
            }

            //Demon Eyes

            if (npc.type == NPCID.DemonEye)
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
            if (npc.type == NPCID.DemonEye2)
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
            if (npc.type == NPCID.CataractEye)
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
            if (npc.type == NPCID.CataractEye)
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
            if (npc.type == NPCID.DemonEyeOwl)
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
            if (npc.type == NPCID.DemonEyeSpaceship)
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
            if (npc.type == NPCID.DialatedEye)
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
            if (npc.type == NPCID.DialatedEye2)
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
            if (npc.type == NPCID.GreenEye)
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
            if (npc.type == NPCID.GreenEye2)
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
            if (npc.type == NPCID.PurpleEye)
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
            if (npc.type == NPCID.PurpleEye2)
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
            if (npc.type == NPCID.SleepyEye)
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
            if (npc.type == NPCID.SleepyEye2)
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
        }
    }
}




