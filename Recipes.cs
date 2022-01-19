using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CraftablePaintings.Tiles;
using CraftablePaintings.Items;

namespace CraftablePaintings
{
    public class Recipes : ModSystem
    {
        public override void AddRecipes()
        {
            #region Golfer
            Recipe recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepGreenPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.GolfPainting2);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepGreenPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.GolfPainting3);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepGreenPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.GolfPainting4);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();
            #endregion

            #region Painter Normal
            recipe = Mod.CreateRecipe(ItemID.ColdWatersintheWhiteLand);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.WhitePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.Daylight);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.GreenPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.DeadlandComesAlive);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.RedPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.DoNotStepontheGrass);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepLimePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.EvilPresence);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepRedPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.FirstEncounter);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.LimePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.GoodMorning);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.YellowPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.TheLandofDeceivingLooks);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.CyanPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.LightlessChasms);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.PurplePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.PlaceAbovetheClouds);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.SkyBluePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.SecretoftheSands);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.YellowPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.SkyGuardian);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.WhitePaint);
            recipe.AddIngredient(ItemID.SoulofFlight);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.ThroughtheWindow);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.GreenPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.UndergroundReward);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.RedPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();
            #endregion

            #region Painter Graveyard
            recipe = Mod.CreateRecipe(ItemID.Nevermore);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BlackPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.AddCondition(Recipe.Condition.InGraveyardBiome);
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.Reborn);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.ShadowPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.AddCondition(Recipe.Condition.InGraveyardBiome);
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.Graveyard);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BlackPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.AddCondition(Recipe.Condition.InGraveyardBiome);
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.GhostManifestation);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.NegativePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.AddCondition(Recipe.Condition.InGraveyardBiome);
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.WickedUndead);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.YellowPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.AddCondition(Recipe.Condition.InGraveyardBiome);
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.BloodyGoblet);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepRedPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.AddCondition(Recipe.Condition.InGraveyardBiome);
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.StillLife);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.GrayPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.AddCondition(Recipe.Condition.InGraveyardBiome);
            recipe.Register();
            #endregion

            #region Princess
            recipe = Mod.CreateRecipe(ItemID.Princess64);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.PinkPaint);
            recipe.AddIngredient(ItemID.SoulofLight);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.PaintingOfALass);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.PinkPaint);
            recipe.AddIngredient(ItemID.SoulofLight);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.DarkSideHallow);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.GlowPaint);
            recipe.AddIngredient(ItemID.SoulofLight);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();
            #endregion

            #region Traveling Merchant
            recipe = Mod.CreateRecipe(ItemID.PaintingAcorns);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.RedPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.PaintingCastleMarsberg);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.GreenPaint);
            recipe.AddIngredient(ItemID.MartianConduitPlating);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.PaintingColdSnap);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepBluePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.PaintingCursedSaint);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.SkyBluePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.PaintingMartiaLisa);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.GreenPaint);
            recipe.AddIngredient(ItemID.MartianConduitPlating);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.MoonLordPainting);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.TealPaint);
            recipe.AddIngredient(ItemID.LunarOre);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.PaintingWilson);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.PaintingWillow);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.PaintingWendy);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.PaintingWolfgang);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.PaintingTheSeason);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.WhitePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.PaintingSnowfellas);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.WhitePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.PaintingTheTruthIsUpThere);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepSkyBluePaint);
            recipe.AddIngredient(ItemID.MartianConduitPlating);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();
            #endregion

            #region Desert Underground Cabins
            recipe = Mod.CreateRecipe(ItemID.AndrewSphinx);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.YellowPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.WatchfulAntlion);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.OrangePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.BurningSpirit);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.VioletPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.JawsOfDeath);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.YellowPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.TheSandsOfSlime);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.YellowPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.SnakesIHateSnakes);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BlackPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.LifeAboveTheSand);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.YellowPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.Oasis);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BluePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.PrehistoryPreserved);
            recipe.AddIngredient(ItemID.Sandstone);
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.AncientTablet);
            recipe.AddIngredient(ItemID.Sandstone);
            recipe.AddIngredient(ItemID.YellowPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.Uluru);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.OrangePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.VisitingThePyramids);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.SkyBluePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.BandageBoy);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.GrayPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.DivineEye);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.WhitePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();
            #endregion

            #region Underground Cabins
            recipe = Mod.CreateRecipe(ItemID.AmericanExplosive);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.OrangePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.CrownoDevoursHisLunch);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.Discover);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.SkyBluePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.FatherofSomeone);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.OrangePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.FindingGold);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepYellowPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.GloriousNight);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BlackPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.GuidePicasso);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.OrangePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.Land);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.TheMerchant);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.NurseLisa);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.GrayPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.OldMiner);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.GrayPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.RareEnchantment);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.VioletPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.Sunflowers);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepYellowPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.TerrarianGothic);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.CyanPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.Waldo);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.WhitePaint);
            recipe.AddIngredient(ItemID.RedPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();
            #endregion

            #region Dungeon
            recipe = Mod.CreateRecipe(ItemID.BloodMoonRising);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.RedPaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.BoneWarp);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.WhitePaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.TheCreationoftheGuide);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.WhitePaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.TheCursedMan);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.WhitePaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.TheDestroyer);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepPurplePaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.Dryadisque);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.LimePaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.TheEyeSeestheEnd);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.FacingtheCerebralMastermind);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.PinkPaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.GloryoftheFire);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BlackPaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.GoblinsPlayingPoker);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.CyanPaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.GreatWave);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BluePaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.TheGuardiansGaze);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.TheHangedMan);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BlackPaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.Impact);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.TealPaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.ThePersistencyofEyes);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.PoweredbyBirds);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.WhitePaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.TheScreamer);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.OrangePaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.SkellingtonJSkellingsworth);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.SparkyPainting);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.SomethingEvilisWatchingYou);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepGreenPaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.StarryNight);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepSkyBluePaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.TrioSuperHeroes);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.TheTwinsHaveAwoken);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepGreenPaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.UnicornCrossingtheHallows);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepPinkPaint);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();
            #endregion

            #region Underworld
            recipe = Mod.CreateRecipe(ItemID.DarkSoulReaper);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepRedPaint);
            recipe.AddIngredient(ItemID.AshBlock);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.Darkness);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.ShadowPaint);
            recipe.AddIngredient(ItemID.AshBlock);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.DemonsEye);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.RedPaint);
            recipe.AddIngredient(ItemID.AshBlock);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.FlowingMagma);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepOrangePaint);
            recipe.AddIngredient(ItemID.AshBlock);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.HandEarth);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.OrangePaint);
            recipe.AddIngredient(ItemID.AshBlock);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.ImpFace);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.OrangePaint);
            recipe.AddIngredient(ItemID.AshBlock);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.LakeofFire);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepOrangePaint);
            recipe.AddIngredient(ItemID.AshBlock);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.LivingGore);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.RedPaint);
            recipe.AddIngredient(ItemID.AshBlock);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.OminousPresence);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepOrangePaint);
            recipe.AddIngredient(ItemID.AshBlock);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.ShiningMoon);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.SkyBluePaint);
            recipe.AddIngredient(ItemID.AshBlock);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.Skelehead);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddIngredient(ItemID.AshBlock);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.TrappedGhost);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.WhitePaint);
            recipe.AddIngredient(ItemID.AshBlock);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();
            #endregion

            #region Goodie Bags
            recipe = Mod.CreateRecipe(ItemID.BitterHarvest);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepOrangePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.BloodMoonCountess);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.DeepPurplePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.HallowsEve);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.OrangePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.JackingSkeletron);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.PurplePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();

            recipe = Mod.CreateRecipe(ItemID.MorbidCuriosity);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.WhitePaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();
            #endregion

            #region Angler
            recipe = Mod.CreateRecipe(ItemID.PillaginMePixels);
            recipe.AddIngredient(ModContent.ItemType<Canvas>());
            recipe.AddIngredient(ItemID.BrownPaint);
            recipe.AddTile(ModContent.TileType<EaselTile>());
            recipe.Register();
            #endregion

            #region SGAmod (Disabled)
            /*Mod sgamod = ModLoader.GetMod("SGAmod");
            if (sgamod != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GreenPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(sgamod.ItemType("DergPainting"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.LimePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(sgamod.ItemType("CalmnessPainting"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.YellowPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(sgamod.ItemType("MeetingTheSunPainting"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.SkyBluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(sgamod.ItemType("AdventurePainting"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.WhitePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(sgamod.ItemType("SerenityPainting"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GreenPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(sgamod.ItemType("UnderTheWaterfallPainting"));
                recipe.Register();
            }*/
            #endregion

            #region Polarities (Disabled)
            /*Mod polarities = ModLoader.GetMod("Polarities");
            if (polarities != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.CyanPaint);
                recipe.AddIngredient(polarities.ItemType("FractalStrands"));
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(polarities.ItemType("WarpedLandscape"));
                recipe.Register();
            }*/
            #endregion

            #region Thorium (Disabled)
            /*Mod thorium = ModLoader.GetMod("ThoriumMod");
            if (thorium != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepRedPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("AToastPaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepTealPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("AquaticParadisePaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepTealPaint);
                recipe.AddIngredient(ItemID.SoulofLight);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("CuriousSeaLifePaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepPurplePaint);
                recipe.AddIngredient(ItemID.SoulofNight);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("CursedHarvestPaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepBluePaint);
                recipe.AddIngredient(ItemID.Bone);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("EarthenEnergyPaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.YellowPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("JellyintheWaterPaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepBluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("JollyRogerPaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepTealPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("LastSupperPaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GrayPaint);
                recipe.AddIngredient(ItemID.Bone);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("LoudFootstepsPaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepRedPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("RedMistPaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GrayPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("ShroudedbytheStormPaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.CyanPaint);
                recipe.AddIngredient(ItemID.Ectoplasm);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("SpectralSymphonyPaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.OrangePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("PumpkinPaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GrayPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("TheFoggyFiferPaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GrayPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("ThunderOverDesertSkiesPaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepVioletPaint);
                recipe.AddIngredient(ItemID.LunarOre);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("TitanicTrioPaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("UnderseaBountyPaint"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.WhitePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("UnspokenPain"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GrayPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(thorium.ItemType("GrayDPaintingItem"));
                recipe.Register();
            }*/
            #endregion

            #region Calamity's Vanities (Disabled)
            /*Mod calvalex = ModLoader.GetMod("CalValEX");
            if (calvalex != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.LimePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Plague22"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.VioletPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("CirrusBooze"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GreenPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("SundayAfternoon"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("AccidentalAbominationn"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("SwearingShroom"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.OrangePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("BlazingConflict"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.LimePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("CalamiteaTime"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GrayPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Yharlamitas"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.RedPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("ModIconPainting"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.RedPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("WilliamPainting"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.VioletPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("CosmicTerror"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("DarkMagic"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepPurplePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Duality"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepVioletPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Espelho"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepSkyBluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Frozen"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.YellowPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("CalamityFriends"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.SkyBluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("LostSouls"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepBluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("NotLikeHome"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Clam"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.VioletPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("RogueExtractor"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.TealPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Scourgy"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.PurplePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Signut"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.TealPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("SleepingGiant"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.TealPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("Snouts"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("TheGreatSandworm"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.YellowPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("TheYhar"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.TealPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("UnholyTrip"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.RedPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("VVanities"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.SkyBluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(calvalex.ItemType("WormHeaven"));
                recipe.Register();
            }*/
            #endregion

            #region pinkymod (Disabled)
            /*Mod pinkymod = ModLoader.GetMod("pinkymod");
            if (pinkymod != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.WhitePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(pinkymod.ItemType("OverlyDetailedChickenScratch"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.WhitePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(pinkymod.ItemType("WormBossIndicator"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.SkyBluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(pinkymod.ItemType("RoketLunchced"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.OrangePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(pinkymod.ItemType("FerniumPainting"));
                recipe.Register();

                //

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.WhitePaint);
                recipe.AddTile(pinkymod.TileType("EaselTile"));
                recipe.SetResult(pinkymod.ItemType("OverlyDetailedChickenScratch"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.WhitePaint);
                recipe.AddTile(pinkymod.TileType("EaselTile"));
                recipe.SetResult(pinkymod.ItemType("WormBossIndicator"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.SkyBluePaint);
                recipe.AddTile(pinkymod.TileType("EaselTile"));
                recipe.SetResult(pinkymod.ItemType("RoketLunchced"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.OrangePaint);
                recipe.AddTile(pinkymod.TileType("EaselTile"));
                recipe.SetResult(pinkymod.ItemType("FerniumPainting"));
                recipe.Register();
            }*/
            #endregion

            #region Shadows of Abaddon (Disabled)
            /*Mod soa = ModLoader.GetMod("SacredTools");
            if (soa != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.WhitePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("Kappa"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("Daryl"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GrayPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("KipSmug"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.PurplePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("Polarius"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.OrangePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("MoodPainting"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("LunaticCultistPainting"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.PurplePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("AbaddonPainting"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.WhitePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("GodOfTerraria"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.PurplePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("Warmth"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.SkyBluePaint);
                recipe.AddIngredient(ItemID.LunarOre);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(soa.ItemType("Deepfreeze"));
                recipe.Register();
            }*/
            #endregion

            #region Spirit (Disabled)
            /*Mod spirit = ModLoader.GetMod("SpiritMod");
            if (spirit != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.RedPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting1"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.CyanPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting10"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GrayPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting11"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.CyanPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting12"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.TealPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting13"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.PurplePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting14"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.TealPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting15"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.OrangePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting16"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepBluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting17"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting18"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.SkyBluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting19"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.YellowPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting2"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.WhitePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting20"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.WhitePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting21"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.CyanPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting22"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting23"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting3"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepTealPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting4"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.TealPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting5"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.TealPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting6"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GreenPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting7"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting8"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.SkyBluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("AdvPainting9"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.VioletPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("DuskingPainting"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepBluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("FishingPainting"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(spirit.ItemType("FloppaPainting"));
                recipe.Register();
            }*/
            #endregion

            #region Split (Disabled)
            /*Mod split = ModLoader.GetMod("Split");
            if (split != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GreenPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("ChildOfTheCorn"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.PurplePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("OneAndOnly"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.PurplePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("OneSmallStepForAPirate"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.VioletPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("TheThunderbolt"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.YellowPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("OOOMagicianOOO"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.WhitePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("BigFan"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GrayPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("DrCool"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.PurplePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("FamiliarFace"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.CyanPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("FilthyFranChan"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("FullHouse"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GrayPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("IDRTO"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.SkyBluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("IBB"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.PurplePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("LadyInWaiting"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("Loneliness"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepBluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("MJ"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepPurplePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("TheGlassman"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepPurplePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("ManOfShadows"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddIngredient(ItemID.Wood);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("MissingPoster"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("MysteryMan"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.WhitePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("PageTurner"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.LimePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("SpinalGalaxy"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("TheIntruder"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.OrangePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("TheNexus"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.OrangePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("TheSandbox"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("TheTremor"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddIngredient(ItemID.Wood);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("WantedPoster"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepBluePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("Aurora"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GreenPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("EverybodyLovesGlowtoad"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepVioletPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("KingoftheNight"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.PurplePaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(split.ItemType("TheGraduation"));
                recipe.Register();
            }*/
            #endregion

            #region Fargo's Mutant Mod
            if (ModLoader.TryGetMod("Fargowiltas", out Mod fargoMutant) && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = Mod.CreateRecipe(fargoMutant.Find<ModItem>("EchPainting").Type);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.WhitePaint);
                recipe.AddIngredient(ItemID.LunarOre);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.Register();
            }
            #endregion

            #region Fargo's Soul Mod (Disabled)
            /*Mod fargoSoul = ModLoader.GetMod("FargowiltasSouls");
            if (fargoSoul != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.PurplePaint);
                recipe.AddIngredient(ItemID.BeeWax);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(fargoSoul.ItemType("TwentyTwoPainting"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddIngredient(fargoSoul.ItemType("Sadism"));
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(fargoSoul.ItemType("ScremPainting"));
                recipe.Register();
            }*/
            #endregion

            #region Mod of Redemption (Disabled)
            /*Mod mor = ModLoader.GetMod("Redemption");
            if (mor != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GrayPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(mor.ItemType("BrothersPainting"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.BrownPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(mor.ItemType("ForestGolemPainting"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.GrayPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(mor.ItemType("BrothersPaintingAlt"));
                recipe.Register();
            }*/
            #endregion

            #region Amongst the Cosmos (Disabled)
            /*Mod atc = ModLoader.GetMod("ATC");
            if (atc != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.DeepGreenPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(atc.ItemType("AccursedWoods"));
                recipe.Register();

                recipe = Mod.CreateRecipe(ItemID.GolfPainting1);
                recipe.AddIngredient(ModContent.ItemType<Canvas>());
                recipe.AddIngredient(ItemID.RedPaint);
                recipe.AddTile(ModContent.TileType<EaselTile>());
                recipe.SetResult(atc.ItemType("PrayUnderTheCrimsonMoon"));
                recipe.Register();
            }*/
            #endregion
        }
    }
}