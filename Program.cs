using System;
using System.Collections.Generic;
using challenges.Models;

namespace challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // User mark = new User("mark", "I<3Code!");
            // User jake = new User("jake", "MarkIsAwesome!");
            // User darryl = new User("darryl", "OutsideIsBetter$$");

            // Dictionary<string, User> users = new Dictionary<string, User>();
            // users.Add(mark.UserName.ToLower(), mark);
            // users.Add(jake.UserName.ToLower(), jake);
            // users.Add(darryl.UserName.ToLower(), darryl);
            // Console.Clear();
            // Console.WriteLine("Welcome");
            // Console.Write("Username: ");
            // string nameInput = Console.ReadLine().ToLower();
            // Console.Write("Password: ");
            // string passwordInput = Console.ReadLine();
            // //NOTE Check if the user dictionary has that key, then check if the key has that password
            // if (users.ContainsKey(nameInput) && users[nameInput].ValidatePassword(passwordInput))
            // {
            //     Console.WriteLine($"Successfully Logged in\nWelcome {nameInput}");
            // }
            // else
            // {
            //     Console.WriteLine("get out hacker");
            // }

            System.Console.WriteLine(Utils.doubleInteger(4));
            System.Console.WriteLine(Utils.doubleInteger(10));
            System.Console.WriteLine(Utils.isNumberEven(2));
            System.Console.WriteLine(Utils.isNumberEven(11));
            System.Console.WriteLine(Utils.getFileExtension("test.txt"));
            System.Console.WriteLine(Utils.getFileExtension("test.test.txt"));
            System.Console.WriteLine(Utils.getFileExtension("testtesttxt"));
            System.Console.WriteLine(Utils.longestString(new string[] { "hello", "world", "in", "pandemic" }));
            System.Console.WriteLine(Utils.longestString(new List<string> { "hello", "world", "in", "pandemic" }));
            System.Console.WriteLine(Utils.longestString(new List<string>()));
            System.Console.WriteLine(Utils.arraySum(new int[] { 1, 2, 3, 4, 2, 23, 4, 5, 2, 13, 5, 634, 23, 4 }));
            System.Console.WriteLine(Utils.arraySum(new List<int>() { 1, 2, 3, 4, 2, 23, 4, 5, 2, 13, 5, 634, 23, 4 }));


        }
    }
}
