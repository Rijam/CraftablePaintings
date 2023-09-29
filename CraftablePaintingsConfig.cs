using System.ComponentModel;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace CraftablePaintings
{
	/// <summary>
	/// This config operates on a server basis. 
	/// These parameters are synced from the server.
	/// </summary>
	public class CraftablePaintingsConfigServer : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

		[Header("ServerHeader")]
		[ReloadRequired]
		[DefaultValue(true)]
		public bool CraftModdedPaintings { get; set; }

		/* Not written by Rijam*/
		public static bool IsPlayerLocalServerOwner(int whoAmI)
		{
			if (Main.netMode == NetmodeID.MultiplayerClient)
			{
				return Netplay.Connection.Socket.GetRemoteAddress().IsLocalHost();
			}

			for (int i = 0; i < Main.maxPlayers; i++)
			{
				RemoteClient client = Netplay.Clients[i];
				if (client.State == 10 && i == whoAmI && client.Socket.GetRemoteAddress().IsLocalHost())
				{
					return true;
				}
			}
			return false;
		}

		public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
		{
			if (Main.netMode == NetmodeID.SinglePlayer)
			{
				return true;
			}

			if (!IsPlayerLocalServerOwner(whoAmI))
			{
				//message = NetworkText.FromKey("Mods.CraftablePaintings.Configs.CraftablePaintingsConfigServer.MultiplayerMessage");
				message = Language.GetTextValue("Mods.CraftablePaintings.Configs.CraftablePaintingsConfigServer.MultiplayerMessage");
				return false;
			}
			return base.AcceptClientChanges(pendingConfig, whoAmI, ref message);
		}
		/* */
	}
}