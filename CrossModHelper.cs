using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftablePaintings
{
	public class CrossModHelper
	{
		/// <summary>
		/// Safely returns the integer of the ModItem from the given mod.
		/// </summary>
		/// <param name="mod">The mod that the item is from.</param>
		/// <param name="itemString">The class name of the item.</param>
		/// <returns>int if found, 0 if not found.</returns>
		public static int SafelyGetCrossModItem(Mod mod, string itemString)
		{
			mod.TryFind<ModItem>(itemString, out ModItem outItem);
			if (outItem != null)
			{
				return outItem.Type;
			}
			ModContent.GetInstance<CraftablePaintings>().Logger.WarnFormat("SafelyGetCrossModItem(): ModItem type \"{0}\" from \"{1}\" was not found.", itemString, mod);
			return 0;
		}
	}
}