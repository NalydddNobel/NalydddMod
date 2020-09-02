using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace nalydmod.Items.Global
{
    public abstract class BaseRarityItem : ModItem
    {
        public int ExampleRarity = 0;
        public Color? customNameColor = null;
        public override void ModifyTooltips(List<TooltipLine> list)
        {
            if (customNameColor != null)
            {
                foreach (TooltipLine line2 in list)
                {
                    if (line2.mod == "Terraria" && line2.Name == "ItemName")
                    {
                        line2.overrideColor = (Color)customNameColor;
                    }
                }
                return;
            }
            if (item.modItem is BaseRarityItem MyModItem && MyModItem.ExampleRarity != 0)
            {
                Color Rare;
                switch (MyModItem.ExampleRarity)
                {
                    default: Rare = Color.White; break;
                    case 12: Rare = BaseColor.LightPurple; break;
                    case 13: Rare = BaseColor.Brown; break;
                    case 14: Rare = BaseColor.LightPurple; break;
                    case 15: Rare = BaseColor.Brown; break;

                }
                foreach (TooltipLine line2 in list)
                {
                    if (line2.mod == "Terraria" && line2.Name == "ItemName")
                    {
                        line2.overrideColor = Rare;
                    }
                }
            }
        }
    }
    public static class BaseColor
    {
        public static Color LightPurple => new Color(150, 90, 175);
        public static Color Brown => new Color(170, 70, 15);
        public static Color DarkGreen => new Color(6, 75, 60);
        public static Color DarkBlue => new Color(30, 75, 120);
    }
}