using IL.Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using On.Terraria;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials
{
    public class SapphireFragment : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sapphire Fragment");           
        }
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 10;            
            item.maxStack = 999;
            Terraria.Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 8));

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SapphireFragment"), 6);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(itemID: ItemID.Sapphire);
            recipe.AddRecipe();
        }
    }
}




