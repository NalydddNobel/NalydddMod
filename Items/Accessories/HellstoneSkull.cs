using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Accessories
{
    public class HellstoneSkull : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Grants immunity to fire blocks.\nInflicts fire damage on attack.");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 20000;
            item.rare = 3;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.fireWalk = true;
            player.magmaStone = true;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ObsidianSkull);
            recipe.AddIngredient(ItemID.MagmaStone);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}