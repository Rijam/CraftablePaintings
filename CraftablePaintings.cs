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
        public override void AddRecipes()
        {
            #region Golfer
            /*ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepGreenPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.GolfPainting1, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepGreenPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.GolfPainting2, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepGreenPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.GolfPainting3, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.GolfPainting4, 1);
            recipe.AddRecipe();*/
            #endregion

            #region Painter Normal
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.WhitePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.ColdWatersintheWhiteLand, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.GreenPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.Daylight, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.RedPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.DeadlandComesAlive, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepLimePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.DoNotStepontheGrass, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepRedPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.EvilPresence, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.LimePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.FirstEncounter, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.YellowPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.GoodMorning, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.CyanPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.TheLandofDeceivingLooks, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.PurplePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.LightlessChasms, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.SkyBluePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PlaceAbovetheClouds, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.YellowPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.SecretoftheSands, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.WhitePaint, 1);
            recipe.AddIngredient(ItemID.SoulofFlight, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.SkyGuardian, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.GreenPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.ThroughtheWindow, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.RedPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.UndergroundReward, 1);
            recipe.AddRecipe();
            #endregion

            #region Painter Graveyard
            /*recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BlackPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.Nevermore, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.ShadowPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.Reborn, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BlackPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.Graveyard, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.NegativePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.GhostManifestation, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.YellowPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.WickedUndead, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepRedPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.BloodyGoblet, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.GrayPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.StillLife, 1);
            recipe.AddRecipe();*/
            #endregion

            #region Princess
            /*recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.PinkPaint, 1);
            recipe.AddIngredient(ItemID.SoulofLight, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.Princess64, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.PinkPaint, 1);
            recipe.AddIngredient(ItemID.SoulofLight, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PaintingOfALass, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.IlluminantPaint, 1);
            recipe.AddIngredient(ItemID.SoulofLight, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.DarkSideHallow, 1);
            recipe.AddRecipe();*/
            #endregion

            #region Traveling Merchant
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.RedPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PaintingAcorns, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.GreenPaint, 1);
            recipe.AddIngredient(ItemID.MartianConduitPlating, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PaintingCastleMarsberg, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepBluePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PaintingColdSnap, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.SkyBluePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PaintingCursedSaint, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.GreenPaint, 1);
            recipe.AddIngredient(ItemID.MartianConduitPlating, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PaintingMartiaLisa, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.TealPaint, 1);
            recipe.AddIngredient(ItemID.LunarOre, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.MoonLordPainting, 1);
            recipe.AddRecipe();

            /*recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PaintingWilson, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PaintingWillow, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PaintingWendy, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PaintingWolfgang, 1);
            recipe.AddRecipe();*/

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.WhitePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PaintingTheSeason, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.WhitePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PaintingSnowfellas, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepSkyBluePaint, 1);
            recipe.AddIngredient(ItemID.MartianConduitPlating, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PaintingTheTruthIsUpThere, 1);
            recipe.AddRecipe();
            #endregion

            #region Desert Underground Cabins
            /*recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.YellowPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.AndrewSphinx, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.OrangePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.WatchfulAntlion, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.VioletPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.BurningSpirit, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.YellowPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.JawsOfDeath, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.YellowPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.TheSandsOfSlime, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BlackPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.SnakesIHateSnakes, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.YellowPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.LifeAboveTheSand, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BluePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.Oasis, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Sandstone, 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PrehistoryPreserved, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Sandstone, 1);
            recipe.AddIngredient(ItemID.YellowPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.AncientTablet, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.OrangePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.Uluru, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.SkyBluePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.VisitingThePyramids, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.GrayPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.BandageBoy, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.WhitePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.DivineEye, 1);
            recipe.AddRecipe();*/
            #endregion

            #region Underground Cabins
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.OrangePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.AmericanExplosive, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.CrownoDevoursHisLunch, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.SkyBluePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.Discover, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.OrangePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.FatherofSomeone, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepYellowPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.FindingGold, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BlackPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.GloriousNight, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.OrangePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.GuidePicasso, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.Land, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.TheMerchant, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.GrayPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.NurseLisa, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.GrayPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.OldMiner, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.VioletPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.RareEnchantment, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepYellowPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.Sunflowers, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.CyanPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.TerrarianGothic, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.WhitePaint, 1);
            recipe.AddIngredient(ItemID.RedPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.Waldo, 1);
            recipe.AddRecipe();
            #endregion

            #region Dungeon
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.RedPaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.BloodMoonRising, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.WhitePaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.BoneWarp, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.WhitePaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.TheCreationoftheGuide, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.WhitePaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.TheCursedMan, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepPurplePaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.TheDestroyer, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.LimePaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.Dryadisque, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.TheEyeSeestheEnd, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.PinkPaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.FacingtheCerebralMastermind, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BlackPaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.GloryoftheFire, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.CyanPaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.GoblinsPlayingPoker, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BluePaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.GreatWave, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.TheGuardiansGaze, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BlackPaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.TheHangedMan, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.TealPaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.Impact, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.ThePersistencyofEyes, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.WhitePaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PoweredbyBirds, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.OrangePaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.TheScreamer, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.SkellingtonJSkellingsworth, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.SparkyPainting, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepGreenPaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.SomethingEvilisWatchingYou, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepSkyBluePaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.StarryNight, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.TrioSuperHeroes, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepGreenPaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.TheTwinsHaveAwoken, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepPinkPaint, 1);
            recipe.AddIngredient(ItemID.Bone, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.UnicornCrossingtheHallows, 1);
            recipe.AddRecipe();
            #endregion

            #region Underworld
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepRedPaint, 1);
            recipe.AddIngredient(ItemID.AshBlock, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.DarkSoulReaper, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.ShadowPaint, 1);
            recipe.AddIngredient(ItemID.AshBlock, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.Darkness, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.RedPaint, 1);
            recipe.AddIngredient(ItemID.AshBlock, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.DemonsEye, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepOrangePaint, 1);
            recipe.AddIngredient(ItemID.AshBlock, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.FlowingMagma, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.OrangePaint, 1);
            recipe.AddIngredient(ItemID.AshBlock, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.HandEarth, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.OrangePaint, 1);
            recipe.AddIngredient(ItemID.AshBlock, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.ImpFace, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepOrangePaint, 1);
            recipe.AddIngredient(ItemID.AshBlock, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.LakeofFire, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.RedPaint, 1);
            recipe.AddIngredient(ItemID.AshBlock, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.LivingGore, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepOrangePaint, 1);
            recipe.AddIngredient(ItemID.AshBlock, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.OminousPresence, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.SkyBluePaint, 1);
            recipe.AddIngredient(ItemID.AshBlock, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.ShiningMoon, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddIngredient(ItemID.AshBlock, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.Skelehead, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.WhitePaint, 1);
            recipe.AddIngredient(ItemID.AshBlock, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.TrappedGhost, 1);
            recipe.AddRecipe();
            #endregion

            #region Goodie Bags
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepOrangePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.BitterHarvest, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.DeepPurplePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.BloodMoonCountess, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.OrangePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.HallowsEve, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.PurplePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.JackingSkeletron, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.WhitePaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.MorbidCuriosity, 1);
            recipe.AddRecipe();
            #endregion

            #region Angler
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
            recipe.AddIngredient(ItemID.BrownPaint, 1);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.SetResult(ItemID.PillaginMePixels, 1);
            recipe.AddRecipe();
            #endregion

            #region SGAmod
            Mod sgamod = ModLoader.GetMod("SGAmod");
            if (sgamod != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GreenPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(sgamod.ItemType("DergPainting"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.LimePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(sgamod.ItemType("CalmnessPainting"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.YellowPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(sgamod.ItemType("MeetingTheSunPainting"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.SkyBluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(sgamod.ItemType("AdventurePainting"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.WhitePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(sgamod.ItemType("SerenityPainting"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GreenPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(sgamod.ItemType("UnderTheWaterfallPainting"), 1);
                recipe.AddRecipe();
            }
            #endregion

            #region Polarities
            Mod polarities = ModLoader.GetMod("Polarities");
            if (polarities != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.CyanPaint, 1);
                recipe.AddIngredient(polarities.ItemType("FractalStrands"), 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(polarities.ItemType("WarpedLandscape"), 1);
                recipe.AddRecipe();
            }
            #endregion

            #region Thorium
            Mod thorium = ModLoader.GetMod("ThoriumMod");
            if (thorium != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepRedPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("AToastPaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepTealPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("AquaticParadisePaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepTealPaint, 1);
                recipe.AddIngredient(ItemID.SoulofLight, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("CuriousSeaLifePaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepPurplePaint, 1);
                recipe.AddIngredient(ItemID.SoulofNight, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("CursedHarvestPaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepBluePaint, 1);
                recipe.AddIngredient(ItemID.Bone, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("EarthenEnergyPaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.YellowPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("JellyintheWaterPaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepBluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("JollyRogerPaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepTealPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("LastSupperPaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GrayPaint, 1);
                recipe.AddIngredient(ItemID.Bone, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("LoudFootstepsPaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepRedPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("RedMistPaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GrayPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("ShroudedbytheStormPaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.CyanPaint, 1);
                recipe.AddIngredient(ItemID.Ectoplasm, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("SpectralSymphonyPaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.OrangePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("PumpkinPaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GrayPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("TheFoggyFiferPaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GrayPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("ThunderOverDesertSkiesPaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepVioletPaint, 1);
                recipe.AddIngredient(ItemID.LunarOre, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("TitanicTrioPaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("UnderseaBountyPaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.WhitePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("UnspokenPain"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GrayPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("GrayDPaintingItem"), 1);
                recipe.AddRecipe();
            }
            #endregion

            #region Calamity's Vanities
            Mod calvalex = ModLoader.GetMod("CalValEX");
            if (calvalex != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.LimePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Plague22"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.VioletPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("CirrusBooze"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GreenPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("SundayAfternoon"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("AccidentalAbominationn"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("SwearingShroom"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.OrangePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("BlazingConflict"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.LimePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("CalamiteaTime"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GrayPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Yharlamitas"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.VioletPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("ModIconPainting"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.RedPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("WilliamPainting"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.VioletPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("CosmicTerror"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("DarkMagic"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepPurplePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Duality"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepVioletPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Espelho"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepSkyBluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Frozen"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.YellowPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("CalamityFriends"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.SkyBluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("LostSouls"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepBluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("NotLikeHome"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Clam"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.VioletPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("RogueExtractor"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.TealPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Scourgy"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.PurplePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Signut"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.TealPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("SleepingGiant"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.TealPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Snouts"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("TheGreatSandworm"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.YellowPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("TheYhar"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.TealPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("UnholyTrip"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.RedPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("VVanities"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.SkyBluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("WormHeaven"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.RedPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("CalamityPaint"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepOrangePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("CalamityPaintRetold"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BlackPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("DraedonPopcorn"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GrayPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("EyeofXeroc"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.RedPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("OldModIconPainting"), 1);
                recipe.AddRecipe();
            }
            #endregion

            #region pinkymod
            Mod pinkymod = ModLoader.GetMod("pinkymod");
            if (pinkymod != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.WhitePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(pinkymod.ItemType("OverlyDetailedChickenScratch"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.WhitePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(pinkymod.ItemType("WormBossIndicator"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.SkyBluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(pinkymod.ItemType("RoketLunchced"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.OrangePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(pinkymod.ItemType("FerniumPainting"), 1);
                recipe.AddRecipe();

                //
                
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.WhitePaint, 1);
                recipe.AddTile(pinkymod.TileType("EaselTile"));
                recipe.SetResult(pinkymod.ItemType("OverlyDetailedChickenScratch"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.WhitePaint, 1);
                recipe.AddTile(pinkymod.TileType("EaselTile"));
                recipe.SetResult(pinkymod.ItemType("WormBossIndicator"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.SkyBluePaint, 1);
                recipe.AddTile(pinkymod.TileType("EaselTile"));
                recipe.SetResult(pinkymod.ItemType("RoketLunchced"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.OrangePaint, 1);
                recipe.AddTile(pinkymod.TileType("EaselTile"));
                recipe.SetResult(pinkymod.ItemType("FerniumPainting"), 1);
                recipe.AddRecipe();
            }
            #endregion

            #region Shadows of Abaddon
            Mod soa = ModLoader.GetMod("SacredTools");
            if (soa != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.WhitePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("Kappa"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("Daryl"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GrayPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("KipSmug"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.PurplePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("Polarius"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.OrangePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("MoodPainting"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("LunaticCultistPainting"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.PurplePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("AbaddonPainting"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.WhitePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("GodOfTerraria"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.PurplePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("Warmth"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.SkyBluePaint, 1);
                recipe.AddIngredient(ItemID.LunarOre, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("Deepfreeze"), 1);
                recipe.AddRecipe();
            }
            #endregion

            #region Spirit
            Mod spirit = ModLoader.GetMod("SpiritMod");
            if (spirit != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.RedPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting1"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.CyanPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting10"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GrayPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting11"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.CyanPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting12"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.TealPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting13"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.PurplePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting14"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.TealPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting15"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.OrangePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting16"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepBluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting17"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting18"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.SkyBluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting19"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.YellowPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting2"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.WhitePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting20"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.WhitePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting21"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.CyanPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting22"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting23"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting3"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepTealPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting4"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.TealPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting5"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.TealPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting6"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GreenPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting7"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting8"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.SkyBluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting9"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.VioletPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("DuskingPainting"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepBluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("FishingPainting"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("FloppaPainting"), 1);
                recipe.AddRecipe();
            }
            #endregion

            #region Split
            Mod split = ModLoader.GetMod("Split");
            if (split != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GreenPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("ChildOfTheCorn"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.PurplePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("OneAndOnly"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.PurplePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("OneSmallStepForAPirate"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.VioletPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("TheThunderbolt"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.YellowPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("OOOMagicianOOO"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.WhitePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("BigFan"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GrayPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("DrCool"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.PurplePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("FamiliarFace"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.CyanPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("FilthyFranChan"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("FullHouse"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GrayPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("IDRTO"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.SkyBluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("IBB"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.PurplePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("LadyInWaiting"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("Loneliness"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepBluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("MJ"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepPurplePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("TheGlassman"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepPurplePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("ManOfShadows"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddIngredient(ItemID.Wood, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("MissingPoster"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("MysteryMan"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.WhitePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("PageTurner"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.LimePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("SpinalGalaxy"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("TheIntruder"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.OrangePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("TheNexus"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.OrangePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("TheSandbox"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("TheTremor"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddIngredient(ItemID.Wood, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("WantedPoster"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepBluePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("Aurora"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GreenPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("EverybodyLovesGlowtoad"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepVioletPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("KingoftheNight"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.PurplePaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("TheGraduation"), 1);
                recipe.AddRecipe();
            }
            #endregion

            #region Fargo's Mutant Mod
            Mod fargoMutant = ModLoader.GetMod("Fargowiltas");
            if (fargoMutant != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.WhitePaint, 1);
                recipe.AddIngredient(ItemID.LunarOre, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(fargoMutant.ItemType("EchPainting"), 1);
                recipe.AddRecipe();
            }
            #endregion

            #region Fargo's Soul Mod
            Mod fargoSoul = ModLoader.GetMod("FargowiltasSouls");
            if (fargoSoul != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.PurplePaint, 1);
                recipe.AddIngredient(ItemID.BeeWax, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(fargoSoul.ItemType("TwentyTwoPainting"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddIngredient(fargoSoul.ItemType("Sadism"), 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(fargoSoul.ItemType("ScremPainting"), 1);
                recipe.AddRecipe();
            }
            #endregion

            #region Mod of Redemption
            Mod mor = ModLoader.GetMod("Redemption");
            if (mor != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GrayPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(mor.ItemType("BrothersPainting"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.BrownPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(mor.ItemType("ForestGolemPainting"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.GrayPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(mor.ItemType("BrothersPaintingAlt"), 1);
                recipe.AddRecipe();
            }
            #endregion

            #region Amongst the Cosmos
            Mod atc = ModLoader.GetMod("ATC");
            if (atc != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.DeepGreenPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(atc.ItemType("AccursedWoods"), 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ModContent.ItemType<Canvas>(), 1);
                recipe.AddIngredient(ItemID.RedPaint, 1);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(atc.ItemType("PrayUnderTheCrimsonMoon"), 1);
                recipe.AddRecipe();
            }
            #endregion
        }
        public override void Unload()
        {
            Instance = null;
            ConfigServer = null;
        }
    }
}