namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname, string sex) 
            : base(name, surname, sex)
        {
        }

        public override void AddGrade(float grade)
        {

            var intAsFloat = (float)grade;
            AddGrade(intAsFloat);
        }

        public override void AddGrade(double grade)
        {
            var doubleAsFloat = (float)grade;
            AddGrade(doubleAsFloat);
        }

        public override void AddGrade(int grade)
        {
            var intAsFloat = (float)grade;
            AddGrade(intAsFloat);
        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
