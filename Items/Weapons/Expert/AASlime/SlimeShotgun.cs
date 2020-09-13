using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Weapons.Expert.AASlime
{
    public class SlimeShotgun : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a very wide spread of bullets");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FlintlockPistol);
            item.damage = 12;
            item.crit = 2;
            item.width = 40;
            item.height = 16;
            item.knockBack = 0.77f;
            item.useTime = 25;
            item.useAnimation = 25;
            item.value = 20000;
            item.rare = 1;
            item.autoReuse = true;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 4 + Main.rand.Next(2);
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(44));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("AASoulofSlime"), 12);
            recipe.AddIngredient(mod.ItemType("RoyalGel"), 18);
            recipe.AddIngredient(ItemID.Gel, 150);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}