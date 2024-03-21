// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");


while (true)
{
    Console.WriteLine("Select Test:");
    Console.WriteLine("   (1) - Fibonacci Sequence");
    Console.WriteLine("   (2) - Find the first solo");
    Console.WriteLine("   (X) - Exit");
    var response = Console.ReadKey().KeyChar;
    if (Char.ToLower(response) == 'x')
    {
        Console.WriteLine($"\nProgram Exit!\n");
        break;
    }
    if (response == '1')
    {
        Console.WriteLine($"\nEnter a value [0 - 9] for number of Fibonacci digits: ");
        var digits = Console.ReadKey().KeyChar.ToString();
        int outDigits;
        if (int.TryParse(digits, out outDigits))
        {
            Console.Write($"\n {getFibonacciSequence(outDigits)} \n");
        }
        
    }
    Console.WriteLine($"\n\n");
}

static string getFibonacciSequence(int digits)
{
    var retVals = new List<int>();
    if (digits < 1)
    {
        return "no digits selected";
    }
    if (digits < 2)
    {
        return "1";
    }
    retVals.Add(1);
    retVals.Add(2);

    for (int i = 2; i < digits; i++)
    {
        var newVal = retVals[i - 1] + retVals[i - 2];

        retVals.Add(newVal);
    }

    return string.Join(", ", retVals.ToArray());
}

static void getFirstSolo()
{

}