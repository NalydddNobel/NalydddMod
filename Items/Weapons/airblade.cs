using IL.Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;

namespace nalydmod.Items.Weapons
{
    public class airblade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Air Blade");
            Tooltip.SetDefault("Slap them with the air.");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 40;
            item.useAnimation = 5;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.knockBack = 15;
            item.value = 20000;
            item.rare = ItemRarityID.Expert;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.expertOnly = true;
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
        }


    }
}




