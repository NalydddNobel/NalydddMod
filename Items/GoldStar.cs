using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items
{
    public class GoldStar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("You did it.\nYou're Winner.");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.None);
        }
    }
}