using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Ranged.UsesArrow
{
    public class WaxWoodBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wax Wood Bow");
        }

        public override void SetDefaults()
        {
            item.damage = 14;
            item.crit = 12;
            item.ranged = true;
            item.width = 20;
            item.height = 20;
            item.useTime = 28;
            item.useAnimation = 28;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.knockBack = 1;
            item.value = 20000;
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item10;
            item.autoReuse = true;
            item.useTurn = false;
            item.shoot = ProjectileID.WoodenArrowFriendly;
            item.shootSpeed = 6;
            item.useAmmo = AmmoID.Arrow;
            item.noMelee = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RottenChunk, 5);
            recipe.AddIngredient(mod.ItemType("SoulofCrime"), 5);
            recipe.AddIngredient(mod.ItemType("GoblinPowder"), 20);
            recipe.AddIngredient(mod.ItemType("Blood3"), 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}




