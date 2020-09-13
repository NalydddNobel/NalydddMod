using Terraria.ModLoader;
namespace nalydmod.Items.Placeables.Special.MusicBox
{
    public class ACMusicBoxEyeofCuthulu : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Eye of Cthulhu)");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(1600);
            item.createTile = mod.TileType("MusicBoxEyeofCuthuluTile");
        }
    }
}