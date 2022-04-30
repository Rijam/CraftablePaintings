using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace CraftablePaintings.Items
{
	public class Canvas : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
		}
		public override void SetDefaults()
		{
			Item.maxStack = 999;
			Item.width = 46;
			Item.height = 36;
			Item.value = Item.sellPrice(0, 0, 4, 0);
			Item.rare = ItemRarityID.White;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.Hay, 2)
				.AddTile(TileID.Loom)
				.Register();

			CreateRecipe()
				.AddIngredient(ItemID.Silk, 2)
				.AddTile(TileID.Loom)
				.Register();
		}
	}
}