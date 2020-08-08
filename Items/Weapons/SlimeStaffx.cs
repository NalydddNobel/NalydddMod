using IL.Terraria;
using nalydmod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;

namespace nalydmod.Items.Weapons
{
    public class SlimeStaffx : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slime Staff");
            Tooltip.SetDefault("Not to be confused with the Summoner Weapon.");
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.magic = true;
            item.width = 48;
            item.height = 48;
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = 5;
            item.knockBack = 1;
            item.value = 20000;
            item.rare = ItemRarityID.Cyan;
            item.UseSound = SoundID.Item21;
            item.autoReuse = true;
            item.useTurn = false;
            item.shoot = ProjectileID.SapphireBolt;
            item.shootSpeed = 9f;
            item.noMelee = true;
            item.mana = 2;

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




