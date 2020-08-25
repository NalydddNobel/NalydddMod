using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Accessories
{
    public class CovetedBeingBand : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases maximum mana and health by 20.\nIncreases mana and life regeneration rate.\nGives lava immunity for 7 seconds.\nMakes you immune to the 'On Fire' debuff");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.value = 20000;
            item.rare = ItemRarityID.LightPurple;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statManaMax2 += 20;
            player.statLifeMax2 += 20;
            player.lifeRegen += 6;
            player.manaRegen += 6;
            player.lavaMax = 420;
            player.onFire = false;
            player.onFire2 = false;
        }
        public override bool CanEquipAccessory(Player player, int slot)
        {
            if (slot < 10)
            {
                int maxAccessoryIndex = 5 + player.extraAccessorySlots;
                for (int i = 3; i < 3 + maxAccessoryIndex; i++)
                {
                    if (slot != i && player.armor[i].type == mod.ItemType("WellBeingBand"))
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
            recipe.AddIngredient(mod.ItemType("WellBeingBand"));
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(mod.ItemType("SoulofGrime"), 20);
            recipe.AddTile(mod.TileType("MetalWorkshopTile"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}