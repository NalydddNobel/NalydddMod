using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace nalydmod.Tiles
{
    public class FractaliteTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileShine[Type] = (int)0.22f;
            Main.tileStone[Type] = true;
            dustType = 8;
            drop = mod.ItemType("Fractalite");
            AddMapEntry(new Color(200, 200, 200));
        }
    }
}