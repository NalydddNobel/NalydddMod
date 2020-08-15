using IL.Terraria;
using nalydmod.Projectiles;
using System.Collections;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;

namespace nalydmod.Items.Weapons.Ammo.Darts
{
    public class Dart : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dart"); 
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.ranged = true;
            item.width = 6;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.value = 125;
            item.rare = ItemRarityID.White;
            item.shoot = mod.ProjectileType("DartProjectile");
            item.shootSpeed = 2;
            item.ammo = AmmoID.Dart;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 1);
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 10);
            recipe.AddRecipe();
        }


    }
}




