using IL.Terraria;
using IL.Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;
using Microsoft.Xna.Framework;


namespace nalydmod.Items.Materials.Expert
{
    public class SlimyBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slimy Bar");
            Tooltip.SetDefault("Sticky and durable");
            
        }

        public override void SetDefaults()
        {
            
            
            item.width = 30;
            item.height = 24;
            item.value = 20000;
            item.maxStack = 999;
            item.rare = ItemRarityID.Expert;
            item.expertOnly = true;
            item.expert = true;           
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SoulofSlime"), 1);
            recipe.AddIngredient(mod.ItemType("RoyalGel"), 5);
            recipe.AddIngredient(ItemID.Gel, 20);
            recipe.AddIngredient(ItemID.GoldCrown, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 40);
            recipe.AddRecipe();
        }
    }
}




