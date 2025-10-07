using ExtensionDateTime;

namespace ExtensionTest
{
    [TestClass]
    public sealed class DateTimeExtensionTest
    {
        [TestMethod]
        public void GetSeason_IsSpringAndNormalYear_ShouldReturnSpring()
        {
            DateTime date = new DateTime(2023, 4, 15);
            Seasons expectedSeason = Seasons.SPRING;
            Seasons actualSeason = date.GetSeason();
            Assert.AreEqual(expectedSeason, actualSeason);
        }

        [TestMethod]
        public void GetSeason_IsSummerAndNormalYear_ShouldReturnSummer()
        {
            DateTime date = new DateTime(2023, 8, 15);
            Seasons expectedSeason = Seasons.SUMMER;
            Seasons actualSeason = date.GetSeason();
            Assert.AreEqual(expectedSeason, actualSeason);
        }

        [TestMethod]
        public void GetSeason_IsAutumnAndNormalYear_ShouldReturnAutumn()
        {
            DateTime date = new DateTime(2023, 10, 21);
            Seasons expectedSeason = Seasons.AUTUMN;
            Seasons actualSeason = date.GetSeason();
            Assert.AreEqual(expectedSeason, actualSeason);
        }

        [TestMethod]
        public void GetSeason_IsWinterAndNormalYear_ShouldReturnWinter()
        {
            DateTime date = new DateTime(2023, 1, 15);
            Seasons expectedSeason = Seasons.WINTER;
            Seasons actualSeason = date.GetSeason();
            Assert.AreEqual(expectedSeason, actualSeason);
        }

        //leap year = anno bisestile
        [TestMethod]
        public void GetSeason_IsSpringAndLeapYear_ShouldReturnSpring()
        {
            DateTime date = new DateTime(2024, 4, 15);
            Seasons expectedSeason = Seasons.SPRING;
            Seasons actualSeason = date.GetSeason();
            Assert.AreEqual(expectedSeason, actualSeason);
        }

        [TestMethod]
        public void GetSeason_IsSummerAndLeapYear_ShouldReturnSummer()
        {
            DateTime date = new DateTime(2024, 8, 15);
            Seasons expectedSeason = Seasons.SUMMER;
            Seasons actualSeason = date.GetSeason();
            Assert.AreEqual(expectedSeason, actualSeason);
        }

        [TestMethod]
        public void GetSeason_IsAutumnAndLeapYear_ShouldReturnAutumn()
        {
            DateTime date = new DateTime(2024, 10, 21);
            Seasons expectedSeason = Seasons.AUTUMN;
            Seasons actualSeason = date.GetSeason();
            Assert.AreEqual(expectedSeason, actualSeason);
        }

        [TestMethod]
        public void GetSeason_IsWinterAndLeapYear_ShouldReturnWinter()
        {
            DateTime date = new DateTime(2024, 1, 15);
            Seasons expectedSeason = Seasons.WINTER;
            Seasons actualSeason = date.GetSeason();
            Assert.AreEqual(expectedSeason, actualSeason);
        }

        [TestMethod]
        public void IsItACertainSeason_IsSpringAndDateIsSpring_ShouldReturnTrue()
        {
            DateTime date = new DateTime(2023, 4, 15);
            Seasons season = Seasons.SPRING;
            bool expected = true;
            bool actual = DateTimeExtension.IsItACertainSeason(season, date);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsItACertainSeason_IsSpringAndDateIsAutumn_ShouldReturnFalse()
        {
            DateTime date = new DateTime(2023, 10, 21);
            Seasons season = Seasons.SPRING;
            bool expected = false;
            bool actual = DateTimeExtension.IsItACertainSeason(season, date);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DaysUntilNextSeason_DatesAreOk_ShouldReturnDaysLeftUntilNExtSeason()
        {
            DateTime date = new DateTime(2023, 4, 15);
            int expectedDays = 67; 
            int actualDays = DateTimeExtension.DaysUntilNextSeason(date);
            Assert.AreEqual(expectedDays, actualDays);
        }
    }
}
