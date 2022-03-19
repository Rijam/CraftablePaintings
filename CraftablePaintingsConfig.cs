using System.ComponentModel;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace CraftablePaintings
{
	/// <summary>
	/// This config operates on a server basis. 
	/// These parameters are synced from the server.
	/// </summary>
	[Label("Server Options")]
	public class CraftablePaintingsConfigServer : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

		[Header("[c/00FF00:Server Options]")]
		[Label("[i:3122]   Craft Modded Paintings")]
		[Tooltip("This option toggles if paintings from the supported mods can be crafted.\n" +
			"  When On: All modded paintings WILL be craftable.\n" +
			"  When Off: All modded paintings WILL NOT be craftable.\n" +
			"    Turn Off in case of a mod conflict or you are getting\n" +
			"    errors stating that a recipe has no result.\n" +
			"Default value: Off\n" +
			"Reload required.")]
		[ReloadRequired]
		[DefaultValue(false)]
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
				message = "You are not the server owner so you can not change this config!";
				return false;
			}
			return base.AcceptClientChanges(pendingConfig, whoAmI, ref message);
		}
		/* */
	}
}