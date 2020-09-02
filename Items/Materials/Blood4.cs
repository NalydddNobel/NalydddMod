using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Materials
{
    public class Blood4 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rushing Teal Blood");
            Tooltip.SetDefault("From Terraria's goblins.");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 10;
            item.value = 200;
            item.maxStack = 999;
            item.rare = ItemRarityID.White;
            Terraria.Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 3));
        }
        public override void Update(ref float gravity, ref float maxFallSpeed)
        {
            if (Main.rand.Next(44) == 0)
            {
                int dust = Dust.NewDust(item.position * Main.rand.Next(1, 2), item.width, item.height, mod.DustType("Blood4Dust"));
                Main.dust[dust].scale = Main.rand.Next(6, 12) * .1f;
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RottenChunk, 5);
            recipe.AddIngredient(mod.ItemType("SoulofCrime"), 5);
            recipe.AddIngredient(mod.ItemType("GoblinPowder"), 20);
            recipe.AddIngredient(mod.ItemType("Blood4"), 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Harpoon);
            recipe.AddRecipe();
        }
    }
}