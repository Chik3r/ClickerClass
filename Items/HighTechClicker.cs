using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ObjectData;
using ClickerClass.Buffs;

namespace ClickerClass.Items
{
	public class HighTechClicker : ClickerItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("High Tech Clicker");
			Tooltip.SetDefault("Click on an enemy within range and sight to damage them");
		}
		
		public override void SetDefaults()
		{
			isClicker = true;
			radiusBoost = 6f;
			clickerColorItem = new Color(75, 255, 200, 0);
			clickerDustColor = 226;
			itemClickerAmount = 10;
			itemClickerEffect = "Discharge";
			itemClickerColorEffect = "59ffcd";
			
			item.damage = 98;
			item.width = 30;
			item.height = 30;
			item.useTime = 1;
			item.useAnimation = 1;
			item.useStyle = 5;
			item.holdStyle = 3;
			item.knockBack = 1f;
			item.value = 1000;
			item.rare = 8;
			item.shoot = mod.ProjectileType("ClickDamage");
			item.shootSpeed = 1f;
		}
	}
}