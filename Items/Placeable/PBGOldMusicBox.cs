using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace OldCalamityMusic.Items.Placeable
{
	public class PBGOldMusicBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (Plaguebringer Goliath - Old)");
			Tooltip.SetDefault("Plays 'Terraria Remix - Eye of Cthulhu'" +
				"\nBy DM DOKURO");
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = TileType<Tiles.PBGOldMusicBox>();
			item.width = 32;
			item.height = 32;
			item.rare = 4;
			item.value = 100000;
			item.accessory = true;
		}

		public override void AddRecipes()
		{
			Mod CalamityMod = ModLoader.GetMod("CalamityMod");
			ModRecipe recipe = new ModRecipe(mod);
			{
				recipe.AddIngredient(CalamityMod.ItemType("PlagueCellCluster"), 5);
				recipe.AddIngredient(ItemID.MusicBox);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}