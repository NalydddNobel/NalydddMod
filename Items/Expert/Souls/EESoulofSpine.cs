using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Souls
{
    public class EESoulofSpine : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul Of Spine");
            Tooltip.SetDefault("'The essence of the bone zone'.\n'Has back problems'\nExpert");

        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = 15000;
            item.maxStack = 999;
            item.rare = 3;
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }
    }
}