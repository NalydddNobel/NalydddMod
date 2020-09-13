using Terraria.ModLoader;
namespace nalydmod.Items.Materials.Special
{
    public class ZADryDoughnut : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dry Doughnut");
            Tooltip.SetDefault("May attract a town NPC that likes dryness if held in your inventory");
        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 48;
            item.rare = 2;
        }
    }
}