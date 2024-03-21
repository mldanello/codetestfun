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
    if (response == '2')
    {
        Console.WriteLine($"\nEnter a string to parse: ");
        var workString = Console.ReadLine();

        if (workString.Length > 0 )
        {
            Console.Write($"\n first non repeated character is:  {getFirstSolo(workString)} \n");
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

static string getFirstSolo(string workstring)
{
    char testChar = ' ';
    for (int i = 0; i < workstring.Length; i++) 
    { 
        testChar = workstring[i];
        var resultStr = workstring.Split(testChar);
        if (resultStr.Length == 2 
             && resultStr[0].Length > 0 )
        {
            break;
        }
    }

    return testChar.ToString();
}