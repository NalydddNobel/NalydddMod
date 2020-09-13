using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Weapons.AFractalite
{
    class MandelStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fractalite Staff");
            Tooltip.SetDefault("Has the essence of Mandel.");
            Item.staff[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.DiamondStaff);
            item.damage = 29;
            item.mana = 6;
            item.width = 28;
            item.height = 28;
            item.useAnimation = 26;
            item.useTime = 26;
            item.autoReuse = true;
            item.rare = 1;
            item.shoot = mod.ProjectileType("FractaliteFractal");
            item.shootSpeed = 10;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("FractaliteBar"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}