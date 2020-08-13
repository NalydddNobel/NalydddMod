using IL.Terraria;
using IL.Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;
using Microsoft.Xna.Framework;


namespace nalydmod.Items.Materials.Expert
{
    public class SoulofCrime : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul Of Crime");
            Tooltip.SetDefault("Soul of an evil monster.");
            
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void SetDefaults()
        {                      
            item.width = 30;
            item.height = 30;
            item.value = 2000;
            item.maxStack = 999;
            item.rare = ItemRarityID.Expert;
            item.expertOnly = true;
            item.expert = true;
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;

        }
    }
}




