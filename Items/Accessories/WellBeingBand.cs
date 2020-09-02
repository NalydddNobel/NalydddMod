using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Accessories
{
    public class WellBeingBand : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases maximum mana and health by 20.\nIncreases mana and life regeneration rate.\nGives lava immunity for 7 seconds.");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.alpha = 30;
            item.color = Color.Transparent;
            item.value = 20000;
            item.rare = ItemRarityID.Orange;
            item.accessory = true;
        }
        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.statManaMax2 += 20;
            player.statLifeMax2 += 20;
            player.lifeRegen += 6;
            player.manaRegen += 6;
            player.lavaMax = 420;
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
                    if (slot != i && player.armor[i].type == mod.ItemType("MagicLifeBand"))
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
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("MagicLifeBand"));
            recipe.AddIngredient(ItemID.LavaCharm);
            recipe.AddIngredient(mod.ItemType("SoulofSpine"), 10);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}




