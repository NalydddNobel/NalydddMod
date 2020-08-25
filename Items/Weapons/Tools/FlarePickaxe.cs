using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Tools
{
    public class FlarePickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flare Pickaxe");
            Tooltip.SetDefault("This isn't the Solar Flare Pickaxe I wanted! This is rubbish!");
        }

        public override void SetDefaults()
        {
            item.damage = 3;
            item.melee = true;
            item.width = 48;
            item.height = 48;
            item.useTime = 5;
            item.useAnimation = 5;
            item.pick = 55;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 3;
            item.value = 10000;
            item.rare = ItemRarityID.Yellow;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.Flare, 150);
            recipe.AddIngredient(ItemID.FlareGun, 1);
            recipe.AddIngredient(ItemID.DemoniteBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.Flare, 150);
            recipe.AddIngredient(ItemID.FlareGun, 1);
            recipe.AddIngredient(ItemID.CrimtaneBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();



        }



    }
}