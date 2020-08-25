using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Melee.Swords.ShortSwords
{
    public class airblade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Air Blade");
            Tooltip.SetDefault("The hitbox of this weapon sucks!");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.melee = true;
            item.width = 60;
            item.height = 60;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.knockBack = 15;
            item.value = 20000;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.expertOnly = true;
            item.rare = ItemRarityID.White;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cloud, 350);
            recipe.AddIngredient(ItemID.PeaceCandle, 1);
            recipe.AddIngredient(ItemID.Feather, 20);
            recipe.AddIngredient(ItemID.RainCloud, 75);
            recipe.AddIngredient(mod.ItemType("SoulofTime"), 10);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this);
        }


    }
}




