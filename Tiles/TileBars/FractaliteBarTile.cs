using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace nalydmod.Tiles.TileBars
{
    public class FractaliteBarTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);
            dustType = 15;
            drop = mod.ItemType("FractaliteBar");
            AddMapEntry(new Color(170, 110, 210), Language.GetText("MapObject.MetalBar"));
        }
    }
}