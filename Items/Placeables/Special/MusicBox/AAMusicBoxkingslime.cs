using Terraria.ModLoader;
namespace nalydmod.Items.Placeables.Special.MusicBox
{
    public class AAMusicBoxkingslime : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (King Slime)");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(1600);
            item.createTile = mod.TileType("MusicBoxkingslimeTile");
        }
    }
}