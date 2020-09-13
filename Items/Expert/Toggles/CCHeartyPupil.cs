using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Toggles
{
    public class CCHeartyPupil : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hearty Pupil");
            Tooltip.SetDefault("Use in order to permanently activate King Slime's expert accessory's effect\nSuper Buffed");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SuspiciousLookingEye);
            item.width = 32;
            item.height = 48;
            item.consumable = true;
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
            return !player.GetModPlayer<MyPlayer>().eoCEffect && MyWorld.extraBuffedMode;
        }
        public override bool UseItem(Player player)
        {
            Main.NewText("You have been ", (byte)MyPlayer.masterColorR, (byte)MyPlayer.masterColorG, 255);
            player.GetModPlayer<MyPlayer>().eoCEffect = true;
            return true;
        }
    }
}