using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Placeables.Special
{
    public class MusicBoxEyeofCuthulu : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Eye of Cuthulu)");
        }

        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("MusicBoxEyeofCuthuluTile");
            item.width = 24;
            item.height = 24;
            item.rare = ItemRarityID.LightRed;
            item.value = 100000;
            item.accessory = true;
        }
    }
}



