using IL.Terraria;
using System.Collections;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;

namespace nalydmod.Items.TreasureBags
{
    public class TreasureBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("Right Click to open");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void OpenBossBag(Terraria.Player player)
        {
            player.TryGettingDevArmor();

            player.QuickSpawnItem(mod.ItemType("Nalydwings"), 1);
        }
    }
    
}




