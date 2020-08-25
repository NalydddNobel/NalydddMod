
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Magic.Staff
{
    class CursedBeamStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Terraria.Item.staff[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ShadowbeamStaff);
            item.rare = ItemRarityID.Green;
            item.damage = 18;
            item.shoot = ModContent.ProjectileType<CursedBeamProjectile>();
            item.crit = 25;
            item.knockBack = 0.35f;
            item.mana = 4;
            item.useTime = 23;
            item.useAnimation = 23;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("CursedSparks"), 20);
            recipe.AddIngredient(mod.ItemType("SoulofTime"), 10);
            recipe.AddIngredient(mod.ItemType("corrupteyes"), 3);
            recipe.AddIngredient(ItemID.RottenChunk, 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class CursedBeamProjectile : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.width = 4;
            projectile.height = 4;
            projectile.aiStyle = 48;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.extraUpdates = 100;
            projectile.timeLeft = 60; // lowered from 300
            projectile.penetrate = -1;
        }

        // Note, this Texture is actually just a blank texture, FYI.
        public override string Texture => "Terraria/Projectile_" + ProjectileID.ShadowBeamFriendly;

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            if (projectile.velocity.X != oldVelocity.X)
            {
                projectile.position.X = projectile.position.X + projectile.velocity.X;
                projectile.velocity.X = -oldVelocity.X;
            }
            if (projectile.velocity.Y != oldVelocity.Y)
            {
                projectile.position.Y = projectile.position.Y + projectile.velocity.Y;
                projectile.velocity.Y = -oldVelocity.Y;
            }
            return false; // return false because we are handling collision
        }

        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            projectile.damage = (int)(projectile.damage * 0.8);
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.CursedInferno, 20);
        }
        public override void AI()
        {
            projectile.localAI[0] += 1f;
            if (projectile.localAI[0] > 9f)
            {
                for (int i = 0; i < 4; i++)
                {
                    Vector2 projectilePosition = projectile.position;
                    projectilePosition -= projectile.velocity * (i * 0.25f);
                    projectile.alpha = 255;
                    // Important, changed 173 to 178!
                    int dust = Dust.NewDust(projectilePosition, 1, 1, 178, 0f, 0f, 0, default, 1f);
                    Main.dust[dust].noGravity = true;
                    Main.dust[dust].position = projectilePosition;
                    Main.dust[dust].scale = Main.rand.Next(70, 110) * 0.013f;
                    Main.dust[dust].velocity *= 0.2f;
                }
            }
        }
    }
}