using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Materials
{
    public class Blood : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rushing Blood");
            Tooltip.SetDefault("From living creatures.");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 10;
            item.value = 100;
            item.maxStack = 999;
            item.rare = ItemRarityID.White;
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 3));
        }
        public override void Update(ref float gravity, ref float maxFallSpeed)
        {
            if (Main.rand.Next(44) == 0)
            {
                int dust = Dust.NewDust(item.position * Main.rand.Next(1, 2), item.width, item.height, mod.DustType("Blood1Dust"));
                Main.dust[dust].scale = Main.rand.Next(6, 12) * .1f;
            }
        }
    }
}