using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Placeables.Special.Decor.Furniture.Special
{
    public class AATotemofExperteese : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Totem of Experteese");
            Tooltip.SetDefault("You have activated Super Buff Mode!\nSuper Buffed");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.DirtBlock);
            item.createTile = mod.TileType("FurnDecorStyle2x3");
            item.placeStyle = 0;
        }
        public override void ModifyTooltips(List<TooltipLine> list)
        {
            foreach (TooltipLine line2 in list)
            {
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                {
                    line2.overrideColor = MyPlayer.BaseColor.Master;
                }
            }
        }
        public override bool CanUseItem(Player player)
        {
            if (MyWorld.extraBuffedMode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}