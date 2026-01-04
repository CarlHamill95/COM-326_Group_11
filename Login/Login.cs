using System;
using System.Collections.Generic;
using System.Linq;

public class LoginMainMenu
{


    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please Select an Option" +
                "\n 1). Student Login" +
                "\n 2). Admin Login" +
                "\n 3). Exit Program");

            switch (Console.ReadLine())
            {
                case "1":
                    StudentLogin(); //This takes the user to the student login screen
                    break;

                case "2":
                    AdminLogin(); //This takes the user to the admin login screen
                    break;

                case "3":
                    Console.WriteLine("End Program");
                    return; //This ends the program

                default:
                    Console.WriteLine("Invalid option - Please select one of the 3 options above");
                    continue; //This repeats the menu if the user doesnt select one of the options
            }
        }
    }

    static void StudentLogin()
    {
        Console.WriteLine("Welcome To the Student Login\n");

        Console.Write("Username: ");
        string inputStudentUsername = Console.ReadLine();

        Console.Write("Password: ");
        string inputStudentPassword = Console.ReadLine();

        bool checkStudent = UserAccounts.studentList.Any(s =>
        s.StudentName == inputStudentUsername &&
        s.StudentPassword == inputStudentPassword);

        if (checkStudent)
        {
            Console.WriteLine("Student successful Welcome " + inputStudentUsername);
        }
        else
        {
            Console.WriteLine("Student login unsuccessful,");
        }
    }

    static void AdminLogin()
    {
        Console.WriteLine("Welcome To the Admin Login\n");

        Console.Write("Username: ");
        string inputAdminUsername = Console.ReadLine();

        Console.Write("Password: ");
        string inputAdminPassword = Console.ReadLine();

        bool checkAdmin = UserAccounts.adminList.Any(a =>
        a.adminName == inputAdminUsername &&
        a.adminPass == inputAdminPassword);

        if (checkAdmin)
        {
            Console.WriteLine("Admin Login Successful, welcome " + inputAdminUsername);
        }
        else
        {
            Console.WriteLine("Admin login unsuccessful");
        }
    }
}
