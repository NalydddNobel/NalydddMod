using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Melee.Boomerangs
{
    public class Firebaozhu : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fire Baozhu");
            Tooltip.SetDefault("Right click to do a high damage long throw.\nExploading Bamboo!");
        }

        public override void SetDefaults()
        {
            item.damage = 18;
            item.melee = true;
            item.noMelee = true;
            item.width = 20;
            item.height = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 14;
            item.useAnimation = 14;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 2;
            item.value = 1;
            item.rare = ItemRarityID.Orange;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.noUseGraphic = true;
            item.shootSpeed = 6;
            item.shoot = mod.ProjectileType("FirebaozhuProjectile");
            Terraria.Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(12, 4));
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
            item.useTime = 60;
            item.useAnimation = 60;
            item.shootSpeed = 12;
            item.shoot = mod.ProjectileType("FirebaozhuProjectile");
            item.damage = 44;
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
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.useTime = 14;
                item.noUseGraphic = true;
                item.noMelee = true;
                item.useAnimation = 14;
                item.damage = 23;
                item.shootSpeed = 6;
                item.shoot = mod.ProjectileType("FirebaozhuProjectile");
            }
            return base.CanUseItem(player);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SoulofSpine"), 10);
            recipe.AddIngredient(ItemID.HellstoneBar, 12);
            recipe.AddIngredient(ItemID.AshBlock, 50);
            recipe.AddIngredient(ItemID.ThornChakram);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}