namespace ChallengeApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void WhenGettingScoreStatisticsAppShouldReturnCorectResult()
        {
            //arrange
            var employee = new Employee("Adam", "Maeve");
            employee.AddGrade("A");
            employee.AddGrade(2.0f);
            employee.AddGrade(6);
            
            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(Math.Round(2.0, 2), Math.Round(statistics.Min, 2));
            Assert.AreEqual(Math.Round(36.0, 2), Math.Round(statistics.Average, 2));
        }
    }
}

