using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Weapons.Summon
{
    public class BloodyTissue : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bloody Rattle");
            Tooltip.SetDefault("Summons a Sneezy Skull to fight for you.\nSmall Summon");
            ItemID.Sets.GamepadWholeScreenUseRange[item.type] = true;
            ItemID.Sets.LockOnIgnoresCollision[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SlimeStaff);
            item.damage = 5;
            item.width = 26;
            item.height = 24;
            item.value = Item.buyPrice(0, 0, 8, 0);
            item.rare = ItemRarityID.White;
            item.shoot = mod.ProjectileType("TissueSkull");
            item.buffType = ModContent.BuffType<Buffs.BloodSkullBuff>();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            player.AddBuff(item.buffType, 2);
            position = Main.MouseWorld;
            return true;
        }
        public override bool CanUseItem(Player player)
        {
            if (player.GetModPlayer<MyPlayer>().smallSummon < player.GetModPlayer<MyPlayer>().maxSmallSummon)
            {
                return true;
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Blood"), 5);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}