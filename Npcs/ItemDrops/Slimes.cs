using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.NPCs.ItemDrops
{
    public class Slimes : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (NPC.downedSlimeKing == false)
            {
                if (npc.type == NPCID.GreenSlime || npc.type == NPCID.BlueSlime || npc.type == NPCID.YellowSlime || npc.type == NPCID.JungleSlime || npc.type == NPCID.IceSlime || npc.type == NPCID.ArmedZombieSlimed)
                {
                    if (Main.rand.Next(44) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                    }
                }
                if (npc.type == NPCID.PurpleSlime || npc.type == NPCID.BlackSlime || npc.type == NPCID.SpikedIceSlime || npc.type == NPCID.SandSlime || npc.type == NPCID.SmallSlimedZombie || npc.type == NPCID.BigSlimedZombie)
                {
                    if (Main.rand.Next(29) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                    }
                }
                if (npc.type == NPCID.MotherSlime || npc.type == NPCID.SpikedJungleSlime)
                {
                    if (Main.rand.Next(9) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                    }
                }

                if (npc.type == NPCID.BabySlime || npc.type == NPCID.SlimeSpiked)
                {
                    if (Main.rand.Next(5) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"));
                    }
                }
            }
        }
    }
}