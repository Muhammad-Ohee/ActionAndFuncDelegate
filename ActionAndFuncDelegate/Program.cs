//Console.WriteLine("Hello, OS");

namespace ActionAndFuncDelegate
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Action Delegate:");
            Action<int, int> ActionCalculator = (a, b) =>
            {
                Console.WriteLine($"Addition Result: {a + b}");
                Console.WriteLine($"Subtraction Result: {a - b}");
                Console.WriteLine($"Multiplication Result: {a * b}");
                Console.WriteLine($"Division Result: {a / b}");
            };

            ActionCalculator(4, 2);

            Console.WriteLine("");
            Console.WriteLine("Func Delegate:");
            var FuncCalculator = new Calculator();

            Func<int, int, int> add = FuncCalculator.Add;
            Console.WriteLine($"Addition Result: {add(4, 2)}");

            Func<int, int, int> subtract = FuncCalculator.Subtract;
            Console.WriteLine($"Addition Result: {subtract(4, 2)}");

            Func<int, int, int> multiply = FuncCalculator.Multiplication;
            Console.WriteLine($"Multiplication Result: {multiply(4, 2)}");

            Func<int, int, int> division = FuncCalculator.Division;
            Console.WriteLine($"Addition Result: {division(4, 2)}");

        }


        public class Calculator
        {
            public int Add(int a, int b) => a + b;
            public int Subtract(int a, int b) => a - b;
            public int Multiplication(int a, int b) => a * b;
            public int Division(int a, int b) => a / b;
        }
    }
}