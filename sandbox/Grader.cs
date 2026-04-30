using System;
using System.Security.Cryptography;

class Grader
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWhat is your first name? ");
        string first = Console.ReadLine();
        Console.WriteLine("\nWhat is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine($"Your name is {last}, {first} {last}");

        Console.WriteLine("\nWhat grade did you get in school? ");
        string grade = Console.ReadLine();
        int gradeInt = Convert.ToInt32(grade);

        string letter = "";
        if (gradeInt >= 90)
        {
            letter = "A. You passed, Im finally proud of you!";
        }
        else if (gradeInt >= 80)
        {
            letter = "B. Really? Even an average student can do better than you";
        }
        else if (gradeInt >= 70)
        {
            letter = "C. Not everyone is borne to win. But walmart is always open to you";
        }
        else if (gradeInt >= 60)
        {
            letter = "D. Your going to spend the rest of your life in prison";
        }
        else
        {
            letter = "F. You failed, your parents will never forgive you";
        }
        Console.WriteLine(letter);

        Console.WriteLine("\nPress enter to exit");
        Console.ReadLine();
    }
}