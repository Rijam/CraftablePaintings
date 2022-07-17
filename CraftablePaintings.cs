using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CraftablePaintings.Tiles;
using CraftablePaintings.Items;
using System;

namespace CraftablePaintings
{
    public class CraftablePaintings : Mod
    {
        public static CraftablePaintings Instance;
        public static CraftablePaintingsConfigServer ConfigServer;
        
        public override void Unload()
        {
            Instance = null;
            ConfigServer = null;
        }

		//Adapted from absoluteAquarian's GraphicsLib
		public override object Call(params object[] args)
		{
			if (args is null)
				throw new ArgumentNullException(nameof(args));

			if (args[0] is not string function)
				throw new ArgumentException("Expected a function name for the first argument");

			return function switch
			{
				"CraftModdedPaintings" => (bool)ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings,
				_ => throw new ArgumentException($"Function \"{function}\" is not defined by BossesAsNPCs"),
			};
		}
	}
}