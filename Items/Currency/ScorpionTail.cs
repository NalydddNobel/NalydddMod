using System.Collections.Generic;
using System.Drawing;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;


namespace nalydmod.Items.Currency
{
    public class ScorpionTail : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scorpion Tail");
            Tooltip.SetDefault("Can be traded with the Desert Devoter.");
        }
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 10;
            item.value = 200;
            item.maxStack = 999;
            item.rare = ItemRarityID.White;
        }
    }
}




