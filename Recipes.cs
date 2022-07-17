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
            Recipe.Create(ItemID.GolfPainting1)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepGreenPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.GolfPainting2)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepGreenPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.GolfPainting3)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepGreenPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.GolfPainting4)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BrownPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();
            #endregion

            #region Painter Normal
            Recipe.Create(ItemID.ColdWatersintheWhiteLand)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.WhitePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.Daylight)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.GreenPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.DeadlandComesAlive)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.RedPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.DoNotStepontheGrass)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepLimePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.EvilPresence)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepRedPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.FirstEncounter)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.LimePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.GoodMorning)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.YellowPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.TheLandofDeceivingLooks)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.CyanPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.LightlessChasms)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.PurplePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.PlaceAbovetheClouds)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.SkyBluePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.SecretoftheSands)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.YellowPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.SkyGuardian)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.WhitePaint)
                .AddIngredient(ItemID.SoulofFlight)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.ThroughtheWindow)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.GreenPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.UndergroundReward)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.RedPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();
            #endregion

            #region Painter Graveyard
            Recipe.Create(ItemID.Nevermore)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BlackPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .AddCondition(Recipe.Condition.InGraveyardBiome)
                .Register();

            Recipe.Create(ItemID.Reborn)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.ShadowPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .AddCondition(Recipe.Condition.InGraveyardBiome)
                .Register();

            Recipe.Create(ItemID.Graveyard)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BlackPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .AddCondition(Recipe.Condition.InGraveyardBiome)
                .Register();

            Recipe.Create(ItemID.GhostManifestation)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.NegativePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .AddCondition(Recipe.Condition.InGraveyardBiome)
                .Register();

            Recipe.Create(ItemID.WickedUndead)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.YellowPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .AddCondition(Recipe.Condition.InGraveyardBiome)
                .Register();

            Recipe.Create(ItemID.BloodyGoblet)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepRedPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .AddCondition(Recipe.Condition.InGraveyardBiome)
                .Register();

            Recipe.Create(ItemID.StillLife)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.GrayPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .AddCondition(Recipe.Condition.InGraveyardBiome)
                .Register();
            #endregion

            #region Princess
            Recipe.Create(ItemID.Princess64)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.PinkPaint)
                .AddIngredient(ItemID.SoulofLight)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.PaintingOfALass)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.PinkPaint)
                .AddIngredient(ItemID.SoulofLight)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.DarkSideHallow)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.GlowPaint)
                .AddIngredient(ItemID.SoulofLight)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();
            #endregion

            #region Traveling Merchant
            Recipe.Create(ItemID.PaintingAcorns)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.RedPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.PaintingCastleMarsberg)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.GreenPaint)
                .AddIngredient(ItemID.MartianConduitPlating)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.PaintingColdSnap)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepBluePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.PaintingCursedSaint)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.SkyBluePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.PaintingMartiaLisa)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.GreenPaint)
                .AddIngredient(ItemID.MartianConduitPlating)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.MoonLordPainting)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.TealPaint)
                .AddIngredient(ItemID.LunarOre)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.PaintingWilson)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BrownPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.PaintingWillow)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BrownPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.PaintingWendy)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BrownPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.PaintingWolfgang)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BrownPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.PaintingTheSeason)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.WhitePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.PaintingSnowfellas)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.WhitePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.PaintingTheTruthIsUpThere)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepSkyBluePaint)
                .AddIngredient(ItemID.MartianConduitPlating)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();
            #endregion

            #region Desert Underground Cabins
            Recipe.Create(ItemID.AndrewSphinx)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.YellowPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.WatchfulAntlion)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.OrangePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.BurningSpirit)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.VioletPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.JawsOfDeath)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.YellowPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.TheSandsOfSlime)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.YellowPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.SnakesIHateSnakes)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BlackPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.LifeAboveTheSand)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.YellowPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.Oasis)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BluePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.PrehistoryPreserved)
                .AddIngredient(ItemID.Sandstone)
                .AddIngredient(ItemID.BrownPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.AncientTablet)
                .AddIngredient(ItemID.Sandstone)
                .AddIngredient(ItemID.YellowPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.Uluru)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.OrangePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.VisitingThePyramids)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.SkyBluePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.BandageBoy)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.GrayPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.DivineEye)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.WhitePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();
            #endregion

            #region Underground Cabins
            Recipe.Create(ItemID.AmericanExplosive)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.OrangePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.CrownoDevoursHisLunch)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BrownPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.Discover)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.SkyBluePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.FatherofSomeone)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.OrangePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.FindingGold)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepYellowPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.GloriousNight)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BlackPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.GuidePicasso)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.OrangePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.Land)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BrownPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.TheMerchant)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BrownPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.NurseLisa)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.GrayPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.OldMiner)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.GrayPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.RareEnchantment)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.VioletPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.Sunflowers)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepYellowPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.TerrarianGothic)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.CyanPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.Waldo)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.WhitePaint)
                .AddIngredient(ItemID.RedPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();
            #endregion

            #region Dungeon
            Recipe.Create(ItemID.BloodMoonRising)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.RedPaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.BoneWarp)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.WhitePaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.TheCreationoftheGuide)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.WhitePaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.TheCursedMan)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.WhitePaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.TheDestroyer)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepPurplePaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.Dryadisque)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.LimePaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.TheEyeSeestheEnd)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BrownPaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.FacingtheCerebralMastermind)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.PinkPaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.GloryoftheFire)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BlackPaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.GoblinsPlayingPoker)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.CyanPaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.GreatWave)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BluePaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.TheGuardiansGaze)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BrownPaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.TheHangedMan)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BlackPaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.Impact)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.TealPaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.ThePersistencyofEyes)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BrownPaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.PoweredbyBirds)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.WhitePaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.TheScreamer)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.OrangePaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.SkellingtonJSkellingsworth)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BrownPaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.SparkyPainting)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BrownPaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.SomethingEvilisWatchingYou)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepGreenPaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.StarryNight)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepSkyBluePaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.TrioSuperHeroes)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BrownPaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.TheTwinsHaveAwoken)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepGreenPaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.UnicornCrossingtheHallows)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepPinkPaint)
                .AddIngredient(ItemID.Bone)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();
            #endregion

            #region Underworld
            Recipe.Create(ItemID.DarkSoulReaper)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepRedPaint)
                .AddIngredient(ItemID.AshBlock)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.Darkness)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.ShadowPaint)
                .AddIngredient(ItemID.AshBlock)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.DemonsEye)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.RedPaint)
                .AddIngredient(ItemID.AshBlock)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.FlowingMagma)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepOrangePaint)
                .AddIngredient(ItemID.AshBlock)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.HandEarth)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.OrangePaint)
                .AddIngredient(ItemID.AshBlock)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.ImpFace)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.OrangePaint)
                .AddIngredient(ItemID.AshBlock)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.LakeofFire)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepOrangePaint)
                .AddIngredient(ItemID.AshBlock)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.LivingGore)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.RedPaint)
                .AddIngredient(ItemID.AshBlock)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.OminousPresence)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepOrangePaint)
                .AddIngredient(ItemID.AshBlock)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.ShiningMoon)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.SkyBluePaint)
                .AddIngredient(ItemID.AshBlock)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.Skelehead)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BrownPaint)
                .AddIngredient(ItemID.AshBlock)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.TrappedGhost)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.WhitePaint)
                .AddIngredient(ItemID.AshBlock)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();
            #endregion

            #region Goodie Bags
            Recipe.Create(ItemID.BitterHarvest)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepOrangePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.BloodMoonCountess)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.DeepPurplePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.HallowsEve)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.OrangePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.JackingSkeletron)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.PurplePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();

            Recipe.Create(ItemID.MorbidCuriosity)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.WhitePaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();
            #endregion

            #region Angler
            Recipe.Create(ItemID.PillaginMePixels)
                .AddIngredient(ModContent.ItemType<Canvas>())
                .AddIngredient(ItemID.BrownPaint)
                .AddTile(ModContent.TileType<EaselTile>())
                .Register();
            #endregion

            bool craftModdedPaintings = ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings;

            #region SGAmod (Disabled)
            /*Mod sgamod = ModLoader.GetMod("SGAmod");
            if (sgamod != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GreenPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(sgamod.Find<ModItem>("DergPainting"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.LimePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(sgamod.Find<ModItem>("CalmnessPainting"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.YellowPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(sgamod.Find<ModItem>("MeetingTheSunPainting"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.SkyBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(sgamod.Find<ModItem>("AdventurePainting"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(sgamod.Find<ModItem>("SerenityPainting"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GreenPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(sgamod.Find<ModItem>("UnderTheWaterfallPainting"));
                    .Register();
            }*/
            #endregion

            #region Polarities (Disabled)
            /*Mod polarities = ModLoader.GetMod("Polarities");
            if (polarities != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.CyanPaint);
                    .AddIngredient(polarities.Find<ModItem>("FractalStrands"));
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(polarities.Find<ModItem>("WarpedLandscape"));
                    .Register();
            }*/
            #endregion

            #region Thorium (Disabled)
            /*Mod thorium = ModLoader.GetMod("ThoriumMod");
            if (thorium != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepRedPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("AToastPaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepTealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("AquaticParadisePaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepTealPaint);
                    .AddIngredient(ItemID.SoulofLight);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("CuriousSeaLifePaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepPurplePaint);
                    .AddIngredient(ItemID.SoulofNight);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("CursedHarvestPaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepBluePaint);
                    .AddIngredient(ItemID.Bone);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("EarthenEnergyPaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.YellowPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("JellyintheWaterPaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("JollyRogerPaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepTealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("LastSupperPaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddIngredient(ItemID.Bone);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("LoudFootstepsPaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepRedPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("RedMistPaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("ShroudedbytheStormPaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.CyanPaint);
                    .AddIngredient(ItemID.Ectoplasm);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("SpectralSymphonyPaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.OrangePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("PumpkinPaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("TheFoggyFiferPaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("ThunderOverDesertSkiesPaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepVioletPaint);
                    .AddIngredient(ItemID.LunarOre);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("TitanicTrioPaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("UnderseaBountyPaint"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("UnspokenPain"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.Find<ModItem>("GrayDPaintingItem"));
                    .Register();
            }*/
            #endregion

            #region Calamity's Vanities
            if (ModLoader.TryGetMod("CalValEX", out Mod calvalex) && craftModdedPaintings)
            {
                Recipe.Create(calvalex.Find<ModItem>("AccidentalAbominationn").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.BrownPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("BlazingConflict").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.OrangePaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("CalamiteaTime").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.LimePaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("CalamityFriends").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.YellowPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("CalamityPaint").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.RedPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("CalamityPaintRetold").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.YellowPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("CirrusBooze").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.VioletPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("Clam").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.BrownPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("CosmicTerror").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.VioletPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("DarkMagic").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.BrownPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("DraedonPopcorn").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.BrownPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("Duality").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.DeepPurplePaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("Espelho").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.DeepVioletPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("EyeofXeroc").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.DeepVioletPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("Frozen").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.DeepSkyBluePaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("LostSouls").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.SkyBluePaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("ModIconPainting").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.VioletPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("NotLikeHome").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.DeepBluePaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("OldModIconPainting").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.RedPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("OldUCMMPainting").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.RedPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("Plague22").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.LimePaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("RogueExtractor").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.VioletPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("Scourgy").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.TealPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("Signut").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.PurplePaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("SleepingGiant").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.TealPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("Snouts").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.TealPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("SundayAfternoon").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.GreenPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("SwearingShroom").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.BluePaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("TheGreatSandworm").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.BrownPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("TheYhar").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.YellowPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("UCMMPainting").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.BluePaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("UnholyTrip").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.TealPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("VVanities").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.RedPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("WilliamPainting").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.RedPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("WormHeaven").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.SkyBluePaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(calvalex.Find<ModItem>("Yharlamitas").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.GrayPaint)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();
            }
            #endregion

            #region pinkymod (Disabled)
            /*Mod pinkymod = ModLoader.GetMod("pinkymod");
            if (pinkymod != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(pinkymod.Find<ModItem>("OverlyDetailedChickenScratch"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(pinkymod.Find<ModItem>("WormBossIndicator"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.SkyBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(pinkymod.Find<ModItem>("RoketLunchced"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.OrangePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(pinkymod.Find<ModItem>("FerniumPainting"));
                    .Register();

                //

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(pinkymod.TileType("EaselTile"));
                    .SetResult(pinkymod.Find<ModItem>("OverlyDetailedChickenScratch"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(pinkymod.TileType("EaselTile"));
                    .SetResult(pinkymod.Find<ModItem>("WormBossIndicator"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.SkyBluePaint);
                    .AddTile(pinkymod.TileType("EaselTile"));
                    .SetResult(pinkymod.Find<ModItem>("RoketLunchced"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.OrangePaint);
                    .AddTile(pinkymod.TileType("EaselTile"));
                    .SetResult(pinkymod.Find<ModItem>("FerniumPainting"));
                    .Register();
            }*/
            #endregion

            #region Shadows of Abaddon (Disabled)
            /*Mod soa = ModLoader.GetMod("SacredTools");
            if (soa != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.Find<ModItem>("Kappa"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.Find<ModItem>("Daryl"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.Find<ModItem>("KipSmug"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.Find<ModItem>("Polarius"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.OrangePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.Find<ModItem>("MoodPainting"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.Find<ModItem>("LunaticCultistPainting"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.Find<ModItem>("AbaddonPainting"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.Find<ModItem>("GodOfTerraria"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.Find<ModItem>("Warmth"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.SkyBluePaint);
                    .AddIngredient(ItemID.LunarOre);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.Find<ModItem>("Deepfreeze"));
                    .Register();
            }*/
            #endregion

            #region Spirit (Disabled)
            /*Mod spirit = ModLoader.GetMod("SpiritMod");
            if (spirit != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.RedPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting1"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.CyanPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting10"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting11"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.CyanPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting12"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.TealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting13"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting14"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.TealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting15"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.OrangePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting16"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting17"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting18"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.SkyBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting19"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.YellowPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting2"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting20"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting21"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.CyanPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting22"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting23"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting3"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepTealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting4"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.TealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting5"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.TealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting6"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GreenPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting7"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting8"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.SkyBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("AdvPainting9"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.VioletPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("DuskingPainting"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("FishingPainting"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.Find<ModItem>("FloppaPainting"));
                    .Register();
            }*/
            #endregion

            #region Split (Disabled)
            /*Mod split = ModLoader.GetMod("Split");
            if (split != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GreenPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("ChildOfTheCorn"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("OneAndOnly"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("OneSmallStepForAPirate"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.VioletPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("TheThunderbolt"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.YellowPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("OOOMagicianOOO"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("BigFan"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("DrCool"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("FamiliarFace"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.CyanPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("FilthyFranChan"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("FullHouse"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("IDRTO"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.SkyBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("IBB"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("LadyInWaiting"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("Loneliness"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("MJ"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepPurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("TheGlassman"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepPurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("ManOfShadows"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddIngredient(ItemID.Wood);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("MissingPoster"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("MysteryMan"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("PageTurner"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.LimePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("SpinalGalaxy"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("TheIntruder"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.OrangePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("TheNexus"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.OrangePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("TheSandbox"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("TheTremor"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddIngredient(ItemID.Wood);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("WantedPoster"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("Aurora"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GreenPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("EverybodyLovesGlowtoad"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepVioletPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("KingoftheNight"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.Find<ModItem>("TheGraduation"));
                    .Register();
            }*/
            #endregion

            #region Fargo's Mutant Mod
            if (ModLoader.TryGetMod("Fargowiltas", out Mod fargoMutant) && craftModdedPaintings)
            {
                Recipe.Create(fargoMutant.Find<ModItem>("EchPainting").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.WhitePaint)
                    .AddIngredient(ItemID.LunarOre)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();
            }
            #endregion

            #region Fargo's Soul Mod
            if (ModLoader.TryGetMod("FargowiltasSouls", out Mod fargoSoul) && craftModdedPaintings)
            {
               Recipe.Create(fargoSoul.Find<ModItem>("TwentyTwoPainting").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.PurplePaint)
                    .AddIngredient(ItemID.BeeWax)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();

                Recipe.Create(fargoSoul.Find<ModItem>("ScremPainting").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.BrownPaint)
                    .AddIngredient(fargoSoul.Find<ModItem>("EternalEnergy").Type)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();
            }
            #endregion

            #region Mod of Redemption (Disabled)
            /*Mod mor = ModLoader.GetMod("Redemption");
            if (mor != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(mor.Find<ModItem>("BrothersPainting"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(mor.Find<ModItem>("ForestGolemPainting"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(mor.Find<ModItem>("BrothersPaintingAlt"));
                    .Register();
            }*/
            #endregion

            #region Amongst the Cosmos (Disabled)
            /*Mod atc = ModLoader.GetMod("ATC");
            if (atc != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepGreenPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(atc.Find<ModItem>("AccursedWoods"));
                    .Register();

                Recipe.Create(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.RedPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(atc.Find<ModItem>("PrayUnderTheCrimsonMoon"));
                    .Register();
            }*/
            #endregion
        }
    }
}