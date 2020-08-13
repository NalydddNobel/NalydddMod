using IL.Terraria;
using IL.Terraria.DataStructures;
using System;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;

namespace nalydmod.Items.Placeables.Animated
{
    public class ExampleAnimatedTile : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Example Animated Tile");
            Tooltip.SetDefault("Animated Firefly");

        }     
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.useStyle = ItemUseStyleID.SwingThrow;
        }
    }
}




