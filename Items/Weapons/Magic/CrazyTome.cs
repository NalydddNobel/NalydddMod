using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Magic
{
    public class CrazyTome : ModItem
    {
        public int projChoice;
        public int projChoice2;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crazy Tome");
        }
        public override void SetDefaults()
        {            
            item.damage = 28;
            item.magic = true;
            item.width = 24;
            item.height = 28;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 1000;
            item.rare = ItemRarityID.Orange;
            item.mana = 12;
            item.UseSound = SoundID.Item21;
            item.autoReuse = true;
            item.shootSpeed = 2;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            projChoice = (int)Main.rand.NextFloat(1, 4);
            switch ((int)Main.rand.NextFloat(1, 4))
            {
                case 1:
                    item.shoot = ProjectileID.BallofFire;
                    break;
                case 2:
                    item.shoot = ProjectileID.SpectreWrath;
                    break;
                case 3:
                    item.shoot = ProjectileID.CursedFlameFriendly;
                    break;
                case 4:
                    item.shoot = ProjectileID.UnholyTridentFriendly;
                    break;
            }
            return true;
        }
    }
}