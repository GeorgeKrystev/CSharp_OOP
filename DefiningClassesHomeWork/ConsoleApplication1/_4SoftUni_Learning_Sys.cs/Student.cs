﻿using System; 

    class Student : Person
    {
    private int studentNumber;
    private double avgGrade;

    public int StudentNumber
    {
        get { return this.studentNumber; }
        set
        {
            if (value < 1000 || value > 10000)
            {
                throw new ArgumentOutOfRangeException("studentNumber", "Student number should be in the range [1000 ... 10000].");
            }

            this.studentNumber = value;
        }
    }

    public double AvgGrade
    {
        get { return this.avgGrade; }
        set
        {
            if (value < 2 || value > 6)
            {
                throw new ArgumentOutOfRangeException("averageGrade", "Average grade should be in the range [2 ... 6].");
            }

            this.avgGrade = value;
        }
    }

    public Student(string firstName, string lastName, int age, int studentNumber, double avgGrade)
        : base(firstName, lastName, age)
    {
        this.StudentNumber = studentNumber;
        this.AvgGrade = avgGrade;
    }

    public override string ToString()
    {
        string result = base.ToString();
        result += "Student number: " + this.StudentNumber + "\r\n";
        result += String.Format("Average grade: {0:f2}\r\n", this.AvgGrade);

        return result;
    }
} 
