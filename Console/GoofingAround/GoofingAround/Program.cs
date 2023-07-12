using GoofingAround.StringHelpers;

namespace GoofingAround;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing StringHelpers");
        var str = "This is a Line of Text!";
        Console.WriteLine($"Original string {str}");
        Console.WriteLine();

        Console.WriteLine($"Reversing the case {str.ReverseCase()}");
        Console.WriteLine();
        
        Console.WriteLine($"Reversing the text {str.Reverse()}");
        Console.WriteLine();

        //leave console window open until user presses a key
        Console.Read();        
    }
}