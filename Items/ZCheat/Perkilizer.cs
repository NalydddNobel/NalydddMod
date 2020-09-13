using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.ZCheat
{
    public class Perkilizer : ModItem
    {
        public override string Texture => "nalydmod/Items/Materials/GemFragments/BasicFragment";
        bool toggle;
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Toggles all consumable permanent player effects.\nCheat Item.");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SuspiciousLookingEye);
            item.scale = 2;
            item.consumable = false;
            item.maxStack = 1;
        }
        public override bool UseItem(Player player)
        {
            if (!toggle)
            {
                player.GetModPlayer<MyPlayer>().kingSlimeEffect = false;
                player.GetModPlayer<MyPlayer>().eoCEffect = false;
                player.GetModPlayer<MyPlayer>().eoWEffect = false;
                player.GetModPlayer<MyPlayer>().boCEffect = false;
                player.GetModPlayer<MyPlayer>().queenBeeEffect = false;
                player.GetModPlayer<MyPlayer>().skeletronEffect = false;
                player.GetModPlayer<MyPlayer>().geodeWormEffect = false;
                player.GetModPlayer<MyPlayer>().ancientMageEffect = false;
                player.GetModPlayer<MyPlayer>().lifeFractals = 0;
                player.GetModPlayer<MyPlayer>().manaFractals = 0;
                Main.NewText("Set all permanent player effect variables to false", 200, 200, 200);
                toggle = true;
                return true;
            }
            if (toggle)
            {
                player.GetModPlayer<MyPlayer>().kingSlimeEffect = true;
                player.GetModPlayer<MyPlayer>().eoCEffect = true;
                player.GetModPlayer<MyPlayer>().eoWEffect = true;
                player.GetModPlayer<MyPlayer>().boCEffect = true;
                player.GetModPlayer<MyPlayer>().queenBeeEffect = true;
                player.GetModPlayer<MyPlayer>().skeletronEffect = true;
                player.GetModPlayer<MyPlayer>().geodeWormEffect = true;
                player.GetModPlayer<MyPlayer>().ancientMageEffect = true;
                player.GetModPlayer<MyPlayer>().lifeFractals = 10;
                player.GetModPlayer<MyPlayer>().manaFractals = 5;
                Main.NewText("Set all permanent player effect variables to true", 200, 200, 200); 
                toggle = false;
                return true;
            }
            return true;
        }
    }
}