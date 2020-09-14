using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Placeables.Wood.LunarWood
{
    public class CLunarTable : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lunar Wood Table");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WorkBench);
            item.createTile = mod.TileType("FurnTable");
            item.placeStyle = 0;
        }
    }
}