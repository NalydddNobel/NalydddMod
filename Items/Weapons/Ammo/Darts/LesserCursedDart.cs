using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Ammo.Darts
{
    public class LesserCursedDart : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Inflicts Cursed Flames");
        }
        public override void SetDefaults()
        {
            item.damage = 6;
            item.ranged = true;
            item.width = 6;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.value = 125;
            item.rare = ItemRarityID.White;
            item.shoot = mod.ProjectileType("LesserCursedDartProjectile");
            item.shootSpeed = 1.88f;
            item.ammo = AmmoID.Dart;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Dart"), 50);
            recipe.AddIngredient(mod.ItemType("CursedSparks"));
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}




