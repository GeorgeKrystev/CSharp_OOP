using System; 

class OnlineStudent : CurrentStudent
{
    public OnlineStudent( string firstName, string lastName, int age, int studentNumber, double avgGrade, string currentCourse)
        : base(firstName, lastName, age, studentNumber, avgGrade, currentCourse)
    {

    }
} 
