using System.Runtime.InteropServices;
using ConsoleExercise1;

internal class Program
{
    private static void Main(string[] args)
    {
        // This is a comment

        int number = 5; // This is a variable declaration

        float pi = 3.14f; // This is a float variable

        double result = 3.14159; // This is a double variable

        decimal price = 19.99m; // This is a decimal variable

        bool isActive = true; // This is a boolean variable

        string name = "John Doe"; // This is a string variable

        string greeting = "Hello, " + name; // String concatenation

        string greetingWithInterpolation = $"Hello, {name}"; // String interpolation

        string verbatimString = @"This is a verbatim string literal.
                                It can span multiple lines.";

        char letter = 'A'; // This is a character variable

        var isActiveVar = false; // Implicitly typed variable   (bool)
        var numberVar = 10; // Implicitly typed variable   (number)
        var piVar = 3.14f; // Implicitly typed variable   (double)

        if (true)
        {

        }

        else
        {

        }

        foreach (var item in new[] { 1, 2, 3 })
        {
            Console.WriteLine(item);
        }

        while (true)
        {
            break;
        }
        do
        {
            break;
        } while (true);

        PrintHelloWorld();


        //stampa risultato esercizio fizzbuzz
        var fizzbuzz = new fizzbuzz();
        fizzbuzz.PrintNumber();
    }


    private static void PrintHelloWorld()
    {
        Console.WriteLine("Hello World!");

    }

   
}


//print tutti i numeri da 1 a 100, se divisibile per 7 diventa pippo, quadrato perfetto pluto, se entrambi paperone










    