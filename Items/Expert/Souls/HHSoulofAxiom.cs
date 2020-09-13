using Microsoft.Xna.Framework;
using nalydmod.Items.Global;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Expert.Souls
{
    public class HHSoulofAxiom : ModItem
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
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }
        public override void ModifyTooltips(List<TooltipLine> list)
        {
            foreach (TooltipLine line2 in list)
            {
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                {
                    line2.overrideColor = MyPlayer.BaseColor.RedBlueCycle;
                }
            }
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
    }
}