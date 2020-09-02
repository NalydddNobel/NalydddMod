using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Placeables.Special.Trophys
{
    public class GeodeWormTrophy : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.EyeofCthulhuTrophy);
            item.createTile = mod.TileType("GeodeWormTrophyTile");
        }
    }
}