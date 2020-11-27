using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClickerClass.Items.Weapons.Clickers
{
	public class ArthursClicker : ClickerWeapon
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Arthur's Clicker");
		}

		public override void SetDefaults()
		{
			base.SetDefaults();
			SetRadius(item, 3.5f);
			SetColor(item, new Color(255, 225, 0, 0));
			SetDust(item, 87);
			SetAmount(item, 12);
			SetEffect(item, "Holy Nova");


			item.damage = 50;
			item.width = 30;
			item.height = 30;
			item.knockBack = 1f;
			item.value = 210000;
			item.rare = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(Mod);
			recipe.AddIngredient(ItemID.HallowedBar, 8);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
