// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


while (true)
{
    Console.WriteLine("Select Test:");
    Console.WriteLine("   (1) - Fibonacci Sequence");
    Console.WriteLine("   (2) - Find the first solo");
    Console.WriteLine("   (X) - Fibonacci Sequence");
    var response = Console.ReadKey().KeyChar;
    if (Char.ToLower(response) == 'x')
    {
        Console.WriteLine($"\nProgram Exit!\n");
        break;
    }
    Console.WriteLine($"\n\n");
}
