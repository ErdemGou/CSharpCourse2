using Maths;

internal class Program
{
    private static void Main(string[] args)
    {

        FourOperations mathOperation = new FourOperations();
        mathOperation.Gather(5, 6);
        mathOperation.Gather(6, 9);

        Console.WriteLine("Hello, World!");
    }
}