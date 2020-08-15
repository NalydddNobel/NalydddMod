using IL.Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using On.Terraria;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials.GemFragments
{
    public class SapphireFragment : ModItem
    {
        public override string Texture => "nalydmod/Items/Materials/GemFragments/BasicFragment";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sapphire Fragment");
            Tooltip.SetDefault("Drops from Sapphire Creatures");
        }
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 10;
            item.maxStack = 999;
            item.alpha = 189;
            item.color = Color.Blue;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            ItemID.Sets.ItemIconPulse[item.type] = true;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.Blue;
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




