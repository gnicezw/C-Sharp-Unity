internal class Program
{
    private static void Main(string[] args)
    {
        //dec vars and init to zero
        int num1 = 0; int num2 = 0;

        //display title in c# console as Console Calc PP
        Console.WriteLine("Console Calc in C#\r");
        Console.WriteLine("------------------\n");

        //Ask user for the first number
        Console.WriteLine("Type a number then press enter");
        num1 = Convert.ToInt32(Console.ReadLine());

        //Ask user for the second number
        Console.WriteLine("Type a number then press enter");
        num2 = Convert.ToInt32(Console.ReadLine());

        //Ask the user to choose an option
        Console.WriteLine("Choose an option from the following list");
        Console.WriteLine("\ta - Add");
        Console.WriteLine("\ts - Subtract");
        Console.WriteLine("\tm - Multiply");
        Console.WriteLine("\td - Divide");
        Console.Write("Your Option");

        //Using a Switch statement for choosing the operand
        switch (Console.ReadLine())
        {
            case "a":
                Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                break;
            case "s":
                Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                break;
            case "m":
                Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                break;
            case "d":
                Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                break;

        }
        //wait for the user to respond before closing
        Console.WriteLine("Press any key to close the calculator console app ...");
        Console.ReadKey();
    }
}