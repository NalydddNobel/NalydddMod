using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Placeables.Walls
{
    class FractaliteBrickWall : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WoodWall);
            item.rare = ItemRarityID.Blue;
            item.createTile = mod.WallType("FractaliteBrickWallWall");
        }
    }
}