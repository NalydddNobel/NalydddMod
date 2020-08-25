using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Summon
{
    public class SlimyTissue : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bloody Tissue");
            Tooltip.SetDefault("Summons a Sneezy Skull to fight for you.");

        }
        public override void SetDefaults()
        {
            item.damage = 5;
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
            item.shoot = mod.ProjectileType("TissueSkull");
            item.shootSpeed = 7f;
            item.buffTime = 3600;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("BloodyTissue"));
            recipe.AddIngredient(ItemID.Gel, 5);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}