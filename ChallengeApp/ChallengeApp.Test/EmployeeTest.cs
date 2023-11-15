namespace ChallengeApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void WhenGettingStatistiscAppShouldReturnMaxResult()
        {
            //arrange
            var employee = new Employee("Adam", "Maeve");
            employee.AddGrade(2.3f);
            employee.AddGrade(3);
            employee.AddGrade(6);
            
            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(6, statistics.Max);
        }

        [Test]
        public void WhenGettingStatistiscAppShouldReturnMinResult()
        {
            //arrange
            var employee = new Employee("Adam", "Maeve");
            employee.AddGrade(2.3f);
            employee.AddGrade(3);
            employee.AddGrade(6.3f);

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(2.3, 2), Math.Round(statistics.Min, 2));
        }

        [Test]
        public void WhenGettingStatistiscAppShouldReturnAverageResult()
        {
            //arrange
            var employee = new Employee("Adam", "Maeve");
            employee.AddGrade(2.3f);
            employee.AddGrade(3);
            employee.AddGrade(6.3f);

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(3.87, 2), Math.Round(statistics.Average, 2));
        }
    }
}

