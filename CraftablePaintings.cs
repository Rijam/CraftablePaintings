using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CraftablePaintings.Tiles;
using CraftablePaintings.Items;

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
    }
}