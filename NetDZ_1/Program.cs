using System.ComponentModel.Design;

namespace NetDZ_1
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool isNumeric1 = int.TryParse(args[0], out n);
            bool isNumeric2 = int.TryParse(args[2], out n);
            if (args.Length == 3 & isNumeric1 && isNumeric2)
            {
                int number1 = int.Parse(args[0]);
                int number2 = int.Parse(args[2]);
                if (args[1] == "+")
                    Console.WriteLine(number1 + number2);
                else if (args[1] == "-")
                    Console.WriteLine(number1 - number2);
                else if (args[1] == "*")
                    Console.WriteLine(number1 * number2);
                else if (args[1] == "/")
                    Console.WriteLine(number1 / number2);
                else Console.WriteLine("Не верная операция");
            }
            else Console.WriteLine("Не верное количество аргументов или неверный формат ввода");
            return;
        }
    }
}
