using ClickerClass.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClickerClass.Items.Armors
{
	[AutoloadEquip(EquipType.Head)]
	public class OverclockHelmet : ClickerItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 30000;
			item.rare = 6;
			item.defense = 8;
		}

		public override void UpdateEquip(Player player)
		{
			player.GetModPlayer<ClickerPlayer>().clickerBonus += 1;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<OverclockSuit>() && legs.type == ModContent.ItemType<OverclockBoots>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = LangHelper.GetText("SetBonus.Overclock");
			player.GetModPlayer<ClickerPlayer>().setOverclock = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 14);
			recipe.AddIngredient(ItemID.SoulofSight, 6);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}