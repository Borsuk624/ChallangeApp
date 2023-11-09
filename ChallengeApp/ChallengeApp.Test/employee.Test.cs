namespace ChallengeApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void WhenPointsAreAddedItShouldGiveTheSumOfThePoints()
        {
            //arrange
            var employee2 = new Employee("Ada ", "Maze", 23);
          
            employee2.AddScore(5);
            employee2.AddScore(-1);
            employee2.AddScore(-2);
            
            // act
            var result = employee2.Result;

            //assert
            Assert.AreEqual(2, result);
        }
    }
}