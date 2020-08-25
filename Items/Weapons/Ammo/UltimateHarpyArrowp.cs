using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Ammo
{
    public class UltimateHarpyArrowp : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Harpy Arrow (P)");
            Tooltip.SetDefault("Aerodynamic, razor sharp, and infinite. " +
                "Hates the ground, these arrows get easily destroyed by most ground tiles." +
                " This arrow pierces up to 25 enemies, " +
                "good for invasions / croud control.");
        }

        public override void SetDefaults()
        {

            item.damage = 25;
            item.ranged = true;
            item.width = 24;
            item.height = 48;
            item.useTime = 12;
            item.maxStack = 1;
            item.consumable = false;
            item.value = 10000;
            item.rare = ItemRarityID.Expert;
            item.shoot = mod.ProjectileType("uharpyarrowp");
            item.shootSpeed = 25;
            item.ammo = AmmoID.Arrow;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 20);
            recipe.AddIngredient(ItemID.ShadowScale, 40);
            recipe.AddIngredient(ItemID.ShroomiteBar, 20);
            recipe.AddIngredient(ItemID.SoulofFright, 20);
            recipe.AddIngredient(ItemID.SoulofNight, 35);
            recipe.AddIngredient(ItemID.SoulofFlight, 200);
            recipe.AddIngredient(ItemID.Feather, 100);
            recipe.AddIngredient(mod.ItemType("HarpyArrow"), 1998);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ItemID.GiantHarpyFeather, 1);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneBar, 20);
            recipe.AddIngredient(ItemID.TissueSample, 40);
            recipe.AddIngredient(ItemID.ShroomiteBar, 20);
            recipe.AddIngredient(ItemID.SoulofFright, 20);
            recipe.AddIngredient(ItemID.SoulofNight, 35);
            recipe.AddIngredient(ItemID.SoulofFlight, 200);
            recipe.AddIngredient(ItemID.Feather, 100);
            recipe.AddIngredient(mod.ItemType("HarpyArrow"), 1998);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ItemID.GiantHarpyFeather, 1);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("UltimateHarpyArrow"), 1);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }


    }
}




