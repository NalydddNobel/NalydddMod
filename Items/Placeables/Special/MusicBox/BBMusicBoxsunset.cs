using Terraria.ModLoader;
namespace nalydmod.Items.Placeables.Special.MusicBox
{
    public class BBMusicBoxsunset : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Sunset)");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(1600);
            item.createTile = mod.TileType("MusicBoxsunsetTile");
        }
    }
}