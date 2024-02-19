namespace ChallengeApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void WhenGettingScoreStatisticsAppShouldReturnCorectResults()
        {
            var employee = new Employee("Adam", "Maeve");
            employee.AddGrade("B");
            employee.AddGrade(2.0f);
            employee.AddGrade(6);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(80, statistics.Max);
            Assert.AreEqual(Math.Round(2.0, 2), Math.Round(statistics.Min, 2));
            Assert.AreEqual(Math.Round(29.33, 2), Math.Round(statistics.Average, 2));
        }
    }
}
