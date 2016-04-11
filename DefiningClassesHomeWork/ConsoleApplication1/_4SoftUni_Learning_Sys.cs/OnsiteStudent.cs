using System;

class OnsiteStudent : CurrentStudent
{
    
    private int numberOfVisits;


    public int NumberOfVisits
    {
        get { return this.numberOfVisits; }
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("numberOfVisits", "Number should be positve number");
            }
            this.numberOfVisits = value;
        }
    }

    public override string ToString()
    {
        string result = base.ToString();
        result += "This student has visited course " + this.NumberOfVisits + " times" + "\r\n";
        return result;
    }

    public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, double avgGrade, string currentCourse, int numberOfVisits)
        : base(firstName, lastName, age, studentNumber, avgGrade, currentCourse)
    {
        this.NumberOfVisits = numberOfVisits;
    } 
} 
