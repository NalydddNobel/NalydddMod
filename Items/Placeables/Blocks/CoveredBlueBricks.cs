using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Placeables.Blocks
{
    public class CoveredBlueBricks : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Covered Blue Bricks");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 22;
            item.maxStack = 999;
            item.rare = ItemRarityID.White;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = mod.TileType("CoveredBlueBricksTile");
        }

    }
}




