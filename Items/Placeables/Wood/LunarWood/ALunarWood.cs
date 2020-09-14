using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Placeables.Wood.LunarWood
{
    public class ALunarWood : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lunar Wood");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Wood);
            item.createTile = mod.TileType("LunarWoodTile");
        }
    }
}