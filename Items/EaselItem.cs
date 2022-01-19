using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
//using Terraria.GameContent.Creative;

namespace CraftablePaintings.Items
{
	public class EaselItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Easel");
			Tooltip.SetDefault("Used to craft paintings");
			//CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{

			item.maxStack = 999;
			item.consumable = true;
			item.width = 32;
			item.height = 48;
			item.value = Item.sellPrice(0, 0, 1, 0);
			item.rare = ItemRarityID.White;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.createTile = ModContent.TileType<Tiles.EaselTile>();
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 6);
			recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
			recipe.AddIngredient(ItemID.Paintbrush, 1);
			recipe.AddTile(TileID.Sawmill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}