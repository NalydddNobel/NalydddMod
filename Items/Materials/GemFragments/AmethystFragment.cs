using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials.GemFragments
{
    public class AmethystFragment : ModItem
    {
        public override string Texture => "nalydmod/Items/Materials/GemFragments/BasicFragment";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amethyst Fragment");
            Tooltip.SetDefault("Drops from Amethyst Creatures");
        }
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 10;
            item.maxStack = 999;
            item.alpha = 189;
            item.color = Color.Purple;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            ItemID.Sets.ItemIconPulse[item.type] = true;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.Purple;
        }
        public override void HoldItem(Player player)
        {
            Vector2 position = player.RotatedRelativePoint(new Vector2(player.itemLocation.X + 12f * player.direction + player.velocity.X, player.itemLocation.Y - 14f + player.velocity.Y), true);
            Lighting.AddLight(position, 1f, 1f, 1f);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("AmethystFragment"), 2);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(itemID: ItemID.Amethyst);
            recipe.AddRecipe();
        }
    }
}