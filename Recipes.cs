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

            #region SGAmod (Disabled)
            /*Mod sgamod = ModLoader.GetMod("SGAmod");
            if (sgamod != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GreenPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(sgamod.ItemType("DergPainting"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.LimePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(sgamod.ItemType("CalmnessPainting"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.YellowPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(sgamod.ItemType("MeetingTheSunPainting"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.SkyBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(sgamod.ItemType("AdventurePainting"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(sgamod.ItemType("SerenityPainting"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GreenPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(sgamod.ItemType("UnderTheWaterfallPainting"));
                    .Register();
            }*/
            #endregion

            #region Polarities (Disabled)
            /*Mod polarities = ModLoader.GetMod("Polarities");
            if (polarities != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.CyanPaint);
                    .AddIngredient(polarities.ItemType("FractalStrands"));
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(polarities.ItemType("WarpedLandscape"));
                    .Register();
            }*/
            #endregion

            #region Thorium (Disabled)
            /*Mod thorium = ModLoader.GetMod("ThoriumMod");
            if (thorium != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepRedPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("AToastPaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepTealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("AquaticParadisePaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepTealPaint);
                    .AddIngredient(ItemID.SoulofLight);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("CuriousSeaLifePaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepPurplePaint);
                    .AddIngredient(ItemID.SoulofNight);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("CursedHarvestPaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepBluePaint);
                    .AddIngredient(ItemID.Bone);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("EarthenEnergyPaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.YellowPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("JellyintheWaterPaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("JollyRogerPaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepTealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("LastSupperPaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddIngredient(ItemID.Bone);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("LoudFootstepsPaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepRedPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("RedMistPaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("ShroudedbytheStormPaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.CyanPaint);
                    .AddIngredient(ItemID.Ectoplasm);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("SpectralSymphonyPaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.OrangePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("PumpkinPaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("TheFoggyFiferPaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("ThunderOverDesertSkiesPaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepVioletPaint);
                    .AddIngredient(ItemID.LunarOre);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("TitanicTrioPaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("UnderseaBountyPaint"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("UnspokenPain"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(thorium.ItemType("GrayDPaintingItem"));
                    .Register();
            }*/
            #endregion

            #region Calamity's Vanities (Disabled)
            /*Mod calvalex = ModLoader.GetMod("CalValEX");
            if (calvalex != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.LimePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("Plague22"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.VioletPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("CirrusBooze"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GreenPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("SundayAfternoon"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("AccidentalAbominationn"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("SwearingShroom"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.OrangePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("BlazingConflict"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.LimePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("CalamiteaTime"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("Yharlamitas"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.RedPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("ModIconPainting"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.RedPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("WilliamPainting"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.VioletPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("CosmicTerror"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("DarkMagic"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepPurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("Duality"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepVioletPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("Espelho"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepSkyBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("Frozen"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.YellowPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("CalamityFriends"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.SkyBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("LostSouls"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("NotLikeHome"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("Clam"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.VioletPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("RogueExtractor"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.TealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("Scourgy"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("Signut"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.TealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("SleepingGiant"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.TealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("Snouts"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("TheGreatSandworm"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.YellowPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("TheYhar"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.TealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("UnholyTrip"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.RedPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("VVanities"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.SkyBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(calvalex.ItemType("WormHeaven"));
                    .Register();
            }*/
            #endregion

            #region pinkymod (Disabled)
            /*Mod pinkymod = ModLoader.GetMod("pinkymod");
            if (pinkymod != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(pinkymod.ItemType("OverlyDetailedChickenScratch"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(pinkymod.ItemType("WormBossIndicator"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.SkyBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(pinkymod.ItemType("RoketLunchced"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.OrangePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(pinkymod.ItemType("FerniumPainting"));
                    .Register();

                //

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(pinkymod.TileType("EaselTile"));
                    .SetResult(pinkymod.ItemType("OverlyDetailedChickenScratch"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(pinkymod.TileType("EaselTile"));
                    .SetResult(pinkymod.ItemType("WormBossIndicator"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.SkyBluePaint);
                    .AddTile(pinkymod.TileType("EaselTile"));
                    .SetResult(pinkymod.ItemType("RoketLunchced"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.OrangePaint);
                    .AddTile(pinkymod.TileType("EaselTile"));
                    .SetResult(pinkymod.ItemType("FerniumPainting"));
                    .Register();
            }*/
            #endregion

            #region Shadows of Abaddon (Disabled)
            /*Mod soa = ModLoader.GetMod("SacredTools");
            if (soa != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.ItemType("Kappa"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.ItemType("Daryl"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.ItemType("KipSmug"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.ItemType("Polarius"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.OrangePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.ItemType("MoodPainting"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.ItemType("LunaticCultistPainting"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.ItemType("AbaddonPainting"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.ItemType("GodOfTerraria"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.ItemType("Warmth"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.SkyBluePaint);
                    .AddIngredient(ItemID.LunarOre);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(soa.ItemType("Deepfreeze"));
                    .Register();
            }*/
            #endregion

            #region Spirit (Disabled)
            /*Mod spirit = ModLoader.GetMod("SpiritMod");
            if (spirit != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.RedPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting1"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.CyanPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting10"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting11"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.CyanPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting12"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.TealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting13"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting14"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.TealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting15"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.OrangePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting16"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting17"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting18"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.SkyBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting19"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.YellowPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting2"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting20"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting21"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.CyanPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting22"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting23"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting3"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepTealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting4"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.TealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting5"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.TealPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting6"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GreenPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting7"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting8"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.SkyBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("AdvPainting9"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.VioletPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("DuskingPainting"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("FishingPainting"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(spirit.ItemType("FloppaPainting"));
                    .Register();
            }*/
            #endregion

            #region Split (Disabled)
            /*Mod split = ModLoader.GetMod("Split");
            if (split != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GreenPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("ChildOfTheCorn"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("OneAndOnly"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("OneSmallStepForAPirate"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.VioletPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("TheThunderbolt"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.YellowPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("OOOMagicianOOO"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("BigFan"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("DrCool"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("FamiliarFace"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.CyanPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("FilthyFranChan"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("FullHouse"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("IDRTO"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.SkyBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("IBB"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("LadyInWaiting"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("Loneliness"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("MJ"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepPurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("TheGlassman"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepPurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("ManOfShadows"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddIngredient(ItemID.Wood);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("MissingPoster"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("MysteryMan"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.WhitePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("PageTurner"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.LimePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("SpinalGalaxy"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("TheIntruder"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.OrangePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("TheNexus"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.OrangePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("TheSandbox"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("TheTremor"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddIngredient(ItemID.Wood);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("WantedPoster"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepBluePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("Aurora"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GreenPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("EverybodyLovesGlowtoad"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepVioletPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("KingoftheNight"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(split.ItemType("TheGraduation"));
                    .Register();
            }*/
            #endregion

            #region Fargo's Mutant Mod
            if (ModLoader.TryGetMod("Fargowiltas", out Mod fargoMutant) && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Recipe.Create(fargoMutant.Find<ModItem>("EchPainting").Type)
                    .AddIngredient(ModContent.ItemType<Canvas>())
                    .AddIngredient(ItemID.WhitePaint)
                    .AddIngredient(ItemID.LunarOre)
                    .AddTile(ModContent.TileType<EaselTile>())
                    .Register();
            }
            #endregion

            #region Fargo's Soul Mod (Disabled)
            /*Mod fargoSoul = ModLoader.GetMod("FargowiltasSouls");
            if (fargoSoul != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.PurplePaint);
                    .AddIngredient(ItemID.BeeWax);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(fargoSoul.ItemType("TwentyTwoPainting"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddIngredient(fargoSoul.ItemType("Sadism"));
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(fargoSoul.ItemType("ScremPainting"));
                    .Register();
            }*/
            #endregion

            #region Mod of Redemption (Disabled)
            /*Mod mor = ModLoader.GetMod("Redemption");
            if (mor != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(mor.ItemType("BrothersPainting"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.BrownPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(mor.ItemType("ForestGolemPainting"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.GrayPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(mor.ItemType("BrothersPaintingAlt"));
                    .Register();
            }*/
            #endregion

            #region Amongst the Cosmos (Disabled)
            /*Mod atc = ModLoader.GetMod("ATC");
            if (atc != null && ModContent.GetInstance<CraftablePaintingsConfigServer>().CraftModdedPaintings)
            {
                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.DeepGreenPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(atc.ItemType("AccursedWoods"));
                    .Register();

                Mod.CreateRecipe(ItemID.GolfPainting1);
                    .AddIngredient(ModContent.ItemType<Canvas>());
                    .AddIngredient(ItemID.RedPaint);
                    .AddTile(ModContent.TileType<EaselTile>());
                    .SetResult(atc.ItemType("PrayUnderTheCrimsonMoon"));
                    .Register();
            }*/
            #endregion
        }
    }
}