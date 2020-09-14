using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace nalydmod.Tiles.Blocks
{
    public class LunarWoodTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            dustType = mod.DustType("LunarWoodDust");
            drop = ModContent.ItemType<Items.Placeables.Wood.LunarWood.ALunarWood>();
            AddMapEntry(new Color(200, 200, 200));
        }
    }
}