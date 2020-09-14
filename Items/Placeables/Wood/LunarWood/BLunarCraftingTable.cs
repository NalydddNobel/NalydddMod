using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Placeables.Wood.LunarWood
{
    public class BLunarCraftingTable : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lunar Wood Work Bench");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WorkBench);
            item.createTile = mod.TileType("FurnWorkBench");
            item.placeStyle = 0;
        }
    }
}