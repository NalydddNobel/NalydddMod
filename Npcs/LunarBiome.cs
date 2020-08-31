using System.Collections.Generic;
using Terraria.ModLoader;
namespace nalydmod.NPCs.ItemDrops
{
    public class LunarBiome : GlobalNPC
    {
        public override void EditSpawnPool(IDictionary<int, float> pool, NPCSpawnInfo spawnInfo)
        {
            if (MyPlayer.LunarBiome == true)
            {
            }
        }
    }
}