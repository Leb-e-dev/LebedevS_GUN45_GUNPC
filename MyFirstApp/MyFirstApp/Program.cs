
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Error! Invalid input. Not a number.");
            return;
        }

        Console.WriteLine("Enter the second number: ");
        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Error! Invalid input. Not a number.");
            return;
        }

        Console.WriteLine("Enter bitwise operator (&, |, ^): ");
        var s = Console.ReadLine();

        if (string.IsNullOrEmpty(s) || s.Length != 1)
        {
            Console.WriteLine("Error! Invalid operator length.");
            return;
        }

        char op = s[0];
        int result = 0;

        switch (op)
        {
            case '&':
                result = a & b;
                break;
            case '|':
                result = a | b;
                break;
            case '^':
                result = a ^ b;
                break;
            default:
                Console.WriteLine("Error! Invalid operator. Choose only &, | or ^.");
                return;
        }

        Console.WriteLine($"\nResult of {a} {op} {b}:");
        Console.WriteLine($"Decimal (10): {result}");
        Console.WriteLine($"Binary  (2) : {Convert.ToString(result, 2)}");
        Console.WriteLine($"Hex     (16): 0x{Convert.ToString(result, 16).ToUpper()}");
    }
}
