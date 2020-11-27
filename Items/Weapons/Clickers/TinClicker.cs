using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClickerClass.Items.Weapons.Clickers
{
	public class TinClicker : ClickerWeapon
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Tin Clicker");
		}

		public override void SetDefaults()
		{
			base.SetDefaults();
			SetRadius(item, 1.15f);
			SetColor(item, new Color(125, 125, 75, 0));
			SetDust(item, 81);
			SetAmount(item, 10);
			SetEffect(item, "Double Click");


			item.damage = 4;
			item.width = 30;
			item.height = 30;
			item.knockBack = 2f;
			item.value = 675;
			item.rare = 0;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.TinBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}
