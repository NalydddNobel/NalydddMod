using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Melee.Boomerangs
{
    public class CrimsonMachete : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crimson Dagger");
            Tooltip.SetDefault("Right Click to throw a knife.");
        }

        public override void SetDefaults()
        {
            item.damage = 22;
            item.melee = true;
            item.width = 30;
            item.height = 46;
            item.useStyle = ItemUseStyleID.Stabbing;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 2;
            item.value = 1;
            item.rare = ItemRarityID.Blue;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
        public override bool CanUseItem(Player player)
        {
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.useTime = 18;
            item.useAnimation = 18;
            item.damage = 14;
            item.shootSpeed = 6;
            item.shoot = mod.ProjectileType("CrimsonBoomerangProjectile");
            if (player.altFunctionUse == 2)
            {
                for (int i = 0; i < 1000; ++i)
                {
                    if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                item.useStyle = ItemUseStyleID.Stabbing;
                item.useTime = 18;
                item.noUseGraphic = false;
                item.noMelee = false;
                item.useAnimation = 18;
                item.damage = 14;
                item.shoot = ProjectileID.None;
            }
            return base.CanUseItem(player);
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            player.statLife += (int)Math.Round(damage / 2f);
            if (Main.myPlayer == player.whoAmI)
            {
                player.HealEffect((int)Math.Round(damage / 2f), true);
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("IchorDroplets"), 20);
            recipe.AddIngredient(mod.ItemType("SoulofTime"), 10);
            recipe.AddIngredient(mod.ItemType("crimsoneyes"), 3);
            recipe.AddIngredient(ItemID.Vertebrae, 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}