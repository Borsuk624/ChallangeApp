namespace ChallengeApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void WhenGettingScoreStatisticsAppShouldReturnCorectResult()
        {
            var employee = new Employee("Adam", "Maeve");
            employee.AddGrade("A");
            employee.AddGrade(2.0f);
            employee.AddGrade(6);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(Math.Round(2.0, 2), Math.Round(statistics.Min, 2));
            Assert.AreEqual(Math.Round(36.0, 2), Math.Round(statistics.Average, 2));
        }
    }
}
//aaa
