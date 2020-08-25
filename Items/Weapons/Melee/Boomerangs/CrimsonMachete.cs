using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Melee.Boomerangs
{
    public class CrimsonMachete : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crimson Machete");
            Tooltip.SetDefault("Stabbing grants regen.\nRight Click for an Ichor inflicting Boomerang.\nBoth buffs are based on chance.");
        }

        public override void SetDefaults()
        {
            item.damage = 14;
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
        public override bool AltFunctionUse(Terraria.Player player)
        {
            return true;
        }
        public override bool CanUseItem(Terraria.Player player)
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
                    if (Terraria.Main.projectile[i].active && Terraria.Main.projectile[i].owner == Terraria.Main.myPlayer && Terraria.Main.projectile[i].type == item.shoot)
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
        public override void OnHitNPC(Terraria.Player player, Terraria.NPC target, int damage, float knockBack, bool crit)
        {
            if (Terraria.Main.rand.Next(100) == 0)
            {
                player.AddBuff(BuffID.Lifeforce, 4000);
            }
            if (Terraria.Main.rand.Next(4) == 0)
            {
                player.AddBuff(BuffID.RapidHealing, 100);
            }
            if (Terraria.Main.rand.Next(2) == 0)
            {
                player.AddBuff(BuffID.Regeneration, 400);
            }
            if (Terraria.Main.rand.Next(2) == 0)
            {
                player.AddBuff(BuffID.ManaRegeneration, 800);
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