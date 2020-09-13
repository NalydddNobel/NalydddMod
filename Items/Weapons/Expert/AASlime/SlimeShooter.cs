using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Weapons.Expert.AASlime
{
    public class SlimeShooter : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slime Shooter");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FlintlockPistol);
            item.width = 32;
            item.height = 20;
            item.useTime = 15;
            item.useAnimation = 15;
            item.value = 20000;
            item.rare = 1;
            item.autoReuse = true;
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