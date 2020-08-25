using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Tiles
{
    public class FractaliteTile : ModTile
    {
        public override void SetDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileShine[Type] = (int)0.22f;
            Main.tileStone[Type] = true;
            dustType = 15;
            drop = mod.ItemType("Fractalite");
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Fractalite");
            AddMapEntry(new Color(170, 110, 210));
            soundType = SoundID.Tink;
            soundStyle = 1;
            mineResist = 2f;
            minPick = 65;
        }
    }
}