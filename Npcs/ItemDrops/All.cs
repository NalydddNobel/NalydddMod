using Terraria;
using Terraria.ModLoader;
namespace nalydmod.NPCs.ItemDrops
{
    public class All : GlobalNPC
    {
        public override void OnHitByProjectile(NPC npc, Projectile projectile, int damage, float knockback, bool crit)
        {
            if (MyPlayer.gemAccessory)
            {
                if (Main.rand.Next(8) == 1)
                {
                    if (Main.rand.Next(40) == 1)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FFDiamondShard"));
                    }
                    else if (Main.rand.Next(25) == 1)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("EERubyShard"));
                    }
                    else if (Main.rand.Next(25) == 1)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DDEmeraldShard"));
                    }
                    else if (Main.rand.Next(15) == 1)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CCSapphireShard"));
                    }
                    else if (Main.rand.Next(6) == 1)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BBTopazShard"));
                    }
                    else
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AAAmethystShard"));
                    }
                }
                if (Main.rand.Next(20) == 1)
                {
                    if (Main.rand.Next(40) == 1)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FFDiamondShard"));
                    }
                    else if (Main.rand.Next(25) == 1)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("EERubyShard"));
                    }
                    else if (Main.rand.Next(25) == 1)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DDEmeraldShard"));
                    }
                    else if (Main.rand.Next(15) == 1)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CCSapphireShard"));
                    }
                    else if (Main.rand.Next(6) == 1)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BBTopazShard"));
                    }
                    else
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AAAmethystShard"));
                    }
                }
            }
        }
    }
}