using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Accessories
{
    public class MagicLifeBand : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases maximum mana and health by 20\nIncreases mana and health regeneration rate");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.alpha = 30;
            item.color = Color.Transparent;
            item.value = 20000;
            item.rare = ItemRarityID.Green;
            item.accessory = true;
        }
        public override bool CanEquipAccessory(Player player, int slot)
        {
            if (slot < 10)
            {
                int maxAccessoryIndex = 5 + player.extraAccessorySlots;
                for (int i = 3; i < 3 + maxAccessoryIndex; i++)
                {
                    if (slot != i && player.armor[i].type == mod.ItemType("CovetedBeingBand"))
                    {
                        return false;
                    }
                    if (slot != i && player.armor[i].type == mod.ItemType("WellBeingBand"))
                    {
                        return false;
                    }
                    if (slot != i && player.armor[i].type == mod.ItemType("LifeBand"))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statManaMax2 += 20;
            player.statLifeMax2 += 20;
            player.lifeRegen += 5;
            player.manaRegen += 5;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("LifeBand"));
            recipe.AddIngredient(ItemID.BandofStarpower);
            recipe.AddIngredient(mod.ItemType("SoulofTime"), 10);
            recipe.AddIngredient(mod.ItemType("Blood3"), 50);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}