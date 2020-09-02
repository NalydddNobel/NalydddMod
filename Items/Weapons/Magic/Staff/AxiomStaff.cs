using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Weapons.Magic.Staff
{
    public class AxiomStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Staff of Axiom");
            Tooltip.SetDefault("Shoots spliting orbs of [c/8D89DF:corruption] / [c/B74544:crimson]");
            Terraria.Item.staff[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.damage = 196;
            item.magic = true;
            item.width = 64;
            item.height = 64;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.knockBack = 0.9f;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = false;
            item.shoot = mod.ProjectileType("MagicDirtBall");
            item.shootSpeed = 16f;
            item.noMelee = true;
            item.rare = 11;
            item.mana = 11;
        }
        public override void ModifyTooltips(System.Collections.Generic.List<TooltipLine> list)
        {
            foreach (TooltipLine line2 in list)
            {
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                {
                    line2.overrideColor = Global.BaseColor.LightPurple;
                }
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("HHSoulofAxiom"), 25);
            recipe.AddIngredient(ItemID.LunarBar, 30);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}