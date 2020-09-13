using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Weapons.Expert.AASlime
{
    public class SlimeSniper : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slime Sniper");
            Tooltip.SetDefault("Turns musket balls into high velocity bullets");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SniperRifle);
            item.damage = 34;
            item.crit = -2;
            item.width = 64;
            item.height = 24;
            item.value = 20000;
            item.rare = 1;
            item.autoReuse = true;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = ProjectileID.BulletHighVelocity;
            }
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("AASoulofSlime"), 15);
            recipe.AddIngredient(mod.ItemType("RoyalGel"), 20);
            recipe.AddIngredient(ItemID.Gel, 100);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}