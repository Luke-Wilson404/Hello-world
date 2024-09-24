using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //Task 1
        Console.WriteLine("TASK 1:");
        Console.WriteLine("Please enter yout name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter yout age: ");
        int age1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hello you are " + name + " and you are " + age1 + " years old.");

        //Task 2
        Console.WriteLine("TASK 2:");
        Console.WriteLine("What is your age?: ");
        int age2 = Convert.ToInt32(Console.ReadLine());
        if (age2 >= 19) {
            Console.WriteLine("You are a adult");
        } else if (age2 <= 13) {
            Console.WriteLine("You are a child");
        } else {
            Console.WriteLine("You are a teenager");
        }

        //Task 3
        Console.WriteLine("TASK 3:");
        Console.WriteLine("Please enter a integer");
        int num1 = Convert.ToInt32(Console.ReadLine());
        if (num1 >= 0) {
            Console.WriteLine("This is a positive number.");
        } else {
            Console.WriteLine("This is a negative number.");
        }

        //Task 4
        Console.WriteLine("TASK 4:");
        Console.WriteLine("Enter a year");
        int year = Convert.ToInt32(Console.ReadLine());
        if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) {
            Console.WriteLine("It is a leap year");
        } else {
            Console.WriteLine("It is not a leap year");
        }

        //Task 5
        Console.WriteLine("TASK 5:");
        Console.WriteLine("Enter a number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if (num2 % 2 == 0) {
            Console.WriteLine("That is a even number");
        } else {
            Console.WriteLine("That is a odd number");
        }
    }
}
