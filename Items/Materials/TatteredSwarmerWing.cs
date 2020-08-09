using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials
{
    public class TatteredSwarmerWing : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tattered Swarmer Wing");
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 20;
            item.value = 2000;
            item.maxStack = 999;
            item.rare = ItemRarityID.Blue;
        }
    }
}




