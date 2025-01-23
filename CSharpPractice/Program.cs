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

/*int sum = 0;
for (int number = 1; number < 21; number++)
{
    if (number % 3 == 0)
    {
        sum = sum + number;
    }
}
Console.WriteLine($"The sum is {sum}");*/

/*int counter = 0;
while (counter < 5)
{
    counter++;
    Console.WriteLine($"Counter is {counter}");
}*/

/*int counter = 0;
do
{
    counter++;
    Console.WriteLine($"Counter is {counter}");
} while (counter > 5);*/

/*
 * For Loop
 */
/*for(int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}*/

// Using int
// int count = 5;

// Using var
// var count = 5; // The compiler infers that 'count' is of type 'int'

/*
 * List T and Collections of data
 */
/*var names = new List<string> { "<name>", "Ana", "Felipe" };
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"Hello {names[i].ToUpper()}!");
}

foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}
Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
Console.WriteLine($"The list has {names.Count} people in it");
Console.WriteLine(names[0]);
Console.WriteLine(names[names.Count-1]);
Console.WriteLine(names[^1]); // end operator

foreach (var name in names[2..names.Count])
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}*/

/*
 * Sorting and searching List
 */
/*var names = new List<string> { "John", "Ana", "Felipe" };
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}
names.Sort();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}*/
/*var numbers = new List<int> { 45, 56,99,48,67,78 };
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine();
Console.WriteLine($"I found 99 at {numbers.IndexOf(99)}");
Console.WriteLine();

numbers.Sort();
Console.WriteLine($"I found 99 at {numbers.IndexOf(99)}");
Console.WriteLine();

foreach (var number in numbers)
{
    Console.WriteLine(number);
}*/

/*
 * Arrays
 */
/*var names = new string[] { "Ana", "Felipe", "Maria", "Bill" };
foreach (var name in names[2..4])
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}
Console.WriteLine();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}
Console.WriteLine();
names = [..names, "John"]; // make new array and add John to it. 
names = names.Append("Sean").ToArray(); // append method from System.Linq to add "Sean" to the end of the names array.
                                        // The Append method returns an IEnumerable<string>, which is then converted
                                        // back to an array using the ToArray method. This is the correct way to append
                                        // an element to an array in C#.
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}*/

/*
 * Generics
 *
 * Generics in C# allow you to define classes, methods, and data structures with a
 * placeholder for the type of data they store or use. This provides type safety
 * without the need to specify the exact data type until the class or method is
 * instantiated or called. Generics improve code reusability and performance by
 * eliminating the need for type casting and boxing/unboxing.
 */

/*
public class GenericList<T>
{
    private T[] items;
    private int count;

    public GenericList(int capacity)
    {
        items = new T[capacity];
        count = 0;
    }

    public void Add(T item)
    {
        if (count < items.Length)
        {
            items[count] = item;
            count++;
        }
    }

    public T Get(int index)
    {
        if (index >= 0 && index < count)
        {
            return items[index];
        }
        throw new IndexOutOfRangeException();
    }
}

public class Utilities
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}

class Program
{
    static void Main()
    {
        // Using the generic class
        GenericList<int> intList = new GenericList<int>(5);
        intList.Add(1);
        intList.Add(2);
        Console.WriteLine(intList.Get(0)); // Output: 1
        Console.WriteLine(intList.Get(1)); // Output: 2

        // Using the generic method
        int a = 5, b = 10;
        Utilities.Swap(ref a, ref b);
        Console.WriteLine($"a: {a}, b: {b}"); // Output: a: 10, b: 5
    }
}
*/

/*
 * LINQ (Language Integrated Query) and IEnumerable
 */
// Specify the data source.
// int[] scores = [97, 92, 81, 60];
List<int> scores = [3, 45, 82 , 97, 92, 100, 81, 60];

// scores.Sort();

// Define the query expression.
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    orderby score descending
    select score;

List<int> myScores = scoreQuery.ToList();

// Execute the query.
foreach (var i in scoreQuery)
{
    Console.Write(i + " ");
} // Output: 97 92 81

Console.WriteLine();
foreach (var score in myScores)
{
    Console.WriteLine(score);
}

Console.WriteLine();
IEnumerable<string> scoreQuery2 =
    from score in scores
    where score > 80
    orderby score descending
    select $"The score is {score}";

// Execute the query.
foreach (var s in scoreQuery2)
{
    Console.WriteLine(s);
} // Output: 97 92 81


Console.WriteLine();

IEnumerable<int> highScoresQuery3 =
    from score in scores
    where score > 80
    select score;

var scoreCount = highScoresQuery3.Count();
Console.WriteLine(scoreCount);

Console.WriteLine();


/*
 * LINQ (Language Integrated Query) and IEnumerable
 */

// The Three Parts of a LINQ Query:
// 1. Data source.
/*int[] numbers = [ 0, 1, 2, 3, 4, 5, 6 ];*/

// 2. Query creation.
// numQuery is an IEnumerable<int>
/*var numQuery = from num in numbers
    where (num % 2) == 0
    select num;*/

// 3. Query execution.
/*foreach (int num in numQuery)
{
    Console.Write("{0,1} ", num);
}*/



 