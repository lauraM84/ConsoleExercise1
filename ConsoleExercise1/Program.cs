using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
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

       
        //stampa risultato esercizio indovina numero
        GuessNumber();


        //esercizio 3
        // contare quante volte è contenuta la parola "pippo" nella stringa "pippo è buono, pippo è simpatico, pippo è meglio di topolino"
        if (args.Length !=2) 
        {
            Console.WriteLine("inserire 2 argomenti");
            return;
        }
        countOccurences(args[0], args[1]);
    }

    static void countOccurences(string word, string text)
    {
        int count = 0;
        int index = 0;
        while ((index = text.IndexOf(word, index)) != -1)
        {
            count++;
            index += word.Length;
        }
        Console.WriteLine($"La parola '{word}' appare {count} volte nel testo.");
    }


    private static void PrintHelloWorld()
    {
        Console.WriteLine("Hello World!");

    }

    //esercizio 2 guess a number
    //saluta utente
    //indovina numero da 1 a 10
    //se indovina numero stampa "hai vinto"
    //se numero più basso stampa "più alto"
    //se numero più alto stampa "più basso"
    //tentativi infiniti per indovinare


    
    private static void GuessNumber()
    {
        Console.WriteLine("Ciao! Indovina il numero da 1 a 10");
        Random random = new Random();
        int randomNumber = random.Next(1, 11);

        while (true)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == randomNumber)
            {
                Console.WriteLine("Hai vinto!");
                break; // esce dal ciclo
            }
            else if (number < randomNumber)
            {
                Console.WriteLine("Sbagliato, era più alto. Riprova!");
            }
            else
            {
                Console.WriteLine("Sbagliato, era più basso. Riprova!");
            }
        }
    }



}


//print tutti i numeri da 1 a 100, se divisibile per 7 diventa pippo, quadrato perfetto pluto, se entrambi paperone


//esercizio 4: come 3 ma deve brendere un file (url)
//numero occorrenze dando parola di cercare
//non viene data parola da trovare ma conta numero parole, numero caratteri, numero vocali e numero consonanti
//rifare csv-parser









