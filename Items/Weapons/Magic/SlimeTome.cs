using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Magic
{
    public class SlimeTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slime Tome");
        }
        public override void SetDefaults()
        {
            item.damage = 18;
            item.magic = true;
            item.width = 24;
            item.height = 28;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 1000;
            item.rare = 1;
            item.mana = 5;
            item.UseSound = SoundID.Item21; 
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("SlimeProjectile"); 
            item.shootSpeed = 8f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("AASoulofSlime"), 10);
            recipe.AddIngredient(mod.ItemType("RoyalGel"), 10);
            recipe.AddIngredient(ItemID.Gel, 100);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}