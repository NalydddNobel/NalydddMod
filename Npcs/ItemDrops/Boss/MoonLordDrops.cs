using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
namespace nalydmod.NPCs.ItemDrops.Boss
{
    public class MoonLordDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.MoonLordCore)
            {
                if (Main.expertMode == false)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"), (int)Main.rand.NextFloat(5, 12));
                }
                if (Main.expertMode == true)
                {
                    MyWorld.AequusPillarSpawn = true;
                    MyWorld.LunarPillarPeonsKilled = 0;
                }
            }
        }
    }
}