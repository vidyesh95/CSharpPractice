// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

/*
using System;

class Program
{
    static void Main()
    {
        int number = 10;
        Console.WriteLine("Before: " + number);
        ModifyValue(ref number);
        Console.WriteLine("After: " + number);
    }

    static void ModifyValue(ref int num)
    {
        num = 20;
    }
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        int number;
        InitializeValue(out number);
        Console.WriteLine("Initialized: " + number);
    }

    static void InitializeValue(out int num)
    {
        num = 30;
    }
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == 2 && j == 2)
                {
                    goto EndLoop;
                }
                Console.WriteLine($"i: {i}, j: {j}");
            }
        }

        EndLoop:
        Console.WriteLine("Exited the loop.");
    }
}
*/

/* Call by Value
When you pass an argument by value, a copy of the
variable's value is passed to the method. Changes
made to the parameter inside the method do not
affect the original variable.
*/


/*
using System;
class Program
{
    static void Main()
    {
        int number = 10;
        Console.WriteLine("Before: " + number);
        ModifyValue(number);
        Console.WriteLine("After: " + number);
    }

    static void ModifyValue(int num)
    {
        num = 20;
    }
}

*/

/*
 * Call by Reference
 *
 * When you pass an argument by reference, a reference
 * to the variable is passed to the method. Changes made
 * to the parameter inside the method affect the original
 * variable.
 */

/*
 * ref
 */

/*
using System;

class Program
{
    static void Main()
    {
        int number = 10;
        Console.WriteLine("Before: " + number);
        ModifyValue(ref number);
        Console.WriteLine("After: " + number);
    }

    static void ModifyValue(ref int num)
    {
        num = 20;
    }
}
*/

/*
 * out
 */

/*
using System;

class Program
{
    static void Main()
    {
        int number;
        InitializeValue(out number);
        Console.WriteLine("Initialized: " + number);
    }

    static void InitializeValue(out int num)
    {
        num = 30;
    }
}
*/

/*
 * out
 *
 * In C#, the out keyword is used to pass arguments to
 * methods by reference. This allows the method to modify
 * the original variable's value. Unlike ref, the variable
 * passed as an out parameter does not need to be
 * initialized before being passed to the method,
 * but it must be assigned a value within the method.
 */

/*
using System;

class Program
{
    static void Main()
    {
        int number;
        InitializeValue(out number);
        Console.WriteLine("Initialized: " + number);
    }

    static void InitializeValue(out int num)
    {
        num = 30;
    }
}
*/

/*

using System;
using System.Threading.Tasks;

namespace AsyncBreakfast
{
    // These classes are intentionally empty for the purpose of this example. They are simply marker classes for the purpose of demonstration, contain no properties, and serve no other purpose.
    internal class Bacon { }
    internal class Coffee { }
    internal class Egg { }
    internal class Juice { }
    internal class Toast { }

    class Program
    {
        static void Main(string[] args)
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Egg eggs = FryEggs(2);
            Console.WriteLine("eggs are ready");

            Bacon bacon = FryBacon(3);
            Console.WriteLine("bacon is ready");

            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");

        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private static Egg FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}

*/

/*
decimal f = 3.5m; // explicit type
decimal d = (decimal)3.5;
decimal m = 3.5m;
decimal f2 = f+d+m;
Console.WriteLine(f2);

double a = 42.1; // natural type
float b = 38.2f;
double c = a + b;
Console.WriteLine(c);
*/

/*double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);*/

/*int a = 5;
int b = 6;
int c = a + b;
Console.WriteLine(c);

if (a+b>10)
{
    Console.WriteLine("The sum is greater than 10.");
}*/

/*int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) || (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("Or the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("And the first number is not equal to the second");
}*/

/*for (int row = 1; row < 11; row++)
{
    Console.WriteLine($"The row is {row}");
}*/

/*for (char column = 'a'; column < 'k'; column++)
{
    Console.WriteLine($"The column is {column}");
}*/

/*for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}*/

int sum = 0;
for (int number = 1; number < 21; number++)
{
    if (number % 3 == 0)
    {
        sum = sum + number;
    }
}
Console.WriteLine($"The sum is {sum}");
