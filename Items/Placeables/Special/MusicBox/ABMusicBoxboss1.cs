using Terraria.ModLoader;
namespace nalydmod.Items.Placeables.Special.MusicBox
{
    public class ABMusicBoxboss1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Geode Worm)");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(1600);
            item.createTile = mod.TileType("MusicBoxboss1Tile");
        }
    }
}