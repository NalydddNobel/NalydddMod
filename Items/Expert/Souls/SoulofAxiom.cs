using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Souls
{
    public class SoulofAxiom : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of Axiom");
            Tooltip.SetDefault("'The essence of Aequus'\n'Unreal, unbelivable!\nExpert");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.value = 50000;
            item.maxStack = 999;
            item.rare = 10;
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
    }
}