using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials
{
    public class MiniLifeFruit : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It hasn't grown up yet.");

        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 10000;
            item.maxStack = 999;
            item.rare = ItemRarityID.Lime;
        }
    }
}