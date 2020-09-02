using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Materials
{
    public class Blood2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rushing Green Blood");
            Tooltip.SetDefault("From corrupted creatures.");

        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 10;
            item.value = 100;
            item.maxStack = 999;
            item.rare = ItemRarityID.White;
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 3));
        }
        public override void Update(ref float gravity, ref float maxFallSpeed)
        {
            if (Main.rand.Next(44) == 0)
            {
                int dust = Dust.NewDust(item.position * Main.rand.Next(1, 2), item.width, item.height, mod.DustType("Blood2Dust"));
                Main.dust[dust].scale = Main.rand.Next(6, 12) * .1f;
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RottenChunk, 5);
            recipe.AddIngredient(mod.ItemType("SoulofSlime"), 5);
            recipe.AddIngredient(mod.ItemType("CursedSparks"), 20);
            recipe.AddIngredient(mod.ItemType("Blood2"), 200);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.Vilethorn);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RottenChunk, 5);
            recipe.AddIngredient(mod.ItemType("SoulofSlime"), 2);
            recipe.AddIngredient(mod.ItemType("CursedSparks"), 5);
            recipe.AddIngredient(mod.ItemType("Blood2"), 50);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.ShadowOrb);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RottenChunk, 5);
            recipe.AddIngredient(mod.ItemType("SoulofSlime"), 5);
            recipe.AddIngredient(mod.ItemType("CursedSparks"), 20);
            recipe.AddIngredient(mod.ItemType("Blood2"), 200);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.BallOHurt);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RottenChunk, 5);
            recipe.AddIngredient(mod.ItemType("SoulofSlime"), 5);
            recipe.AddIngredient(mod.ItemType("CursedSparks"), 10);
            recipe.AddIngredient(mod.ItemType("Blood2"), 125);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.BandofStarpower);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RottenChunk, 5);
            recipe.AddIngredient(mod.ItemType("SoulofSlime"), 5);
            recipe.AddIngredient(mod.ItemType("CursedSparks"), 20);
            recipe.AddIngredient(mod.ItemType("Blood2"), 200);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.Musket);
            recipe.AddRecipe();
        }
    }
}