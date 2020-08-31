using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Weapons.Melee.Swords
{
    public class Lavafury : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a glob of lava.");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Starfury);
            item.damage = 30;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 33;
            item.useAnimation = 33;
            item.knockBack = 2;
            item.value = 1;
            item.shootSpeed = 14;
            item.rare = 3;
            item.shoot = mod.ProjectileType("LavaGlob");
            item.autoReuse = true;
        }
        public override void Update(ref float gravity, ref float maxFallSpeed)
        {
            if (Main.rand.Next(44) == 0)
            {
                int dust = Dust.NewDust(item.position * Main.rand.Next(1, 2), item.width, item.height, mod.DustType("LavaShine"));
                Main.dust[dust].scale = Main.rand.Next(6, 12) * .1f;
                Main.dust[dust].alpha = 130;
            }
            if (Main.rand.Next(254) == 0)
            {
                int dust = Dust.NewDust(item.position, item.width, item.height, mod.DustType("LavaSparkle"));
                Main.dust[dust].velocity.Y = -4;
                Main.dust[dust].scale = 1.2f;
                Main.dust[dust].alpha = 130;
            }
            if (Main.rand.Next(6) == 0)
            {
                int dust2 = Dust.NewDust(item.position, item.width, item.height, DustID.Fire);
                Main.dust[dust2].velocity /= 60f;
                Main.dust[dust2].scale = 0.9f;
                Main.dust[dust2].alpha = 100;
            }
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (Main.rand.Next(3) == 0)
            {
                target.AddBuff(BuffID.OnFire, 112);
            }
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Starfury);
            recipe.AddIngredient(ItemID.HellstoneBar, 23);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}