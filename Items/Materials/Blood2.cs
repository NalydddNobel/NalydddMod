using IL.Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using On.Terraria;
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
            DisplayName.SetDefault("Green Blood Droplet");
            Tooltip.SetDefault("From undead creatures.");

        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 10;
            item.value = 20000;
            item.maxStack = 999;
            item.rare = ItemRarityID.White;
            Terraria.Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 3));
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EbonstoneBlock, 1);
            recipe.AddIngredient(ItemID.CrimstoneBlock, 1);
            recipe.AddIngredient(ItemID.RottenChunk, 1);
            recipe.AddTile(TileID.SkullLanterns);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EbonstoneBlock, 1);
            recipe.AddIngredient(ItemID.CrimstoneBlock, 1);
            recipe.AddIngredient(ItemID.Vertebrae, 1);
            recipe.AddTile(TileID.SkullLanterns);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
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
            recipe.AddIngredient(mod.ItemType("SoulofSlime"), 4);
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




