using Terraria.ModLoader;

namespace nalydmod.Items.Expert.Orbs
{
    public class orb1Eoc : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orb of The Eye of Cthulhu");
            Tooltip.SetDefault("Expert");
        }
        public override void SetDefaults()
        {
            item.width = 15;
            item.height = 15;
            item.value = 50000;
            item.maxStack = 999;
            item.rare = 1;
        }
    }
}