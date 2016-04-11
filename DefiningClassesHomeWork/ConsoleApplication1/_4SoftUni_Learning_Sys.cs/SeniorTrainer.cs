using System;
class SeniorTrainer : Trainer
{
    public SeniorTrainer(string firstName, string lastName, int age) 
        : base(firstName, lastName, age)
    {
    }

    public void DeleteCourse(string deletedCourse)
    {
        Console.WriteLine("{0} course has been deleted", deletedCourse);
    }
} 
