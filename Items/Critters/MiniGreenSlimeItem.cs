using Terraria;
using nalydmod.Items.Materials.Expert;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using nalydmod.Items.Materials.GemFragments;
using nalydmod.Items.Materials.GemFragmentsq;
using nalydmod.Items.Materials;
using Terraria.ID;
using nalydmod.Items.Accessories;
using nalydmod.Npcs.Enemies.DemonEyes;

namespace nalydmod.Items.TreasureBags
{
    public class MiniGreenSlimeItem : ModItem
    {
        public override string Texture => "nalydmod/Items/Critters/MiniSlimeItem";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mini Green Slime");
            Tooltip.SetDefault("Cute!");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Worm);
            item.scale = 2f;
            item.color = Colors.RarityGreen;
            item.bait = 12;
            item.makeNPC = (short)mod.NPCType("MiniGreenSlime");
        }      
    }
}