using Terraria.ModLoader;

namespace nalydmod.Items.ZCheat
{
    public class TestItem1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Test Item I");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.maxStack = 999;
        }
    }
}




