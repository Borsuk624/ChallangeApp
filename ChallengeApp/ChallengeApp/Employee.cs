namespace ChallengeApp;

public class Employee : IEmployee
{
    private List<float> grades = new List<float>();

    public Employee(string name, string surname, string sex)
    {
        this.Name = name;
        this.Surname = surname;
        this.Sex = sex;
    }

    public string Name { get; private set; }

    public string Surname { get; private set; }

    public string Sex { get; private set; }


    public void AddGrade(float grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            this.grades.Add(grade);
        }
        else
        {
            throw new Exception("Podaj wartość z zakresu 0-100");
        }
    }

    public void AddGrade(double grade)
    {
        var doubleAsFloat = (float)grade;
        AddGrade(doubleAsFloat);
    }
    public void AddGrade(long grade)
    {
        var longAsFloat = (float)grade;
        AddGrade(longAsFloat);
    }

    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        foreach (var grade in this.grades)
        {
            if (grade >= 0)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
        }
        statistics.Average /= this.grades.Count;

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

    public void AddGrade(char grade)
    {
        switch (grade)
        {
            case 'A':
            case 'a':
                this.AddGrade(100);
                break;
            case 'B':
            case 'b':
                this.AddGrade(80);
                break;
            case 'C':
            case 'c':
                this.AddGrade(60);
                break;
            case 'D':
            case 'd':
                this.AddGrade(40);
                break;
            case 'E':
            case 'e':
                this.AddGrade(20);
                break;
            default:
                this.AddGrade(0);
                throw new Exception("Zła litera - podaj literę z zakresu od 'A' do 'E'");
        }
    }

    public void AddGrade(string grade)
    {
        if (float.TryParse(grade, out float result))
        {
            this.AddGrade(result);
        }
        else if (char.TryParse(grade, out char resultChar))
        {
            this.AddGrade(resultChar);
        }
        else
        {
            throw new Exception("Błędny znak. Podaj litere z zakresu 'A' do 'E' lub liczbę z zakresu 0-100");
        }
    }
}