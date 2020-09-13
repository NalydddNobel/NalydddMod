using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.AADev
{
    public class AANalydsPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nalyd's Potion");
            Tooltip.SetDefault("Used to test out buffs\nMay contain dangerous doses of everything bad\nGives the 'Deadly Flames' debuff");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArcheryPotion);
            item.rare = ItemRarityID.Blue;
            item.buffType = ModContent.BuffType<Buffs.DeadlyFlamesDeBuff>();
            item.buffTime = 3600;
        }
    }
}