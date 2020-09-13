using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Weapons.Melee.Swords
{
    public class Lavafury : ModItem
    {
        public static short glowMask;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a glob of lava.");
            if (Main.netMode != NetmodeID.Server)
            {
                glowMask = GlowMaskAPI.Tools.instance.AddGlowMask(mod.GetTexture("Items/Glows/Glow7"));
            }
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Starfury);
            item.damage = 30;
            item.width = 40;
            item.height = 40;
            item.shootSpeed = 14;
            item.rare = 3;
            item.shoot = mod.ProjectileType("LavaGlob");
            item.autoReuse = true;
            item.glowMask = glowMask;
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (Main.rand.Next(3) == 0)
            {
                target.AddBuff(BuffID.OnFire, 112);
            }
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