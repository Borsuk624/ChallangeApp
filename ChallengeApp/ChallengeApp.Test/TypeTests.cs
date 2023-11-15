namespace ChallengeApp.Test
{
    public class TypeTests
    {
        [Test]
        public void CheckIfNumbersAreTheSame()
        {
            //arrange
            int number1 = 2;
            int number2 = 2;
            
            // act
            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void CheckIfEmployeesNameAreTheSame()
        {
            //arrange
            var employee1 = GetEmployee("Adam", "ddd");
            var employee2 = GetEmployee("Adam", "ddd");
            // act
            //assert
            Assert.AreEqual(employee1.Name, employee2.Name);
        }
        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }

        [Test]
        public void CheckIfEmployeesAreDiffrent()
        {
            //arrange
            var employee3 = GetEmployee("Adam", "ddd");
            var employee4 = GetEmployee("Adam", "ddd");
            // act
            //assert
            Assert.AreNotEqual(employee3, employee4);
        }

        [Test]
        public void CheckIfFloatsAreDiffrents()
        {
            //arrange
            float F1 = 11.11f;
            float F2 = 12.11f;
            // act
            //assert
            Assert.AreNotEqual(F1, F2);
        }
    }
}
