using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Ranged.UsesBullet
{
    public class SlimeShooter : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slime Shooter");
        }

        public override void SetDefaults()
        {
            item.damage = 7;
            item.ranged = true;
            item.width = 32;
            item.height = 30;
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.knockBack = 1;
            item.value = 20000;
            item.rare = 1;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.useTurn = false;
            item.shoot = ItemID.MusketBall;
            item.shootSpeed = 6;
            item.useAmmo = AmmoID.Bullet;
            item.noMelee = true;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SlimyBar"), 50);
            recipe.AddIngredient(mod.ItemType("SoulofSlime"), 10);
            recipe.AddIngredient(mod.ItemType("RoyalGel"), 10);
            recipe.AddIngredient(ItemID.Gel, 100);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }
}




