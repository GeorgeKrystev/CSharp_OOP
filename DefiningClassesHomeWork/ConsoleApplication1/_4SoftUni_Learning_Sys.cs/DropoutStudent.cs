using System; 

class DropoutStudent : Student
{
    private string dropoutReason;


    public string DropoutReason
    {
        get { return this.dropoutReason; }
        set
        {
            if(String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("dropoutReason", "Reason cannot be an empty string");
            }
            this.dropoutReason = value;
        }
    }
    public override string ToString()
    {
        string result = base.ToString();
        result += "Dropout reason: " + this.DropoutReason + "\r\n";

        return result;
    }
    public void Reapply()
    {
        Console.WriteLine(this);
    }
    public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double avgGrade, string dropoutReason)
        : base(firstName, lastName, age, studentNumber, avgGrade)
    {
        this.DropoutReason = dropoutReason;
    }
} 
