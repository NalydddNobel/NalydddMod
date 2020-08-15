using IL.Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;

namespace nalydmod.Items.Weapons.Ranged.UsesDart
{
    public class WaxWoodPipe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wax Wood Pipe");
            Tooltip.SetDefault("Theres dust inside.\nUses Darts as ammo");
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.crit = 12;
            item.ranged = true;
            item.width = 15;
            item.height = 5;
            item.useTime = 48;
            item.useAnimation = 48;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.knockBack = 3;
            item.value = 20000;
            item.rare = ItemRarityID.Green;
            item.autoReuse = true;
            item.useTurn = false;
            item.shoot = ProjectileID.PoisonDartBlowgun;
            item.shootSpeed = 6;
            item.useAmmo = AmmoID.Dart;
            item.noMelee = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RottenChunk, 5);
            recipe.AddIngredient(mod.ItemType("SoulofCrime"), 5);
            recipe.AddIngredient(mod.ItemType("GoblinPowder"), 20);
            recipe.AddIngredient(mod.ItemType("Blood3"), 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}




