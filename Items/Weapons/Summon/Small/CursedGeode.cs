using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Weapons.Summon.Small
{
    public class CursedGeode : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons a Cursed Geode to fight for you.\nSmall Summon");
            ItemID.Sets.GamepadWholeScreenUseRange[item.type] = true;
            ItemID.Sets.LockOnIgnoresCollision[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SlimeStaff);
            item.damage = 9;
            item.width = 24;
            item.height = 24;
            item.useStyle = 4;
            item.value = Item.buyPrice(0, 1, 20, 0);
            item.rare = 0;
            item.shoot = mod.ProjectileType("CursedGeode");
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
        bool start;
        float red;
        float green;
        float blue;
        public override void Update(ref float gravity, ref float maxFallSpeed)
        {
            if (!start)
            {
                red = 0.5f;
                green = 0.5f;
                blue = 0.5f;
                start = true;
            }
            else
            {
                {
                    if (red > 1.5)
                    {
                        red = 1.5f;
                    }
                    red += Main.rand.Next(-1, 2) * 0.01f;
                }
                {
                    if (green > 1.5)
                    {
                        green = 1.5f;
                    }
                    green += Main.rand.Next(-1, 2) * 0.01f;
                }
                {
                    if (blue > 1.5)
                    {
                        blue = 1.5f;
                    }
                    blue += Main.rand.Next(-1, 2) * 0.01f;
                }
            }
            Lighting.AddLight((int)(item.position.X / 16f), (int)(item.position.Y / 16f), red, green, blue);
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