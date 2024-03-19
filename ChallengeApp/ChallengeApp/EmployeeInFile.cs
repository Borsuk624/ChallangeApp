namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname, string sex)
            : base(name, surname, sex)
        {
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
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
            var charAsFloat = (float)grade;
            AddGrade(charAsFloat);
        }

        public override void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MaxValue;
            statistics.Min = float.MinValue;

            foreach (var grade in grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }
            statistics.Average /= grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }

    }
}
