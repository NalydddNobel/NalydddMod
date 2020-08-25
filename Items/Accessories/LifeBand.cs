using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Accessories
{
    public class LifeBand : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Band of Life");
            Tooltip.SetDefault("Increases maximum health by 20");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.alpha = 30;
            item.color = Color.Transparent;
            item.value = 20000;
            item.rare = ItemRarityID.Blue;
            item.accessory = true;
        }
        public override bool CanEquipAccessory(Player player, int slot)
        {
            if (slot < 10)
            {
                int maxAccessoryIndex = 5 + player.extraAccessorySlots;
                for (int i = 3; i < 3 + maxAccessoryIndex; i++)
                {
                    if (slot != i && player.armor[i].type == mod.ItemType("MagicLifeBand"))
                    {
                        return false;
                    }
                    if (slot != i && player.armor[i].type == mod.ItemType("WellBeingBand"))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.statLifeMax2 += 20;
        }
    }
}




