using System; 

class CurrentStudent : Student
{
    private string currentCourse;

    public CurrentStudent(string firstName, string lastName, int age, int studentNumber, double avgGrade, string currentCourse) 
        :  base(firstName, lastName, age, studentNumber, avgGrade)
    {
    }

    public string CurrentCourse
    {
        get { return this.currentCourse; }
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("currentCourse", "Course cannot be an empty string");
            }
            this.currentCourse = value;
        }
    }

    public override string ToString()
    {   
        string result = base.ToString();
        result += "Current course: " + this.CurrentCourse + "\r\n";
        return result;
    }
} 
