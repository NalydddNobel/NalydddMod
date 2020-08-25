using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Summon
{
    public class MaggotBait : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Maggot Bait");
            Tooltip.SetDefault("Summons a Flying Hungry Maggot to fight for you.\nTakes up 3/4ths of a minion slot.");

        }
        public override void SetDefaults()
        {
            item.damage = 10;
            item.summon = true;
            item.mana = 10;
            item.width = 26;
            item.height = 28;
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.buyPrice(0, 30, 0, 0);
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item44;
            item.shoot = mod.ProjectileType("HungryMaggot");
            item.shootSpeed = 7f;
            item.buffTime = 3600;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Blood2"), 5);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}