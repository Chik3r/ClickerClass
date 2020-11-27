using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClickerClass.Items.Weapons.Clickers
{
	public class GoldClicker : ClickerWeapon
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Gold Clicker");
		}

		public override void SetDefaults()
		{
			base.SetDefaults();
			SetRadius(item, 1.6f);
			SetColor(item, new Color(255, 200, 25, 0));
			SetDust(item, 10);
			SetAmount(item, 8);
			SetEffect(item, "Double Click");


			item.damage = 8;
			item.width = 30;
			item.height = 30;
			item.knockBack = 1f;
			item.value = 9000;
			item.rare = 0;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}
