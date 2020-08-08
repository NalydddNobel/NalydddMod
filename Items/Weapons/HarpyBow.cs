using IL.Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;

namespace nalydmod.Items.Weapons
{
    public class HarpyBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("HarpyBow"); 
            
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 20;
            item.height = 20;
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.knockBack = 1;
            item.value = 20000;
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item10;
            item.autoReuse = true;
            item.useTurn = false;
            item.shoot = mod.ProjectileType("harpyarrow");
            item.shootSpeed = 6;
            item.useAmmo = AmmoID.Arrow;
            item.noMelee = true;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cloud, 350);
            recipe.AddIngredient(ItemID.PeaceCandle, 1);
            recipe.AddIngredient(ItemID.Feather, 20);
            recipe.AddIngredient(ItemID.RainCloud, 75);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }
}




