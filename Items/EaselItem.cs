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

			Item.maxStack = 999;
			Item.consumable = true;
			Item.width = 32;
			Item.height = 48;
			Item.value = Item.sellPrice(0, 0, 1, 0);
			Item.rare = ItemRarityID.White;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.createTile = ModContent.TileType<Tiles.EaselTile>();
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddRecipeGroup(RecipeGroupID.Wood, 6)
				.AddIngredient(ModContent.ItemType<Canvas>())
				.AddIngredient(ItemID.Paintbrush)
				.AddTile(TileID.Sawmill)
				.Register();
		}
	}
}