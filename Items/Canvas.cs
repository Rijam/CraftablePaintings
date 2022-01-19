using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
//using Terraria.GameContent.Creative;

namespace CraftablePaintings.Items
{
	public class Canvas : ModItem
	{
		public override void SetStaticDefaults()
		{
			//CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
		}
		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.width = 46;
			item.height = 36;
			item.value = Item.sellPrice(0, 0, 4, 0);
			item.rare = ItemRarityID.White;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Hay, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}