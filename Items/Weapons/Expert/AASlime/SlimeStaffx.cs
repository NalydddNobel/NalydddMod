using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Weapons.Expert.AASlime
{
    public class SlimeStaffx : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slime Staff");
            Tooltip.SetDefault("Not to be confused with the summoner weapon.");
            Terraria.Item.staff[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.AmethystStaff);
            item.damage = 15;
            item.width = 40;
            item.height = 40;
            item.rare = 1;
            item.autoReuse = true;
            item.shoot = ProjectileID.SapphireBolt;
            item.shootSpeed = 9f;
            item.mana = 5;
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