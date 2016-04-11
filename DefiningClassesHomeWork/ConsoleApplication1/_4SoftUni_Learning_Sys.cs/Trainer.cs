using System;

class Trainer : Person
{
    public Trainer(string firstName, string lastName, int age) 
        : base(firstName, lastName, age)
    {
    }

    public void CreateCourse(string courseName)
    {
        Console.WriteLine("{0} course has been created", courseName);
    }

    //private string courseName;

    //public string CourseName
    //{
    //    get { return this.courseName; }
    //    set
    //    {
    //        if (String.IsNullOrWhiteSpace(value))
    //        {
    //            throw new ArgumentException("courseName", "Cousse cannot be an empty string");
    //        }
    //        this.courseName = value;
    //    }
    //}

    //public override string ToString()
    //{

    //    return base.ToString();
    //}
} 
