using IL.Terraria;
using nalydmod.Projectiles;
using System.Collections;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;

namespace nalydmod.Items.Weapons.Ammo
{
    public class WormArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dirt Arrow"); 
            Tooltip.SetDefault("May poision enemies.");
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.ranged = true;
            item.width = 18;
            item.height = 30;
            item.maxStack = 999;
            item.consumable = true;
            item.value = 125;
            item.rare = ItemRarityID.White;
            item.shoot = mod.ProjectileType("WormArrow");
            item.shootSpeed = 7;
            item.ammo = AmmoID.Arrow;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddIngredient(ItemID.MudBlock, 1);
            recipe.AddIngredient(ItemID.Worm, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 60);
            recipe.AddRecipe();
        }


    }
}




