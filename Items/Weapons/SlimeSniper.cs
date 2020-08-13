using IL.Terraria;
using nalydmod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;

namespace nalydmod.Items.Weapons
{
    public class SlimeSniper : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slime Sniper");
            Tooltip.SetDefault("Slow reloads, but fast and high damaging bullets!");
        
        }

        public override void SetDefaults()
        {
            item.damage = 33;
            item.ranged = true;
            item.width = 64;
            item.height = 30;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.knockBack = 8;
            item.value = 20000;
            item.rare = ItemRarityID.Cyan;
            item.UseSound = SoundID.Item40;
            item.autoReuse = true;
            item.shoot = ItemID.MusketBall;
            item.shootSpeed = 32;
            item.useAmmo = AmmoID.Bullet;
            item.noMelee = true;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SlimyBar"), 75);
            recipe.AddIngredient(mod.ItemType("SoulofSlime"), 15);
            recipe.AddIngredient(mod.ItemType("RoyalGel"), 20);
            recipe.AddIngredient(ItemID.Gel, 100);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }
}




