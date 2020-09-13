using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Accessories.AExpert.ABoss
{
    [AutoloadEquip(EquipType.Waist)]
    public class BBBagofGems : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bag of Gems");
            Tooltip.SetDefault("Makes healing gem fragments drop from enemies.");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 20000;
            item.rare = ItemRarityID.Blue;
            item.expert = true;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (!MyPlayer.gemAccessory)
            {
                MyPlayer.gemAccessory = true;
            }
        }
    }
}