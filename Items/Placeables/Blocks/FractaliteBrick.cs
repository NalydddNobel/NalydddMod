using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Placeables.Blocks
{
    public class FractaliteBrick : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.maxStack = 999;
            item.rare = ItemRarityID.Blue;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = mod.TileType("FractaliteBrickTile");
        }

    }
}




