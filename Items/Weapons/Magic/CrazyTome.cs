using System;
using IL.Terraria;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Magic
{
    public class CrazyTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crazy Tome");
        }
        public override void SetDefaults()
        {
            item.damage = 28;
            item.magic = true;                     //this make the item do magic damage
            item.width = 24;
            item.height = 28;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = ItemUseStyleID.HoldingOut;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 1000;
            item.rare = ItemRarityID.Orange;
            item.mana = 12;             //mana use
            item.UseSound = SoundID.Item21;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("CrazyBall");
            item.shootSpeed = 6;    //projectile speed when shoot
        }
	}
}