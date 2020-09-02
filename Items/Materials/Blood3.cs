using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Materials
{
    public class Blood3 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rushing Deep Red Blood");
            Tooltip.SetDefault("From crimson creatures.");
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
                int dust = Dust.NewDust(item.position * Main.rand.Next(1, 2), item.width, item.height, mod.DustType("Blood3Dust"));
                Main.dust[dust].scale = Main.rand.Next(6, 12) * .1f;
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Vertebrae, 5);
            recipe.AddIngredient(mod.ItemType("SoulofSlime"), 5);
            recipe.AddIngredient(mod.ItemType("IchorDroplets"), 20);
            recipe.AddIngredient(mod.ItemType("Blood3"), 300);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.CrimsonRod);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Vertebrae, 5);
            recipe.AddIngredient(mod.ItemType("SoulofSlime"), 2);
            recipe.AddIngredient(mod.ItemType("IchorDroplets"), 5);
            recipe.AddIngredient(mod.ItemType("Blood3"), 30);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.CrimsonHeart);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Vertebrae, 5);
            recipe.AddIngredient(mod.ItemType("SoulofSlime"), 5);
            recipe.AddIngredient(mod.ItemType("IchorDroplets"), 20);
            recipe.AddIngredient(mod.ItemType("Blood3"), 300);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.TheRottedFork);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Vertebrae, 5);
            recipe.AddIngredient(mod.ItemType("SoulofSlime"), 5);
            recipe.AddIngredient(mod.ItemType("IchorDroplets"), 10);
            recipe.AddIngredient(mod.ItemType("Blood3"), 225);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.PanicNecklace);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Vertebrae, 5);
            recipe.AddIngredient(mod.ItemType("SoulofSlime"), 5);
            recipe.AddIngredient(mod.ItemType("IchorDroplets"), 20);
            recipe.AddIngredient(mod.ItemType("Blood3"), 300);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.TheUndertaker);
            recipe.AddRecipe();
        }
    }
}