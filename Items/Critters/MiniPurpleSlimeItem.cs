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
    public class MiniPurpleSlimeItem : ModItem
    {
        public override string Texture => "nalydmod/Items/Critters/MiniSlimeItem";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mini Purple Slime");
            Tooltip.SetDefault("Cute!");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Worm);
            item.scale = 2.08f;
            item.color = Colors.RarityBlue;
            item.bait = 12;
            item.makeNPC = (short)mod.NPCType("MiniPurpleSlime");
        }      
    }
}