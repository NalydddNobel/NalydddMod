using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Placeables.Special.Trophys
{
    public class AAGeodeWormTrophy : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.EyeofCthulhuTrophy);
            item.createTile = mod.TileType("ModTrophyTile");
            item.placeStyle = 1;
        }
    }
}